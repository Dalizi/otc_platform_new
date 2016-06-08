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
    public partial class FormTradingDatesSetting : Form
    {
        OTCDataSet dataset;
        public FormTradingDatesSetting()
        {
            InitializeComponent();
        }
        public FormTradingDatesSetting(OTCDataSet ds):this()
        { 
            this.dataset = ds;
            this.listBoxNonTradeDay.DataSource = ds.Tables["non_trade_dates"];
            this.listBoxNonTradeDay.ValueMember = "non_trade_dates";
            this.listBoxNonTradeDay.DisplayMember = "non_trade_dates";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddDay_Click(object sender, EventArgs e)
        {
            var table = (DataTable)this.listBoxNonTradeDay.DataSource;
            table.Rows.Add(this.dateTimePicker1.Value);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var s_item = this.listBoxNonTradeDay.SelectedItem;
            var table = (DataTable)this.listBoxNonTradeDay.DataSource;
            if (s_item != null)
            {
                DataRowView row = (DataRowView)s_item;
                table.Rows.Find(row[0]).Delete();
            }

        }

        private void commitChange()
        {
            this.dataset.Commit("non_trade_dates");
            this.dataset.Tables["non_trade_dates"].DefaultView.Sort = "[non_trade_dates]";
            ((DataTable)this.listBoxNonTradeDay.DataSource).AcceptChanges();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            commitChange();
            this.Close();
        }
    }


}
