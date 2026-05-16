namespace ACNH_win
{
    partial class frmResidentDelete
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResidentDelete));
			label1 = new Label();
			btnDelete = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.Dock = DockStyle.Top;
			label1.Font = new Font("微軟正黑體", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
			label1.Location = new Point(0, 0);
			label1.Margin = new Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new Size(262, 60);
			label1.TabIndex = 5;
			label1.Text = "確定要刪除這位居民嗎?";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// btnDelete
			// 
			btnDelete.Anchor = AnchorStyles.Bottom;
			btnDelete.DialogResult = DialogResult.OK;
			btnDelete.Location = new Point(94, 56);
			btnDelete.Margin = new Padding(2);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(73, 23);
			btnDelete.TabIndex = 6;
			btnDelete.Text = "刪除";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// frmResidentDelete
			// 
			AcceptButton = btnDelete;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(262, 92);
			Controls.Add(btnDelete);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			Icon = (Icon)resources.GetObject("$this.Icon");
			KeyPreview = true;
			Margin = new Padding(2);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmResidentDelete";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "刪除居民";
			ResumeLayout(false);
		}

		#endregion
		private Label label1;
        private ComboBox cboResidents;
        private Button btnDelete;
    }
}