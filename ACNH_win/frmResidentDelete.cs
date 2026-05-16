using ACNH_win.Helpers;
using Microsoft.Data.SqlClient;
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
    public partial class frmResidentDelete : Form
    {
        private readonly int _residentId;
        private readonly string _connStr;
        public frmResidentDelete(string connStr, int residentId, string residentName)
        {
            InitializeComponent();

            _residentId = residentId;
            _connStr = connStr;

            label1.Text = $"確定要刪除居民{residentName}移到垃圾桶嗎?";

            this.BackColor = Color.FromArgb(250, 247, 242);

            this.KeyPreview = true;
            this.KeyDown += frmResidentDelete_KeyDown;

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var sql = @"UPDATE Residents SET IsDeleted = 1 WHERE Id = @Id";

            var helper = new DbHelper(_connStr);
            int rows = helper.ExecuteNonQuery(sql,
                new SqlParameter("@Id", _residentId));

            if (rows > 0)
            {
                MessageBox.Show("已移到垃圾桶(可回復)");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else 
            {
                MessageBox.Show("刪除失敗");
            }
        }
        private void frmResidentDelete_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();   // ESC = 取消刪除、關閉視窗
            }
        }
    }
}
