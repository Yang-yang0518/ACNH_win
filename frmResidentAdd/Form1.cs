using System.Windows.Forms;

namespace ACNH_win
{
    public partial class frmResidentAdd : Form
    {
        private readonly string _connStr;

        public frmResidentAdd(string connStr)
        {
            InitializeComponent();
            _connStr = connStr;
        }
    }
}
