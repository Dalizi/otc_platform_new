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
            InitDates();
        }
        public void InitDates()
        {
            this.monthCalendarTrading.MinDate = DateTime.Today;
            try
            {
                var connection = dataset.CreateSQLConnection();
                connection.Open();
                var command = new MySql.Data.MySqlClient.MySqlCommand("select * from trade_dates", connection);
                var reader = command.ExecuteReader();
                while (reader.Read()) {
                    DateTime date = DateTime.Parse(reader[0].ToString());
                    this.monthCalendarTrading.AddBoldedDate(date);
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void monthCalendar1_MouseDown(object sender, MouseEventArgs e)
        {
            MonthCalendar.HitTestInfo info = this.monthCalendarTrading.HitTest(e.Location);
            if (info.HitArea == MonthCalendar.HitArea.Date)
            {
                if (this.monthCalendarTrading.BoldedDates.Contains(info.Time))
                    this.monthCalendarTrading.RemoveBoldedDate(info.Time);
                else
                    this.monthCalendarTrading.AddBoldedDate(info.Time);
                this.monthCalendarTrading.UpdateBoldedDates();
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                var connection = dataset.CreateSQLConnection();
                connection.Open();
                var command = new MySql.Data.MySqlClient.MySqlCommand("delete from trade_dates", connection);
                command.ExecuteNonQuery();
                command.CommandText = "insert into trade_dates values";
                foreach (var date in this.monthCalendarTrading.BoldedDates)
                {
                    command.CommandText += "('" + date.ToString("yyyy/MM/dd") + "'),";
                }
                command.CommandText = command.CommandText.Trim(',');
                command.ExecuteNonQuery();
                connection.Close();
                this.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
{
                MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


}
