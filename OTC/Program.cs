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
            MySqlConnection conn = new MySqlConnection();
            if (new Login(conn).ShowDialog() == DialogResult.OK)
            {
                OTCDataSet dataset = new OTCDataSet("otc", conn);
                Application.Run(new MainWindow(dataset));
            }
            conn.Close();
        }

    }
}
