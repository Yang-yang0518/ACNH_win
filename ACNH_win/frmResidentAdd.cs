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

			this.BackColor = Color.FromArgb(250, 247, 242);

            this.KeyPreview = true;
            this.KeyDown -= frmResidentAdd_KeyDown;
            this.KeyDown += frmResidentAdd_KeyDown;
        }
		private string? _selectedImageFile;

		private void frmResidentAdd_Load(object sender, EventArgs e)
		{
			BindSpecies();
			BindPersonality();

			cboSpecies.DropDownStyle = ComboBoxStyle.DropDownList;
			cboPersonality.DropDownStyle = ComboBoxStyle.DropDownList;
		}



		private void btnSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(_selectedImageFile))
			{
				MessageBox.Show("請選擇居民照片");
				btnBrowsePhoto.Focus();
				return;
			}


			string name = txtName.Text.Trim();
			string? imagePath = SavePhotoToResidentsFolder(name);
			string catchPhrase = txtCatchPhrase.Text.Trim();

			if (string.IsNullOrWhiteSpace(name))
			{
				MessageBox.Show("名字必填");
				txtName.Focus();
				return;
			}

			if (cboSpecies.SelectedValue == null || cboPersonality.SelectedValue == null)
			{
				MessageBox.Show("請選擇種族與性格");
				return;
			}

			int speciesId = Convert.ToInt32(cboSpecies.SelectedValue);
			int personalityId = Convert.ToInt32(cboPersonality.SelectedValue);

			var helper = new DbHelper(_connStr);

			var sql = @"
INSERT INTO Residents
    (Name, SpeciesId, PersonalityId, CatchPhrase, ImagePath, IsDeleted)
VALUES
    (@Name, @SpeciesId, @PersonalityId, @CatchPhrase, @ImagePath, 0);

SELECT CAST(SCOPE_IDENTITY() AS int);";


			var p = new SqlParameterBuilder()
				.AddNVarChar("@Name", 50, name)
				.AddInt("@SpeciesId", speciesId)
				.AddInt("@PersonalityId", personalityId)
				.AddNVarChar("@CatchPhrase", 50, catchPhrase) // 空字串OK（或你要改成DBNull看DB）
				.AddNVarChar("@ImagePath", 200, imagePath?? @"Residents\輪廓.png")
				.ToArry();

			try
			{
				int newId = helper.Query(r => new IdDto { Id = r.GetInt32(0) }, sql, p)
					.Select(x => x.Id)
					.FirstOrDefault();

				if (newId <= 0)
				{
					MessageBox.Show("新增失敗（未取得新ID）");
					return;
				}

				NewResidentId = newId;
				MessageBox.Show("新增成功！");
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			catch (Exception ex)
			{
				// 如果你有 UNIQUE(Name)，這裡會很常進來
				MessageBox.Show("新增失敗：" + ex.Message);
			}
		}


		private void BindSpecies()
		{
			var helper = new DbHelper(_connStr);
			var sql = "SELECT Id, Name FROM Species ORDER BY Name;";

			var date = helper.Query(r => new OptionDto
			{
				Id = r.GetInt32(0),
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
			}, sql).ToList();

			cboPersonality.DataSource = data;
			cboPersonality.DisplayMember = "Name";
			cboPersonality.ValueMember = "Id";
		}

		private void btnBrowsePhoto_Click(object sender, EventArgs e)
		{
			using var ofd = new OpenFileDialog
			{
				Title = "選擇居民照片",
				Filter = "圖片檔|*.png;*.jpg;*.jpeg;*.bmp;*.webp",
				InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
				Multiselect = false
			};

			if (ofd.ShowDialog() != DialogResult.OK) return;

			_selectedImageFile = ofd.FileName;

			// 預覽：不鎖檔
			picPreview.Image?.Dispose();
			var bytes = File.ReadAllBytes(_selectedImageFile);
			using var ms = new MemoryStream(bytes);
			picPreview.Image = Image.FromStream(ms);
			picPreview.SizeMode = PictureBoxSizeMode.Zoom;
		}
		private string? SavePhotoToResidentsFolder(string residentName) 
		{
			if (string.IsNullOrWhiteSpace(_selectedImageFile)) return null;

			string destFolder = Path.Combine(Application.StartupPath, "Residents");
			Directory.CreateDirectory(destFolder);

			string ext = Path.GetExtension(_selectedImageFile); // .png/.jpg...
			string safeName = string.Concat(residentName.Where(ch => !Path.GetInvalidFileNameChars().Contains(ch)));
			if (string.IsNullOrWhiteSpace(safeName)) safeName = "resident";

			string fileName = $"{safeName}{ext}";
			string destFullPath = Path.Combine(destFolder, fileName);

			// 避免同名覆蓋：加時間戳
			if (File.Exists(destFullPath))
			{
				string stamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
				fileName = $"{safeName}_{stamp}{ext}";
				destFullPath = Path.Combine(destFolder, fileName);
			}

			File.Copy(_selectedImageFile, destFullPath, overwrite: false);

			// 存進 DB 的相對路徑
			return Path.Combine("Residents", fileName);
		}
        private void frmResidentAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                this.Close();
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
