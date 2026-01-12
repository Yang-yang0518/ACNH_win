using ACNH_win.Security;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text; // 密碼不要 Trim

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("請輸入帳號與密碼");
                return;
            }

            string connStr = Program.GetConnectionString();

            if (UserRepository.TryLogin(connStr, username, password, out int userId))
            {
                Session.CurrentUserId = userId;
                Session.CurrentUsername = username;

                var main = new Form1();
                main.Show();

                this.Hide();   // 或 this.Close();
            }
            else
            {
                MessageBox.Show("帳號或密碼錯誤");
            }
        }
    }
}
