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
    public partial class FromModifyGrants : Form
    {
        public FromModifyGrants(OTCDataSet ds)
        {
            dataset = ds;
            InitializeComponent();
            var row  = dataset.display_ds.Tables["business_overview"].Rows.Find(1);
            this.textBoxPrevGrants.Text = row["granted_balance"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal granted_balance;
            if (!decimal.TryParse(this.textBoxNewGrants.Text, out granted_balance))
            {
                MessageBox.Show("错误", "新额度格式错误。");
                return;
            }
            dataset.Tables["business_overview"].Rows.Find(1)["granted_balance"] = granted_balance;
            dataset.Commit("business_overview");
            Close();
        }
        OTCDataSet dataset;

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
