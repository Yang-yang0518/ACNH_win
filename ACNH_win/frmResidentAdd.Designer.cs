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
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(55, 21);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 13;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(235, 189);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "取消";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(119, 189);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 12;
            btnSave.Text = "存檔";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(235, 96);
            label4.Name = "label4";
            label4.Size = new Size(69, 19);
            label4.TabIndex = 7;
            label4.Text = "口頭禪：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(210, 24);
            label3.Name = "label3";
            label3.Size = new Size(54, 19);
            label3.TabIndex = 8;
            label3.Text = "性格：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 87);
            label5.Name = "label5";
            label5.Size = new Size(54, 19);
            label5.TabIndex = 9;
            label5.Text = "種族：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 24);
            label1.Name = "label1";
            label1.Size = new Size(54, 19);
            label1.TabIndex = 10;
            label1.Text = "名字：";
            // 
            // cboPersonality
            // 
            cboPersonality.FormattingEnabled = true;
            cboPersonality.Location = new Point(189, 57);
            cboPersonality.Name = "cboPersonality";
            cboPersonality.Size = new Size(151, 27);
            cboPersonality.TabIndex = 5;
            // 
            // cboSpecies
            // 
            cboSpecies.FormattingEnabled = true;
            cboSpecies.Location = new Point(19, 118);
            cboSpecies.Name = "cboSpecies";
            cboSpecies.Size = new Size(151, 27);
            cboSpecies.TabIndex = 6;
            // 
            // txtCatchPhrase
            // 
            txtCatchPhrase.Location = new Point(239, 132);
            txtCatchPhrase.Name = "txtCatchPhrase";
            txtCatchPhrase.Size = new Size(125, 27);
            txtCatchPhrase.TabIndex = 14;
            // 
            // frmResidentAdd
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 421);
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
            Name = "frmResidentAdd";
            Text = "frmResidentAdd";
            Load += frmResidentAdd_Load;
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
    }
}