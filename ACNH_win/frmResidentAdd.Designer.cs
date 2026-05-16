namespace ACNH_win
{
    partial class frmResidentAdd
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResidentAdd));
			txtName = new TextBox();
			btnCancel = new Button();
			btnSave = new Button();
			label4 = new Label();
			label3 = new Label();
			label5 = new Label();
			label1 = new Label();
			cboPersonality = new ComboBox();
			cboSpecies = new ComboBox();
			txtCatchPhrase = new TextBox();
			picPreview = new PictureBox();
			btnBrowsePhoto = new Button();
			toolTip1 = new ToolTip(components);
			((System.ComponentModel.ISupportInitialize)picPreview).BeginInit();
			SuspendLayout();
			// 
			// txtName
			// 
			txtName.Location = new Point(11, 35);
			txtName.Margin = new Padding(2, 2, 2, 2);
			txtName.MaxLength = 50;
			txtName.Name = "txtName";
			txtName.Size = new Size(118, 23);
			txtName.TabIndex = 13;
			// 
			// btnCancel
			// 
			btnCancel.DialogResult = DialogResult.Cancel;
			btnCancel.Location = new Point(167, 194);
			btnCancel.Margin = new Padding(2, 2, 2, 2);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(73, 23);
			btnCancel.TabIndex = 11;
			btnCancel.Text = "取消";
			btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			btnSave.DialogResult = DialogResult.OK;
			btnSave.Location = new Point(56, 194);
			btnSave.Margin = new Padding(2, 2, 2, 2);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(73, 23);
			btnSave.TabIndex = 12;
			btnSave.Text = "存檔";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("微軟正黑體", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
			label4.Location = new Point(165, 72);
			label4.Margin = new Padding(2, 0, 2, 0);
			label4.Name = "label4";
			label4.Size = new Size(60, 17);
			label4.TabIndex = 7;
			label4.Text = "口頭禪：";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("微軟正黑體", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
			label3.Location = new Point(193, 202);
			label3.Margin = new Padding(2, 0, 2, 0);
			label3.Name = "label3";
			label3.Size = new Size(47, 17);
			label3.TabIndex = 8;
			label3.Text = "性格：";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("微軟正黑體", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
			label5.Location = new Point(11, 72);
			label5.Margin = new Padding(2, 0, 2, 0);
			label5.Name = "label5";
			label5.Size = new Size(47, 17);
			label5.TabIndex = 9;
			label5.Text = "種族：";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("微軟正黑體", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
			label1.Location = new Point(11, 16);
			label1.Margin = new Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new Size(47, 17);
			label1.TabIndex = 10;
			label1.Text = "居民：";
			// 
			// cboPersonality
			// 
			cboPersonality.DropDownStyle = ComboBoxStyle.DropDownList;
			cboPersonality.FormattingEnabled = true;
			cboPersonality.Location = new Point(165, 35);
			cboPersonality.Margin = new Padding(2, 2, 2, 2);
			cboPersonality.Name = "cboPersonality";
			cboPersonality.Size = new Size(118, 23);
			cboPersonality.TabIndex = 5;
			// 
			// cboSpecies
			// 
			cboSpecies.DropDownStyle = ComboBoxStyle.DropDownList;
			cboSpecies.FormattingEnabled = true;
			cboSpecies.Location = new Point(11, 90);
			cboSpecies.Margin = new Padding(2, 2, 2, 2);
			cboSpecies.Name = "cboSpecies";
			cboSpecies.Size = new Size(118, 23);
			cboSpecies.TabIndex = 6;
			// 
			// txtCatchPhrase
			// 
			txtCatchPhrase.Location = new Point(165, 91);
			txtCatchPhrase.Margin = new Padding(2, 2, 2, 2);
			txtCatchPhrase.MaxLength = 50;
			txtCatchPhrase.Name = "txtCatchPhrase";
			txtCatchPhrase.Size = new Size(118, 23);
			txtCatchPhrase.TabIndex = 14;
			// 
			// picPreview
			// 
			picPreview.Location = new Point(29, 125);
			picPreview.Name = "picPreview";
			picPreview.Size = new Size(100, 50);
			picPreview.TabIndex = 15;
			picPreview.TabStop = false;
			// 
			// btnBrowsePhoto
			// 
			btnBrowsePhoto.Location = new Point(165, 141);
			btnBrowsePhoto.Name = "btnBrowsePhoto";
			btnBrowsePhoto.Size = new Size(75, 23);
			btnBrowsePhoto.TabIndex = 16;
			btnBrowsePhoto.Text = "選擇圖片";
			toolTip1.SetToolTip(btnBrowsePhoto, "必填：請選擇一張居民照片");
			btnBrowsePhoto.UseVisualStyleBackColor = true;
			btnBrowsePhoto.Click += btnBrowsePhoto_Click;
			// 
			// frmResidentAdd
			// 
			AcceptButton = btnSave;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = btnCancel;
			ClientSize = new Size(293, 230);
			Controls.Add(btnBrowsePhoto);
			Controls.Add(picPreview);
			Controls.Add(txtCatchPhrase);
			Controls.Add(txtName);
			Controls.Add(btnCancel);
			Controls.Add(btnSave);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label5);
			Controls.Add(label1);
			Controls.Add(cboPersonality);
			Controls.Add(cboSpecies);
			DoubleBuffered = true;
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			KeyPreview = true;
			Margin = new Padding(2, 2, 2, 2);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmResidentAdd";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "新增居民";
			Load += frmResidentAdd_Load;
			((System.ComponentModel.ISupportInitialize)picPreview).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtName;
        private Button btnCancel;
        private Button btnSave;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label1;
        private ComboBox cboPersonality;
        private ComboBox cboSpecies;
        private TextBox txtCatchPhrase;
		private PictureBox picPreview;
		private Button btnBrowsePhoto;
		private ToolTip toolTip1;
	}
}