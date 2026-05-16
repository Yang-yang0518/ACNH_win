using ACNH_win.Assets;

namespace ACNH_win
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
			txtUsername = new TextBox();
			txtPassword = new TextBox();
			btnLogin = new Button();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			panelLogin = new Panel();
			picBackground = new PictureBox();
			panelLogin.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)picBackground).BeginInit();
			SuspendLayout();
			// 
			// txtUsername
			// 
			txtUsername.BackColor = Color.AliceBlue;
			txtUsername.Location = new Point(140, 77);
			txtUsername.Margin = new Padding(2);
			txtUsername.MaxLength = 50;
			txtUsername.Name = "txtUsername";
			txtUsername.Size = new Size(98, 23);
			txtUsername.TabIndex = 0;
			// 
			// txtPassword
			// 
			txtPassword.BackColor = Color.AliceBlue;
			txtPassword.Location = new Point(140, 118);
			txtPassword.Margin = new Padding(2);
			txtPassword.MaxLength = 50;
			txtPassword.Name = "txtPassword";
			txtPassword.PasswordChar = '*';
			txtPassword.Size = new Size(98, 23);
			txtPassword.TabIndex = 1;
			txtPassword.UseSystemPasswordChar = true;
			// 
			// btnLogin
			// 
			btnLogin.Location = new Point(153, 157);
			btnLogin.Margin = new Padding(2);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(73, 23);
			btnLogin.TabIndex = 2;
			btnLogin.Text = "登入";
			btnLogin.UseVisualStyleBackColor = true;
			btnLogin.Click += btnLogin_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.AliceBlue;
			label1.Font = new Font("微軟正黑體", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
			label1.ForeColor = Color.FromArgb(128, 128, 255);
			label1.Location = new Point(91, 78);
			label1.Margin = new Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new Size(42, 21);
			label1.TabIndex = 3;
			label1.Text = "帳號";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.AliceBlue;
			label2.Font = new Font("微軟正黑體", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
			label2.ForeColor = Color.FromArgb(128, 128, 255);
			label2.Location = new Point(90, 118);
			label2.Margin = new Padding(2, 0, 2, 0);
			label2.Name = "label2";
			label2.Size = new Size(42, 21);
			label2.TabIndex = 3;
			label2.Text = "密碼";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.AliceBlue;
			label3.Font = new Font("微軟正黑體", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 136);
			label3.Location = new Point(110, 29);
			label3.Margin = new Padding(2, 0, 2, 0);
			label3.Name = "label3";
			label3.Size = new Size(137, 38);
			label3.TabIndex = 4;
			label3.Text = "島主登入";
			// 
			// panelLogin
			// 
			panelLogin.BackColor = Color.Black;
			panelLogin.Controls.Add(txtUsername);
			panelLogin.Controls.Add(label3);
			panelLogin.Controls.Add(txtPassword);
			panelLogin.Controls.Add(btnLogin);
			panelLogin.Controls.Add(label2);
			panelLogin.Controls.Add(label1);
			panelLogin.Controls.Add(picBackground);
			panelLogin.Dock = DockStyle.Fill;
			panelLogin.ForeColor = SystemColors.ControlText;
			panelLogin.Location = new Point(0, 0);
			panelLogin.Name = "panelLogin";
			panelLogin.Size = new Size(347, 208);
			panelLogin.TabIndex = 5;
			// 
			// picBackground
			// 
			picBackground.BackColor = Color.Black;
			picBackground.Dock = DockStyle.Fill;
			picBackground.Location = new Point(0, 0);
			picBackground.Name = "picBackground";
			picBackground.Size = new Size(347, 208);
			picBackground.SizeMode = PictureBoxSizeMode.StretchImage;
			picBackground.TabIndex = 6;
			picBackground.TabStop = false;
			// 
			// frmLogin
			// 
			AcceptButton = btnLogin;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(347, 208);
			Controls.Add(panelLogin);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(2);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmLogin";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "島主登入";
			Load += frmLogin_Load;
			panelLogin.ResumeLayout(false);
			panelLogin.PerformLayout();
			((System.ComponentModel.ISupportInitialize)picBackground).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label label1;
        private Label label2;
        private Label label3;
		private Panel panelLogin;
		private PictureBox picBackground;
	}
}