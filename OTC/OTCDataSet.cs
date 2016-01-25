using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OTC
{
    public class OTCDataSet : System.Data.DataSet
    {
        public OTCDataSet() { InitializeComponent(); }

        public OTCDataSet(MySqlConnection conn)
        {
            InitializeComponent();
            this.connection = conn;
            GetData();
        }

        public OTCDataSet(String name) : base(name)
        {
            InitializeComponent();
        }

        public OTCDataSet(String name, MySqlConnection conn) : base(name)
        {
            InitializeComponent();
            this.connection = conn;
            GetData();
        }

        private void InitializeComponent()
        {

            this.colNameDict = new Dictionary<string, string>();
            this.connection = new MySqlConnection();
            this.adapterDict = new Dictionary<string, MySqlDataAdapter>();
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
                "options_verbose_positions",
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
                "options_verbose_positions_view"


            };
            String selectString = "";
            foreach (String t in table_names)
            {
                selectString = String.Format("select * from {0};", t);
                MySqlCommand command = new MySqlCommand(selectString, this.connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                command.CommandType = System.Data.CommandType.Text;
                adapter.SelectCommand = command;
                MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
                adapter.InsertCommand = builder.GetInsertCommand();
                adapter.UpdateCommand = builder.GetUpdateCommand();
                adapter.DeleteCommand = builder.GetDeleteCommand();
                adapter.FillSchema(this, System.Data.SchemaType.Source, t);
                adapter.Fill(this, t);
                adapterDict.Add(t, adapter);
            }
            foreach (String t in view_names)
            {
                selectString = String.Format("select * from {0};", t);
                MySqlCommand command = new MySqlCommand(selectString, this.connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                command.CommandType = System.Data.CommandType.Text;
                adapter.SelectCommand = command;
                adapter.FillSchema(this, System.Data.SchemaType.Source, t);
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
                System.Data.DataTable sum_table = this.Tables["options_positions_summary"];
                sum_table.PrimaryKey = new System.Data.DataColumn[] { sum_table.Columns["client_id"], sum_table.Columns["contract_code"], sum_table.Columns["long_short"]};
            }
            {
                System.Data.DataTable sum_table = this.Tables["futures_positions_summary"];
                sum_table.PrimaryKey = new System.Data.DataColumn[] { sum_table.Columns["account_no"], sum_table.Columns["contract_code"], sum_table.Columns["long_short"] };
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
            adapterDict[table_name].Fill(this, table_name);
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
        }

        MySqlConnection connection;
        Dictionary<String, MySqlDataAdapter> adapterDict;
        Dictionary<String, String> colNameDict;
        String[] table_names;
        String[] view_names;
    }
}
