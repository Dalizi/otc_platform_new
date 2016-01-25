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
    public partial class FormAddFuturesAccount : Form
    {
        public FormAddFuturesAccount(MainWindow mw)
        {
            InitializeComponent();
            mainWind = mw;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.maskedTextBoxFuturesAccount.Text))
            {
                DataTable futuresAccountInfoTable = mainWind.dataset.Tables["futures_account_info"];
                int account_no;
                if (int.TryParse(maskedTextBoxFuturesAccount.Text, out account_no))
                {
                    futuresAccountInfoTable.Rows.Add(account_no);
                    this.mainWind.dataset.Commit("futures_account_info");
                    this.mainWind.dataset.Update();
                    this.Close();
                } else
                {
                    MessageBox.Show("期货账号格式非法。", "错误");
                }
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

        MainWindow mainWind;

    }
}
