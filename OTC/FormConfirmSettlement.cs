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
            var cmd = sql_conn.CreateCommand();
            cmd.CommandText = string.Format("call confirm('{0}')", dateTimePickerConfirmSettlement.Value.Date.ToLongDateString());
            cmd.ExecuteNonQuery();
        }

        OTCDataSet dataset;
    }
}
