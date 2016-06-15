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
    public partial class FormQuotes : Form
    {
        public FormQuotes(OTCDataSet ds)
        {
            InitializeComponent();
            dataset = ds;
            linkEvents();
            InitilizeUserComponent();
        }

        private void InitilizeUserComponent()
        {
            redis_conn = dataset.CreateRedisConnection();
            comboBoxOptionType.Items.AddRange(new string[] { "认购", "认沽" });
            comboBoxBuySell.Items.AddRange(new string[] { "买入", "卖出" });

            radioButtonITM.Select();

            this.labelBuySellError.Text = "";
            this.labelMaturityDateError.Text = "";
            this.labelOptionTypeError.Text = "";
            this.labelRateError.Text = "";
            this.labelStrikeError.Text = "";
            this.labelUnderlyingError.Text = "";
            this.labelVolatilityError.Text = "";
            this.labelYieldError.Text = "";
            this.labelQuantityError.Text = "";

            double.TryParse(textBoxRate.Text, out r);
            double.TryParse(textBoxYield.Text, out yield);


            dateTimePickerMaturityDate.Value = DateTime.Today.AddDays(1);
            timer_quote = new Timer();
            timer_underlying = new Timer();
            timer_quote.Tick += new EventHandler(timerTicked);
            timer_underlying.Tick += new EventHandler(timerTicked1);
            timer_quote.Interval = 500;
            timer_underlying.Interval = 500;
            timer_underlying.Start();

            foreach(var row in dataset.Tables["client_info"].AsEnumerable())
            {
                comboBoxClientName.Items.Add(row["客户编号"].ToString() + '-' + row["客户名称"].ToString());
            }
            comboBoxClientName.SelectedIndex = 0;
        }

        private void linkEvents()
        {
            this.buttonCalculate.Click += new EventHandler(this.textBoxUnderlying_TextChanged);
            this.buttonCalculate.Click += new EventHandler(comboBoxOptionType_SelectedIndexChanged);
            this.buttonCalculate.Click += new EventHandler(comboBoxBuySell_SelectedIndexChanged);
            this.buttonCalculate.Click += new EventHandler(dateTimePickerMaturityDate_ValueChanged);
            this.buttonCalculate.Click += new EventHandler(textBoxStrike_Validated);
            this.buttonCalculate.Click += new EventHandler(textBoxVolatility_Validated);
            this.buttonCalculate.Click += new EventHandler(textBoxRate_Validated);
            this.buttonCalculate.Click += new EventHandler(textBoxYield_Validated);
            this.buttonCalculate.Click += new EventHandler(textBoxQuantity_Validated);
            this.FormClosed += new FormClosedEventHandler(formClosed);
        }

        private void formClosed(object sender, EventArgs e)
        {
            this.timer_quote.Stop();
            this.timer_underlying.Stop();
        }


        private void timerTicked(object sender, EventArgs e)
        {
            if (!(strike_valid && maturity_valid && rate_valid && volatility_valid && underlying_valid && yield_valid && buysell_valid && callput_valid && quantity_valid))
            {
                timer_quote.Stop();
                textBoxPrice.Text = "";
                textBoxDelta.Text = "";
                return;
            }
            if (double.TryParse(redis_conn.HashGet(underlying_code, "LastPrice"), out underlying_price))
            {
                double spread_value = checkBoxSpreadQuote.Checked?((call_put == 'c' ? 1 : -1) * (buy_sell == 'b' ? 1 : -1)*(double)numericUpDownSpreadValue.Value):0;
                textBoxPrice.Text = OptionsCalculator.GetBlsPrice(underlying_price + spread_value, strike, T, volatility, r, call_put).ToString("N2");
                textBoxDelta.Text = OptionsCalculator.GetBlsDelta(underlying_price, strike, T, volatility, r, call_put).ToString("N2");
                textBoxValue.Text = (decimal.Parse(textBoxPrice.Text) * decimal.Parse(textBoxQuantity.Text)).ToString();
                textBoxTotalDelta.Text = (decimal.Parse(textBoxDelta.Text) * decimal.Parse(textBoxQuantity.Text)).ToString();
                textBoxRemainBalance.Text = (decimal.Parse(textBoxBalance.Text) - decimal.Parse(textBoxValue.Text)).ToString();
            }
            else
            {
                textBoxPrice.Text = "";
                textBoxDelta.Text = "";
            }


        }
        private void timerTicked1(object sender, EventArgs e)
        {
            if (underlying_valid)
            {
                labelBidPrice.Text = redis_conn.HashGet(underlying_code, "BidPrice1");
                labelAskPrice.Text = redis_conn.HashGet(underlying_code, "AskPrice1");
                labelBidVolume.Text = redis_conn.HashGet(underlying_code, "BidVolume1");
                labelAskVolume.Text = redis_conn.HashGet(underlying_code, "AskVolume1");
                int hedge_direction = (buy_sell == 'b' ? 1 : -1) * ((call_put == 'c' ? 1 : -1));
                if (checkBoxPercentStrike.Checked)
                {
                    decimal price;
                    if (hedge_direction == 1)
                    {
                        price = decimal.Parse(labelAskPrice.Text);
                    }
                    else
                    {
                        price = decimal.Parse(labelBidPrice.Text);
                    }
                    var percent_strike = numericUpDownPercentStrike.Value;
                    int len = Math.Max(price.ToString().Length - ((int)price).ToString().Length - 1, 0);
                    var multiplier = (int)Math.Pow(10, len);
                    var strike_price = Decimal.Round((1 + (call_put=='c'?1:-1)*(radioButtonITM.Checked?-1:1)*percent_strike/100m) * price * multiplier) / multiplier;
                    textBoxStrike.Text = strike_price.ToString("N2");
                    textBoxStrike_Validated(sender, e);
               }
            }

        }



        private void textBoxUnderlying_TextChanged(object sender, EventArgs e)
        {
            if (!redis_conn.KeyExists(textBoxUnderlying.Text))
            {
                this.labelUnderlyingError.Text = "标的代码不存在";
                underlying_valid = false;
            }
            else
            {
                underlying_code = textBoxUnderlying.Text;
                this.labelUnderlyingError.Text = "";
                underlying_valid = true;
                var contract_row = dataset.Tables["futures_contracts"].Rows.Find(textBoxUnderlying.Text);
                if (contract_row != null)
                {
                    textBoxVolatility.Text = contract_row["波动率"].ToString();
                    volatility = double.Parse(textBoxVolatility.Text);
                }
            }
        }

        private void dateTimePickerMaturityDate_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerMaturityDate.Value > DateTime.Today)
            {
                this.labelMaturityDateError.Text = "";
                T = dataset.GetDTM(dateTimePickerMaturityDate.Value) / 256d;
                maturity_valid = true;
            }
            else
            {
                this.labelMaturityDateError.Text = "到期日必须大于当前日期";
                maturity_valid = false;
            }
        }

        private void comboBoxBuySell_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBuySell.SelectedIndex != -1)
            {
                buy_sell = comboBoxBuySell.SelectedIndex == 0 ? 'b' : 's';
                buysell_valid = true;
                labelBuySellError.Text = "";
            }
            else
            {
                this.labelBuySellError.Text = "买卖方向错误";
                buysell_valid = false;
            }
        }

        private void textBoxStrike_Validated(object sender, EventArgs e)
        {
            if (double.TryParse(this.textBoxStrike.Text, out strike))
            {
                this.labelStrikeError.Text = "";
                strike_valid = true;
            }
            else
            {
                this.labelStrikeError.Text = "执行价格式错误";
                strike_valid = false;
            }
        }
        private void textBoxQuantity_Validated(object sender, EventArgs e)
        {
            if (int.TryParse(this.textBoxQuantity.Text, out quantity))
            {
                this.labelQuantityError.Text = "";
                quantity_valid = true;
            }
            else
            {
                this.labelQuantityError.Text = "数量格式错误";
                quantity_valid = false;
            }
        }

        private void comboBoxOptionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOptionType.SelectedIndex != -1)
            {
                call_put = comboBoxOptionType.SelectedIndex == 0 ? 'c' : 'p';
                callput_valid = true;
                labelOptionTypeError.Text = "";
            }
            else
            {
                this.labelOptionTypeError.Text = "期权类型错误";
                callput_valid = false;
            }
        }

        private void textBoxVolatility_Validated(object sender, EventArgs e)
        {
            if (double.TryParse(this.textBoxVolatility.Text, out volatility))
            {
                this.labelVolatilityError.Text = "";
                volatility_valid = true;
            }
            else
            {
                this.labelVolatilityError.Text = "波动率格式错误";
                volatility_valid = false;
            }
        }

        private void textBoxRate_Validated(object sender, EventArgs e)
        {
            if (double.TryParse(this.textBoxRate.Text, out r))
            {
                this.labelRateError.Text = "";
                rate_valid = true;
            }
            else
            {
                this.labelRateError.Text = "利率格式错误";
                rate_valid = false;
            }
        }

        private void textBoxYield_Validated(object sender, EventArgs e)
        {
            if (double.TryParse(this.textBoxYield.Text, out yield))
            {
                this.labelYieldError.Text = "";
                yield_valid = true;
            }
            else
            {
                this.labelYieldError.Text = "持有收益率格式错误";
                yield_valid = false;
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            this.timerTicked(sender, e);
            if (strike_valid && maturity_valid && rate_valid && volatility_valid && underlying_valid && yield_valid && buysell_valid && callput_valid && quantity_valid)
            {
                timer_quote.Start();
            }
        }


        private void checkBoxSpreadQuote_CheckedChanged(object sender, EventArgs e)
        {
            var s = (CheckBox)sender;
            if (s.Checked == true)
            {
                numericUpDownSpreadValue.Enabled = true;
            }
            else
            {
                numericUpDownSpreadValue.Enabled = false;
            }
            timerTicked(sender, e);
        }

        int client_id;
        string underlying_code;
        double underlying_price;
        double strike;
        double r;
        double volatility;
        double yield;
        double T;
        int quantity;
        char call_put;
        char buy_sell;
        IDatabase redis_conn;
        OTCDataSet dataset;
        Timer timer_quote, timer_underlying;

        private void checkBoxPercentStrike_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPercentStrike.Checked == true)
            {
                this.numericUpDownPercentStrike.Enabled = true;
                this.textBoxStrike.ReadOnly = true;
                this.panel1.Enabled = true;
            }
            else
            {
                this.numericUpDownPercentStrike.Enabled = false;
                this.panel1.Enabled = false;
                this.textBoxStrike.ReadOnly = false;
            }
            timerTicked1(sender, e);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer_quote.Stop();
        }

        private void comboBoxClientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int client_id = int.Parse(comboBoxClientName.Text.Split('-')[0]);
            var row_info = dataset.Tables["client_balance_join"].Rows.Find(client_id);
            textBoxValidationCode.Text = row_info["下单验证码"].ToString();
            textBoxBalance.Text = row_info["当前余额"].ToString();
            if(textBoxValue.Text!="")
                textBoxRemainBalance.Text = (decimal.Parse(textBoxBalance.Text) - decimal.Parse(textBoxValue.Text)).ToString();
        }

        bool strike_valid, maturity_valid, rate_valid=true, volatility_valid, underlying_valid, yield_valid=true, buysell_valid, callput_valid, quantity_valid;

    }
}
