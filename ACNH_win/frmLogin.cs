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
		//增加建構子
		private readonly string _connStr;
		public frmLogin(string connStr)
		{
			InitializeComponent();
			this.DoubleBuffered = true;
			_connStr = connStr;

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



			if (UserRepository.TryLogin(_connStr, username, password, out int userId))
			{
				Session.CurrentUserId = userId;
				Session.CurrentUsername = username;

                var main = new frmMain(_connStr);
                main.Show();

                main.FormClosed += (_, __) => this.Close();

                this.Hide();
            }
			else
			{
				MessageBox.Show("帳號或密碼錯誤");
			}
		}

		private void frmLogin_Load(object sender, EventArgs e)
        {
            string gifPath = Path.Combine(Application.StartupPath, "Assets", "背景.gif");
            picBackground.Image = Image.FromFile(gifPath);
            picBackground.SendToBack();

           
            label1.Parent = picBackground;
            label2.Parent = picBackground;
            label3.Parent = picBackground;

            
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;

            
            label1.ForeColor = Color.FromArgb(255, 252, 240);
			label2.ForeColor = Color.FromArgb(255, 252, 240);
			label3.ForeColor = Color.FromArgb(245, 220, 160);



			label3.Padding = new Padding(4, 2, 4, 2);
            label1.Padding = new Padding(4, 2, 4, 2);
            label2.Padding = new Padding(4, 2, 4, 2);

            
            btnLogin.BackColor = Color.FromArgb(76, 175, 80);
            btnLogin.ForeColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;



        }
    }
}
