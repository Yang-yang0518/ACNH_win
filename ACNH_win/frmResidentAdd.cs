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

namespace ACNH_win
{
    public partial class frmResidentAdd : Form
    {
        private readonly string _connStr;

        public int? NewResidentId { get; private set; }  //讓主畫面讀得到

        public frmResidentAdd(string connStr)            //讓主畫面可以傳 _connStr
        {
            InitializeComponent();
            _connStr = connStr;
            this.Load += frmResidentAdd_Load;
        }

        private void frmResidentAdd_Load(object sender, EventArgs e)
        {
            BindSpecies();
            BindPersonality();

            cboSpecies.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPersonality.DropDownStyle = ComboBoxStyle.DropDownList;
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            //取值
            string name = txtName.Text.Trim();
            string catchPhrase = txtCatchPhrase.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("名字必填");
                return;
            }

            if (cboSpecies.SelectedItem == null || cboPersonality.SelectedItem == null)
            {
                MessageBox.Show("請選擇種族與性格");
                return;
            }

            int speciesId = (int)cboSpecies.SelectedValue;
            int personalityId = (int)cboPersonality.SelectedValue;

            var helper = new DbHelper(_connStr); //INSERT+取新Id

            var sql = @"
INSERT INTO Residents (Name, SpeciesId, PersonalityId, CatchPhrase, IsDeleted)
VALUES (@Name, @SpeciesId, @PersonalityId, @CatchPhrase, 0);

SELECT CAST(SCOPE_IDENTITY() AS int);";

            var p = new SqlParameterBuilder()
                .AddNVarChar("@Name", 50, name)
                .AddInt("@SpeciesId", speciesId)
                .AddInt("@PersonalityId", personalityId)
                .AddNVarChar("@CatchPhrase", 50, catchPhrase)
                .ToArry();

            int newId = helper.Query(r => new IdDto { Id = r.GetInt32(0) }, sql, p)
                .Select(x => x.Id)
                .FirstOrDefault();

            NewResidentId = newId;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BindSpecies() 
        { 
            var helper = new DbHelper(_connStr);
            var sql = "SELECT Id, Name FROM Species ORDER BY Name;";

            var date = helper.Query(r => new OptionDto
            { 
                Id=r.GetInt32(0),
                Name = r.GetString(1)
            }, sql).ToList();

            cboSpecies.DataSource = date;
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
                Name = r.GetString(1)
            },sql).ToList();

            cboPersonality.DataSource = data;
            cboPersonality.DisplayMember = "Name";
            cboPersonality.ValueMember = "Id";
        }
    }
}
