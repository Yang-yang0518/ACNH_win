namespace ACNH_win
{
    partial class frmGiveGift
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiveGift));
			lblResidentTitle = new Label();
			lblResidentNameValue = new Label();
			lblGiftTitle = new Label();
			cboGifts = new ComboBox();
			btnSendGift = new Button();
			lblFeedback = new Label();
			lblDeltaTitle = new Label();
			lblDeltaValue = new Label();
			lblAffectionTitle = new Label();
			lblAffectionValue = new Label();
			btnClose = new Button();
			pbAffection = new ProgressBar();
			lblAffectionText = new Label();
			lblAffectionLevel = new Label();
			SuspendLayout();
			// 
			// lblResidentTitle
			// 
			lblResidentTitle.AutoSize = true;
			lblResidentTitle.Font = new Font("微軟正黑體", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
			lblResidentTitle.Location = new Point(31, 27);
			lblResidentTitle.Margin = new Padding(2, 0, 2, 0);
			lblResidentTitle.Name = "lblResidentTitle";
			lblResidentTitle.Size = new Size(73, 17);
			lblResidentTitle.TabIndex = 0;
			lblResidentTitle.Text = "送禮對象：";
			// 
			// lblResidentNameValue
			// 
			lblResidentNameValue.AutoSize = true;
			lblResidentNameValue.Font = new Font("標楷體", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
			lblResidentNameValue.ForeColor = Color.Black;
			lblResidentNameValue.Location = new Point(101, 27);
			lblResidentNameValue.Margin = new Padding(2, 0, 2, 0);
			lblResidentNameValue.Name = "lblResidentNameValue";
			lblResidentNameValue.Size = new Size(93, 16);
			lblResidentNameValue.TabIndex = 1;
			lblResidentNameValue.Text = "(居民名字)";
			// 
			// lblGiftTitle
			// 
			lblGiftTitle.AutoSize = true;
			lblGiftTitle.Font = new Font("微軟正黑體", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
			lblGiftTitle.Location = new Point(31, 85);
			lblGiftTitle.Margin = new Padding(2, 0, 2, 0);
			lblGiftTitle.Name = "lblGiftTitle";
			lblGiftTitle.Size = new Size(73, 17);
			lblGiftTitle.TabIndex = 2;
			lblGiftTitle.Text = "選擇禮物：";
			// 
			// cboGifts
			// 
			cboGifts.DropDownStyle = ComboBoxStyle.DropDownList;
			cboGifts.FormattingEnabled = true;
			cboGifts.Location = new Point(101, 82);
			cboGifts.Margin = new Padding(2);
			cboGifts.Name = "cboGifts";
			cboGifts.Size = new Size(118, 23);
			cboGifts.TabIndex = 0;
			// 
			// btnSendGift
			// 
			btnSendGift.Location = new Point(62, 158);
			btnSendGift.Margin = new Padding(2);
			btnSendGift.Name = "btnSendGift";
			btnSendGift.Size = new Size(73, 23);
			btnSendGift.TabIndex = 1;
			btnSendGift.Text = "送出";
			btnSendGift.UseVisualStyleBackColor = true;
			btnSendGift.Click += btnSendGift_Click;
			// 
			// lblFeedback
			// 
			lblFeedback.AutoSize = true;
			lblFeedback.Font = new Font("微軟正黑體", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
			lblFeedback.ForeColor = Color.Gray;
			lblFeedback.Location = new Point(286, 53);
			lblFeedback.Margin = new Padding(2, 0, 2, 0);
			lblFeedback.Name = "lblFeedback";
			lblFeedback.Size = new Size(79, 16);
			lblFeedback.TabIndex = 5;
			lblFeedback.Text = "（尚未送禮）";
			// 
			// lblDeltaTitle
			// 
			lblDeltaTitle.AutoSize = true;
			lblDeltaTitle.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
			lblDeltaTitle.Location = new Point(273, 84);
			lblDeltaTitle.Margin = new Padding(2, 0, 2, 0);
			lblDeltaTitle.Name = "lblDeltaTitle";
			lblDeltaTitle.Size = new Size(79, 16);
			lblDeltaTitle.TabIndex = 6;
			lblDeltaTitle.Text = "好感度變化：";
			// 
			// lblDeltaValue
			// 
			lblDeltaValue.AutoSize = true;
			lblDeltaValue.Location = new Point(361, 84);
			lblDeltaValue.Margin = new Padding(2, 0, 2, 0);
			lblDeltaValue.Name = "lblDeltaValue";
			lblDeltaValue.Size = new Size(14, 15);
			lblDeltaValue.TabIndex = 7;
			lblDeltaValue.Text = "0";
			// 
			// lblAffectionTitle
			// 
			lblAffectionTitle.AutoSize = true;
			lblAffectionTitle.Font = new Font("微軟正黑體", 9F, FontStyle.Bold);
			lblAffectionTitle.Location = new Point(261, 100);
			lblAffectionTitle.Margin = new Padding(2, 0, 2, 0);
			lblAffectionTitle.Name = "lblAffectionTitle";
			lblAffectionTitle.Size = new Size(91, 16);
			lblAffectionTitle.TabIndex = 8;
			lblAffectionTitle.Text = "送禮後好感度：";
			// 
			// lblAffectionValue
			// 
			lblAffectionValue.AutoSize = true;
			lblAffectionValue.Location = new Point(368, 100);
			lblAffectionValue.Margin = new Padding(2, 0, 2, 0);
			lblAffectionValue.Name = "lblAffectionValue";
			lblAffectionValue.Size = new Size(14, 15);
			lblAffectionValue.TabIndex = 9;
			lblAffectionValue.Text = "0";
			// 
			// btnClose
			// 
			btnClose.DialogResult = DialogResult.Cancel;
			btnClose.Location = new Point(158, 158);
			btnClose.Margin = new Padding(2);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(73, 23);
			btnClose.TabIndex = 2;
			btnClose.Text = "關閉";
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += btnClose_Click;
			// 
			// pbAffection
			// 
			pbAffection.Location = new Point(101, 123);
			pbAffection.Maximum = 10;
			pbAffection.Name = "pbAffection";
			pbAffection.Size = new Size(118, 23);
			pbAffection.TabIndex = 10;
			// 
			// lblAffectionText
			// 
			lblAffectionText.AutoSize = true;
			lblAffectionText.Location = new Point(44, 123);
			lblAffectionText.Name = "lblAffectionText";
			lblAffectionText.Size = new Size(33, 15);
			lblAffectionText.TabIndex = 11;
			lblAffectionText.Text = "0/10";
			// 
			// lblAffectionLevel
			// 
			lblAffectionLevel.AutoSize = true;
			lblAffectionLevel.Location = new Point(226, 128);
			lblAffectionLevel.Name = "lblAffectionLevel";
			lblAffectionLevel.Size = new Size(42, 15);
			lblAffectionLevel.TabIndex = 12;
			lblAffectionLevel.Text = "label1";
			// 
			// frmGiveGift
			// 
			AcceptButton = btnSendGift;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = btnClose;
			ClientSize = new Size(426, 192);
			Controls.Add(lblAffectionLevel);
			Controls.Add(lblAffectionText);
			Controls.Add(pbAffection);
			Controls.Add(btnClose);
			Controls.Add(lblAffectionValue);
			Controls.Add(lblAffectionTitle);
			Controls.Add(lblDeltaValue);
			Controls.Add(lblDeltaTitle);
			Controls.Add(lblFeedback);
			Controls.Add(btnSendGift);
			Controls.Add(cboGifts);
			Controls.Add(lblGiftTitle);
			Controls.Add(lblResidentNameValue);
			Controls.Add(lblResidentTitle);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(2);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmGiveGift";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "送禮後呈現";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblResidentTitle;
        private Label lblResidentNameValue;
        private Label lblGiftTitle;
        private ComboBox cboGifts;
        private Button btnSendGift;
        private Label lblFeedback;
        private Label lblDeltaTitle;
        private Label lblDeltaValue;
        private Label lblAffectionTitle;
        private Label lblAffectionValue;
        private Button btnClose;
		private ProgressBar pbAffection;
		private Label lblAffectionText;
		private Label lblAffectionLevel;
	}
}