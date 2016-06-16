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
using Microsoft.VisualStudio.Data;

namespace OTC
{
    public partial class Login : Form
    {
        public Login(DatabaseManager dm)
        {
            InitializeComponent();
            this.dbManager = dm;
            String s = Properties.Settings.Default.Password;
            this.textBoxUserName.Text = Properties.Settings.Default.UserName;
            if (String.IsNullOrEmpty(Properties.Settings.Default.Password))
            {
                this.textBoxPassword.Text = "";
            }
            else
            {
                this.textBoxPassword.Text = DataProtection.DecryptString(Properties.Settings.Default.Password);
            }
            this.checkBoxRememberLoginInfo.Checked = Properties.Settings.Default.isRememberPasswordChecked;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder connStringBuilder = new MySqlConnectionStringBuilder();
            connStringBuilder.Server = Properties.Settings.Default.HostName;
            connStringBuilder.UserID = textBoxUserName.Text;
            connStringBuilder.Password = textBoxPassword.Text;
            connStringBuilder.Database = Properties.Settings.Default.Database;
            connStringBuilder.CharacterSet = "utf8";
            connStringBuilder.Port = uint.Parse(Properties.Settings.Default.Port);
            dbManager.SetConnString(DataProtection.EncryptString(connStringBuilder.ConnectionString));
            try
            {
                MySqlConnection conn = dbManager.GetSQLConnection();
                conn.Open();
                if (this.checkBoxRememberLoginInfo.Checked)
                {
                    Properties.Settings.Default.UserName = this.textBoxUserName.Text;
                    Properties.Settings.Default.Password = DataProtection.EncryptString(this.textBoxPassword.Text);
                }
                else
                {
                    Properties.Settings.Default.UserName = "";
                    Properties.Settings.Default.Password = DataProtection.EncryptString("");
                }
                Properties.Settings.Default.isRememberPasswordChecked = this.checkBoxRememberLoginInfo.Checked;
                Properties.Settings.Default.Save();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (MySqlException sqlException)
            {
                if (sqlException.Number == 0)
                    MessageBox.Show("登录被拒绝：登录信息错误，或者用户没有该数据库的访问权限。", "数据库连接错误");
                else if (sqlException.Number == 1042)
                    MessageBox.Show("数据库连接超时", "数据库连接错误");

            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfig_Click(object sender, EventArgs e)
        {
            FormLoginConfig loginConfig = new FormLoginConfig();
            loginConfig.Show();
        }

        DatabaseManager dbManager;
    }
}
