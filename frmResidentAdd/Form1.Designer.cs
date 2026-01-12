namespace ACNH_win
{
    partial class frmResidentAdd

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
            label1 = new Label();
            cboSpecies = new ComboBox();
            cboPersonality = new ComboBox();
            label3 = new Label();
            txtCatchPhrase = new ComboBox();
            label4 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            label5 = new Label();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 54);
            label1.Name = "label1";
            label1.Size = new Size(54, 19);
            label1.TabIndex = 1;
            label1.Text = "名字：";
            // 
            // cboSpecies
            // 
            cboSpecies.FormattingEnabled = true;
            cboSpecies.Location = new Point(120, 148);
            cboSpecies.Name = "cboSpecies";
            cboSpecies.Size = new Size(151, 27);
            cboSpecies.TabIndex = 0;
            // 
            // cboPersonality
            // 
            cboPersonality.FormattingEnabled = true;
            cboPersonality.Location = new Point(290, 87);
            cboPersonality.Name = "cboPersonality";
            cboPersonality.Size = new Size(151, 27);
            cboPersonality.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(311, 54);
            label3.Name = "label3";
            label3.Size = new Size(54, 19);
            label3.TabIndex = 1;
            label3.Text = "性格：";
            // 
            // txtCatchPhrase
            // 
            txtCatchPhrase.FormattingEnabled = true;
            txtCatchPhrase.Location = new Point(311, 148);
            txtCatchPhrase.Name = "txtCatchPhrase";
            txtCatchPhrase.Size = new Size(151, 27);
            txtCatchPhrase.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(336, 126);
            label4.Name = "label4";
            label4.Size = new Size(69, 19);
            label4.TabIndex = 1;
            label4.Text = "口頭禪：";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(220, 219);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "存檔";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(336, 219);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "取消";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(120, 117);
            label5.Name = "label5";
            label5.Size = new Size(54, 19);
            label5.TabIndex = 1;
            label5.Text = "種族：";
            // 
            // txtName
            // 
            txtName.Location = new Point(156, 51);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 318);
            Controls.Add(txtName);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(txtCatchPhrase);
            Controls.Add(cboPersonality);
            Controls.Add(cboSpecies);
            Name = "Form1";
            Text = "frmResidentAdd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboName;
        private Label label1;
        private ComboBox cboSpecies;
        private Label label2;
        private ComboBox cboPersonality;
        private Label label3;
        private ComboBox txtCatchPhrase;
        private Label label4;
        private Button btnSave;
        private Button btnCancel;
        private Label label5;
        private TextBox txtName;
    }
}
