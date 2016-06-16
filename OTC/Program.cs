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
            try {
                if (new Login(dbManager).ShowDialog() == DialogResult.OK)
                {
                    var logging_form = new FormLogging();
                    OTCDataSet dataset = new OTCDataSet("otc", dbManager);
                    logging_form.Close();
                    Application.Run(new MainWindow(dataset));
                }
            }
            catch (StackExchange.Redis.RedisConnectionException e)
            {
                MessageBox.Show(string.Format("Redis连接错误:请重新登录。\n错误信息:{0}", e.Message), "错误");
                if (new Login(dbManager).ShowDialog() == DialogResult.OK)
                {
                    OTCDataSet dataset = new OTCDataSet("otc", dbManager);
                    Application.Run(new MainWindow(dataset));
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException e)
            {
                MessageBox.Show(string.Format("Mysql错误。\n错误信息:{0}", e.Message), "错误");
                if (new Login(dbManager).ShowDialog() == DialogResult.OK)
                {
                    OTCDataSet dataset = new OTCDataSet("otc", dbManager);
                    Application.Run(new MainWindow(dataset));
                }
            }
        }

    }
}
