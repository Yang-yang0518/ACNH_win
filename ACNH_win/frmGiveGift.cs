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
using Microsoft.Data.SqlClient;

namespace ACNH_win
{
    public partial class frmGiveGift : Form
    {
        private readonly int _residentId;
        private readonly string _residentName;
        private readonly string _connStr;

        //建構函式
        public frmGiveGift(int residentId, string residentName, string connStr)
        {
            InitializeComponent();

            _residentId = residentId;
            _residentName = residentName;
            _connStr = connStr;

            lblResidentNameValue.Text = _residentName;
            LoadGifts(); //呼叫

            cboGifts.SelectedIndexChanged += (_, __) => RefreshPreview();
            RefreshPreview();
        }

        //載入禮物清單
        private void LoadGifts()
        {
            var helper = new DbHelper(_connStr);

            string sql = @"
SELECT Id, Name
FROM Gifts
WHERE IsDeleted = 0
ORDER BY Name;";

            var gifts = helper.Query(reader => new GiftOptionDto
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1)
            }, sql).ToList();

            cboGifts.DataSource = gifts;
            cboGifts.DisplayMember = "Name";
            cboGifts.ValueMember = "Id";
        }

        private void RefreshPreview()
        {
            if (cboGifts.SelectedItem is not GiftOptionDto gift) return;

            var helper = new DbHelper(_connStr);

            // Delta
            string sqlDelta = @"
SELECT COALESCE((
    SELECT TOP (1) Delta
    FROM dbo.ResidentGiftPreference
    WHERE ResidentId = @ResidentId AND GiftId = @GiftId
), 0) AS Value;";

            var p1 = new SqlParameterBuilder()
                .AddInt("@ResidentId", _residentId)
                .AddInt("@GiftId", gift.Id)
                .ToArry();

            var deltaRow = helper.Load(reader => new IntResultDto
            {
                Value = reader.GetInt32(0)
            }, sqlDelta, p1);

            int delta = deltaRow?.Value ?? 0;

            // Affection (目前好感度)
            string sqlAff = @"
SELECT COALESCE((
    SELECT TOP (1) Affection
    FROM dbo.ResidentFriendship
    WHERE ResidentId = @ResidentId
), 0) AS Value;";

            var p2 = new SqlParameterBuilder()
                .AddInt("@ResidentId", _residentId)
                .ToArry();

            var affRow = helper.Load(reader => new IntResultDto
            {
                Value = reader.GetInt32(0)
            }, sqlAff, p2);

            int affection = affRow?.Value ?? 0;

            // 更新 UI（預覽）
            lblDeltaValue.Text = delta >= 0 ? $"+{delta}" : delta.ToString();
            lblAffectionValue.Text = (affection + delta).ToString();
            lblFeedback.Text = "(尚未送禮)";
        }






        private void btnSendGift_Click(object sender, EventArgs e)
        {
            if (cboGifts.SelectedItem == null)
            {
                MessageBox.Show("請先選禮物");
                return;
            }

            var gift = (GiftOptionDto)cboGifts.SelectedItem;

            var helper = new DbHelper(_connStr);

            string sql = @"
DECLARE @Delta INT;

SELECT @Delta = Delta
FROM dbo.ResidentGiftPreference
WHERE ResidentId = @ResidentId
  AND GiftId = @GiftId;

IF @Delta IS NULL SET @Delta = 0;

IF NOT EXISTS (SELECT 1 FROM dbo.ResidentFriendship WHERE ResidentId = @ResidentId)
BEGIN
    INSERT INTO dbo.ResidentFriendship (ResidentId, Affection, UpdatedTime)
    VALUES (@ResidentId, 0, SYSDATETIME());
END

UPDATE dbo.ResidentFriendship
SET Affection = Affection + @Delta,
    UpdatedTime = SYSDATETIME()
WHERE ResidentId = @ResidentId;

SELECT @Delta AS DeltaApplied, Affection
FROM dbo.ResidentFriendship
WHERE ResidentId = @ResidentId;
";

            var parameters = new SqlParameterBuilder()
                .AddInt("@ResidentId", _residentId)
                .AddInt("@GiftId", gift.Id)
                .ToArry();

            // 讀回 DeltaApplied 與 Affection
            var result = helper.Load(reader => new GiveGiftResultDto
            {
                DeltaApplied = reader.GetInt32(0),
                Affection = reader.GetInt32(1)
            }, sql, parameters);

            if (result == null)
            {
                MessageBox.Show("送禮失敗：查無回傳結果");
                return;
            }

            // 更新 UI
            lblDeltaValue.Text = result.DeltaApplied >= 0 ? $"+{result.DeltaApplied}" : result.DeltaApplied.ToString();
            lblAffectionValue.Text = result.Affection.ToString();
            lblFeedback.Text = BuildFeedbackText(result.DeltaApplied);

            // 告訴上一個視窗：成功了，請刷新
            //this.DialogResult = DialogResult.OK;
            //this.Close();
        }


        //添加屬性for視窗用
        private class GiveGiftResultDto
        {
            public int DeltaApplied { get; set; }
            public int Affection { get; set; }
        }

        private class IntResultDto
        {
            public int Value { get; set; }
        }


        private string BuildFeedbackText(int delta)
        {
            if (delta > 0) return $"喜歡!!!! (好感度 +{delta})";
            if (delta < 0) return $"討厭!!!! (好感度 -{delta})";
            return "普通ㄟ~(好感度 +0)";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
