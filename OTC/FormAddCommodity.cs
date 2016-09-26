/*
版权所有：中粮期货有限公司
作者：谭泽寰
功能：Windows Form窗口，用来添加商品种类信息
*/
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
    public partial class FormAddCommodity : Form
    {
        public FormAddCommodity(MainWindow mw)
        {
            InitializeComponent();
            this.mainWind = mw;
            table = this.mainWind.dataset.Tables["commodity_category"];
            
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxCommodityCode.Text) && !string.IsNullOrEmpty(textBoxCommodityName.Text))
            {
                if (table.Rows.Find(textBoxCommodityCode.Text) != null)
                {
                    MessageBox.Show("商品代码已存在", "错误");
                }
                else
                {
                    table.Rows.Add(this.textBoxCommodityCode.Text, this.textBoxCommodityName.Text);
                    this.mainWind.dataset.Commit("commodity_category");
                    this.mainWind.dataset.Update("commodity_category");
                    this.Close();
                }
            }
            else if (string.IsNullOrEmpty(textBoxCommodityCode.Text))
            {
                MessageBox.Show("商品代码不能为空", "错误");
            }
            else
            {
                MessageBox.Show("商品名称不能为空", "错误");
            }
        }
        DataTable table;
        MainWindow mainWind;

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
