namespace ACNH_win
{
    partial class frmResidentSearch
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResidentSearch));
			label1 = new Label();
			dgvResidents = new DataGridView();
			btnSearch = new Button();
			txtKeyword = new TextBox();
			((System.ComponentModel.ISupportInitialize)dgvResidents).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Microsoft JhengHei UI", 10F);
			label1.Location = new Point(121, 29);
			label1.Margin = new Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new Size(64, 18);
			label1.TabIndex = 13;
			label1.Text = "關鍵字：";
			// 
			// dgvResidents
			// 
			dgvResidents.AllowUserToAddRows = false;
			dgvResidents.AllowUserToDeleteRows = false;
			dgvResidents.AllowUserToResizeColumns = false;
			dgvResidents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvResidents.BackgroundColor = Color.White;
			dgvResidents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvResidents.Location = new Point(32, 64);
			dgvResidents.Margin = new Padding(2, 2, 2, 2);
			dgvResidents.Name = "dgvResidents";
			dgvResidents.ReadOnly = true;
			dgvResidents.RowHeadersVisible = false;
			dgvResidents.RowHeadersWidth = 51;
			dgvResidents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvResidents.Size = new Size(448, 156);
			dgvResidents.TabIndex = 10;
			// 
			// btnSearch
			// 
			btnSearch.Location = new Point(199, 234);
			btnSearch.Margin = new Padding(2, 2, 2, 2);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new Size(104, 23);
			btnSearch.TabIndex = 1;
			btnSearch.Text = "查詢";
			btnSearch.UseVisualStyleBackColor = true;
			// 
			// txtKeyword
			// 
			txtKeyword.Location = new Point(189, 27);
			txtKeyword.Margin = new Padding(2, 2, 2, 2);
			txtKeyword.Name = "txtKeyword";
			txtKeyword.PlaceholderText = "輸入居民名稱關鍵字";
			txtKeyword.Size = new Size(145, 23);
			txtKeyword.TabIndex = 0;
			// 
			// frmResidentSearch
			// 
			AcceptButton = btnSearch;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(514, 267);
			Controls.Add(label1);
			Controls.Add(dgvResidents);
			Controls.Add(btnSearch);
			Controls.Add(txtKeyword);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			Icon = (Icon)resources.GetObject("$this.Icon");
			KeyPreview = true;
			Margin = new Padding(2, 2, 2, 2);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmResidentSearch";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "居民搜尋";
			Load += frmResidentSearch_Load;
			((System.ComponentModel.ISupportInitialize)dgvResidents).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label label1;
        private DataGridView dgvResidents;
        private Button btnSearch;
        private TextBox txtKeyword;
		
	}
}