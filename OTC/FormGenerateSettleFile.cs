using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace OTC
{
    public partial class FormGenerateSettleFile : Form
    {
        public FormGenerateSettleFile(OTCDataSet ds)
        {
            InitializeComponent();
            dataset = ds;
            checkBox1.Checked = false;
            groupBoxSendEmail.Enabled = false;
            this.textBox1.Text = Properties.Settings.Default.SettleFileDir;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxSendEmail.Enabled = checkBox1.Checked;
        }


        private OTCDataSet dataset;

        private void buttonSelectFolder_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.ShowDialog();
            this.textBox1.Text = this.folderBrowserDialog1.SelectedPath;
        }

        private void buttonSetAsDefault_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^([a-zA-Z]:\\)?[^\/\:\*\?\""\<\>\|\,]+$");
            if (!reg.IsMatch(textBox1.Text))
                MessageBox.Show("路径不合法","错误");
            Properties.Settings.Default.SettleFileDir = textBox1.Text;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^([a-zA-Z]:\\)?[^\/\:\*\?\""\<\>\|\,]+$");
            if (!reg.IsMatch(textBox1.Text))
                MessageBox.Show("路径不合法", "错误");
            var sr = new SettlementReports(dataset, this.textBox1.Text);
            var date = this.dateTimePicker1.Value.Date;
            try {
                if (sr.GenerateBusinessReport(date) == -1 || sr.GenerateDetailedReport(date) == -1 || sr.GenerateOptionReport(date) == -1)
                {
                    MessageBox.Show("结算数据缺失", "错误");
                    return;
                }
                else if (sr.GenerateBusinessReport(date) == -2 || sr.GenerateDetailedReport(date) == -2 || sr.GenerateOptionReport(date) == -2)
                {
                    MessageBox.Show("创建目录失败：用户权限不够。", "错误");
                    return;
                }
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("结算文件正在被其他程序使用，请关闭后再试。", "错误");
                return;
            }
            Close();          
        }
    }
}
