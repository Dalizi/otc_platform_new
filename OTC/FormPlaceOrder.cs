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
    public partial class FormPlaceOrder : Form
    {
        public FormPlaceOrder(OTCDataSet ds)
        {
            InitializeComponent();
            this.comboBoxEntityCode.SelectedIndexChanged += new EventHandler(SetMaxQuantity);
            this.comboBoxOrderType.SelectedIndexChanged += new EventHandler(SetMaxQuantity);
            this.comboBoxTargetID.SelectedIndexChanged += new EventHandler(SetMaxQuantity);

            this.comboBoxContractCode.SelectedIndexChanged += new EventHandler(SetMaxQuantity);
            this.comboBoxContractCode.SelectedIndexChanged += new EventHandler(SetCloseTargetIDs);

            this.comboBoxLongShort.SelectedIndexChanged += new EventHandler(SetMaxQuantity);
            this.comboBoxLongShort.SelectedIndexChanged += new EventHandler(SetCloseTargetIDs);

            this.comboBoxOpenClose.SelectedIndexChanged += new EventHandler(SetMaxQuantity);

            this.numericUpDownPrice.ValueChanged += new EventHandler(SetMaxQuantity);
            this.numericUpDownPrice.ValueChanged += new EventHandler(ComputeValue);

            this.numericUpDownQuantity.ValueChanged += new EventHandler(ComputeValue);

            this.dataset = ds;
            this.comboBoxOrderType.Items.AddRange(new String[]{"期权","期货"});
            this.comboBoxLongShort.Items.AddRange(new String[] { "买入", "卖出" });
            this.comboBoxLongShort.Text = "买入";
            this.comboBoxOpenClose.Items.AddRange(new String[] { "开仓", "平仓" });
            this.comboBoxOpenClose.Text = "开仓";
            this.comboBoxOrderType.SelectedIndex = 0;
        }

        public FormPlaceOrder(OTCDataSet ds, String instrType, DataGridViewRow row)
        {
            InitializeComponent();

            this.textBoxClientName.Enabled = false;

            this.comboBoxEntityCode.SelectedIndexChanged += new EventHandler(SetMaxQuantity);
            this.comboBoxOrderType.SelectedIndexChanged += new EventHandler(SetMaxQuantity);
            this.comboBoxTargetID.SelectedIndexChanged += new EventHandler(SetMaxQuantity);

            this.comboBoxContractCode.SelectedIndexChanged += new EventHandler(SetMaxQuantity);
            this.comboBoxContractCode.SelectedIndexChanged += new EventHandler(SetCloseTargetIDs);

            this.comboBoxLongShort.SelectedIndexChanged += new EventHandler(SetMaxQuantity);
            this.comboBoxLongShort.SelectedIndexChanged += new EventHandler(SetCloseTargetIDs);

            this.comboBoxOpenClose.SelectedIndexChanged += new EventHandler(SetMaxQuantity);
            this.numericUpDownPrice.ValueChanged += new EventHandler(SetMaxQuantity);

            this.dataset = ds;
            this.comboBoxOrderType.Items.AddRange(new String[] { "期权", "期货" });
            this.comboBoxLongShort.Items.AddRange(new String[] { "买入", "卖出" });
            this.comboBoxOpenClose.Items.AddRange(new String[] { "开仓", "平仓" });
            this.comboBoxOpenClose.Text = "平仓";
            this.comboBoxOrderType.SelectedIndex = 0;
            if (instrType == "期货")
            {
                this.SetAsFuturesCloseOrderForm(row);
            }
            else if (instrType == "期权")
            {
                this.SetAsOptionsCloseOrderForm(row);
            }
            else
            {
                MessageBox.Show("未知的产品种类。", "错误");
                this.Close();
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (this.numericUpDownQuantity.Value == 0)
            {
                MessageBox.Show("数量不能为0", "错误");
                return;
            }
            if (this.comboBoxOrderType.Text == "期货")
            {
                DataTable table = this.dataset.Tables["futures_transactions"];
                int account_no = 0;
                double quantity = 0;
                double price = 0;
                int target_client_id = 0;

                if (!int.TryParse(this.comboBoxEntityCode.Text, out account_no))
                {
                    MessageBox.Show("期货账号格式错误。", "错误");
                }
                else if (!int.TryParse(this.comboBoxTargetID.Text, out target_client_id) && this.comboBoxTargetID.Text != "无")
                {
                    MessageBox.Show("目标客户编号格式错误。", "错误");
                }
                else if (!double.TryParse(this.numericUpDownPrice.Text, out price))
                {
                    MessageBox.Show("价格格式错误。", "错误");
                }
                else if (!double.TryParse(this.numericUpDownQuantity.Text, out quantity))
                {
                    MessageBox.Show("数量格式错误。", "错误");
                }
                else
                {
                    if (this.comboBoxTargetID.Text != "无")
                    {
                        table.Rows.Add(DBNull.Value,
                            account_no,
                            this.comboBoxContractCode.Text,
                            quantity,
                            price,
                            this.comboBoxOpenClose.Text == "开仓" ? "open" : "close",
                            this.comboBoxLongShort.Text == "买入" ? "long" : "short",
                            DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"),
                            DBNull.Value,
                            DBNull.Value,
                            target_client_id);
                    }
                    else
                    {

                        table.Rows.Add(DBNull.Value,
                            account_no,
                            this.comboBoxContractCode.Text,
                            quantity,
                            price,
                            this.comboBoxOpenClose.Text,
                            this.comboBoxLongShort.Text,
                            DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"),
                            DBNull.Value,
                            DBNull.Value,
                            DBNull.Value);
                    }
                        this.dataset.Commit("futures_transactions");
                        this.dataset.Update();
                        this.Close();
                    
                }
            }
            else
            {
                DataTable table = this.dataset.Tables["options_transactions"];
                int client_id = 0;
                double quantity = 0;
                double price = 0;
                int target_transaction_id = -1;

                if (!int.TryParse(this.comboBoxEntityCode.Text, out client_id))
                {
                    MessageBox.Show("客户编号格式错误。", "错误");
                }
                else if (!int.TryParse(this.comboBoxTargetID.Text, out target_transaction_id) && this.comboBoxTargetID.Text != "无")
                {
                    MessageBox.Show("平仓目标编号格式错误。", "错误");
                }
                else if (!double.TryParse(this.numericUpDownPrice.Text, out price))
                {
                    MessageBox.Show("价格格式错误。", "错误");
                }
                else if (!double.TryParse(this.numericUpDownQuantity.Text, out quantity))
                {
                    MessageBox.Show("数量格式错误。", "错误");
                }
                else
                {
                    if (this.comboBoxTargetID.Text != "无")
                    {
                        table.Rows.Add(DBNull.Value,
                            client_id,
                            this.comboBoxContractCode.Text,
                            quantity,
                            price,
                            this.comboBoxOpenClose.Text,
                            this.comboBoxLongShort.Text,
                            DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"),
                            DBNull.Value,
                            DBNull.Value,
                            target_transaction_id);
                    }
                    else
                    {
                        table.Rows.Add(DBNull.Value,
                            client_id,
                            this.comboBoxContractCode.Text,
                            quantity,
                            price,
                            this.comboBoxOpenClose.Text,
                            this.comboBoxLongShort.Text,
                            DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"),
                            DBNull.Value,
                            DBNull.Value,
                            null);
                    }
                    this.dataset.Commit("options_transactions");
                    this.dataset.Update();
                    this.Close();
                }
            }
        }

        private void comboBoxOrderType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;

            if (cb.Text == "期货")
            {
                this.labelEntityInfo.Text = "期货账号：";
                this.comboBoxEntityCode.Items.Clear();
                this.labelTargetID.Show();
                this.comboBoxTargetID.Show();
                foreach (DataRow row in this.dataset.Tables["futures_account_info"].Rows)
                {
                    this.comboBoxEntityCode.Items.Add(row["期货账号"].ToString());
                }
                if (this.comboBoxEntityCode.Items.Count > 0)
                {
                    this.comboBoxEntityCode.SelectedIndex = 0;
                }
                this.labelTargetID.Text = "目标客户编号：";
                this.labelClientName.Hide();
                this.textBoxClientName.Hide();
                this.comboBoxContractCode.Items.Clear();
                foreach (DataRow row in this.dataset.Tables["futures_contracts"].Rows)
                {
                    this.comboBoxContractCode.Items.Add(row["合约代码"]);
                }
                if (this.comboBoxContractCode.Items.Count >0 )
                {
                    this.comboBoxContractCode.SelectedIndex = 0;
                }
            }
            else
            {
                if (this.comboBoxOpenClose.Text == "开仓")
                {
                    this.labelTargetID.Hide();
                    this.comboBoxTargetID.Hide();
                }
                else
                {
                    this.labelTargetID.Show();
                    this.comboBoxTargetID.Show();
                }
                this.labelEntityInfo.Text = "客户编号：";
                this.comboBoxEntityCode.Items.Clear();
                foreach (DataRow row in this.dataset.Tables["client_info"].Rows)
                {
                    this.comboBoxEntityCode.Items.Add(row["客户编号"].ToString().PadLeft(8,'0'));
                }
                if (this.comboBoxEntityCode.Items.Count > 0)
                {
                    this.comboBoxEntityCode.SelectedIndex = 0;
                }
                this.labelTargetID.Text = "平仓目标编号：";
                this.labelClientName.Show();
                this.textBoxClientName.Show();
                this.comboBoxContractCode.Items.Clear();
                foreach (DataRow row in this.dataset.Tables["options_contracts"].Rows)
                {
                    this.comboBoxContractCode.Items.Add(row["合约代码"]);
                }
                if (this.comboBoxContractCode.Items.Count > 0)
                {
                    this.comboBoxContractCode.SelectedIndex = 0;
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxEntityCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxTargetID.Items.Clear();
            this.comboBoxTargetID.Items.Add("无");
            if (this.comboBoxOrderType.Text == "期货")
            {
                int account_no = 0;
                if (!int.TryParse(this.comboBoxEntityCode.Text, out account_no))
                {
                    MessageBox.Show("期货账号格式错误。", "错误");
                }
                else
                {
                    foreach (DataRow row in this.dataset.Tables["client_info"].Rows)
                    {
                        if (Convert.ToInt32(row["期货账号"]) == account_no)
                        {
                            this.comboBoxTargetID.Items.Add(row["客户编号"].ToString().PadLeft(8, '0'));
                        }
                    }
                    if (this.comboBoxTargetID.Items.Count > 0)
                    {
                        this.comboBoxTargetID.SelectedIndex = 0;
                    }
                    this.textBoxBalance.Text = ((double)this.dataset.Tables["futures_account_balance"].Rows.Find(account_no)["当前余额"]).ToString("N2");
                }
            }
            else
            {
                int client_id = 0;
                if (!int.TryParse(this.comboBoxEntityCode.Text, out client_id))
                {
                    MessageBox.Show("客户编号格式错误。", "错误");
                }
                else
                {
                    this.textBoxClientName.Text = this.dataset.Tables["client_info"].Rows.Find(client_id)["客户名称"].ToString();
                    this.textBoxBalance.Text = ((double)this.dataset.Tables["client_balance"].Rows.Find(client_id)["余额"]).ToString("N2");

                }
                SetCloseTargetIDs(sender, e);
            }
            

        }

        private void comboBoxOpenClose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((this.comboBoxOrderType.Text == "期权" && this.comboBoxOpenClose.Text == "平仓")|| this.comboBoxOrderType.Text == "期货")
            {
                this.comboBoxTargetID.Show();
                this.labelTargetID.Show();
            }
            else
            {
                this.comboBoxTargetID.Hide();
                this.labelTargetID.Hide();
            }
        }

        private void buttonMaxQuantity_Click(object sender, EventArgs e)
        {
            this.numericUpDownQuantity.Value = this.numericUpDownQuantity.Maximum;
        }

        private void SetMaxQuantity(object sender, EventArgs e)
        {
            String contract_code = this.comboBoxContractCode.Text;
            if (String.IsNullOrEmpty(contract_code))
            {
                this.numericUpDownQuantity.Maximum = 0;
                return;
            }
            if (this.comboBoxOrderType.Text == "期权")
            {
                int client_id;
                if (!int.TryParse(this.comboBoxEntityCode.Text, out client_id))
                {
                    this.numericUpDownQuantity.Maximum = 0;
                    return;
                }

                if (this.comboBoxOpenClose.Text == "平仓")
                {
                    int target_id;
                    if (!int.TryParse(this.comboBoxTargetID.Text, out target_id) && this.comboBoxTargetID.Text != "无")
                    {
                        this.numericUpDownQuantity.Maximum = 0;
                        return;
                    }

                    String long_short = this.comboBoxLongShort.Text == "买入" ? "卖出" : "买入";
                    DataTable table = this.dataset.Tables["options_verbose_positions"];
                    String filterText = "";
                    if (this.comboBoxTargetID.Text != "无")
                    {
                        filterText = String.Format("(客户编号={0}) AND (合约代码='{1}') AND (买卖方向='{2}') AND (成交编号={3})",
                            client_id,
                            contract_code,
                            long_short,
                            target_id);
                    }
                    else
                    {
                        filterText = String.Format("(客户编号={0}) AND (合约代码='{1}') AND (买卖方向='{2}')",
                            client_id,
                            contract_code,
                            long_short);
                    }
                    int maximum = 0;
                    if (int.TryParse(table.Compute("sum(数量)", filterText).ToString(), out maximum))
                        {
                        this.numericUpDownQuantity.Maximum = maximum;
                    }
                    else
                    {
                        this.numericUpDownQuantity.Maximum = 0;
                    }
                }
                else
                {
                    if (this.numericUpDownPrice.Value == 0)
                    {
                        this.numericUpDownQuantity.Maximum = 0;
                        return;
                    }
                    decimal price = this.numericUpDownPrice.Value;
                    DataRow rowBalance = this.dataset.Tables["client_balance"].Rows.Find(client_id);
                    DataRow rowContract = this.dataset.Tables["options_contracts"].Rows.Find(contract_code);
                    if (rowContract == null || rowBalance == null)
                    {
                        this.numericUpDownQuantity.Maximum = 0;
                        return;
                    }
                    decimal marginRate = Convert.ToDecimal(rowContract["保证金率"]);
                    decimal commission = Convert.ToDecimal(rowContract["手续费"]);
                    decimal multiplier = Convert.ToDecimal(rowContract["合约乘数"]);
                    this.numericUpDownQuantity.Maximum = (int)(Convert.ToDecimal(rowBalance["余额"])/(price*multiplier + commission));
                }
            }
            else
            {
                int account_no;
                if (!int.TryParse(this.comboBoxEntityCode.Text, out account_no))
                {
                    this.numericUpDownQuantity.Maximum = 0;
                    return;
                }

                if (this.comboBoxOpenClose.Text == "平仓")
                {
                    String long_short = this.comboBoxLongShort.Text == "买入" ? "卖出" : "买入";
                    DataTable table = this.dataset.Tables["futures_verbose_positions"];
                    String filterText = "";
                    filterText = String.Format("(期货账号={0}) AND (合约代码='{1}') AND (买卖方向='{2}')",
                            account_no,
                            contract_code,
                            long_short);
                    int maximum = 0;
                    if (int.TryParse(table.Compute("sum(数量)", filterText).ToString(), out maximum))
                    {
                        this.numericUpDownQuantity.Maximum = maximum;
                    }
                    else
                    {
                        this.numericUpDownQuantity.Maximum = 0;
                    }
                }
                else
                {
                    DataRow rowBalance = this.dataset.Tables["futures_account_balance"].Rows.Find(account_no);

                    DataRow rowContract = this.dataset.Tables["futures_contracts"].Rows.Find(contract_code);
                    if (rowContract == null || rowBalance == null)
                    {
                        this.numericUpDownQuantity.Maximum = 0;
                        return;
                    }
                    decimal settlePrice = Convert.ToDecimal(rowContract["结算价"]);
                    decimal marginRate = Convert.ToDecimal(rowContract["保证金率"]);
                    decimal commission = Convert.ToDecimal(rowContract["手续费"]);
                    decimal multiplier = Convert.ToDecimal(rowContract["合约乘数"]);
                    if (settlePrice == 0 || marginRate==0||multiplier==0)
                    {
                        this.numericUpDownQuantity.Maximum = 0;
                        return;
                    }
                    this.numericUpDownQuantity.Maximum = (int)(Convert.ToDecimal(rowBalance["当前余额"]) / (settlePrice* marginRate*multiplier+commission));
                }
            }
        }

        private void SetCloseTargetIDs(object sender, EventArgs args)
        {
            String contractCode = this.comboBoxContractCode.Text;
            if (String.IsNullOrEmpty(contractCode))
            {
                return;
            }
            int client_id = 0;
            if (!int.TryParse(this.comboBoxEntityCode.Text, out client_id))
            {
                MessageBox.Show("客户编号格式错误。", "错误");
            }
            else
            {
                foreach (DataRow row in this.dataset.Tables["options_verbose_positions"].Select(String.Format("(客户编号={0}) AND (合约代码='{1}') AND 买卖方向='{2}'", client_id, contractCode, this.comboBoxLongShort.Text == "买入" ? "卖出" : "买入")))
                {

                    this.comboBoxTargetID.Items.Add(row["成交编号"].ToString().PadLeft(8, '0'));
                }
                if (this.comboBoxTargetID.Items.Count > 0)
                {
                    this.comboBoxTargetID.SelectedIndex = 0;
                }
            }
        }

        private void SetAsCloseOrderForm(DataGridViewRow row)
        {
            this.comboBoxOpenClose.Enabled = false;
            this.comboBoxLongShort.Text = row.Cells["买卖方向"].Value.ToString() == "买入" ? "卖出" : "买入";
            this.comboBoxLongShort.Enabled = false;
            this.comboBoxContractCode.Text = row.Cells["合约代码"].Value.ToString();
            this.comboBoxContractCode.Enabled = false;
            this.comboBoxTargetID.Text = row.Cells["成交编号"].Value.ToString().PadLeft(8, '0');
            this.comboBoxTargetID.Enabled = false;
        }

        private void SetAsOptionsCloseOrderForm(DataGridViewRow row)
        {
            this.comboBoxOrderType.Text = "期权";
            this.comboBoxOrderType.Enabled = false;
            this.comboBoxEntityCode.Text = row.Cells["客户编号"].Value.ToString().PadLeft(8, '0');
            this.comboBoxEntityCode.Enabled = false;
            SetAsCloseOrderForm(row);
        }

        private void SetAsFuturesCloseOrderForm(DataGridViewRow row)
        {
            this.comboBoxOrderType.Text = "期货";
            this.comboBoxOrderType.Enabled = false;
            this.comboBoxEntityCode.Text = row.Cells["期货账号"].Value.ToString().PadLeft(8, '0');
            this.comboBoxEntityCode.Enabled = false;
            SetAsCloseOrderForm(row);
        }

        private void ComputeValue(object sender, EventArgs e)
        {
            String contractCode = this.comboBoxContractCode.Text;
            if (contractCode != null)
            {
                this.textBoxValue.Text = "0";
            }
            decimal commission = 0;
            decimal multiplier = 0;
            decimal margin_rate = 0;
            String table_name = this.comboBoxOrderType.Text == "期货" ? "futures_contracts" : "options_contracts";
            DataRow row = this.dataset.Tables["futures_contracts"].Rows.Find(contractCode);
            commission = (decimal)row["手续费"];
            multiplier = (decimal)row["乘数"];
            margin_rate = (decimal)row["保证金率"];
            this.textBoxValue.Text = (this.numericUpDownPrice.Value * this.numericUpDownQuantity.Value).ToString("N2");
        }

        OTCDataSet dataset;
    }
}