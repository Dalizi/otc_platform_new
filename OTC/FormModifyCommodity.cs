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
    public partial class FormModifyCommodity : Form
    {
        public FormModifyCommodity(MainWindow mw)
        {
            InitializeComponent();
            this.mainWind = mw;
            table = this.mainWind.dataset.Tables["commodity_category"];
            foreach (DataRow row in table.Rows)
            {
                this.comboBoxCommodityCode.Items.Add(row[0].ToString());
            }
            if (this.comboBoxCommodityCode.Items.Count != 0)
            {
                this.comboBoxCommodityCode.SelectedIndex = 0;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.textBoxCommodityName.Text))
            {
                table.Rows.Find(this.comboBoxCommodityCode.Text)[1] = this.textBoxCommodityName.Text;
                this.mainWind.dataset.Commit("commodity_category");
                this.mainWind.dataset.Update("commodity_category");
                this.Close();
            }
            else
            {
                MessageBox.Show("商品名称不能为空", "错误");
            }
        }

        MainWindow mainWind;
        DataTable table;

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxCommodityCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow row = this.table.Rows.Find(this.comboBoxCommodityCode.Text);
            this.textBoxCommodityName.Text = row[1].ToString();
        }
    }
}
