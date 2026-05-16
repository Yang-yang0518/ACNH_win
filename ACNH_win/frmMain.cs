using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACNH_win
{
    public partial class frmMain : Form
    {
        private readonly string _connStr;

        public frmMain(string connStr)
        {
            InitializeComponent();
            _connStr = connStr;

            StyleMenuButton(btnResidentList);
            StyleMenuButton(btnResidentAdd);
            StyleMenuButton(btnExit);
        }

        private void btnResidentList_Click(object sender, EventArgs e)
        {
            var f = new frmResidentInfo(_connStr);
            f.Show();
        }

        private void btnResidentAdd_Click(object sender, EventArgs e)
        {
            var f = new frmResidentAdd(_connStr);
            f.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string gifPath = Path.Combine(Application.StartupPath, "Assets", "Main.gif");
            picBackground.Image = Image.FromFile(gifPath);
            picBackground.SendToBack();

            // 讓按鈕顯示在 GIF 上
            btnResidentList.Parent = picBackground;
            btnResidentAdd.Parent = picBackground;
            btnExit.Parent = picBackground;

            btnResidentList.Parent = picBackground;
            btnResidentAdd.Parent = picBackground;
            btnExit.Parent = picBackground;
        }
        void StyleMenuButton(Button b)
        {
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;

            b.BackColor = Color.Transparent;
            b.ForeColor = Color.White;
            b.Cursor = Cursors.Hand;

            // ✅ 透明度遮罩：第一個數字是透明度(0~255)
            b.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 0, 0, 0);
            b.FlatAppearance.MouseDownBackColor = Color.FromArgb(170, 0, 0, 0);
        }

        
    }
}
