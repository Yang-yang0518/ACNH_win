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
#if DEBUG
            return ConfigurationManager
                .ConnectionStrings["ACNH_DB_HOME"]
                .ConnectionString;
#else
    return ConfigurationManager
        .ConnectionStrings["ACNH_DB_SCHOOL"]
        .ConnectionString;
#endif
        }

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            string connStr = GetConnectionString();
            Application.Run(new frmLogin());

            //UserRepository.CreateUser(connStr, "admin", "1234");

        }
    }
}
