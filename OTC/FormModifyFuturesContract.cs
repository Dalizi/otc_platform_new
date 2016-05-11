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
    public partial class FormModifyFuturesContract : Form
    {
        public FormModifyFuturesContract(OTCDataSet ds)
        {
            InitializeComponent();
            this.dataset= ds;
            table = this.dataset.Tables["futures_contracts"];
            foreach (DataRow row in this.dataset.Tables["commodity_category"].Rows)
            {
                this.comboBoxUnderlyingCode.Items.Add(row[0].ToString()+'-'+row[1].ToString());
            }

            foreach (DataRow row in table.Rows)
            {
                this.comboBoxFuturesContractCode.Items.Add(row[0].ToString());
            }
            if (this.comboBoxFuturesContractCode.Items.Count != 0)
            {
                this.comboBoxFuturesContractCode.SelectedIndex = 0;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            decimal commision = 0;
            decimal margin = 0;
            decimal multiplier = 0;
            decimal pre_settle = 0;
            if (String.IsNullOrEmpty(this.comboBoxFuturesContractCode.Text))
            {
                MessageBox.Show("期货合约代码不能为空。", "错误");
            }
            else if (String.IsNullOrEmpty(this.comboBoxUnderlyingCode.Text))
            {
                MessageBox.Show("标的不能为空。", "错误");
            }
            else if (!decimal.TryParse(this.textBoxCommission.Text, out commision))
            {
                MessageBox.Show("手续费格式错误。", "错误");
            }
            else if (!decimal.TryParse(this.textBoxMarginRate.Text, out margin))
            {
                MessageBox.Show("保证金格式错误。", "错误");
            }
            else if (!decimal.TryParse(this.textBoxMultiplier.Text, out multiplier))
            {
                MessageBox.Show("合约乘数格式错误。", "错误");
            }
            else if (!decimal.TryParse(this.textBoxPreSettle.Text, out pre_settle))
            {
                MessageBox.Show("前结算价格式错误。", "错误");
            }
            else
            {
                DataRow row = table.Rows.Find(this.comboBoxFuturesContractCode.Text);
                row[1] = this.comboBoxUnderlyingCode.Text.Split('-')[0];
                row[2] = commision;
                row[3] = margin;
                row[4] = pre_settle;
                row[5] = multiplier;
                this.dataset.Commit("futures_contracts");
                this.dataset.Update("futures_contracts");
                this.dataset.Update("futures_contracts_view");
                this.Close();
            }
        }

        OTCDataSet dataset;
        DataTable table;

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxFuturesContractCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow row = table.Rows.Find(this.comboBoxFuturesContractCode.Text);
            this.comboBoxUnderlyingCode.SelectedIndex = this.comboBoxUnderlyingCode.FindString(row[1].ToString()+'-');
            this.textBoxCommission.Text = row[2].ToString();
            this.textBoxMarginRate.Text = row[3].ToString();
            this.textBoxMultiplier.Text = row[5].ToString();
        }
    }
}
