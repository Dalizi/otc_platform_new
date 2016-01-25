using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTC
{
    public partial class FormLoginConfig : Form
    {
        public FormLoginConfig(Login loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            this.textBoxHost.Text = loginForm.host;
            this.textBoxPort.Text = loginForm.port;
            this.textBoxDatabase.Text = loginForm.database;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            loginForm.host = textBoxHost.Text;
            loginForm.port = textBoxPort.Text;
            loginForm.database = textBoxDatabase.Text;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Login loginForm;
    }
}
