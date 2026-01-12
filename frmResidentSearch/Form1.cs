using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace frmResidentSearch
{
    public partial class Form1 : Form
    {
        private readonly string _connStr =
            @"Data Source=.\sql2025;
              Initial Catalog=ACNH_DB;
              User ID=sa5;
              Password=Sa5!sa5!;
              TrustServerCertificate=True";

        public Form1()
        {
            InitializeComponent();
        }
    }
}
