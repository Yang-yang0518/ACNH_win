namespace ACNH_win
{
    partial class frmResidentInfo
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResidentInfo));
            dgvResidents = new DataGridView();
            picResident = new PictureBox();
            lblNameTitle = new Label();
            lblNameValue = new Label();
            label4 = new Label();
            lblSpeciesValue = new Label();
            label3 = new Label();
            lblPersonalityValue = new Label();
            label2 = new Label();
            lblAffectionValue = new Label();
            label1 = new Label();
            lblCatchPhraseValue = new Label();
            btnGiveGift = new Button();
            btnDeleteResident = new Button();
            btnResetAffection = new Button();
            btnRestore = new Button();
            chkTrashMode = new CheckBox();
            BtnSearch = new Button();
            btnAddResident = new Button();
            ((System.ComponentModel.ISupportInitialize)picResident).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvResidents).BeginInit();
            SuspendLayout();

            // dgvResidents（欄位由 Form1.cs 程式碼動態加入，不在此宣告）
            dgvResidents.AllowUserToAddRows = false;
            dgvResidents.AllowUserToDeleteRows = false;
            dgvResidents.AllowUserToResizeRows = false;
            dgvResidents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResidents.BackgroundColor = Color.White;
            dgvResidents.BorderStyle = BorderStyle.None;
            dgvResidents.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvResidents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResidents.Location = new Point(12, 44);
            dgvResidents.MultiSelect = false;
            dgvResidents.Name = "dgvResidents";
            dgvResidents.ReadOnly = true;
            dgvResidents.RowHeadersVisible = false;
            dgvResidents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResidents.Size = new Size(610, 178);
            dgvResidents.TabIndex = 0;

            // picResident
            picResident.Location = new Point(12, 234);
            picResident.Name = "picResident";
            picResident.Size = new Size(148, 140);
            picResident.SizeMode = PictureBoxSizeMode.Zoom;
            picResident.TabIndex = 6;
            picResident.TabStop = false;

            // lblNameTitle
            lblNameTitle.AutoSize = true;
            lblNameTitle.Font = new Font("微軟正黑體", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lblNameTitle.Location = new Point(172, 238);
            lblNameTitle.Name = "lblNameTitle";
            lblNameTitle.Size = new Size(47, 17);
            lblNameTitle.TabIndex = 14;
            lblNameTitle.Text = "名字：";

            // lblNameValue
            lblNameValue.BorderStyle = BorderStyle.FixedSingle;
            lblNameValue.Location = new Point(240, 236);
            lblNameValue.Name = "lblNameValue";
            lblNameValue.Size = new Size(120, 22);
            lblNameValue.TabIndex = 9;
            lblNameValue.TextAlign = ContentAlignment.MiddleLeft;

            // label4 (種族)
            label4.AutoSize = true;
            label4.Font = new Font("微軟正黑體", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label4.Location = new Point(172, 267);
            label4.Name = "label4";
            label4.Size = new Size(47, 17);
            label4.TabIndex = 15;
            label4.Text = "種族：";

            // lblSpeciesValue
            lblSpeciesValue.BorderStyle = BorderStyle.FixedSingle;
            lblSpeciesValue.Location = new Point(240, 265);
            lblSpeciesValue.Name = "lblSpeciesValue";
            lblSpeciesValue.Size = new Size(120, 22);
            lblSpeciesValue.TabIndex = 10;
            lblSpeciesValue.TextAlign = ContentAlignment.MiddleLeft;

            // label3 (性格)
            label3.AutoSize = true;
            label3.Font = new Font("微軟正黑體", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label3.Location = new Point(172, 296);
            label3.Name = "label3";
            label3.Size = new Size(47, 17);
            label3.TabIndex = 16;
            label3.Text = "性格：";

            // lblPersonalityValue
            lblPersonalityValue.BorderStyle = BorderStyle.FixedSingle;
            lblPersonalityValue.Location = new Point(240, 294);
            lblPersonalityValue.Name = "lblPersonalityValue";
            lblPersonalityValue.Size = new Size(120, 22);
            lblPersonalityValue.TabIndex = 11;
            lblPersonalityValue.TextAlign = ContentAlignment.MiddleLeft;

            // label2 (好感度)
            label2.AutoSize = true;
            label2.Font = new Font("微軟正黑體", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label2.Location = new Point(150, 325);
            label2.Name = "label2";
            label2.Size = new Size(86, 17);
            label2.TabIndex = 17;
            label2.Text = "目前好感度：";

            // lblAffectionValue
            lblAffectionValue.BorderStyle = BorderStyle.FixedSingle;
            lblAffectionValue.Location = new Point(240, 323);
            lblAffectionValue.Name = "lblAffectionValue";
            lblAffectionValue.Size = new Size(120, 22);
            lblAffectionValue.TabIndex = 12;
            lblAffectionValue.TextAlign = ContentAlignment.MiddleLeft;

            // label1 (口頭禪)
            label1.AutoSize = true;
            label1.Font = new Font("微軟正黑體", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(172, 354);
            label1.Name = "label1";
            label1.Size = new Size(60, 17);
            label1.TabIndex = 18;
            label1.Text = "口頭禪：";

            // lblCatchPhraseValue
            lblCatchPhraseValue.BorderStyle = BorderStyle.FixedSingle;
            lblCatchPhraseValue.Location = new Point(240, 352);
            lblCatchPhraseValue.Name = "lblCatchPhraseValue";
            lblCatchPhraseValue.Size = new Size(120, 22);
            lblCatchPhraseValue.TabIndex = 13;
            lblCatchPhraseValue.TextAlign = ContentAlignment.MiddleLeft;

            // btnGiveGift
            btnGiveGift.Location = new Point(500, 240);
            btnGiveGift.Name = "btnGiveGift";
            btnGiveGift.Size = new Size(110, 30);
            btnGiveGift.TabIndex = 4;
            btnGiveGift.Text = "送禮";
            btnGiveGift.UseVisualStyleBackColor = true;
            btnGiveGift.Click += btnGiveGift_Click;

            // btnDeleteResident
            btnDeleteResident.Location = new Point(500, 278);
            btnDeleteResident.Name = "btnDeleteResident";
            btnDeleteResident.Size = new Size(110, 30);
            btnDeleteResident.TabIndex = 21;
            btnDeleteResident.Text = "刪除居民";
            btnDeleteResident.UseVisualStyleBackColor = true;
            btnDeleteResident.Click += btnDeleteResident_Click;

            // btnRestore
            btnRestore.BackColor = Color.FromArgb(192, 255, 192);
            btnRestore.FlatAppearance.BorderSize = 0;
            btnRestore.FlatStyle = FlatStyle.Flat;
            btnRestore.Location = new Point(500, 316);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(110, 30);
            btnRestore.TabIndex = 24;
            btnRestore.Text = "回復居民";
            btnRestore.UseVisualStyleBackColor = false;
            btnRestore.Visible = false;
            btnRestore.Click += btnRestore_Click;

            // btnResetAffection
            btnResetAffection.BackColor = Color.LightGray;
            btnResetAffection.Cursor = Cursors.Hand;
            btnResetAffection.FlatAppearance.BorderSize = 0;
            btnResetAffection.FlatStyle = FlatStyle.Flat;
            btnResetAffection.Location = new Point(500, 354);
            btnResetAffection.Name = "btnResetAffection";
            btnResetAffection.Size = new Size(110, 30);
            btnResetAffection.TabIndex = 22;
            btnResetAffection.Text = "歸零好感度";
            btnResetAffection.UseVisualStyleBackColor = false;
            btnResetAffection.Click += btnResetAffection_Click;

            // chkTrashMode
            chkTrashMode.AutoSize = true;
            chkTrashMode.Location = new Point(12, 16);
            chkTrashMode.Name = "chkTrashMode";
            chkTrashMode.Size = new Size(86, 19);
            chkTrashMode.TabIndex = 23;
            chkTrashMode.Text = "顯示垃圾桶";
            chkTrashMode.UseVisualStyleBackColor = true;
            chkTrashMode.CheckedChanged += chkTrashMode_CheckedChanged_1;

            // BtnSearch
            BtnSearch.Location = new Point(420, 13);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(95, 25);
            BtnSearch.TabIndex = 25;
            BtnSearch.Text = "搜尋居民";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += btnOpenSearch_Click;

            // btnAddResident
            btnAddResident.Location = new Point(519, 13);
            btnAddResident.Name = "btnAddResident";
            btnAddResident.Size = new Size(103, 25);
            btnAddResident.TabIndex = 26;
            btnAddResident.Text = "新增居民";
            btnAddResident.UseVisualStyleBackColor = true;
            btnAddResident.Click += btnAddResident_Click;

            // frmResidentInfo
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 390);
            Controls.Add(dgvResidents);
            Controls.Add(picResident);
            Controls.Add(lblNameTitle);
            Controls.Add(lblNameValue);
            Controls.Add(label4);
            Controls.Add(lblSpeciesValue);
            Controls.Add(label3);
            Controls.Add(lblPersonalityValue);
            Controls.Add(label2);
            Controls.Add(lblAffectionValue);
            Controls.Add(label1);
            Controls.Add(lblCatchPhraseValue);
            Controls.Add(btnGiveGift);
            Controls.Add(btnDeleteResident);
            Controls.Add(btnRestore);
            Controls.Add(btnResetAffection);
            Controls.Add(chkTrashMode);
            Controls.Add(BtnSearch);
            Controls.Add(btnAddResident);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            this.Name = "frmResidentInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "居民資訊";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picResident).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvResidents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvResidents;
        private PictureBox picResident;
        private Label lblNameTitle;
        private Label lblNameValue;
        private Label label4;
        private Label lblSpeciesValue;
        private Label label3;
        private Label lblPersonalityValue;
        private Label label2;
        private Label lblAffectionValue;
        private Label label1;
        private Label lblCatchPhraseValue;
        private Button btnGiveGift;
        private Button btnDeleteResident;
        private Button btnResetAffection;
        private Button btnRestore;
        private CheckBox chkTrashMode;
        private Button BtnSearch;
        private Button btnAddResident;
    }
}
