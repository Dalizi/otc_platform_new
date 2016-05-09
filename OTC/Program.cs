using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
namespace OTC
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DatabaseManager dbManager = new DatabaseManager();
            if (new Login(dbManager).ShowDialog() == DialogResult.OK)
            {
                OTCDataSet dataset = new OTCDataSet("otc", dbManager);
                Application.Run(new MainWindow(dataset));
            }
        }

    }
}
