using ACNH_win.Helpers;
using Microsoft.Data.SqlClient;
using System.IO;
namespace ACNH_win
{
    public partial class frmResidentInfo : Form
    {
        private readonly string _connStr;
        private int? _lastBubbleResidentId = null;
        private bool _tresMode = false;

        public frmResidentInfo(string connStr)
        {
            InitializeComponent();
            _connStr = connStr;

            this.BackColor = Color.FromArgb(250, 247, 242);

            this.KeyPreview = true;
            this.KeyDown += (s, e) => { if (e.KeyCode == Keys.Escape) this.Close(); };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _tresMode = false;
            btnRestore.Visible = false;
            BindResidents();
        }

        // ── 垃圾桶模式 ──────────────────────────────────────────────
        private void chkTrashMode_CheckedChanged_1(object sender, EventArgs e)
        {
            _tresMode = chkTrashMode.Checked;
            btnRestore.Visible = _tresMode;
            btnGiveGift.Enabled = !_tresMode;
            btnDeleteResident.Enabled = !_tresMode;
            btnResetAffection.Enabled = !_tresMode;
            ClearResidentUI();
            BindResidents();
        }

        // ── 資料載入 ─────────────────────────────────────────────────
        private void BindResidents()
        {
            var helper = new DbHelper(_connStr);
            var sql = @"
SELECT r.Id, r.Name, s.Name AS Species, p.Name AS Personality,
       ISNULL(rf.Affection, 0) AS Affection
FROM   Residents r
JOIN   Species      s  ON s.Id = r.SpeciesId
JOIN   Personality  p  ON p.Id = r.PersonalityId
LEFT JOIN ResidentFriendship rf ON rf.ResidentId = r.Id
WHERE  r.IsDeleted = @IsDeleted
ORDER  BY r.Name;";

            var parameters = new SqlParameterBuilder()
                .AddInt("@IsDeleted", _tresMode ? 1 : 0)
                .ToArry();

            var rows = helper.Query(reader => new ResidentRowDto
            {
                Id          = reader.GetInt32(0),
                Name        = reader.GetString(1),
                Species     = reader.GetString(2),
                Personality = reader.GetString(3),
                Affection   = reader.GetInt32(4)
            }, sql, parameters).ToList();

            dgvResidents.DataSource = rows;
        }

        private void LoadResidentDetail(int residentId)
        {
            var helper = new DbHelper(_connStr);
            var sql = @"
SELECT r.Id, r.Name, s.Name AS Species, p.Name AS Personality,
       r.CatchPhrase, r.ImagePath,
       ISNULL(rf.Affection, 0) AS Affection
FROM   Residents r
JOIN   Species      s  ON s.Id = r.SpeciesId
JOIN   Personality  p  ON p.Id = r.PersonalityId
LEFT JOIN ResidentFriendship rf ON rf.ResidentId = r.Id
WHERE  r.Id = @Id AND r.IsDeleted = 0;";

            var parameters = new SqlParameterBuilder()
                .AddInt("@Id", residentId)
                .ToArry();

            var dto = helper.Load(reader => new ResidentDetailDto
            {
                Id          = reader.GetInt32(0),
                Name        = reader.GetString(1),
                Species     = reader.GetString(2),
                Personality = reader.GetString(3),
                CatchPhrase = reader.IsDBNull(4) ? "" : reader.GetString(4),
                ImagePath   = reader.IsDBNull(5) ? null : reader.GetString(5),
                Affection   = reader.GetInt32(6)
            }, sql, parameters);

            if (dto == null) return;

            lblNameValue.Text        = dto.Name;
            lblSpeciesValue.Text     = dto.Species;
            lblPersonalityValue.Text = dto.Personality;
            lblCatchPhraseValue.Text = dto.CatchPhrase;
            lblAffectionValue.Text   = dto.Affection.ToString();

            LoadResidentImage(dto.ImagePath);
        }

        // ── DataGridView 選取 ─────────────────────────────────────────
        private void dgvResidents_SelectionChanged(object sender, EventArgs e)
        {
            if (_tresMode) return;
            if (dgvResidents.SelectedRows.Count == 0) return;

            var selected = dgvResidents.SelectedRows[0].DataBoundItem as ResidentRowDto;
            if (selected == null) return;

            LoadResidentDetail(selected.Id);

            if (_lastBubbleResidentId == selected.Id) return;
            string catchPhrase = lblCatchPhraseValue.Text;
            if (!string.IsNullOrWhiteSpace(catchPhrase))
                ShowSpeechBubble(catchPhrase);
            _lastBubbleResidentId = selected.Id;
        }

        private void SelectResidentById(int id)
        {
            foreach (DataGridViewRow row in dgvResidents.Rows)
            {
                if (row.DataBoundItem is ResidentRowDto dto && dto.Id == id)
                {
                    dgvResidents.ClearSelection();
                    row.Selected = true;
                    dgvResidents.FirstDisplayedScrollingRowIndex = row.Index;
                    return;
                }
            }
        }

