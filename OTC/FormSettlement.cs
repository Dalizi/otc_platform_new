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
    public partial class FormSettlement : Form
    {
        public FormSettlement(OTCDataSet ds)
        {
            InitializeComponent();
            dataset = ds;
            this.dateTimePickerSettleDate.Value = DateTime.Today;
            this.dataGridViewOptionInfo.DataSource = dataset;
            this.dataGridViewOptionInfo.DataMember = "option_settle_info_view";
            this.dataGridViewFutureInfo.DataSource = dataset;
            this.dataGridViewFutureInfo.DataMember = "future_settle_info_view";
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            var conn = this.dataset.CreateSQLConnection();
            conn.Open();
            var query = new MySql.Data.MySqlClient.MySqlCommand(String.Format("call settlement('{0}')",dateTimePickerSettleDate.Value.ToString("yyyy-MM-dd")), conn);
            query.ExecuteNonQuery();
            this.Close();
        }
        OTCDataSet dataset;
    }
}
