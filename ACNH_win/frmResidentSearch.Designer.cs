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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvResidents = new DataGridView();
            btnSearch = new Button();
            cboPersonality = new ComboBox();
            cboSpecies = new ComboBox();
            txtKeyword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvResidents).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 186);
            label3.Name = "label3";
            label3.Size = new Size(54, 19);
            label3.TabIndex = 11;
            label3.Text = "喜好：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 119);
            label2.Name = "label2";
            label2.Size = new Size(54, 19);
            label2.TabIndex = 12;
            label2.Text = "種族：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 34);
            label1.Name = "label1";
            label1.Size = new Size(69, 19);
            label1.TabIndex = 13;
            label1.Text = "關鍵字：";
            // 
            // dgvResidents
            // 
            dgvResidents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResidents.Location = new Point(351, 199);
            dgvResidents.Name = "dgvResidents";
            dgvResidents.RowHeadersWidth = 51;
            dgvResidents.Size = new Size(300, 188);
            dgvResidents.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(94, 251);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "查詢";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // cboPersonality
            // 
            cboPersonality.FormattingEnabled = true;
            cboPersonality.Location = new Point(99, 183);
            cboPersonality.Name = "cboPersonality";
            cboPersonality.Size = new Size(151, 27);
            cboPersonality.TabIndex = 8;
            // 
            // cboSpecies
            // 
            cboSpecies.FormattingEnabled = true;
            cboSpecies.Location = new Point(99, 141);
            cboSpecies.Name = "cboSpecies";
            cboSpecies.Size = new Size(151, 27);
            cboSpecies.TabIndex = 7;
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(195, 34);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(125, 27);
            txtKeyword.TabIndex = 6;
            // 
            // frmResidentSearch
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvResidents);
            Controls.Add(btnSearch);
            Controls.Add(cboPersonality);
            Controls.Add(cboSpecies);
            Controls.Add(txtKeyword);
            Name = "frmResidentSearch";
            Text = "frmResidentSearch";
            Load += frmResidentSearch_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResidents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvResidents;
        private Button btnSearch;
        private ComboBox cboPersonality;
        private ComboBox cboSpecies;
        private TextBox txtKeyword;
    }
}