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
    public partial class FormModifyClient : Form
    {
        public FormModifyClient(OTCDataSet ds)
        {
            InitializeComponent();
            this.dataset = ds;
            DataTable table = this.dataset.Tables["client_info"];
            foreach (DataRow dr in dataset.Tables["futures_account_info"].Rows)
            {
                this.comboBoxFuturesAccount.Items.Add(dr["期货账号"]);
            }
            foreach (DataRow row in table.Rows)
            {
                this.comboBoxClientID.Items.Add(row["客户编号"]);
            }
            if (this.comboBoxClientID.Items.Count > 0)
            {
                this.comboBoxClientID.SelectedIndex = 0;
            }
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxClientName.Text) && !String.IsNullOrEmpty(comboBoxFuturesAccount.Text))
            {
                DataRow dr = this.dataset.Tables["client_info"].Rows.Find(int.Parse(this.comboBoxClientID.Text));
                dr[1] = this.textBoxClientName.Text;
                dr[2] = this.comboBoxFuturesAccount.Text;
                dataset.Commit("client_info");
                dataset.Update();
                this.Close();
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
            this.Close();
        }
        OTCDataSet dataset;
        DataTable table;

        private void comboBoxClientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow dr = this.dataset.Tables["client_info"].Rows.Find(int.Parse(this.comboBoxClientID.Text));
            this.textBoxClientName.Text = dr["客户名称"].ToString();
            this.comboBoxFuturesAccount.SelectedIndex = this.comboBoxFuturesAccount.FindString(dr["期货账号"].ToString());
        }
    }
}