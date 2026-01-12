using ACNH_win.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ACNH_win
{
    public partial class frmResidentSearch : Form
    {
        private readonly string _connStr;

        public int? SelectedResidentId { get; private set; }
        public frmResidentSearch(string connStr)
        {
            InitializeComponent();
            _connStr = connStr;

            this.Load += frmResidentSearch_Load;
            btnSearch.Click += BtnSearch_Click;
            dgvResidents.CellDoubleClick += DgvResidents_CellDoubleClick;
        }

        private void frmResidentSearch_Load(object sender, EventArgs e)
        {
            BindSpecies();
            BindPersonality();

            cboSpecies.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPersonality.DropDownStyle = ComboBoxStyle.DropDownList;

            dgvResidents.AutoGenerateColumns = true;
            dgvResidents.ReadOnly = true;
            dgvResidents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResidents.MultiSelect = false;

            SearchAndBind();
        }

        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            SearchAndBind();
        }

        private void SearchAndBind()
        {
            var helper = new DbHelper(_connStr);

            string keyword = txtKeyword.Text.Trim();
            int? speciesId = (cboSpecies.SelectedValue as int?);
            int? personalityId = (cboPersonality.SelectedValue as int?);

            if (speciesId == 0) speciesId = null;
            if (personalityId == 0) personalityId = null;

            string sql = @"
SELECT
    r.Id,
    r.Name,
    s.Name AS Species,
    p.Name AS Personality,
    ISNULL(rf.Affection, 0) AS Affection
FROM Residents r
JOIN Species s ON s.Id = r.SpeciesId
JOIN Personality p ON p.Id = r.PersonalityId
LEFT JOIN ResidentFriendship rf ON rf.ResidentId = r.Id
WHERE r.IsDeleted = 0
";

            var builder = new SqlParameterBuilder();

            //名字條件
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                sql += " AND r.Name LIKE @Keyword";
                builder.AddNVarChar("@Keyword", 50, "%" + keyword + "%");
            }

            //種族條件
            if (speciesId.HasValue)
            {
                sql += " AND r.SpeciesId = @SpeciesId";
                builder.AddInt("@SpeciesId", speciesId.Value);
            }

            //性格條件
            if (personalityId.HasValue)
            {
                sql += " AND r.PersonalityId = @PersonalityId";
                builder.AddInt("@PersonalityId", personalityId.Value);
            }

            sql += " ORDER BY r.Name;";

            var parameters = builder.ToArry();

            var rows = helper.Query(r => new ResidentRowDto
            {
                Id = r.GetInt32(0),
                Name = r.GetString(1),
                Species = r.GetString(2),
                Personality = r.GetString(3),
                Affection = r.GetInt32(4)
            }, sql, parameters).ToList();

            dgvResidents.DataSource = rows;
        }

        private void BindSpecies()  //下拉資料(含全部)
        {
            var helper = new DbHelper(_connStr);
            var sql = "SELECT Id, Name FROM Species ORDER BY Name;";

            var data = helper.Query(r => new OptionDto
            {
                Id = r.GetInt32(0),
                Name = r.GetString(1),
            }, sql).ToList();

            data.Insert(0, new OptionDto { Id = 0, Name = "全部" });

            cboSpecies.DataSource = data;
            cboSpecies.DisplayMember = "Name";
            cboSpecies.ValueMember = "Id";
        }

        private void BindPersonality()
        {
            var helper = new DbHelper(_connStr);
            var sql = "SELECT Id, Name FROM Personality ORDER BY Name;";

            var data = helper.Query(r => new OptionDto
            {
                Id = r.GetInt32(0),
                Name = r.GetString(1),
            }, sql).ToList();

            data.Insert(0, new OptionDto { Id = 0, Name = "全部" });

            cboPersonality.DataSource = data;
            cboPersonality.DisplayMember = "Name";
            cboPersonality.ValueMember = "Id";

        }

        private void DgvResidents_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvResidents.Rows[e.RowIndex].DataBoundItem as ResidentRowDto;
            if (row == null) return;

            SelectedResidentId = row.Id;
            this.DialogResult = DialogResult.OK;
        }
    }
}
