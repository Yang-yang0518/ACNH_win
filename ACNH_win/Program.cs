using System;
using System.Configuration;
using System.Windows.Forms;
using ACNH_win.Security;

namespace ACNH_win
{
    internal static class Program
    {
        public static string GetConnectionString()
        {
			//return ConfigurationManager
			//    .ConnectionStrings["default"]
			//    .ConnectionString;
			return ConfigurationManager
		    .ConnectionStrings["ACNH_DB"]
		    .ConnectionString;

		}

        [STAThread]
        static void Main()
        {
			ApplicationConfiguration.Initialize();
			string connStr = GetConnectionString();

			Application.Run(new frmLogin(connStr));
		}
    }
}
