using ACNH_win.Helpers;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
namespace ACNH_win

{
    public partial class Form1 : Form
    {
        private readonly string _connStr =
           @"Data Source=.\sql2025;
              Initial Catalog=ACNH_DB;
              User ID=sa;
              Password=Sa5!sa5!;
              TrustServerCertificate=True";
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BindResidents();

        }
        private void BindResidents()
        {
            var helper = new DbHelper(_connStr);

            var sql = @"
SELECT Id, Name
FROM Residents
WHERE IsDeleted = 0
ORDER BY Name;";

            var residents = helper.Query(reader => new ResidentsOptionDto
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1)
            }, sql).ToList();

            lstResidents.DataSource = residents;
            lstResidents.DisplayMember = "Name";
            lstResidents.ValueMember = "Id";
        }

        private void lstResidents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstResidents.SelectedItem == null) return;

            var selected = (ResidentsOptionDto)lstResidents.SelectedItem;
            LoadResidentDetail(selected.Id);
        }
        private void LoadResidentDetail(int residentId)
        {
            var helper = new DbHelper(_connStr);
            var sql = @"
SELECT
r.Id,
r.Name,
s.Name AS Species,
p.Name AS Personality,
r.CatchPhrase,
r.ImagePath,
ISNULL(rf.Affection,0) AS Affection
FROM Residents r
JOIN Species s ON s.Id = r.SpeciesId
JOIN Personality p ON p.Id = r.PersonalityId
LEFT JOIN ResidentFriendship rf ON rf.ResidentId = r.Id
WHERE r.Id=@Id AND r.IsDeleted = 0;";

            var parameters = new SqlParameterBuilder()
                .AddInt("@Id", residentId)
                .ToArry();

            var dto = helper.Load(reader => new ResidentDetailDto
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                Species = reader.GetString(2),
                Personality = reader.GetString(3),
                CatchPhrase = reader.IsDBNull(4) ? "" : reader.GetString(4),
                ImagePath = reader.IsDBNull(5) ? null : reader.GetString(5),
                Affection = reader.GetInt32(6)
            }, sql, parameters);

            if (dto == null) return;

            lblNameValue.Text = dto.Name;
            lblSpeciesValue.Text = dto.Species;
            lblPersonalityValue.Text = dto.Personality;
            lblCatchPhraseValue.Text = dto.CatchPhrase;
            lblAffectionValue.Text = dto.Affection.ToString();

            LoadResidentImage(dto.ImagePath);
        }

        private void LoadResidentImage(string? imagePath)
        {
            picResident.Image = null;

            if (string.IsNullOrWhiteSpace(imagePath)) return;

            var fullPath = Path.Combine(Application.StartupPath, imagePath);

            if (!File.Exists(fullPath)) return;

            // 避免鎖檔：用 bytes + MemoryStream
            var bytes = File.ReadAllBytes(fullPath);
            using var ms = new MemoryStream(bytes);
            picResident.Image = Image.FromStream(ms);
        }




        private void btnGiveGift_Click(object sender, EventArgs e)
        {
            if (lstResidents.SelectedItem == null) return;

            var selected = (ResidentsOptionDto)lstResidents.SelectedItem;

            using (var frm = new frmGiveGift(
                selected.Id,
                selected.Name,
                _connStr))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    //送禮後重新載入居民資訊(好感度會變)
                    LoadResidentDetail(selected.Id);
                }
            }

        }
        private int GetAffectionDelta(int giftId)
        {
            var helper = new DbHelper(_connStr);

            var sql = @"SELECT BaseValue FROM Gifts WHERE Id = @Id AND IsDeleted = 0;";
            var p = new SqlParameterBuilder()
                .AddInt("@Id", giftId)
                .ToArry();

            var dto = helper.Query(r => new GiftBaseValueDto
            {
                BaseValue = r.GetInt32(0)
            }, sql, p).FirstOrDefault();

            if (dto == null) return 0;

            int baseValue = dto.BaseValue;

            if (baseValue <= 10) return 1;
            if (baseValue <= 30) return 2;
            return 3;
        }


        private void InsertGiftInteraction(int residentId, int giftId, int delta)
        {
            var helper = new DbHelper(_connStr);

            var sql = @"
INSERT INTO GiftInteractions(ResidentId, GiftId, AffectionDelta)
VALUES(@ResidentId, @GiftId, @Delta);";

            var p = new SqlParameterBuilder()
                .AddInt("@ResidentId", residentId)
                .AddInt("@GiftId", giftId)
                .AddInt("@Delta", delta)
                .ToArry();

            helper.ExecuteNonQuery(sql, p);
        }
        private void UpsertFriendship(int residentId, int delta)
        {
            var helper = new DbHelper(_connStr);

            var sql = @"
IF EXISTS (SELECT 1 FROM ResidentFriendship WHERE ResidentId = @ResidentId)
BEGIN
    UPDATE ResidentFriendship
    SET Affection = Affection + @Delta,
        UpdatedTime = SYSDATETIME()
    WHERE ResidentId = @ResidentId;
END
ELSE
BEGIN
    INSERT INTO ResidentFriendship(ResidentId, Affection)
    VALUES(@ResidentId, @Delta);
END";

            var p = new SqlParameterBuilder()
                .AddInt("@ResidentId", residentId)
                .AddInt("@Delta", delta)
                .ToArry();

            helper.ExecuteNonQuery(sql, p);
        }

        private void btnAddResident_Click(object sender, EventArgs e)
        {
            var frm = new frmResidentAdd(_connStr);
            var result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                BindResidents();

                if (frm.NewResidentId.HasValue)
                {
                    lstResidents.SelectedValue = frm.NewResidentId.Value;
                }
            }
            frm.Dispose();
        }

        private void btnOpenSearch_Click(object sender, EventArgs e)
        {
            var frm = new frmResidentSearch(_connStr);
            var result = frm.ShowDialog();

            if (result == DialogResult.OK && frm.SelectedResidentId.HasValue)
            {
                lstResidents.SelectedValue = frm.SelectedResidentId.Value;
            }
            frm.Dispose();
        }

        private void btnDeleteResident_Click(object sender, EventArgs e)
        {
            if (lstResidents.SelectedItem == null)
            {
                MessageBox.Show("請先選擇居民");
                return;
            }

            var resident = (ResidentsOptionDto)lstResidents.SelectedItem;

            var frm = new frmResidentDelete(
                _connStr,
                resident.Id,
                resident.Name);
            var result = frm.ShowDialog();

        }
    }
}

