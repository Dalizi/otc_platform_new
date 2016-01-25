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
    public partial class FormFuturesAccountCashflow : Form
    {
        public FormFuturesAccountCashflow(OTCDataSet ds)
        {
            InitializeComponent();
            this.dataset = ds;
            this.comboBoxCashFlowType.SelectedIndex = 0;
            this.table = this.dataset.Tables["futures_cashflow"];
            foreach (DataRow row in this.dataset.Tables["futures_account_info"].Rows)
            {
                this.comboBoxFuturesAccount.Items.Add(row["期货账号"].ToString());
            }
            if (this.comboBoxFuturesAccount.Items.Count>0)
            {
                this.comboBoxFuturesAccount.SelectedIndex = 0;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            int maxID = 0;
            int.TryParse(table.Compute("max(资金流水编号)", "").ToString(), out maxID);
            double value = 0;
            if (double.TryParse(maskedTextBoxValue.Text, out value))
            {
                String cashFlowType = this.comboBoxCashFlowType.Text == "入金" ? "dp" : "wd";
                table.Rows.Add(DBNull.Value, Convert.ToInt32(this.comboBoxFuturesAccount.Text), value, cashFlowType, DBNull.Value, DBNull.Value,this.richTextBoxMemo.Text);
                this.dataset.Commit("futures_cashflow");
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
