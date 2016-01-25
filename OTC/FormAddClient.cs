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
    public partial class FormAddClient : Form
    {
        public FormAddClient(OTCDataSet ds)
        {
            InitializeComponent();
            this.dataset = ds;
            table = this.dataset.Tables["client_info"];
            InitializeInfo();
        }

        private void InitializeInfo()
        {
            int maxID = 0;
            int.TryParse(table.Compute("max(客户编号)", "").ToString(), out maxID);
            this.textBoxClientId.Text = (maxID + 1).ToString("00000000");
          DataTable futuresAccountInfoTable = this.dataset.Tables["futures_account_info"];
            foreach (DataRow dr in futuresAccountInfoTable.Rows)
            {
                this.comboBoxFuturesAccount.Items.Add(dr["期货账号"]);
            }
            if (this.comboBoxFuturesAccount.Items.Count>0)
            {
                this.comboBoxFuturesAccount.SelectedIndex = 0;
            }  
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(textBoxClientName.Text) && !String.IsNullOrEmpty(comboBoxFuturesAccount.Text))
            {
                this.dataset.Tables["client_info"].Rows.Add(int.Parse(textBoxClientId.Text), textBoxClientName.Text, int.Parse(comboBoxFuturesAccount.Text));
                this.dataset.Commit("client_info");
                this.dataset.Update();
                Close();
            }
            else if (String.IsNullOrEmpty(textBoxClientName.Text))
            {
                MessageBox.Show("客户名称不能为空。", "错误");
            }
            else
            {
                MessageBox.Show("期货账号不能为空。", "错误");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        OTCDataSet dataset;
        DataTable table;
    }
}
