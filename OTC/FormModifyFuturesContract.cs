﻿using System;
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
        public FormModifyFuturesContract(OTCDataSet ds, string contract_code)
        {
            InitializeComponent();
            this.dataset= ds;
            table = this.dataset.Tables["futures_contracts"];
            this.radioButtonAbsCommission.Select();
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
            if (this.comboBoxFuturesContractCode.Items.Count > 0)
            {
                this.comboBoxFuturesContractCode.SelectedIndex = this.comboBoxFuturesContractCode.FindStringExact(contract_code);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            decimal commision = 0;
            decimal margin = 0;
            decimal multiplier = 0;
            decimal pre_settle = 0;
            decimal volatility = 0;
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
            else if (!decimal.TryParse(this.textBoxVolatility.Text, out volatility))
            {
                MessageBox.Show("波动率格式错误。", "错误");
            }
            else
            {
                DataRow row = table.Rows.Find(this.comboBoxFuturesContractCode.Text);
                row["标的代码"] = this.comboBoxUnderlyingCode.Text.Split('-')[0];
                row["手续费模式"] = this.radioButtonAbsCommission.Checked ? "abs" : "pct";
                row["手续费"] = commision;
                row["保证金率"] = margin;
                row["结算价"] = pre_settle;
                row["合约乘数"] = multiplier;
                row["波动率"] = volatility;
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
            if (row["手续费模式"].ToString() == "abs") this.radioButtonAbsCommission.Checked = true;
            else this.radioButtonPctCommission.Checked = true;
            this.textBoxCommission.Text = row["手续费"].ToString();
            this.textBoxMarginRate.Text = row["保证金率"].ToString();
            this.textBoxMultiplier.Text = row["合约乘数"].ToString();
            this.textBoxPreSettle.Text = row["结算价"].ToString();
            this.textBoxVolatility.Text = row["波动率"].ToString();
        }
    }
}
