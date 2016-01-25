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
        public FormLoginConfig()
        {
            InitializeComponent();
            this.textBoxHost.Text = Properties.Settings.Default.HostName;
            this.textBoxPort.Text = Properties.Settings.Default.Port;
            this.textBoxDatabase.Text = Properties.Settings.Default.Database;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.HostName = textBoxHost.Text;
            Properties.Settings.Default.Port = textBoxPort.Text;
            Properties.Settings.Default.Database = textBoxDatabase.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
