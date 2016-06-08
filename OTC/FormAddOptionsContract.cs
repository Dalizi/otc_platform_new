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
    public partial class FormAddOptionsContract : Form
    {
        public FormAddOptionsContract(OTCDataSet ds)
        {
            InitializeComponent();
            this.dataset = ds;
            table = this.dataset.Tables["options_contracts"];
            foreach (DataRow row in this.dataset.Tables["futures_contracts"].Rows)
            {
                this.comboBoxUnderlyingCode.Items.Add(row["合约代码"].ToString());
            }
            if (this.comboBoxUnderlyingCode.Items.Count != 0)
            {
                this.comboBoxUnderlyingCode.SelectedIndex = 0;
            }
            foreach (DataRow row in this.dataset.Tables["options_types"].Rows)
            {
                this.comboBoxOptionsType.Items.Add(row[0].ToString()+'-'+row[1].ToString());
            }
            if (this.comboBoxOptionsType.Items.Count != 0)
            {
                this.comboBoxOptionsType.SelectedIndex = 0;
            }
            this.comboBoxOptionsDirection.Items.AddRange(new String[]{ "认购","认沽"});
            this.comboBoxOptionsDirection.SelectedIndex = 0;
            this.dateTimePickerMaturityDate.Value = DateTime.Today.AddDays(1);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            decimal commision = 0;
            decimal margin = 0;
            decimal multiplier = 0;
            decimal strike = 0;
            decimal volatility = 0;
            if (String.IsNullOrEmpty(this.textBoxOptionsContractCode.Text))
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
            else if (!decimal.TryParse(this.textBoxStrikePrice.Text, out strike))
            {
                MessageBox.Show("执行价格式错误。", "错误");
            }
            else if (!decimal.TryParse(this.textBoxVolatility.Text, out volatility))
            {
                MessageBox.Show("波动率格式错误。", "错误");
            }
            else
            {
                table.Rows.Add(this.textBoxOptionsContractCode.Text,
                    this.comboBoxOptionsType.Text.Split('-')[0],
                    this.comboBoxOptionsDirection.Text == "认购" ? 'c' : 'p',
                    strike,
                    dateTimePickerMaturityDate.Value.Date,
                    margin,
                    this.comboBoxUnderlyingCode.Text, 0, multiplier, commision, volatility,0, false);
                this.dataset.Commit("options_contracts");
                this.dataset.Update("options_contracts");
                this.dataset.Update("options_contracts_view");
                this.Close();
            }
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setContractCode()
        {
            String contract_code = "";
            contract_code += "OTC-";
            contract_code += this.comboBoxOptionsType.Text.Split('-')[0];
            contract_code += this.comboBoxOptionsDirection.Text=="认购"?'c':'p';
            contract_code += '-';
            contract_code += this.comboBoxUnderlyingCode.Text.PadLeft(6,'0');
            contract_code += '-';
            contract_code += this.dateTimePickerMaturityDate.Value.Date.ToString("yyyyMMdd");
            double strike = 0;
            double multiplier = 0;
            if (!Double.TryParse(this.textBoxStrikePrice.Text, out strike))
            {
                MessageBox.Show("执行价格式错误。", "错误");
            }
            else if (!Double.TryParse(this.textBoxMultiplier.Text, out multiplier))
            {
                MessageBox.Show("合约乘数格式错误。", "错误");
            }
            contract_code += '-';
            contract_code += Math.Round(strike * multiplier).ToString().PadLeft(6,'0');
            contract_code = contract_code.ToUpper();
            this.textBoxOptionsContractCode.Text = contract_code;
        }

        OTCDataSet dataset;
        DataTable table;

        private void comboBoxUnderlyingCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBoxMultiplier.Text = dataset.Tables["futures_contracts"].Rows.Find(this.comboBoxUnderlyingCode.Text)["合约乘数"].ToString();
            setContractCode();
        }

        private void textBoxMultiplier_TextChanged(object sender, EventArgs e)
        {
            setContractCode();
        }

        private void comboBoxOptionsType_SelectedIndexChanged(object sender, EventArgs e)
        {
            setContractCode();
        }

        private void comboBoxOptionsDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            setContractCode();
        }

        private void dateTimePickerMaturityDate_ValueChanged(object sender, EventArgs e)
        {
            setContractCode();
        }

        private void textBoxStrikePrice_TextChanged(object sender, EventArgs e)
        {
            setContractCode();
        }
    }
}
