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
    public partial class FormAddFuturesContract : Form
    {
        public FormAddFuturesContract(OTCDataSet ds)
        {
            InitializeComponent();
            this.dataset = ds;
            table = this.dataset.Tables["futures_contracts"];
            this.radioButtonAbsCommission.Select();
            foreach (DataRow row in this.dataset.Tables["commodity_category"].Rows)
            {
                this.comboBoxUnderlyingCode.Items.Add(row[1].ToString()+'-'+row[0].ToString());
            }
            if (this.comboBoxUnderlyingCode.Items.Count != 0)
            {
                this.comboBoxUnderlyingCode.SelectedIndex = 0;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            decimal commision = 0;
            decimal margin = 0;
            decimal multiplier = 0;
            decimal volatility = 0;
            if (String.IsNullOrEmpty(this.textBoxFuturesContractCode.Text))
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
            else if (!decimal.TryParse(this.textBoxVolatility.Text, out volatility))
            {
                MessageBox.Show("波动率格式错误。", "错误");
            }
            else
            {
                DatabaseManager dm = new DatabaseManager();
                var conn = dm.GetRedisConnection();
                var db = conn.GetDatabase();
                if (db.KeyExists(this.textBoxFuturesContractCode.Text))
                {
                    double pre_settle = double.Parse(db.HashGet(this.textBoxFuturesContractCode.Text, "PreSettlementPrice").ToString());
                    string commission_mode = this.radioButtonAbsCommission.Checked ? "abs" : "pct";
                    table.Rows.Add(this.textBoxFuturesContractCode.Text, this.comboBoxUnderlyingCode.Text.Split('-')[1], commission_mode, commision, margin, pre_settle, multiplier, volatility, false);
                    this.dataset.Commit("futures_contracts");
                    this.dataset.Update("futures_contracts");
                    this.dataset.Update("futures_contracts_view");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("期货合约不存在。", "错误");
                }
            }
        }

        OTCDataSet dataset;
        DataTable table;

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxMarginRate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
