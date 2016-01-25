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
                table.Rows.Add(this.textBoxCommodityCode.Text, this.textBoxCommodityName.Text);
                this.mainWind.dataset.Commit("commodity_category");
                this.mainWind.dataset.Update("commodity_category");
                this.Close();
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
