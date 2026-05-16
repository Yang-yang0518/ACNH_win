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
			btnGiveGift = new Button();
			picResident = new PictureBox();
			pnlResidentDetail = new SplitContainer();
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
			btnAddResident = new Button();
			btnOpenSearch = new Button();
			btnDeleteResident = new Button();
			((System.ComponentModel.ISupportInitialize)picResident).BeginInit();
			((System.ComponentModel.ISupportInitialize)pnlResidentDetail).BeginInit();
			pnlResidentDetail.SuspendLayout();
			SuspendLayout();
			// 
			// btnGiveGift
			// 
			btnGiveGift.Location = new Point(360, 239);
			btnGiveGift.Margin = new Padding(2, 2, 2, 2);
			btnGiveGift.Name = "btnGiveGift";
			btnGiveGift.Size = new Size(73, 23);
			btnGiveGift.TabIndex = 4;
			btnGiveGift.Text = "送禮";
			btnGiveGift.UseVisualStyleBackColor = true;
			btnGiveGift.Click += btnGiveGift_Click;
			// 
			// picResident
			// 
			picResident.BorderStyle = BorderStyle.FixedSingle;
			picResident.Location = new Point(292, 12);
			picResident.Margin = new Padding(2, 2, 2, 2);
			picResident.Name = "picResident";
			picResident.Size = new Size(189, 208);
			picResident.SizeMode = PictureBoxSizeMode.Zoom;
			picResident.TabIndex = 6;
			picResident.TabStop = false;
			// 
			// pnlResidentDetail
			// 
			pnlResidentDetail.BorderStyle = BorderStyle.FixedSingle;
			pnlResidentDetail.Location = new Point(25, 192);
			pnlResidentDetail.Margin = new Padding(2, 2, 2, 2);
			pnlResidentDetail.Name = "pnlResidentDetail";
			pnlResidentDetail.Size = new Size(240, 160);
			pnlResidentDetail.SplitterDistance = 80;
			pnlResidentDetail.SplitterWidth = 3;
			pnlResidentDetail.TabIndex = 7;
			pnlResidentDetail.TabStop = false;
			// 
			// lstResidents
			// 
			lstResidents.DisplayMember = "Name";
			lstResidents.FormattingEnabled = true;
			lstResidents.HorizontalScrollbar = true;
			lstResidents.IntegralHeight = false;
			lstResidents.ItemHeight = 15;
			lstResidents.Location = new Point(24, 2);
			lstResidents.Margin = new Padding(2, 2, 2, 2);
			lstResidents.Name = "lstResidents";
			lstResidents.Size = new Size(219, 185);
			lstResidents.TabIndex = 0;
			lstResidents.ValueMember = "Id";
			lstResidents.SelectedIndexChanged += lstResidents_SelectedIndexChanged;
			// 
			// lblNameValue
			// 
			lblNameValue.BorderStyle = BorderStyle.FixedSingle;
			lblNameValue.Location = new Point(100, 363);
			lblNameValue.Margin = new Padding(2, 0, 2, 0);
			lblNameValue.Name = "lblNameValue";
			lblNameValue.Size = new Size(100, 22);
			lblNameValue.TabIndex = 9;
			lblNameValue.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// lblSpeciesValue
			// 
			lblSpeciesValue.BorderStyle = BorderStyle.FixedSingle;
			lblSpeciesValue.Location = new Point(100, 399);
			lblSpeciesValue.Margin = new Padding(2, 0, 2, 0);
			lblSpeciesValue.Name = "lblSpeciesValue";
			lblSpeciesValue.Size = new Size(100, 22);
			lblSpeciesValue.TabIndex = 10;
			lblSpeciesValue.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// lblPersonalityValue
			// 
			lblPersonalityValue.BorderStyle = BorderStyle.FixedSingle;
			lblPersonalityValue.Location = new Point(100, 430);
			lblPersonalityValue.Margin = new Padding(2, 0, 2, 0);
			lblPersonalityValue.Name = "lblPersonalityValue";
			lblPersonalityValue.Size = new Size(100, 22);
			lblPersonalityValue.TabIndex = 11;
			lblPersonalityValue.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// lblAffectionValue
			// 
			lblAffectionValue.BorderStyle = BorderStyle.FixedSingle;
			lblAffectionValue.Location = new Point(100, 463);
			lblAffectionValue.Margin = new Padding(2, 0, 2, 0);
			lblAffectionValue.Name = "lblAffectionValue";
			lblAffectionValue.Size = new Size(100, 22);
			lblAffectionValue.TabIndex = 12;
			lblAffectionValue.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// lblCatchPhraseValue
			// 
			lblCatchPhraseValue.BorderStyle = BorderStyle.FixedSingle;
			lblCatchPhraseValue.Location = new Point(100, 499);
			lblCatchPhraseValue.Margin = new Padding(2, 0, 2, 0);
			lblCatchPhraseValue.Name = "lblCatchPhraseValue";
			lblCatchPhraseValue.Size = new Size(100, 22);
			lblCatchPhraseValue.TabIndex = 13;
			lblCatchPhraseValue.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(36, 503);
			label1.Margin = new Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new Size(55, 15);
			label1.TabIndex = 18;
			label1.Text = "口頭禪：";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 467);
			label2.Margin = new Padding(2, 0, 2, 0);
			label2.Name = "label2";
			label2.Size = new Size(79, 15);
			label2.TabIndex = 17;
			label2.Text = "目前好感度：";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(48, 437);
			label3.Margin = new Padding(2, 0, 2, 0);
			label3.Name = "label3";
			label3.Size = new Size(43, 15);
			label3.TabIndex = 16;
			label3.Text = "喜好：";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(48, 403);
			label4.Margin = new Padding(2, 0, 2, 0);
			label4.Name = "label4";
			label4.Size = new Size(43, 15);
			label4.TabIndex = 15;
			label4.Text = "種族：";
			// 
			// lblNameTitle
			// 
			lblNameTitle.AutoSize = true;
			lblNameTitle.Location = new Point(48, 367);
			lblNameTitle.Margin = new Padding(2, 0, 2, 0);
			lblNameTitle.Name = "lblNameTitle";
			lblNameTitle.Size = new Size(43, 15);
			lblNameTitle.TabIndex = 14;
			lblNameTitle.Text = "名字：";
			lblNameTitle.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// btnAddResident
			// 
			btnAddResident.Location = new Point(360, 276);
			btnAddResident.Margin = new Padding(2, 2, 2, 2);
			btnAddResident.Name = "btnAddResident";
			btnAddResident.Size = new Size(73, 23);
			btnAddResident.TabIndex = 19;
			btnAddResident.Text = "新增居民";
			btnAddResident.UseVisualStyleBackColor = true;
			btnAddResident.Click += btnAddResident_Click;
			// 
			// btnOpenSearch
			// 
			btnOpenSearch.Location = new Point(360, 315);
			btnOpenSearch.Margin = new Padding(2, 2, 2, 2);
			btnOpenSearch.Name = "btnOpenSearch";
			btnOpenSearch.Size = new Size(73, 23);
			btnOpenSearch.TabIndex = 20;
			btnOpenSearch.Text = "查詢";
			btnOpenSearch.UseVisualStyleBackColor = true;
			btnOpenSearch.Click += btnOpenSearch_Click;
			// 
			// btnDeleteResident
			// 
			btnDeleteResident.Location = new Point(360, 352);
			btnDeleteResident.Margin = new Padding(2, 2, 2, 2);
			btnDeleteResident.Name = "btnDeleteResident";
			btnDeleteResident.Size = new Size(73, 23);
			btnDeleteResident.TabIndex = 21;
			btnDeleteResident.Text = "刪除居民";
			btnDeleteResident.UseVisualStyleBackColor = true;
			btnDeleteResident.Click += btnDeleteResident_Click;
			// 
			// frmResidentInfo
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(711, 547);
			Controls.Add(lblNameValue);
			Controls.Add(lblNameTitle);
			Controls.Add(lblSpeciesValue);
			Controls.Add(lstResidents);
			Controls.Add(lblPersonalityValue);
			Controls.Add(lblCatchPhraseValue);
			Controls.Add(lblAffectionValue);
			Controls.Add(label2);
			Controls.Add(picResident);
			Controls.Add(btnDeleteResident);
			Controls.Add(label3);
			Controls.Add(btnOpenSearch);
			Controls.Add(label4);
			Controls.Add(btnAddResident);
			Controls.Add(pnlResidentDetail);
			Controls.Add(btnGiveGift);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			KeyPreview = true;
			Margin = new Padding(2, 2, 2, 2);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmResidentInfo";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "居民資訊";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)picResident).EndInit();
			((System.ComponentModel.ISupportInitialize)pnlResidentDetail).EndInit();
			pnlResidentDetail.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button btnGiveGift;
        private PictureBox picResident;
        private SplitContainer pnlResidentDetail;
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
        private Button btnAddResident;
        private Button btnOpenSearch;
        private Button btnDeleteResident;
    }
}
