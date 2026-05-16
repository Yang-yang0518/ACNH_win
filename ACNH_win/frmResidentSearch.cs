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

            this.KeyPreview = true;
            this.KeyDown += frmResidentSearch_KeyDown;

            this.Load += frmResidentSearch_Load;
			btnSearch.Click += BtnSearch_Click;
			dgvResidents.CellDoubleClick += DgvResidents_CellDoubleClick;

            this.BackColor = Color.FromArgb(250, 247, 242);
        }

		private void frmResidentSearch_Load(object sender, EventArgs e)
		{
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

			if (rows.Count == 0) 
			{
				MessageBox.Show("查無符合的居民","提示",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			if (dgvResidents.Columns["Id"] != null) dgvResidents.Columns["Id"].HeaderText = "編號";
			if (dgvResidents.Columns["Name"] != null) dgvResidents.Columns["Name"].HeaderText = "居民";
			if (dgvResidents.Columns["Species"] != null) dgvResidents.Columns["Species"].HeaderText = "種族";
			if (dgvResidents.Columns["Personality"] != null) dgvResidents.Columns["Personality"].HeaderText = "性格";
			if (dgvResidents.Columns["Affection"] != null) dgvResidents.Columns["Affection"].HeaderText = "好感度";

			if (dgvResidents.Columns["Id"] != null) dgvResidents.Columns["Id"].Visible = false;

			if (dgvResidents.Columns["Affection"] != null)
				dgvResidents.Columns["Affection"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;



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


        }

		private void DgvResidents_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			var row = dgvResidents.Rows[e.RowIndex].DataBoundItem as ResidentRowDto;
			if (row == null) return;

			SelectedResidentId = row.Id;
			this.DialogResult = DialogResult.OK;
		}

        private void frmResidentSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

    }
}
