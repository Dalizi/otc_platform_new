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
    public partial class FormModifyOptionsContract : Form
    {
        public FormModifyOptionsContract(OTCDataSet ds)
        {
            InitializeComponent();
            this.dataset = ds;
            table = this.dataset.Tables["options_contracts"];
            foreach (DataRow row in this.dataset.Tables["futures_contracts"].Rows)
            {
                this.comboBoxUnderlyingCode.Items.Add(row["合约代码"].ToString());
            }
            foreach (DataRow row in this.dataset.Tables["options_types"].Rows)
            {
                this.comboBoxOptionsType.Items.Add(row[0].ToString()+'-'+row[1].ToString());
            }
            this.comboBoxOptionsDirection.Items.AddRange(new String[]{ "认购","认沽"});
            foreach (DataRow row in table.Rows)
            {
                this.comboBoxOptionsContractCode.Items.Add(row["合约代码"]);
            }
            if (this.comboBoxOptionsContractCode.Items.Count > 0)
            {
                this.comboBoxOptionsContractCode.SelectedIndex = 0;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            decimal commision = 0;
            decimal margin = 0;
            decimal multiplier = 0;
            double strike = 0;
            double settle = 0;
            double volatility = 0;
            if (String.IsNullOrEmpty(this.comboBoxOptionsContractCode.Text))
            {
                MessageBox.Show("合约代码不能为空。", "错误");
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
            else if (String.IsNullOrEmpty(this.comboBoxOptionsType.Text))
            {
                MessageBox.Show("期权类型不能为空。", "错误");
            }
            else if (String.IsNullOrEmpty(this.comboBoxOptionsDirection.Text))
            {
                MessageBox.Show("期权方向不能为空。", "错误");
            }
            else if (!double.TryParse(this.textBoxStrikePrice.Text, out strike))
            {
                MessageBox.Show("执行价格式错误。", "错误");
            }
            else if (!double.TryParse(this.textBoxSettle.Text, out settle))
            {
                MessageBox.Show("结算价格式错误。", "错误");
            }
            else if (!double.TryParse(this.textBoxVolatility.Text, out volatility))
            {
                MessageBox.Show("波动率格式错误。", "错误");
            }
            else
            {
                DataRow row = this.table.Rows.Find(this.comboBoxOptionsContractCode.Text);
                row["结算价"] = settle;
                row["手续费"] = commision;
                row["保证金率"] = margin;
                row["波动率"] = volatility;
                this.dataset.Commit("options_contracts");
                this.dataset.Update("options_contracts");
                this.dataset.Update("options_contracts_view");
                this.Close();
            }
        }

        OTCDataSet dataset;
        DataTable table;

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxOptionsContractCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow row = this.table.Rows.Find(this.comboBoxOptionsContractCode.Text);
            this.comboBoxUnderlyingCode.SelectedIndex = this.comboBoxUnderlyingCode.FindStringExact(row["标的代码"].ToString());
            this.textBoxSettle.Text = row["结算价"].ToString();
            this.textBoxCommission.Text = row["手续费"].ToString();
            this.textBoxMarginRate.Text = row["保证金率"].ToString();
            this.textBoxMultiplier.Text = row["合约乘数"].ToString();
            this.comboBoxOptionsType.SelectedIndex = this.comboBoxOptionsType.FindString(row["期权类型"].ToString());
            this.comboBoxOptionsDirection.SelectedIndex = this.comboBoxOptionsDirection.FindStringExact(row["认购认沽"].ToString()=="c"?"认购":"认沽");
            this.textBoxStrikePrice.Text = row["执行价"].ToString();
        }
    }
}
