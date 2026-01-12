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

            label1.Text = $"確定要刪除居民{residentName}嗎?";

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var sql = @"UPDATE Residents SET IsDeleted = 1 WHERE Id = @Id";

            var helper = new DbHelper(_connStr);
            int rows = helper.ExecuteNonQuery(sql,
                new SqlParameter("@Id", _residentId));

            if (rows > 0)
            {
                MessageBox.Show("居民已刪除");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else 
            {
                MessageBox.Show("刪除失敗");
            }
        }
    }
}
