using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using StackExchange.Redis;
using System.Data;

namespace OTC
{
    public class OTCDataSet : DataSet
    {
        public OTCDataSet() { InitializeComponent(); }

        public OTCDataSet(DatabaseManager dm) : this()
        {
            this.dbManager = dm;
            this.sql_connection = dm.GetSQLConnection();
            this.redis_connection = dm.GetRedisConnection();
            GetData();
        }

        public OTCDataSet(String name) : base(name)
        {
            InitializeComponent();
        }

        public OTCDataSet(String name, DatabaseManager dm) : this(dm)
        {
            base.DataSetName = name;
        }

        private void InitializeComponent()
        {

            this.colNameDict = new Dictionary<string, string>();
            this.sql_connection = new MySqlConnection();
            this.adapterDict = new Dictionary<string, MySqlDataAdapter>();
            this.tmp_ds = new DataSet();
            GetColNameMapping();

        }

        private void GetColNameMapping()
        {

            String text = System.IO.File.ReadAllText("./TextFileColNameMapping.txt");
            foreach (String line in text.Split('\n'))
            {
                String[] keyValue = line.TrimEnd('\r').Split('=');
                colNameDict.Add(keyValue[0], keyValue[1]);
            }
        }


        private void GetData()
        {
            table_names = new String[] {
                "client_balance",
                "client_cashflow",
                "client_cashflow_type",
                "client_info",
                "commodity_category",
                "futures_account_balance",
                "futures_account_info",
                "futures_cashflow",
                "futures_cashflow_type",
                "futures_contracts",
                "futures_transactions",
                "futures_verbose_positions",
                "options_contracts",
                "options_direction_type",
                "options_transactions",
                "options_types",
                "options_verbose_positions"
            };

            view_names = new String[]
            {
                "client_balance_join",
                "client_cashflow_view",
                "commodity_category_view",
                "futures_account_balance_view",
                "futures_cashflow_view",
                "futures_contracts_view",
                "futures_positions_summary",
                "futures_transactions_view",
                "futures_verbose_positions_view",
                "options_contracts_view",
                "options_direction_type_view",
                "options_positions_summary",
                "options_transactions_view",
                "options_types_view",
                "options_verbose_positions_view",
                "non_trade_dates",
                "business_state_view"
            };
            String selectString = "";
            foreach (String t in table_names)
            {
                selectString = String.Format("select * from {0};", t);
                MySqlCommand command = new MySqlCommand(selectString, this.sql_connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                command.CommandType = System.Data.CommandType.Text;
                adapter.SelectCommand = command;
                MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
                adapter.InsertCommand = builder.GetInsertCommand();
                adapter.UpdateCommand = builder.GetUpdateCommand();
                adapter.DeleteCommand = builder.GetDeleteCommand();
                adapter.FillSchema(this, System.Data.SchemaType.Source, t);
                adapter.FillSchema(tmp_ds, SchemaType.Source, t);
                adapter.Fill(this, t);
                adapterDict.Add(t, adapter);
            }
            foreach (String t in view_names)
            {
                selectString = String.Format("select * from {0};", t);
                if (t == "futures_verbose_positions_view")
                    selectString = "SELECT * FROM futures_verbose_positions;";
                MySqlCommand command = new MySqlCommand(selectString, this.sql_connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                command.CommandType = System.Data.CommandType.Text;
                adapter.SelectCommand = command;
                if (t == "non_trade_dates")
                {
                    MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
                    adapter.InsertCommand = builder.GetInsertCommand();
                    adapter.UpdateCommand = builder.GetUpdateCommand();
                    adapter.DeleteCommand = builder.GetDeleteCommand();
                }
                adapter.FillSchema(this, System.Data.SchemaType.Source, t);
                adapter.FillSchema(tmp_ds, SchemaType.Source, t);
                adapter.Fill(this, t);
                adapterDict.Add(t, adapter);
            }
            foreach (System.Data.DataTable table in this.Tables)
            {
                foreach (System.Data.DataColumn col in table.Columns)
                {
                    col.AllowDBNull = true;
                }
            }

            {
                System.Data.DataTable client_table = this.Tables["client_balance_join"];
                var tmp_client_table = this.tmp_ds.Tables["client_balance_join"];
                client_table.PrimaryKey = new System.Data.DataColumn[] { client_table.Columns["client_id"] };
                tmp_client_table.PrimaryKey = new System.Data.DataColumn[] { tmp_client_table.Columns["client_id"] };
            }

            {
                System.Data.DataTable sum_table = this.Tables["options_positions_summary"];
                var tmp_sum_table = this.tmp_ds.Tables["options_positions_summary"];
                sum_table.PrimaryKey = new System.Data.DataColumn[] { sum_table.Columns["client_id"], sum_table.Columns["contract_code"], sum_table.Columns["long_short"] };
                tmp_sum_table.PrimaryKey = new System.Data.DataColumn[] { tmp_sum_table.Columns["client_id"], tmp_sum_table.Columns["contract_code"], tmp_sum_table.Columns["long_short"] };
            }
            {
                System.Data.DataTable sum_table = this.Tables["futures_positions_summary"];
                var tmp_sum_table = this.tmp_ds.Tables["futures_positions_summary"];
                sum_table.PrimaryKey = new System.Data.DataColumn[] { sum_table.Columns["account_no"], sum_table.Columns["contract_code"], sum_table.Columns["long_short"] };
                tmp_sum_table.PrimaryKey = new System.Data.DataColumn[] { tmp_sum_table.Columns["account_no"], tmp_sum_table.Columns["contract_code"], tmp_sum_table.Columns["long_short"] };

            }

            foreach (String t in table_names)
            {
                System.Data.DataTable table = Tables[t];
                MySqlDataAdapter adapter = adapterDict[t];
                System.Data.Common.DataTableMapping mapping = adapter.TableMappings.Add(t, t);
                foreach (System.Data.DataColumn col in table.Columns)
                {
                    String mappedName = "";
                    if (colNameDict.TryGetValue(col.ColumnName, out mappedName))
                        mapping.ColumnMappings.Add(col.ColumnName, mappedName);
                }
            }

            foreach (String t in view_names)
            {
                System.Data.DataTable table = Tables[t];
                MySqlDataAdapter adapter = adapterDict[t];
                System.Data.Common.DataTableMapping mapping = adapter.TableMappings.Add(t, t);
                foreach (System.Data.DataColumn col in table.Columns)
                {
                    String mappedName = "";
                    if (colNameDict.TryGetValue(col.ColumnName, out mappedName))
                        mapping.ColumnMappings.Add(col.ColumnName, mappedName);
                }
            }

            //this.Update();

            foreach (System.Data.DataTable table in Tables)
            {
                foreach (System.Data.DataColumn col in table.Columns)
                {
                    String mappedName = "";
                    if (colNameDict.TryGetValue(col.ColumnName, out mappedName))
                        col.ColumnName = mappedName;
                }
            }

            foreach (System.Data.DataTable table in tmp_ds.Tables)
            {
                foreach (System.Data.DataColumn col in table.Columns)
                {
                    String mappedName = "";
                    col.AllowDBNull = true;
                    if (colNameDict.TryGetValue(col.ColumnName, out mappedName))
                        col.ColumnName = mappedName;
                }
            }

            this.Tables.Add("risk_info");
            using (DataTable table = this.Tables["risk_info"])
            {
                table.Columns.Add("客户编号", Type.GetType("System.UInt32"));
                table.Columns.Add("合约代码", Type.GetType("System.String"));
                table.Columns.Add("标的代码", Type.GetType("System.String"));
                table.Columns.Add("买卖方向", Type.GetType("System.String"));
                table.Columns.Add("标的现价", Type.GetType("System.Decimal"));
                table.Columns.Add("数量", Type.GetType("System.Double"));
                table.Columns.Add("到期天数", Type.GetType("System.UInt32"));
                table.Columns.Add("波动率", Type.GetType("System.Double"));
                table.Columns.Add("Delta", Type.GetType("System.Double"));
                table.Columns.Add("Gamma", Type.GetType("System.Double"));
                table.Columns.Add("Theta", Type.GetType("System.Double"));
                table.Columns.Add("Vega", Type.GetType("System.Double"));
                table.Columns.Add("Rho", Type.GetType("System.Double"));
                table.PrimaryKey = new DataColumn[] { table.Columns["客户编号"], table.Columns["合约代码"], table.Columns["买卖方向"] };

            }

            this.Tables.Add("risk_info_gross");
            using (DataTable table = this.Tables["risk_info_gross"])
            {
                table.Columns.Add("标的代码", Type.GetType("System.String"));
                table.Columns.Add("标的现价", Type.GetType("System.Decimal"));
                table.Columns.Add("Delta", Type.GetType("System.Double"));
                table.Columns.Add("Gamma", Type.GetType("System.Double"));
                table.Columns.Add("Theta", Type.GetType("System.Double"));
                table.Columns.Add("Vega", Type.GetType("System.Double"));
                table.Columns.Add("Rho", Type.GetType("System.Double"));
                table.PrimaryKey = new DataColumn[] { table.Columns["标的代码"] };

            }
            UpdateGreeks();
        }

        //private void AddAdapter(String sqlCommand, String table_name)
        //{
        //    MySqlDataAdapter adapter = new MySqlDataAdapter(sqlCommand, this.connection);
        //    adapter.FillSchema(this, System.Data.SchemaType.Source, table_name);
        //    adapter.Fill(this, table_name);
        //    this.adapterDict.Add(table_name, adapter);
        //    this.table_names.Add(table_name);
        //}

        public void Commit(String table_name)
        {
            MySqlDataAdapter a = adapterDict[table_name];
            try
            {
                a.Update(this, table_name);
            }
            catch (MySqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "数据库错误");
            }
            //a.Fill(this, table_name);

        }
        public void Commit()
        {
            foreach (String table_name in table_names)
            {
                Commit(table_name);
            }
        }
        public void Update(String table_name)
        {
            FillTable(table_name);
        }
        public void Update()
        {
            foreach (String table_name in table_names)
            {
                this.Tables[table_name].Clear();
                Update(table_name);
            }
            foreach (String table_name in view_names)
            {
                Update(table_name);
            }
            UpdateGreeks();
        }
        public MySqlConnection CreateSQLConnection()
        {
            return dbManager.GetSQLConnection();
        }
        public IDatabase CreateRedisConnection()
        {
            var conn = dbManager.GetRedisConnection();
            return conn.GetDatabase();
        }
        public double GetDTM(DateTime exp_date)
        {
            double dtm = (exp_date - DateTime.Today).TotalDays;
            var non_trade_days = this.Tables["non_trade_dates"];
            if (DateTime.Now.TimeOfDay < new DateTime(2016, 1, 1, 12, 0, 0).TimeOfDay)
            {
                dtm += 1;
            }
            DateTime d = DateTime.Today;
            int n_weekends = 0;
            while (d <= exp_date)
            {
                if (d.DayOfWeek == DayOfWeek.Saturday || d.DayOfWeek == DayOfWeek.Sunday || non_trade_days.Rows.Find(d) != null)
                {
                    n_weekends += 1;
                }
                d = d.AddDays(1);
            }
            dtm = dtm - n_weekends;
            dtm = dtm > 0 ? dtm : 0;
            return dtm;
        }
        private void UpdateGreeks()
        {
            var db = this.redis_connection.GetDatabase();
            DataTable table = Tables["risk_info"];
            foreach (var row in Tables["options_positions_summary"].AsEnumerable().ToArray())
            {
                if (row.RowState != DataRowState.Deleted)
                {
                    String contract_code = row["合约代码"].ToString();
                    int client_id = int.Parse(row["客户编号"].ToString());
                    string position_direction = row["买卖方向"].ToString();
                    double quantity = double.Parse(row["数量"].ToString());
                    DataRow contract_row = Tables["options_contracts"].Rows.Find(contract_code);
                    String underlying = contract_row["标的代码"].ToString();
                    double S0 = double.Parse(db.HashGet(underlying, "LastPrice"));
                    double K = double.Parse(contract_row["执行价"].ToString());
                    double sigma = double.Parse(contract_row["波动率"].ToString());
                    DateTime date = DateTime.Parse(contract_row["到期日"].ToString());
                    double dtm = GetDTM(date);
                    char type = char.Parse(contract_row["认购认沽"].ToString());
                    double rate = 0.015;
                    int direction_multiplier = position_direction == "买入" ? -1 : 1;
                    double delta = OptionsCalculator.GetBlsDelta(S0, K, dtm / 256d, sigma, rate, type) * quantity * direction_multiplier;
                    double gamma = OptionsCalculator.GetBlsGamma(S0, K, dtm / 256d, sigma, rate) * quantity * direction_multiplier;
                    double theta = OptionsCalculator.GetBlsTheta(S0, K, dtm / 256d, sigma, rate, type) * quantity / 256 * direction_multiplier * 10;
                    double vega = OptionsCalculator.GetBlsVega(S0, K, dtm / 256d, sigma, rate) * quantity / 100 * direction_multiplier * 10;
                    double rho = OptionsCalculator.GetBlsRho(S0, K, dtm / 256d, sigma, rate, type) * quantity / 100 * direction_multiplier * 10;
                    if (table.Rows.Contains(new object[] { client_id, contract_code, position_direction }))
                    {
                        DataRow row_risk = table.Rows.Find(new object[] { client_id, contract_code, position_direction });
                        row_risk["数量"] = quantity;
                        row_risk["波动率"] = sigma;
                        row_risk["标的现价"] = S0;
                        row_risk["到期天数"] = dtm;
                        row_risk["Delta"] = delta;
                        row_risk["Gamma"] = gamma;
                        row_risk["Theta"] = theta;
                        row_risk["Vega"] = vega;
                        row_risk["Rho"] = rho;
                    }
                    else
                    {
                        table.Rows.Add(client_id, contract_code, underlying, position_direction, S0, quantity, dtm, sigma, delta, gamma, theta, vega, rho);
                    }
                }


            }

            var position_keys = new List<object[]>();
            foreach (var row in table.AsEnumerable())
            {
                position_keys.Add(new object[] { row["客户编号"], row["合约代码"], row["买卖方向"] });
            }
            foreach (var key in position_keys)
            {
                if (!Tables["options_positions_summary"].Rows.Contains(key))
                {
                    table.Rows.Find(key).Delete();
                }
            }
            var risk_info_gross = from row in table.AsEnumerable()
                                  group row by row.Field<String>("标的代码")
                                  into grp
                                  select
                                  new
                                  {
                                      code = grp.Key,
                                      price = grp.First().Field<decimal>("标的现价"),
                                      Delta = grp.Sum(r => r.Field<double>("Delta")),
                                      Gamma = grp.Sum(r => r.Field<double>("Gamma")),
                                      Theta = grp.Sum(r => r.Field<double>("Theta")),
                                      Vega = grp.Sum(r => r.Field<double>("Vega")),
                                      Rho = grp.Sum(r => r.Field<double>("Rho")),
                                  };
            List<String> contracts = new List<string>();
            foreach (var a in risk_info_gross)
            {
                double long_underlying_position = 0;
                double short_underlying_position = 0;
                double.TryParse(this.Tables["futures_positions_summary"].Compute("sum(数量)", string.Format("合约代码='{0}' AND 买卖方向='{1}'", a.code, "买入")).ToString(), out long_underlying_position);
                double.TryParse(this.Tables["futures_positions_summary"].Compute("sum(数量)", string.Format("合约代码='{0}' AND 买卖方向='{1}'", a.code, "卖出")).ToString(), out short_underlying_position);

                contracts.Add(a.code);
                if (!Tables["risk_info_gross"].Rows.Contains(a.code))
                {
                    Tables["risk_info_gross"].Rows.Add(a.code, a.price, a.Delta + long_underlying_position - short_underlying_position, a.Gamma, a.Theta, a.Vega, a.Rho);
                }
                else
                {
                    var row = Tables["risk_info_gross"].Rows.Find(a.code);
                    row["标的现价"] = a.price;
                    row["Delta"] = a.Delta + long_underlying_position - short_underlying_position;
                    row["Gamma"] = a.Gamma;
                    row["Theta"] = a.Theta;
                    row["Vega"] = a.Vega;
                    row["Rho"] = a.Rho;
                }
            }
            List<string> position_codes = new List<string>();
            foreach (var row in Tables["risk_info_gross"].AsEnumerable())
            {
                position_codes.Add(row.Field<string>("标的代码"));
            }
            foreach (var code in position_codes)
            {
                if (!contracts.Contains(code))
                {
                    Tables["risk_info_gross"].Rows.Find(code).Delete();
                }
            }
        }
        private void FillTable(string table_name)
        {
            DataTable temp_table = tmp_ds.Tables[table_name];
            temp_table.Clear();
            DataTable target_table = Tables[table_name];
            var adapter = adapterDict[table_name];
            adapter.Fill(temp_table);
            var n_keys = target_table.PrimaryKey.Count();
            if (n_keys != 0)
            {
                foreach (var row in temp_table.AsEnumerable().ToArray())
                {
                    var values = new object[n_keys];
                    int i = 0;
                    foreach (var key in temp_table.PrimaryKey)
                    {
                        var temp_value = row[key];
                        values[i] = row[key];
                        ++i;
                    }
                    if (target_table.Rows.Find(values) == null)
                    {
                        target_table.Rows.Add(row.ItemArray);
                    }

                }
                foreach (var row in target_table.AsEnumerable().ToArray())
                {
                    if (row.RowState != DataRowState.Deleted)
                    {
                        var values = new object[n_keys];
                        int i = 0;
                        foreach (var key in target_table.PrimaryKey)
                        {
                            values[i] = row[key];
                            ++i;
                        }
                        if (temp_table.Rows.Find(values) == null)
                        {
                            target_table.Rows.Find(values).Delete();
                        }
                        else
                        {
                            target_table.Rows.Find(values).ItemArray = temp_table.Rows.Find(values).ItemArray;
                        }

                    }

                }



            }

        }

        DatabaseManager dbManager;
        MySqlConnection sql_connection;
        ConnectionMultiplexer redis_connection;
        Dictionary<string, MySqlDataAdapter> adapterDict;
        Dictionary<String, String> colNameDict;
        DataSet tmp_ds;
        string[] table_names;
        string[] view_names;
    }
}