        // ── 語音泡泡 ─────────────────────────────────────────────────
        private void ShowSpeechBubble(string text)
        {
            var bubble   = new Form2frmSpeechBubble(text);
            var formRect = this.RectangleToScreen(this.ClientRectangle);
            var pic      = picResident.PointToScreen(Point.Empty);

            int x = pic.X + picResident.Width / 2 - bubble.Width / 2;
            int y = pic.Y - bubble.Height - 10;

            if (x < formRect.Left)                     x = formRect.Left;
            if (x + bubble.Width > formRect.Right)     x = formRect.Right - bubble.Width;
            y = Math.Max(y, formRect.Top + 5);
            if (y + bubble.Height > formRect.Bottom)   y = formRect.Bottom - bubble.Height;

            bubble.Location = new Point(x, y);
            bubble.Show(this);
        }

        // ── 圖片載入 ─────────────────────────────────────────────────
        private void LoadResidentImage(string? imagePath)
        {
            string defaultRelative = @"Residents\default.png";
            string relative = string.IsNullOrWhiteSpace(imagePath) ? defaultRelative : imagePath;
            string fullPath = Path.Combine(Application.StartupPath, relative);

            if (!File.Exists(fullPath))
                fullPath = Path.Combine(Application.StartupPath, defaultRelative);

            if (!File.Exists(fullPath)) return;

            picResident.Image?.Dispose();
            var bytes = File.ReadAllBytes(fullPath);
            using var ms = new MemoryStream(bytes);
            picResident.Image    = Image.FromStream(ms);
            picResident.SizeMode = PictureBoxSizeMode.Zoom;
        }

        // ── UI 清除 ───────────────────────────────────────────────────
        private void ClearResidentUI()
        {
            lblNameValue.Text        = "";
            lblSpeciesValue.Text     = "";
            lblPersonalityValue.Text = "";
            lblCatchPhraseValue.Text = "";
            lblAffectionValue.Text   = "0";
            picResident.Image?.Dispose();
            picResident.Image = null;
        }

        // ── 按鈕事件 ─────────────────────────────────────────────────
        private void btnGiveGift_Click(object sender, EventArgs e)
        {
            if (dgvResidents.SelectedRows.Count == 0) return;
            var selected = dgvResidents.SelectedRows[0].DataBoundItem as ResidentRowDto;
            if (selected == null) return;

            using var frm = new frmGiveGift(selected.Id, selected.Name, _connStr);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadResidentDetail(selected.Id);
                BindResidents(); // 重新整理好感度欄
            }
        }

        private void btnDeleteResident_Click(object sender, EventArgs e)
        {
            if (dgvResidents.SelectedRows.Count == 0)
            {
                MessageBox.Show("請先選擇居民");
                return;
            }
            var selected = dgvResidents.SelectedRows[0].DataBoundItem as ResidentRowDto;
            if (selected == null) return;

            using var frm = new frmResidentDelete(_connStr, selected.Id, selected.Name);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                BindResidents();
                ClearResidentUI();
            }
        }

        private void btnResetAffection_Click(object sender, EventArgs e)
        {
            if (dgvResidents.SelectedRows.Count == 0)
            {
                MessageBox.Show("請先選擇居民");
                return;
            }
            var selected = dgvResidents.SelectedRows[0].DataBoundItem as ResidentRowDto;
            if (selected == null) return;

            ResetAffectionForResident(selected.Id);
            LoadResidentDetail(selected.Id);
            BindResidents();
            MessageBox.Show("已歸零（測試用）");
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (!_tresMode)
            {
                MessageBox.Show("請先勾選「顯示垃圾桶」");
                return;
            }
            if (dgvResidents.SelectedRows.Count == 0)
            {
                MessageBox.Show("請先選擇要回復的居民");
                return;
            }
            var selected = dgvResidents.SelectedRows[0].DataBoundItem as ResidentRowDto;
            if (selected == null) return;

            var helper = new DbHelper(_connStr);
            int rows = helper.ExecuteNonQuery(
                "UPDATE Residents SET IsDeleted = 0 WHERE Id = @Id",
                new SqlParameter("@Id", selected.Id));

            if (rows > 0)
            {
                MessageBox.Show("已回復居民");
                BindResidents();
                ClearResidentUI();
            }
            else
            {
                MessageBox.Show("回復失敗");
            }
        }

        private void btnAddResident_Click(object sender, EventArgs e)
        {
            using var frm = new frmResidentAdd(_connStr);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                BindResidents();
                if (frm.NewResidentId.HasValue)
                    SelectResidentById(frm.NewResidentId.Value);
            }
        }

        private void btnOpenSearch_Click(object sender, EventArgs e)
        {
            using var frm = new frmResidentSearch(_connStr);
            if (frm.ShowDialog() == DialogResult.OK && frm.SelectedResidentId.HasValue)
                SelectResidentById(frm.SelectedResidentId.Value);
        }

        // ── 好感度歸零（DB）────────────────────────────────────────────
        private void ResetAffectionForResident(int residentId)
        {
            using var conn = new SqlConnection(_connStr);
            conn.Open();
            using var cmd = new SqlCommand(@"
UPDATE dbo.ResidentFriendship
SET    Affection = 0, UpdatedTime = GETDATE()
WHERE  ResidentId = @ResidentId;", conn);
            cmd.Parameters.AddWithValue("@ResidentId", residentId);
            if (cmd.ExecuteNonQuery() == 0)
            {
                using var insert = new SqlCommand(@"
INSERT INTO dbo.ResidentFriendship(ResidentId, Affection, UpdatedTime)
VALUES (@ResidentId, 0, GETDATE());", conn);
                insert.Parameters.AddWithValue("@ResidentId", residentId);
                insert.ExecuteNonQuery();
            }
        }
    }
}
