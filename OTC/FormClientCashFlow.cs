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
    public partial class FormClientCashFlow : Form
    {
        public FormClientCashFlow(OTCDataSet ds, uint client_id)
        {
            InitializeComponent();
            this.dataset = ds;
            this.table = dataset.Tables["client_cashflow"];
            this.comboBoxCashFlowType.SelectedIndex = 0;
            foreach (DataRow row in this.dataset.Tables["client_info"].Rows)
            {
                this.comboBoxClientInfo.Items.Add(row.Field<uint>("客户编号").ToString("00000000") + '-' + row["客户名称"].ToString());
            }
            if (this.comboBoxClientInfo.Items.Count > 0)
            {
                this.comboBoxClientInfo.SelectedIndex = this.comboBoxClientInfo.FindString(client_id.ToString("00000000"));
            }
            
        }



        private void buttonOK_Click(object sender, EventArgs e)
        {
            int maxID = 0;
            int.TryParse(this.table.Compute("max(资金流水编号)", "").ToString(), out maxID);
            decimal value = 0;
            if (decimal.TryParse(maskedTextBoxValue.Text, out value))
            {
                String cashFlowType = this.comboBoxCashFlowType.Text == "入金" ? "dp" : "wd";
                this.table.Rows.Add(DBNull.Value, Convert.ToInt32(this.comboBoxClientInfo.Text.Split('-')[0]), value, cashFlowType, DBNull.Value, DBNull.Value, this.richTextBoxMemo.Text);
                this.dataset.Commit("client_cashflow");
                this.dataset.Update();
                this.Close();
            }
            else
            {
                MessageBox.Show("出入资金额格式错误。", "错误");
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
