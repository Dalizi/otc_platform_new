using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OTC
{
    public partial class MainWindow : Form
    {
        public OTCDataSet dataset;

        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(OTCDataSet dataset)
        {
            InitializeComponent();
            this.dataset = dataset;
            SetDataSource();
            FormatTable();
            LinkEventsHandlers();
            this.timerUpdate.Start();
        }

        private void SetDataSource()
        {
            this.dataGridViewClientBalance.DataSource = this.dataset;
            this.dataGridViewClientBalance.DataMember = "client_balance_join";

            this.dataGridViewFuturesBlance.DataSource = this.dataset;
            this.dataGridViewFuturesBlance.DataMember = "futures_account_balance_view";

            this.dataGridViewCommodity.DataSource = this.dataset;
            this.dataGridViewCommodity.DataMember = "commodity_category_view";

            this.dataGridViewOptionsType.DataSource = this.dataset;
            this.dataGridViewOptionsType.DataMember = "options_types_view";

            this.dataGridViewFuturesContract.DataSource = this.dataset;
            this.dataGridViewFuturesContract.DataMember = "futures_contracts_view";

            this.dataGridViewOptionsContract.DataSource = this.dataset;
            this.dataGridViewOptionsContract.DataMember = "options_contracts_view";

            this.dataGridViewClientCashflow.DataSource = this.dataset;
            this.dataGridViewClientCashflow.DataMember = "client_cashflow_view";
            

            this.dataGridViewFuturesAccountCashflow.DataSource = this.dataset;
            this.dataGridViewFuturesAccountCashflow.DataMember = "futures_cashflow_view";

            this.dataGridViewOptionsTransactions.DataSource = this.dataset;
            this.dataGridViewOptionsTransactions.DataMember = "options_transactions_view";

            this.dataGridViewFuturesTransactions.DataSource = this.dataset;
            this.dataGridViewFuturesTransactions.DataMember = "futures_transactions_view";

            this.dataGridViewOptionsVerbosePositions.DataSource = this.dataset;
            this.dataGridViewOptionsVerbosePositions.DataMember = "options_verbose_positions_view";

            this.dataGridViewFuturesVerbosePositions.DataSource = this.dataset;
            this.dataGridViewFuturesVerbosePositions.DataMember = "futures_verbose_positions_view";

            this.dataGridViewOptionsPositionsSum.DataSource = this.dataset;
            this.dataGridViewOptionsPositionsSum.DataMember = "options_positions_summary";

            this.dataGridViewFuturesPositionsSum.DataSource = this.dataset;
            this.dataGridViewFuturesPositionsSum.DataMember = "futures_positions_summary";

            this.dataGridViewRiskInfoDetailed.DataSource = this.dataset;
            this.dataGridViewRiskInfoDetailed.DataMember = "risk_info";

            this.dataGridViewRiskGross.DataSource = this.dataset;
            this.dataGridViewRiskGross.DataMember = "risk_info_gross";
        }

        private void FormatTable()
        {
            this.dataGridViewClientBalance.Columns["客户编号"].DefaultCellStyle.Format = "00000000";
            this.dataGridViewClientBalance.Columns["期货账号"].DefaultCellStyle.Format = "00000000";
            this.dataGridViewClientBalance.Columns["余额"].DefaultCellStyle.Format = "N2";
            this.dataGridViewClientBalance.Columns["持仓市值"].DefaultCellStyle.Format = "N2";

            this.dataGridViewFuturesBlance.Columns["期货账号"].DefaultCellStyle.Format = "00000000";
            this.dataGridViewFuturesBlance.Columns["当前余额"].DefaultCellStyle.Format = "N2";
            this.dataGridViewFuturesBlance.Columns["当前保证金"].DefaultCellStyle.Format = "N2";
            this.dataGridViewFuturesBlance.Columns["期初余额"].DefaultCellStyle.Format = "N2";
            this.dataGridViewFuturesBlance.Columns["当前保证金"].DefaultCellStyle.Format = "N2";

            this.dataGridViewClientCashflow.Columns["资金流水编号"].DefaultCellStyle.Format = "00000000";
            this.dataGridViewClientCashflow.Columns["客户编号"].DefaultCellStyle.Format = "00000000";
            this.dataGridViewClientCashflow.Columns["成交编号"].DefaultCellStyle.Format = "00000000";
            this.dataGridViewClientCashflow.Columns["发生金额"].DefaultCellStyle.Format = "N2";

            this.dataGridViewFuturesAccountCashflow.Columns["资金流水编号"].DefaultCellStyle.Format = "00000000";
            this.dataGridViewFuturesAccountCashflow.Columns["期货账号"].DefaultCellStyle.Format = "00000000";
            this.dataGridViewFuturesAccountCashflow.Columns["成交编号"].DefaultCellStyle.Format = "00000000";
            this.dataGridViewFuturesAccountCashflow.Columns["发生金额"].DefaultCellStyle.Format = "N2";


            this.dataGridViewOptionsTransactions.Columns["成交编号"].DefaultCellStyle.Format = "00000000";
            this.dataGridViewOptionsTransactions.Columns["客户编号"].DefaultCellStyle.Format = "00000000";
            this.dataGridViewOptionsTransactions.Columns["平仓目标合同号"].DefaultCellStyle.Format = "00000000";
            this.dataGridViewOptionsTransactions.Columns["价格"].DefaultCellStyle.Format = "N2";
            this.dataGridViewOptionsTransactions.Columns["平仓盈亏"].DefaultCellStyle.Format = "N2";

            this.dataGridViewFuturesTransactions.Columns["成交编号"].DefaultCellStyle.Format = "00000000";
            this.dataGridViewFuturesTransactions.Columns["对应客户编号"].DefaultCellStyle.Format = "00000000";
            this.dataGridViewFuturesTransactions.Columns["期货账号"].DefaultCellStyle.Format = "00000000";
            this.dataGridViewFuturesTransactions.Columns["价格"].DefaultCellStyle.Format = "N2";
            this.dataGridViewFuturesTransactions.Columns["平仓盈亏"].DefaultCellStyle.Format = "N2";


            this.dataGridViewOptionsVerbosePositions.Columns["客户编号"].DefaultCellStyle.Format = "00000000";
            this.dataGridViewOptionsVerbosePositions.Columns["成交编号"].DefaultCellStyle.Format = "00000000";
            this.dataGridViewOptionsVerbosePositions.Columns["开仓价格"].DefaultCellStyle.Format = "N2";
            this.dataGridViewOptionsVerbosePositions.Columns["持仓价格"].DefaultCellStyle.Format = "N2";

            this.dataGridViewFuturesVerbosePositions.Columns["成交编号"].DefaultCellStyle.Format = "00000000";
            this.dataGridViewFuturesVerbosePositions.Columns["期货账号"].DefaultCellStyle.Format = "00000000";
            this.dataGridViewFuturesVerbosePositions.Columns["开仓价格"].DefaultCellStyle.Format = "N2";
            this.dataGridViewFuturesVerbosePositions.Columns["持仓价格"].DefaultCellStyle.Format = "N2";

            this.dataGridViewOptionsPositionsSum.Columns["客户编号"].DefaultCellStyle.Format = "00000000";
            this.dataGridViewOptionsPositionsSum.Columns["平均开仓价格"].DefaultCellStyle.Format = "N2";
            this.dataGridViewOptionsPositionsSum.Columns["平均持仓价格"].DefaultCellStyle.Format = "N2";


            this.dataGridViewFuturesPositionsSum.Columns["期货账号"].DefaultCellStyle.Format = "00000000";
            this.dataGridViewFuturesPositionsSum.Columns["平均开仓价格"].DefaultCellStyle.Format = "N2";
            this.dataGridViewFuturesPositionsSum.Columns["平均持仓价格"].DefaultCellStyle.Format = "N2";

            this.dataGridViewOptionsContract.Columns["手续费"].DefaultCellStyle.Format = "N2";
            this.dataGridViewOptionsContract.Columns["结算价"].DefaultCellStyle.Format = "N2";
            this.dataGridViewOptionsContract.Columns["执行价"].DefaultCellStyle.Format = "N2";
            
            this.dataGridViewFuturesContract.Columns["手续费"].DefaultCellStyle.Format = "N2";
            this.dataGridViewFuturesContract.Columns["结算价"].DefaultCellStyle.Format = "N2";

            this.dataGridViewRiskInfoDetailed.Columns["客户编号"].DefaultCellStyle.Format = "00000000";
            this.dataGridViewRiskInfoDetailed.Columns["合约代码"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewRiskInfoDetailed.Columns["标的现价"].DefaultCellStyle.Format = "N2";
            this.dataGridViewRiskInfoDetailed.Columns["波动率"].DefaultCellStyle.Format = "00.00%";
            this.dataGridViewRiskInfoDetailed.Columns["Delta"].DefaultCellStyle.Format = "N4";
            this.dataGridViewRiskInfoDetailed.Columns["Gamma"].DefaultCellStyle.Format = "N4";
            this.dataGridViewRiskInfoDetailed.Columns["Theta"].DefaultCellStyle.Format = "N4";
            this.dataGridViewRiskInfoDetailed.Columns["Vega"].DefaultCellStyle.Format = "N4";
            this.dataGridViewRiskInfoDetailed.Columns["Rho"].DefaultCellStyle.Format = "N4";

            this.dataGridViewRiskGross.Columns["标的代码"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewRiskGross.Columns["标的现价"].DefaultCellStyle.Format = "N2";
            this.dataGridViewRiskGross.Columns["Delta"].DefaultCellStyle.Format = "N4";
            this.dataGridViewRiskGross.Columns["Gamma"].DefaultCellStyle.Format = "N4";
            this.dataGridViewRiskGross.Columns["Theta"].DefaultCellStyle.Format = "N4";
            this.dataGridViewRiskGross.Columns["Vega"].DefaultCellStyle.Format = "N4";
            this.dataGridViewRiskGross.Columns["Rho"].DefaultCellStyle.Format = "N4";
        }

        private void LinkEventsHandlers()
        {
            this.dataGridViewOptionsVerbosePositions.CellDoubleClick += new DataGridViewCellEventHandler(onOptionsVerbosePositionCellDoubleClick);
            this.dataGridViewFuturesVerbosePositions.CellDoubleClick += new DataGridViewCellEventHandler(onFuturesVerbosePositionCellDoubleClick);
        }

        private void onOptionsVerbosePositionCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView table = (DataGridView)sender;
            FormPlaceOrder form = new FormPlaceOrder(this.dataset, "期权", table.Rows[e.RowIndex]);
            form.ShowDialog();
        }

        private void onFuturesVerbosePositionCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView table = (DataGridView)sender;
            FormPlaceOrder form = new FormPlaceOrder(this.dataset, "期货", table.Rows[e.RowIndex]);
            form.ShowDialog();
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            FormAddClient fac = new FormAddClient(this.dataset);
            fac.ShowDialog();
        }

        private void buttonRemoveClient_Click(object sender, EventArgs e)
        {
            DataGridViewRow curRow = this.dataGridViewClientBalance.CurrentRow;
            int client_id = Convert.ToInt32(curRow.Cells[0].Value);
            String client_name = curRow.Cells[1].Value.ToString();
            var result = MessageBox.Show(String.Format("你确定要删除客户{0}({1})吗？", client_name, client_id.ToString("00000000")), "删除客户",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.dataset.Tables["client_balance"].Rows.Find(client_id).Delete();
                this.dataset.Tables["client_info"].Rows.Find(client_id).Delete();
                this.dataset.Commit("client_balance");
                this.dataset.Commit("client_info");
                this.dataset.Tables["client_balance_join"].Clear();
                this.dataset.Update();
            }
        }

        private void buttonModifyClient_Click(object sender, EventArgs e)
        {
            uint client_id;
            if (this.dataGridViewClientBalance.CurrentRow == null) client_id = 0;
            else client_id = (uint)this.dataGridViewClientBalance.CurrentRow.Cells["客户编号"].Value;
            FormModifyClient fmc = new FormModifyClient(this.dataset, client_id);
            fmc.ShowDialog();
        }

        private void buttonClientCashflow_Click(object sender, EventArgs e)
        {
            uint client_id;
            if (this.dataGridViewClientBalance.CurrentRow == null) client_id = 0;    
            else client_id = (uint)this.dataGridViewClientBalance.CurrentRow.Cells["客户编号"].Value;
            FormClientCashFlow fccf = new FormClientCashFlow(this.dataset, client_id);
            fccf.ShowDialog();
        }

        private void buttonAddFuturesAccount_Click(object sender, EventArgs e)
        {
            FormAddFuturesAccount fafa = new FormAddFuturesAccount(this);
            fafa.ShowDialog();
        }

        private void buttonRemoveFuturesAccount_Click(object sender, EventArgs e)
        {
            DataGridViewRow curRow = this.dataGridViewFuturesBlance.CurrentRow;
            int account_no = Convert.ToInt32(curRow.Cells[0].Value);
            var result = MessageBox.Show(String.Format("你确定要删除账号{0}吗？", account_no), "删除账号",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.dataset.Tables["futures_account_balance"].Rows.Find(account_no).Delete();
                this.dataset.Tables["futures_account_info"].Rows.Find(account_no).Delete();
                this.dataset.Commit("futures_account_balance");
                this.dataset.Commit("futures_account_info");
                this.dataset.Tables["futures_account_balance_view"].Clear();
                this.dataset.Update();
            }
        }

        private void buttonFuturesCashflow_Click(object sender, EventArgs e)
        {
            uint futures_account_no;
            if (this.dataGridViewFuturesBlance.CurrentRow == null) futures_account_no = 0;
            else futures_account_no = (uint)this.dataGridViewFuturesBlance.CurrentRow.Cells["期货账号"].Value;
            FormFuturesAccountCashflow form = new FormFuturesAccountCashflow(this.dataset, futures_account_no);
            form.Show();
        }

        //商品种类表
        private void buttonAddCommodity_Click(object sender, EventArgs e)
        {
            FormAddCommodity fac = new FormAddCommodity(this);
            fac.Show(); 
        }

        private void buttonRemoveCommodity_Click(object sender, EventArgs e)
        {
            DataGridViewRow curRow = this.dataGridViewCommodity.CurrentRow;
            String commodity_code = curRow.Cells[0].Value.ToString();
            String commodity_name = curRow.Cells[1].Value.ToString();
            var result = MessageBox.Show(String.Format("你确定要删除商品品种 {0}({1}) 吗？", commodity_name, commodity_code), "删除商品品种",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.dataset.Tables["commodity_category"].Rows.Find(commodity_code).Delete();
                this.dataset.Commit("commodity_category");
                this.dataset.Tables["commodity_category_view"].Clear();
                this.dataset.Update();
            }
        }

        private void buttonModifyCommodity_Click(object sender, EventArgs e)
        {
            FormModifyCommodity form = new FormModifyCommodity(this);
            form.Show();
        }

        //期权类型表
        private void buttonAddOptionsType_Click(object sender, EventArgs e)
        {
            FormAddOptionsType form = new FormAddOptionsType(this.dataset);
            form.Show();
        }

        private void buttonRemoveOptionsType_Click(object sender, EventArgs e)
        {
            DataGridViewRow curRow = this.dataGridViewOptionsType.CurrentRow;
            String options_code = curRow.Cells[0].Value.ToString();
            String options_name = curRow.Cells[1].Value.ToString();
            var result = MessageBox.Show(String.Format("你确定要删除期权类型 {0}({1}) 吗？", options_name, options_code), "删除期权类型",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.dataset.Tables["options_types"].Rows.Find(options_code).Delete();
                this.dataset.Commit("options_types");
                this.dataset.Tables["options_types_view"].Clear();
                this.dataset.Update();
            }
        }

        private void buttonModifyOptionsType_Click(object sender, EventArgs e)
        {
            FormModifyOptionsType form = new FormModifyOptionsType(this.dataset);
            form.Show();
        }

        //期货合约表
        private void buttonAddFuturesContract_Click(object sender, EventArgs e)
        {
            FormAddFuturesContract form = new FormAddFuturesContract(this.dataset);
            form.Show();
        }
        private void buttonRemoveFuturesContract_Click(object sender, EventArgs e)
        {
            DataGridViewRow curRow = this.dataGridViewFuturesContract.CurrentRow;
            String contract_code = curRow.Cells[0].Value.ToString();
            var result = MessageBox.Show(String.Format("你确定要删除期货合约 {0} 吗？", contract_code), "删除期货合约",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.dataset.Tables["futures_contracts"].Rows.Find(contract_code).Delete();
                this.dataset.Commit("futures_contracts");
                this.dataset.Tables["futures_contracts_view"].Clear();
                this.dataset.Update();
            }
        }

        private void buttonModifyFuturesContract_Click(object sender, EventArgs e)
        {
            FormModifyFuturesContract form = new FormModifyFuturesContract(this.dataset);
            form.Show();
        }

        //期权合约表
        private void buttonAddOptionsContract_Click(object sender, EventArgs e)
        {
            FormAddOptionsContract form = new FormAddOptionsContract(this.dataset);
            form.Show();
        }

        private void buttonRemoveOptionsContract_Click(object sender, EventArgs e)
        {
            DataGridViewRow curRow = this.dataGridViewOptionsContract.CurrentRow;
            String contract_code = curRow.Cells[0].Value.ToString();
            var result = MessageBox.Show(String.Format("你确定要删除期权合约 {0} 吗？", contract_code), "删除期权合约",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.dataset.Tables["options_contracts"].Rows.Find(contract_code).Delete();
                this.dataset.Commit("options_contracts");
                this.dataset.Tables["options_contracts_view"].Clear();
                this.dataset.Update();
            }
        }

        private void buttonModifyOptionsContract_Click(object sender, EventArgs e)
        {
            FormModifyOptionsContract form = new FormModifyOptionsContract(this.dataset);
            form.Show();
        }

        private void buttonPlaceOrder_Click(object sender, EventArgs e)
        {
            FormPlaceOrder form = new FormPlaceOrder(this.dataset);
            form.Show();
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            this.dataset.Update();
        }

        private void buttonRollbackOptionsTransaction_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(String.Format("你确定要回滚上一笔期权成交吗？"), "回滚期权成交",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MySqlConnection conn = this.dataset.CreateSQLConnection();
                
                conn.Open();
                MySqlCommand command = new MySqlCommand("DELETE FROM futures_transactions ORDER BY transaction_time DESC LIMIT 1", conn);
                command.ExecuteNonQuery();
                conn.Close();
                this.dataset.Tables["options_transactions_view"].Clear();
                this.dataset.Tables["futures_transactions_view"].Clear();
                this.dataset.Update();
            }

        }

        private void buttonRollBackFuturesTransaction_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(String.Format("你确定要回滚上一笔期货成交吗？"), "回滚期货成交",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MySqlConnection conn = this.dataset.CreateSQLConnection();
                conn.Open();
                MySqlCommand command = new MySqlCommand("DELETE FROM futures_transactions ORDER BY transaction_time DESC LIMIT 1", conn);
                command.ExecuteNonQuery();
                conn.Close();
                this.dataset.Tables["futures_transactions_view"].Clear();
                this.dataset.Tables["futures_cashflow_view"].Clear();
                this.dataset.Update();
            }
        }

        private void buttonTradingDatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTradingDatesSetting form = new FormTradingDatesSetting(dataset);
            form.ShowDialog();
        }
    }
        
}
