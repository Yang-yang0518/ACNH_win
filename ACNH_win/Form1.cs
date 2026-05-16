using ACNH_win.Helpers;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
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
			this.Load += Form1_Load;
			_connStr = connStr;

			this.KeyPreview = true;
			this.KeyDown += frmResidentInfo_KeyDown;

			lstResidents.PreviewKeyDown += (s, e) =>
			{
				if (e.KeyCode == Keys.Escape) this.Close();
			};



			this.BackColor = Color.FromArgb(250, 247, 242);
			lstResidents.Font = new Font("微軟正黑體", 11F);


			foreach (Control c in this.Controls)
			{
				if (c is TextBox tb)
				{
					tb.BackColor = Color.White;
				}
			}
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			_tresMode = false;

			btnRestore.Visible = false;
			chkTrashMode.CheckedChanged += ChkTrashMode_CheckedChanged;

			BindResidents();

		}

		private void ChkTrashMode_CheckedChanged(object? sender, EventArgs e)
		{
			_tresMode = chkTrashMode.Checked;

			btnRestore.Visible = _tresMode;

			// 垃圾桶模式不給送禮/刪除/歸零（避免邏輯混亂）
			btnGiveGift.Enabled = !_tresMode;
			btnDeleteResident.Enabled = !_tresMode;
			btnResetAffection.Enabled = !_tresMode;

			ClearResidentUI();
			BindResidents();
		}

		private void BindResidents()
		{
			var helper = new DbHelper(_connStr);

			var sql = @"
SELECT Id, Name
FROM Residents
WHERE IsDeleted = @IsDeleted
ORDER BY Name;";

			var parameters = new SqlParameterBuilder()
				.AddInt("@IsDeleted", _tresMode ? 1 : 0)
				.ToArry();

			var residents = helper.Query(reader => new ResidentsOptionDto
			{
				Id = reader.GetInt32(0),
				Name = reader.GetString(1)
			}, sql, parameters).ToList();

			lstResidents.DataSource = residents;
			lstResidents.DisplayMember = "Name";
			lstResidents.ValueMember = "Id";
		}

		private void lstResidents_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (_tresMode) return;

			if (lstResidents.SelectedItem == null) return;

			var selected = (ResidentsOptionDto)lstResidents.SelectedItem;
			LoadResidentDetail(selected.Id);

			if (_lastBubbleResidentId == selected.Id) return;

			// 直接拿居民口頭禪
			string catchPhrase = lblCatchPhraseValue.Text;

			if (string.IsNullOrWhiteSpace(catchPhrase))
				return; // 沒口頭禪就不要跳

			// 顯示對話泡泡
			ShowSpeechBubble(catchPhrase);

			_lastBubbleResidentId = selected.Id;
		}

		private void ShowSpeechBubble(string text)
		{
			var bubble = new Form2frmSpeechBubble(text);

			// 主視窗（居民資訊）在螢幕上的範圍
			var formRect = this.RectangleToScreen(this.ClientRectangle);

			// 居民圖片在螢幕上的位置
			var pic = picResident.PointToScreen(Point.Empty);

			// 目標：放在圖片「正上方」
			int x = pic.X + picResident.Width / 2 - bubble.Width / 2;
			int y = pic.Y - bubble.Height - 10;

			// 先把 X 夾在「主視窗」範圍內
			if (x < formRect.Left) x = formRect.Left;
			if (x + bubble.Width > formRect.Right) x = formRect.Right - bubble.Width;

			y = Math.Max(y, formRect.Top + 5);


			// 也不能超出視窗底部
			if (y + bubble.Height > formRect.Bottom) y = formRect.Bottom - bubble.Height;

			bubble.Location = new Point(x, y);
			bubble.Show(this);
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
			//先決定：沒路徑或找不到，就用預設輪廓圖
			string defaultRelative = @"Residents\default.png";
			string relative = string.IsNullOrWhiteSpace(imagePath) ? defaultRelative : imagePath;

			string fullPath = Path.Combine(Application.StartupPath, relative);

			if (!File.Exists(fullPath))
			{
				// 找不到指定圖 ,改用預設圖
				fullPath = Path.Combine(Application.StartupPath, defaultRelative);
			}

			//如果連預設圖都沒有，就不要清空（避免畫面突然空白）
			if (!File.Exists(fullPath))
			{
				// 你也可以改成 MessageBox 提醒
				return;
			}

			// 顯示：不鎖檔 + 保持比例
			picResident.Image?.Dispose();
			var bytes = File.ReadAllBytes(fullPath);
			using var ms = new MemoryStream(bytes);
			picResident.Image = Image.FromStream(ms);

			picResident.SizeMode = PictureBoxSizeMode.Zoom;
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

			using (var frm = new frmResidentDelete(_connStr, resident.Id, resident.Name))
			{
				var result = frm.ShowDialog();

				if (result == DialogResult.OK)
				{
					BindResidents();
					ClearResidentUI();
				}
			}

		}
		private void ClearResidentUI()
		{
			lblNameValue.Text = "";
			lblSpeciesValue.Text = "";
			lblPersonalityValue.Text = "";
			lblCatchPhraseValue.Text = "";
			lblAffectionValue.Text = "0";

			picResident.Image?.Dispose();
			picResident.Image = null;
		}

		private void btnResetAffection_Click(object sender, EventArgs e)
		{
			if (lstResidents.SelectedItem == null)
			{
				MessageBox.Show("請先選擇居民");
				return;
			}

			var selected = (ResidentsOptionDto)lstResidents.SelectedItem;

			ResetAffectionForResident(selected.Id);


			LoadResidentDetail(selected.Id);

			MessageBox.Show("已歸零（測試用）");
		}

		private void ResetAffectionForResident(int residentId)
		{
			using var conn = new SqlConnection(_connStr);
			conn.Open();

			// 先更新
			using (var cmd = new SqlCommand(
				@"UPDATE dbo.ResidentFriendship
          SET Affection = 0,
              UpdatedTime = GETDATE()
          WHERE ResidentId = @ResidentId;", conn))
			{
				cmd.Parameters.AddWithValue("@ResidentId", residentId);
				int rows = cmd.ExecuteNonQuery();

				// 如果沒更新到（代表沒有那筆），就補一筆
				if (rows == 0)
				{
					using var insertCmd = new SqlCommand(
						@"INSERT INTO dbo.ResidentFriendship(ResidentId, Affection, UpdatedTime)
                  VALUES (@ResidentId, 0, GETDATE());", conn);

					insertCmd.Parameters.AddWithValue("@ResidentId", residentId);
					insertCmd.ExecuteNonQuery();
				}
			}
		}
		private void frmResidentInfo_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}

		private void chkTrashMode_CheckedChanged_1(object sender, EventArgs e)
		{
			_tresMode = chkTrashMode.Checked;

			btnRestore.Visible = _tresMode;

			btnGiveGift.Enabled = !_tresMode;
			btnResetAffection.Enabled = !_tresMode;
			btnDeleteResident.Enabled = !_tresMode;

			ClearResidentUI();

			BindResidents();

		}

		private void btnRestore_Click(object sender, EventArgs e)
		{
			if (!_tresMode)
			{
				MessageBox.Show("請先勾選「顯示垃圾桶」");
				return;
			}

			if (lstResidents.SelectedItem == null)
			{
				MessageBox.Show("請先選擇要回復的居民");
				return;
			}

			int residentId = Convert.ToInt32(lstResidents.SelectedValue);

			var helper = new DbHelper(_connStr);
			var sql = @"UPDATE Residents SET IsDeleted = 0 WHERE Id = @Id";

			int rows = helper.ExecuteNonQuery(sql, new SqlParameter("@Id", residentId));

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
	}
}

