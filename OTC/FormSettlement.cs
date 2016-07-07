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
            option_table = new DataTable();
            option_table.Columns.Add("合约代码", Type.GetType("System.String"));
            option_table.Columns.Add("波动率", Type.GetType("System.Double"));
            option_table.Columns.Add("结算价", Type.GetType("System.Decimal"));
            option_table.Columns.Add("delta", Type.GetType("System.Double"));
            option_table.Columns.Add("gamma", Type.GetType("System.Double"));
            option_table.Columns.Add("theta", Type.GetType("System.Double"));
            option_table.Columns.Add("vega", Type.GetType("System.Double"));
            option_table.Columns.Add("rho", Type.GetType("System.Double"));
            var option_info = from o in dataset.display_ds.Tables["options_contracts"].AsEnumerable()
                              join p in dataset.display_ds.Tables["options_verbose_positions"].AsEnumerable()
                              on o.Field<string>("合约代码") equals p.Field<string>("合约代码")
                              select new {
                                  contract_code = o.Field<string>("合约代码"),
                                  volatility = o.Field<double>("波动率"),
                                  settle_price = o.Field<decimal>("结算价"),
                                  delta = 0,
                                  gamma = 0,
                                  theta = 0,
                                  vega = 0,
                                  rho = 0
                              };
            foreach (var r in option_info)
            {
                option_table.Rows.Add(r.contract_code, r.volatility, r.settle_price, r.delta, r.gamma, r.theta, r.vega, r.rho);
            }
            this.dateTimePickerSettleDate.Value = DateTime.Today;
            this.dataGridViewOptionInfo.DataSource = option_table;
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

        private void InitDataTable()
        {
            option_table = new DataTable();
            option_table.Columns.Add("合约代码", Type.GetType("System.String"));
            option_table.Columns.Add("波动率", Type.GetType("System.Double"));
            option_table.Columns.Add("结算价", Type.GetType("System.Decimal"));
            option_table.Columns.Add("delta", Type.GetType("System.Double"));
            option_table.Columns.Add("gamma", Type.GetType("System.Double"));
            option_table.Columns.Add("theta", Type.GetType("System.Double"));
            option_table.Columns.Add("vega", Type.GetType("System.Double"));
            option_table.Columns.Add("rho", Type.GetType("System.Double"));
            var option_info = from o in dataset.display_ds.Tables["options_contracts"].AsEnumerable()
                              join p in dataset.display_ds.Tables["options_verbose_positions"].AsEnumerable()
                              on o.Field<string>("合约代码") equals p.Field<string>("合约代码")
                              select new
                              {
                                  contract_code = o.Field<string>("合约代码"),
                                  volatility = o.Field<double>("波动率"),
                                  settle_price = o.Field<decimal>("结算价"),
                                  delta = 0,
                                  gamma = 0,
                                  theta = 0,
                                  vega = 0,
                                  rho = 0
                              };
            foreach (var r in option_info)
            {
                option_table.Rows.Add(r.contract_code, r.volatility, r.settle_price, r.delta, r.gamma, r.theta, r.vega, r.rho);
            }

            future_table = new DataTable();
            future_table.Columns.Add("合约代码", Type.GetType("System.String"));
            future_table.Columns.Add("手续费", Type.GetType("System.Decimal"));
            future_table.Columns.Add("保证金", Type.GetType("System.Decimal"));
            future_table.Columns.Add("结算价", Type.GetType("System.Decimal"));
            var future_info = from o in dataset.display_ds.Tables["futures_contracts"].AsEnumerable()
                              join p in dataset.display_ds.Tables["futures_verbose_positions"].AsEnumerable()
                              on o.Field<string>("合约代码") equals p.Field<string>("合约代码")
                              select new
                              {
                                  contract_code = o.Field<string>("合约代码"),
                                  commission = o.Field<decimal>("手续费"),
                                  margin_rate = o.Field<decimal>("保证金率"),
                                  settle_price = o.Field<decimal>("结算价")
                              };
            foreach (var r in future_info)
            {
                future_table.Rows.Add(r.contract_code, r.commission, r.margin_rate, r.settle_price);
            }

            this.dateTimePickerSettleDate.Value = DateTime.Today;
            this.dataGridViewOptionInfo.DataSource = option_table;
            this.dataGridViewFutureInfo.DataSource = future_table;
        }
        OTCDataSet dataset;
        DataTable option_table;
        DataTable future_table;
    }
}