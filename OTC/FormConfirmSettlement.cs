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
    public partial class FormConfirmSettlement : Form
    {
        public FormConfirmSettlement(OTCDataSet dataset)
        {
            InitializeComponent();
            this.dataset = dataset;
            dateTimePickerConfirmSettlement.Value = DateTime.Today;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            var sql_conn = dataset.CreateSQLConnection();
            sql_conn.Open();
            var cmd = sql_conn.CreateCommand();
            cmd.CommandText = string.Format("call confirm_settlement('{0}')", dateTimePickerConfirmSettlement.Value.Date.ToString("yyyy-MM-dd"));
            cmd.ExecuteNonQuery();
            Close();
        }

        OTCDataSet dataset;
    }
}
