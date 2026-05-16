namespace ACNH_win
{
    partial class frmResidentInfo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResidentInfo));
			btnGiveGift = new Button();
			picResident = new PictureBox();
			lstResidents = new ListBox();
			lblNameValue = new Label();
			lblSpeciesValue = new Label();
			lblPersonalityValue = new Label();
			lblAffectionValue = new Label();
			lblCatchPhraseValue = new Label();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			lblNameTitle = new Label();
			btnDeleteResident = new Button();
			btnResetAffection = new Button();
			chkTrashMode = new CheckBox();
			btnRestore = new Button();
			BtnSearch = new Button();
			((System.ComponentModel.ISupportInitialize)picResident).BeginInit();
			SuspendLayout();
			// 
			// btnGiveGift
			// 
			btnGiveGift.Location = new Point(268, 230);
			btnGiveGift.Margin = new Padding(2);
			btnGiveGift.Name = "btnGiveGift";
			btnGiveGift.Size = new Size(89, 32);
			btnGiveGift.TabIndex = 4;
			btnGiveGift.Text = "送禮";
			btnGiveGift.UseVisualStyleBackColor = true;
			btnGiveGift.Click += btnGiveGift_Click;
			// 
			// picResident
			// 
			picResident.Location = new Point(17, 42);
			picResident.Margin = new Padding(2);
			picResident.Name = "picResident";
			picResident.Size = new Size(198, 165);
			picResident.SizeMode = PictureBoxSizeMode.Zoom;
			picResident.TabIndex = 6;
			picResident.TabStop = false;
			// 
			// lstResidents
			// 
			lstResidents.DisplayMember = "Name";
			lstResidents.FormattingEnabled = true;
			lstResidents.HorizontalScrollbar = true;
			lstResidents.IntegralHeight = false;
			lstResidents.ItemHeight = 15;
			lstResidents.Location = new Point(226, 42);
			lstResidents.Margin = new Padding(2);
			lstResidents.Name = "lstResidents";
			lstResidents.Size = new Size(182, 166);
			lstResidents.TabIndex = 0;
			lstResidents.ValueMember = "Id";
			lstResidents.SelectedIndexChanged += lstResidents_SelectedIndexChanged;
			// 
			// lblNameValue
			// 
			lblNameValue.BorderStyle = BorderStyle.FixedSingle;
			lblNameValue.Location = new Point(85, 214);
			lblNameValue.Margin = new Padding(2, 0, 2, 0);
			lblNameValue.Name = "lblNameValue";
			lblNameValue.Size = new Size(100, 22);
			lblNameValue.TabIndex = 9;
			lblNameValue.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// lblSpeciesValue
			// 
			lblSpeciesValue.BorderStyle = BorderStyle.FixedSingle;
			lblSpeciesValue.Location = new Point(86, 248);
			lblSpeciesValue.Margin = new Padding(2, 0, 2, 0);
			lblSpeciesValue.Name = "lblSpeciesValue";
			lblSpeciesValue.Size = new Size(100, 22);
			lblSpeciesValue.TabIndex = 10;
			lblSpeciesValue.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// lblPersonalityValue
			// 
			lblPersonalityValue.BorderStyle = BorderStyle.FixedSingle;
			lblPersonalityValue.Location = new Point(86, 280);
			lblPersonalityValue.Margin = new Padding(2, 0, 2, 0);
			lblPersonalityValue.Name = "lblPersonalityValue";
			lblPersonalityValue.Size = new Size(100, 22);
			lblPersonalityValue.TabIndex = 11;
			lblPersonalityValue.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// lblAffectionValue
			// 
			lblAffectionValue.BorderStyle = BorderStyle.FixedSingle;
			lblAffectionValue.Location = new Point(86, 315);
			lblAffectionValue.Margin = new Padding(2, 0, 2, 0);
			lblAffectionValue.Name = "lblAffectionValue";
			lblAffectionValue.Size = new Size(100, 22);
			lblAffectionValue.TabIndex = 12;
			lblAffectionValue.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// lblCatchPhraseValue
			// 
			lblCatchPhraseValue.BorderStyle = BorderStyle.FixedSingle;
			lblCatchPhraseValue.Location = new Point(86, 350);
			lblCatchPhraseValue.Margin = new Padding(2, 0, 2, 0);
			lblCatchPhraseValue.Name = "lblCatchPhraseValue";
			lblCatchPhraseValue.Size = new Size(100, 22);
			lblCatchPhraseValue.TabIndex = 13;
			lblCatchPhraseValue.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("微軟正黑體", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
			label1.Location = new Point(22, 352);
			label1.Margin = new Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new Size(60, 17);
			label1.TabIndex = 18;
			label1.Text = "口頭禪：";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("微軟正黑體", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
			label2.Location = new Point(4, 316);
			label2.Margin = new Padding(2, 0, 2, 0);
			label2.Name = "label2";
			label2.Size = new Size(86, 17);
			label2.TabIndex = 17;
			label2.Text = "目前好感度：";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("微軟正黑體", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
			label3.Location = new Point(35, 282);
			label3.Margin = new Padding(2, 0, 2, 0);
			label3.Name = "label3";
			label3.Size = new Size(47, 17);
			label3.TabIndex = 16;
			label3.Text = "喜好：";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("微軟正黑體", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
			label4.Location = new Point(34, 251);
			label4.Margin = new Padding(2, 0, 2, 0);
			label4.Name = "label4";
			label4.Size = new Size(47, 17);
			label4.TabIndex = 15;
			label4.Text = "種族：";
			// 
			// lblNameTitle
			// 
			lblNameTitle.AutoSize = true;
			lblNameTitle.Font = new Font("微軟正黑體", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
			lblNameTitle.Location = new Point(34, 215);
			lblNameTitle.Margin = new Padding(2, 0, 2, 0);
			lblNameTitle.Name = "lblNameTitle";
			lblNameTitle.Size = new Size(47, 17);
			lblNameTitle.TabIndex = 14;
			lblNameTitle.Text = "名字：";
			lblNameTitle.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// btnDeleteResident
			// 
			btnDeleteResident.Location = new Point(268, 269);
			btnDeleteResident.Margin = new Padding(2);
			btnDeleteResident.Name = "btnDeleteResident";
			btnDeleteResident.Size = new Size(89, 32);
			btnDeleteResident.TabIndex = 21;
			btnDeleteResident.Text = "刪除居民";
			btnDeleteResident.UseVisualStyleBackColor = true;
			btnDeleteResident.Click += btnDeleteResident_Click;
			// 
			// btnResetAffection
			// 
			btnResetAffection.BackColor = Color.LightGray;
			btnResetAffection.Cursor = Cursors.Hand;
			btnResetAffection.FlatAppearance.BorderSize = 0;
			btnResetAffection.FlatStyle = FlatStyle.Flat;
			btnResetAffection.Location = new Point(277, 352);
			btnResetAffection.Name = "btnResetAffection";
			btnResetAffection.Size = new Size(75, 23);
			btnResetAffection.TabIndex = 22;
			btnResetAffection.Text = "歸零好感度";
			btnResetAffection.UseVisualStyleBackColor = false;
			btnResetAffection.Click += btnResetAffection_Click;
			// 
			// chkTrashMode
			// 
			chkTrashMode.AutoSize = true;
			chkTrashMode.Location = new Point(385, 264);
			chkTrashMode.Name = "chkTrashMode";
			chkTrashMode.Size = new Size(86, 19);
			chkTrashMode.TabIndex = 23;
			chkTrashMode.Text = "顯示垃圾桶";
			chkTrashMode.UseVisualStyleBackColor = true;
			chkTrashMode.CheckedChanged += chkTrashMode_CheckedChanged_1;
			// 
			// btnRestore
			// 
			btnRestore.BackColor = Color.FromArgb(192, 255, 192);
			btnRestore.FlatAppearance.BorderSize = 0;
			btnRestore.FlatStyle = FlatStyle.Flat;
			btnRestore.Location = new Point(389, 287);
			btnRestore.Name = "btnRestore";
			btnRestore.Size = new Size(75, 25);
			btnRestore.TabIndex = 24;
			btnRestore.Text = "回復居民";
			btnRestore.UseVisualStyleBackColor = false;
			btnRestore.Visible = false;
			btnRestore.Click += btnRestore_Click;
			// 
			// BtnSearch
			// 
			BtnSearch.FlatAppearance.BorderSize = 0;
			BtnSearch.ForeColor = Color.Black;
			BtnSearch.Location = new Point(268, 307);
			BtnSearch.Name = "BtnSearch";
			BtnSearch.Size = new Size(89, 27);
			BtnSearch.TabIndex = 25;
			BtnSearch.Text = "查詢";
			BtnSearch.UseCompatibleTextRendering = true;
			BtnSearch.UseVisualStyleBackColor = true;
			BtnSearch.Click += btnOpenSearch_Click;
			// 
			// frmResidentInfo
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(483, 402);
			Controls.Add(BtnSearch);
			Controls.Add(btnRestore);
			Controls.Add(chkTrashMode);
			Controls.Add(btnResetAffection);
			Controls.Add(picResident);
			Controls.Add(lblNameValue);
			Controls.Add(lblNameTitle);
			Controls.Add(lblSpeciesValue);
			Controls.Add(lstResidents);
			Controls.Add(lblPersonalityValue);
			Controls.Add(lblCatchPhraseValue);
			Controls.Add(lblAffectionValue);
			Controls.Add(label2);
			Controls.Add(btnDeleteResident);
			Controls.Add(label3);
			Controls.Add(label4);
			Controls.Add(btnGiveGift);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			KeyPreview = true;
			Margin = new Padding(2);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmResidentInfo";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "居民資訊";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)picResident).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button btnGiveGift;
        private PictureBox picResident;
        private ListBox lstResidents;
        private Label lblNameValue;
        private Label lblSpeciesValue;
        private Label lblPersonalityValue;
        private Label lblAffectionValue;
        private Label lblCatchPhraseValue;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblNameTitle;
        private Button btnDeleteResident;
		private Button btnResetAffection;
		private CheckBox chkTrashMode;
		private Button btnRestore;
		private Button BtnSearch;
	}
}
