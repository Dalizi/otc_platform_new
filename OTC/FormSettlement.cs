using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StackExchange.Redis;

namespace OTC
{
    public partial class FormSettlement : Form
    {
        public FormSettlement(OTCDataSet ds)
        {
            InitializeComponent();
            dataset = ds;
            InitDataTable();
            this.dateTimePickerSettleDate.Value = DateTime.Today;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            foreach (var l in option_table.AsEnumerable())
            {
                var key = l.Field<string>("合约代码");
                var c_line = dataset.Tables["options_contracts"].Rows.Find(key);
                c_line["波动率"] = l.Field<double>("波动率");
                c_line["结算价"] = l.Field<decimal>("结算价");
            }
            dataset.Commit("options_contracts");

            foreach (var l in future_table.AsEnumerable())
            {
                var key = l.Field<string>("合约代码");
                var c_line = dataset.Tables["futures_contracts"].Rows.Find(key);
                c_line["手续费"] = l.Field<decimal>("手续费");
                c_line["保证金率"] = l.Field<decimal>("保证金率");
                c_line["结算价"] = l.Field<decimal>("结算价");
            }
            dataset.Commit("futures_contracts");

            var conn = this.dataset.CreateSQLConnection();
            conn.Open();
            var query = new MySql.Data.MySqlClient.MySqlCommand(String.Format("call settlement('{0}')", dateTimePickerSettleDate.Value.ToString("yyyy-MM-dd")), conn);
            query.ExecuteNonQuery();

            this.dataset.Update("option_position_settle_info");
            foreach (var l in option_table.AsEnumerable())
            {
                var key = l.Field<string>("合约代码");
                foreach (var c_line in dataset.Tables["option_position_settle_info"].Select(string.Format("settle_date='{0}' and code='{1}'", dateTimePickerSettleDate.Value.ToString("yyyy-MM-dd"), key)))
                {

                    c_line["delta"] = l.Field<double>("delta");
                    c_line["gamma"] = l.Field<double>("gamma");
                    c_line["theta"] = l.Field<double>("theta");
                    c_line["vega"] = l.Field<double>("vega");
                    c_line["rho"] = l.Field<double>("rho");
                }
            }
            dataset.Commit("option_position_settle_info");

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
                              //join s in dataset.Tables["option_position_settle_info"].AsEnumerable()
                              //on p.Field<string>("合约代码") equals s.Field<string>("code")
                              where p.Field<decimal>("数量") > 0 && p.RowState != DataRowState.Deleted //&& s.Field<DateTime>("settle_date").Date == this.dateTimePickerSettleDate.Value.Date
                              select new
                              {
                                  contract_code = o.Field<string>("合约代码"),
                                  volatility = o.Field<double>("波动率"),
                                  settle_price = o.Field<decimal>("结算价"),
                                  //delta = s.Field<decimal>("delta"),
                                  //gamma = s.Field<decimal>("gamma"),
                                  //theta = s.Field<decimal>("theta"),
                                  //vega = s.Field<decimal>("vega"),
                                  //rho = s.Field<decimal>("rho")
                                  delta = 0,
                                  gamma = 0,
                                  theta = 0,
                                  vega = 0,
                                  rho = 0
                              };
            foreach (var r in option_info.Distinct())
            {
                option_table.Rows.Add(r.contract_code, r.volatility, r.settle_price, r.delta, r.gamma, r.theta, r.vega, r.rho);
            }

            future_table = new DataTable();
            future_table.Columns.Add("合约代码", Type.GetType("System.String"));
            future_table.Columns.Add("手续费", Type.GetType("System.Decimal"));
            future_table.Columns.Add("保证金率", Type.GetType("System.Decimal"));
            future_table.Columns.Add("前结算价", Type.GetType("System.Decimal"));
            future_table.Columns.Add("结算价", Type.GetType("System.Decimal"));
            var future_info = from p in dataset.display_ds.Tables["futures_verbose_positions"].AsEnumerable()
                              join o in dataset.display_ds.Tables["futures_contracts"].AsEnumerable()
                              on p.Field<string>("合约代码") equals o.Field<string>("合约代码")
                              where p.Field<decimal>("数量") > 0 && p.RowState != DataRowState.Deleted
                              select new
                              {
                                  contract_code = o.Field<string>("合约代码"),
                                  commission = o.Field<decimal>("手续费"),
                                  margin_rate = o.Field<decimal>("保证金率"),
                                  settle_price = o.Field<decimal>("结算价")
                              };
            var redis_db = this.dataset.CreateRedisConnection();
            foreach (var r in future_info.Distinct())
            {
                decimal s_price = r.settle_price;
                if (redis_db.KeyExists(r.contract_code))
                {
                    var settle_price = redis_db.HashGet(r.contract_code, "SettlementPrice");
                    s_price = decimal.Parse(settle_price == RedisValue.Null?0:settle_price);
                }
                else
                    MessageBox.Show("错误", string.Format("Key:{0}不存在", r.contract_code));
                future_table.Rows.Add(r.contract_code, r.commission, r.margin_rate, r.settle_price, s_price);
            }


            this.dataGridViewOptionInfo.DataSource = option_table;
            this.dataGridViewFutureInfo.DataSource = future_table;
        }
        OTCDataSet dataset;
        DataTable option_table;
        DataTable future_table;

        private void dateTimePickerSettleDate_ValueChanged(object sender, EventArgs e)
        {
            InitDataTable();
        }
    }
}