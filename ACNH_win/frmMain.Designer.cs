namespace ACNH_win
{
    partial class frmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			btnResidentList = new Button();
			btnResidentAdd = new Button();
			btnExit = new Button();
			picBackground = new PictureBox();
			((System.ComponentModel.ISupportInitialize)picBackground).BeginInit();
			SuspendLayout();
			// 
			// btnResidentList
			// 
			btnResidentList.FlatAppearance.BorderSize = 0;
			btnResidentList.FlatStyle = FlatStyle.Flat;
			btnResidentList.Font = new Font("微軟正黑體", 12F, FontStyle.Bold);
			btnResidentList.ForeColor = Color.White;
			btnResidentList.Location = new Point(108, 47);
			btnResidentList.Margin = new Padding(2);
			btnResidentList.Name = "btnResidentList";
			btnResidentList.Size = new Size(85, 35);
			btnResidentList.TabIndex = 0;
			btnResidentList.Text = "居民清單";
			btnResidentList.UseVisualStyleBackColor = true;
			btnResidentList.Click += btnResidentList_Click;
			// 
			// btnResidentAdd
			// 
			btnResidentAdd.FlatAppearance.BorderSize = 0;
			btnResidentAdd.FlatStyle = FlatStyle.Flat;
			btnResidentAdd.Font = new Font("微軟正黑體", 12F, FontStyle.Bold);
			btnResidentAdd.ForeColor = Color.White;
			btnResidentAdd.Location = new Point(110, 87);
			btnResidentAdd.Margin = new Padding(2);
			btnResidentAdd.Name = "btnResidentAdd";
			btnResidentAdd.Size = new Size(82, 28);
			btnResidentAdd.TabIndex = 1;
			btnResidentAdd.Text = "新增居民";
			btnResidentAdd.UseVisualStyleBackColor = true;
			btnResidentAdd.Click += btnResidentAdd_Click;
			// 
			// btnExit
			// 
			btnExit.FlatAppearance.BorderSize = 0;
			btnExit.FlatStyle = FlatStyle.Flat;
			btnExit.Font = new Font("微軟正黑體", 12F, FontStyle.Bold);
			btnExit.ForeColor = Color.White;
			btnExit.Location = new Point(111, 126);
			btnExit.Margin = new Padding(2);
			btnExit.Name = "btnExit";
			btnExit.Size = new Size(81, 32);
			btnExit.TabIndex = 2;
			btnExit.Text = "離開";
			btnExit.UseVisualStyleBackColor = true;
			btnExit.Click += btnExit_Click;
			// 
			// picBackground
			// 
			picBackground.Dock = DockStyle.Fill;
			picBackground.Location = new Point(0, 0);
			picBackground.Margin = new Padding(2);
			picBackground.Name = "picBackground";
			picBackground.Size = new Size(291, 193);
			picBackground.SizeMode = PictureBoxSizeMode.StretchImage;
			picBackground.TabIndex = 3;
			picBackground.TabStop = false;
			// 
			// frmMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(291, 193);
			Controls.Add(btnExit);
			Controls.Add(btnResidentAdd);
			Controls.Add(btnResidentList);
			Controls.Add(picBackground);
			DoubleBuffered = true;
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(2);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmMain";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "主頁";
			Load += frmMain_Load;
			((System.ComponentModel.ISupportInitialize)picBackground).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Button btnResidentList;
        private Button btnResidentAdd;
        private Button btnExit;
        private PictureBox picBackground;
    }
}