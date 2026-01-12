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
            SuspendLayout();
            // 
            // lblResidentTitle
            // 
            lblResidentTitle.AutoSize = true;
            lblResidentTitle.Location = new Point(130, 113);
            lblResidentTitle.Name = "lblResidentTitle";
            lblResidentTitle.Size = new Size(84, 19);
            lblResidentTitle.TabIndex = 0;
            lblResidentTitle.Text = "送禮對象：";
            // 
            // lblResidentNameValue
            // 
            lblResidentNameValue.AutoSize = true;
            lblResidentNameValue.Location = new Point(220, 113);
            lblResidentNameValue.Name = "lblResidentNameValue";
            lblResidentNameValue.Size = new Size(79, 19);
            lblResidentNameValue.TabIndex = 1;
            lblResidentNameValue.Text = "(居民名字)";
            // 
            // lblGiftTitle
            // 
            lblGiftTitle.AutoSize = true;
            lblGiftTitle.Location = new Point(130, 186);
            lblGiftTitle.Name = "lblGiftTitle";
            lblGiftTitle.Size = new Size(84, 19);
            lblGiftTitle.TabIndex = 2;
            lblGiftTitle.Text = "選擇禮物：";
            // 
            // cboGifts
            // 
            cboGifts.FormattingEnabled = true;
            cboGifts.Location = new Point(220, 183);
            cboGifts.Name = "cboGifts";
            cboGifts.Size = new Size(151, 27);
            cboGifts.TabIndex = 3;
            // 
            // btnSendGift
            // 
            btnSendGift.Location = new Point(134, 260);
            btnSendGift.Name = "btnSendGift";
            btnSendGift.Size = new Size(94, 29);
            btnSendGift.TabIndex = 4;
            btnSendGift.Text = "送出";
            btnSendGift.UseVisualStyleBackColor = true;
            btnSendGift.Click += btnSendGift_Click;
            // 
            // lblFeedback
            // 
            lblFeedback.AutoSize = true;
            lblFeedback.Location = new Point(394, 206);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new Size(99, 19);
            lblFeedback.TabIndex = 5;
            lblFeedback.Text = "（尚未送禮）";
            // 
            // lblDeltaTitle
            // 
            lblDeltaTitle.AutoSize = true;
            lblDeltaTitle.Location = new Point(394, 247);
            lblDeltaTitle.Name = "lblDeltaTitle";
            lblDeltaTitle.Size = new Size(99, 19);
            lblDeltaTitle.TabIndex = 6;
            lblDeltaTitle.Text = "好感度變化：";
            // 
            // lblDeltaValue
            // 
            lblDeltaValue.AutoSize = true;
            lblDeltaValue.Location = new Point(499, 247);
            lblDeltaValue.Name = "lblDeltaValue";
            lblDeltaValue.Size = new Size(18, 19);
            lblDeltaValue.TabIndex = 7;
            lblDeltaValue.Text = "0";
            // 
            // lblAffectionTitle
            // 
            lblAffectionTitle.AutoSize = true;
            lblAffectionTitle.Location = new Point(370, 284);
            lblAffectionTitle.Name = "lblAffectionTitle";
            lblAffectionTitle.Size = new Size(114, 19);
            lblAffectionTitle.TabIndex = 8;
            lblAffectionTitle.Text = "送禮後好感度：";
            // 
            // lblAffectionValue
            // 
            lblAffectionValue.AutoSize = true;
            lblAffectionValue.Location = new Point(490, 284);
            lblAffectionValue.Name = "lblAffectionValue";
            lblAffectionValue.Size = new Size(18, 19);
            lblAffectionValue.TabIndex = 9;
            lblAffectionValue.Text = "0";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(264, 271);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 10;
            btnClose.Text = "關閉";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmGiveGift
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "frmGiveGift";
            Text = "frmGiveGift";
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
    }
}