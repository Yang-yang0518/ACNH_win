namespace ACNH_win
{
    partial class Form1
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
            splitMain = new SplitContainer();
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
            label5 = new Label();
            btnAddResident = new Button();
            btnOpenSearch = new Button();
            btnDeleteResident = new Button();
            ((System.ComponentModel.ISupportInitialize)picResident).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.SuspendLayout();
            SuspendLayout();
            // 
            // btnGiveGift
            // 
            btnGiveGift.Location = new Point(412, 230);
            btnGiveGift.Name = "btnGiveGift";
            btnGiveGift.Size = new Size(94, 29);
            btnGiveGift.TabIndex = 4;
            btnGiveGift.Text = "送禮";
            btnGiveGift.UseVisualStyleBackColor = true;
            btnGiveGift.Click += btnGiveGift_Click;
            // 
            // picResident
            // 
            picResident.Location = new Point(237, 18);
            picResident.Name = "picResident";
            picResident.Size = new Size(186, 176);
            picResident.TabIndex = 6;
            picResident.TabStop = false;
            // 
            // splitMain
            // 
            splitMain.Location = new Point(12, 12);
            splitMain.Name = "splitMain";
            splitMain.Size = new Size(219, 182);
            splitMain.SplitterDistance = 73;
            splitMain.TabIndex = 7;
            // 
            // lstResidents
            // 
            lstResidents.FormattingEnabled = true;
            lstResidents.ItemHeight = 19;
            lstResidents.Location = new Point(12, 204);
            lstResidents.Name = "lstResidents";
            lstResidents.Size = new Size(150, 118);
            lstResidents.TabIndex = 8;
            lstResidents.SelectedIndexChanged += lstResidents_SelectedIndexChanged;
            // 
            // lblNameValue
            // 
            lblNameValue.AutoSize = true;
            lblNameValue.Location = new Point(234, 284);
            lblNameValue.Name = "lblNameValue";
            lblNameValue.Size = new Size(51, 19);
            lblNameValue.TabIndex = 9;
            lblNameValue.Text = "label1";
            // 
            // lblSpeciesValue
            // 
            lblSpeciesValue.AutoSize = true;
            lblSpeciesValue.Location = new Point(234, 303);
            lblSpeciesValue.Name = "lblSpeciesValue";
            lblSpeciesValue.Size = new Size(51, 19);
            lblSpeciesValue.TabIndex = 10;
            lblSpeciesValue.Text = "label2";
            // 
            // lblPersonalityValue
            // 
            lblPersonalityValue.AutoSize = true;
            lblPersonalityValue.Location = new Point(234, 322);
            lblPersonalityValue.Name = "lblPersonalityValue";
            lblPersonalityValue.Size = new Size(51, 19);
            lblPersonalityValue.TabIndex = 11;
            lblPersonalityValue.Text = "label3";
            // 
            // lblAffectionValue
            // 
            lblAffectionValue.AutoSize = true;
            lblAffectionValue.Location = new Point(234, 341);
            lblAffectionValue.Name = "lblAffectionValue";
            lblAffectionValue.Size = new Size(51, 19);
            lblAffectionValue.TabIndex = 12;
            lblAffectionValue.Text = "label4";
            // 
            // lblCatchPhraseValue
            // 
            lblCatchPhraseValue.AutoSize = true;
            lblCatchPhraseValue.Location = new Point(234, 360);
            lblCatchPhraseValue.Name = "lblCatchPhraseValue";
            lblCatchPhraseValue.Size = new Size(51, 19);
            lblCatchPhraseValue.TabIndex = 13;
            lblCatchPhraseValue.Text = "label5";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 360);
            label1.Name = "label1";
            label1.Size = new Size(69, 19);
            label1.TabIndex = 18;
            label1.Text = "口頭禪：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 341);
            label2.Name = "label2";
            label2.Size = new Size(99, 19);
            label2.TabIndex = 17;
            label2.Text = "目前好感度：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(177, 322);
            label3.Name = "label3";
            label3.Size = new Size(54, 19);
            label3.TabIndex = 16;
            label3.Text = "喜好：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(177, 303);
            label4.Name = "label4";
            label4.Size = new Size(54, 19);
            label4.TabIndex = 15;
            label4.Text = "種族：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(177, 284);
            label5.Name = "label5";
            label5.Size = new Size(54, 19);
            label5.TabIndex = 14;
            label5.Text = "名字：";
            // 
            // btnAddResident
            // 
            btnAddResident.Location = new Point(412, 274);
            btnAddResident.Name = "btnAddResident";
            btnAddResident.Size = new Size(94, 29);
            btnAddResident.TabIndex = 19;
            btnAddResident.Text = "新增居民";
            btnAddResident.UseVisualStyleBackColor = true;
            btnAddResident.Click += btnAddResident_Click;
            // 
            // btnOpenSearch
            // 
            btnOpenSearch.Location = new Point(434, 323);
            btnOpenSearch.Name = "btnOpenSearch";
            btnOpenSearch.Size = new Size(94, 29);
            btnOpenSearch.TabIndex = 20;
            btnOpenSearch.Text = "查詢";
            btnOpenSearch.UseVisualStyleBackColor = true;
            btnOpenSearch.Click += btnOpenSearch_Click;
            // 
            // btnDeleteResident
            // 
            btnDeleteResident.Location = new Point(448, 368);
            btnDeleteResident.Name = "btnDeleteResident";
            btnDeleteResident.Size = new Size(94, 29);
            btnDeleteResident.TabIndex = 21;
            btnDeleteResident.Text = "刪除居民";
            btnDeleteResident.UseVisualStyleBackColor = true;
            btnDeleteResident.Click += btnDeleteResident_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 421);
            Controls.Add(picResident);
            Controls.Add(btnDeleteResident);
            Controls.Add(btnOpenSearch);
            Controls.Add(btnAddResident);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(lblCatchPhraseValue);
            Controls.Add(lblAffectionValue);
            Controls.Add(lblPersonalityValue);
            Controls.Add(lblSpeciesValue);
            Controls.Add(lblNameValue);
            Controls.Add(lstResidents);
            Controls.Add(splitMain);
            Controls.Add(btnGiveGift);
            Name = "Form1";
            Text = "frmResientInfo";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picResident).EndInit();
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnGiveGift;
        private PictureBox picResident;
        private SplitContainer splitMain;
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
        private Label label5;
        private Button btnAddResident;
        private Button btnOpenSearch;
        private Button btnDeleteResident;
    }
}
