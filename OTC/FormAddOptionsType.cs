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
    public partial class FormAddOptionsType : Form
    {
        public FormAddOptionsType(OTCDataSet ds)
        {
            InitializeComponent();
            this.dataset = ds;
            table = this.dataset.Tables["options_types"];
            
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxOptionsTypeCode.Text) && !string.IsNullOrEmpty(textBoxOptionsTypeName.Text))
            {
                table.Rows.Add(this.textBoxOptionsTypeCode.Text, this.textBoxOptionsTypeName.Text);
                this.dataset.Commit("options_types");
                this.dataset.Update("options_types");
                this.Close();
            }
            else if (string.IsNullOrEmpty(textBoxOptionsTypeCode.Text))
            {
                MessageBox.Show("期权类型代码不能为空", "错误");
            }
            else
            {
                MessageBox.Show("期权类型名称名称不能为空", "错误");
            }
        }
        DataTable table;
        OTCDataSet dataset;

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
