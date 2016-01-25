using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OTC
{
    public partial class Login : Form
    {
        public Login(MySqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
            host = "10.2.7.210";
            port = "3306";
            database = "otc";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder connStringBuilder = new MySqlConnectionStringBuilder();
            connStringBuilder.Server = host;
            connStringBuilder.UserID = textBoxUserName.Text;
            connStringBuilder.Password = textBoxPassword.Text;
            connStringBuilder.Database = database;
            connStringBuilder.Port = Convert.ToUInt32(port);
            String otcConnectionString = connStringBuilder.ConnectionString;
            try
            {
                conn.ConnectionString = otcConnectionString;
                conn.Open();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (MySqlException sqlException)
            {
                if (sqlException.Number==0)
                    MessageBox.Show("登录被拒绝：登录信息错误，或者用户没有该数据库的访问权限。", "数据库连接错误");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfig_Click(object sender, EventArgs e)
        {
            FormLoginConfig loginConfig = new FormLoginConfig(this);
            loginConfig.Show();
        }
        public String host { get; set; }
        public String port { get; set; }
        public String database { get; set; }
        public String username { get; set; }
        public String password { get; set; }
        MySqlConnection conn;
    }
}
