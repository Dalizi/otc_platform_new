namespace OTC
{
    partial class FormQuotes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelUnderlying = new System.Windows.Forms.Label();
            this.textBoxUnderlying = new System.Windows.Forms.TextBox();
            this.labelOptionType = new System.Windows.Forms.Label();
            this.comboBoxOptionType = new System.Windows.Forms.ComboBox();
            this.textBoxStrike = new System.Windows.Forms.TextBox();
            this.labelStrike = new System.Windows.Forms.Label();
            this.dateTimePickerMaturityDate = new System.Windows.Forms.DateTimePicker();
            this.labelMaturityDate = new System.Windows.Forms.Label();
            this.textBoxVolatility = new System.Windows.Forms.TextBox();
            this.labelVolatility = new System.Windows.Forms.Label();
            this.textBoxRate = new System.Windows.Forms.TextBox();
            this.labelRate = new System.Windows.Forms.Label();
            this.groupBoxParam = new System.Windows.Forms.GroupBox();
            this.labelQuantityError = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelYieldError = new System.Windows.Forms.Label();
            this.textBoxYield = new System.Windows.Forms.TextBox();
            this.labelYield = new System.Windows.Forms.Label();
            this.labelBuySellError = new System.Windows.Forms.Label();
            this.labelOptionTypeError = new System.Windows.Forms.Label();
            this.labelMaturityDateError = new System.Windows.Forms.Label();
            this.labelRateError = new System.Windows.Forms.Label();
            this.labelVolatilityError = new System.Windows.Forms.Label();
            this.labelStrikeError = new System.Windows.Forms.Label();
            this.labelUnderlyingError = new System.Windows.Forms.Label();
            this.labelBuySell = new System.Windows.Forms.Label();
            this.comboBoxBuySell = new System.Windows.Forms.ComboBox();
            this.groupBoxQuotes = new System.Windows.Forms.GroupBox();
            this.numericUpDownSpreadValue = new System.Windows.Forms.NumericUpDown();
            this.checkBoxSpreadQuote = new System.Windows.Forms.CheckBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelDelta = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxDelta = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBidPrice = new System.Windows.Forms.Label();
            this.labelAskPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelBidVolume = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelAskVolume = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownPercentStrike = new System.Windows.Forms.NumericUpDown();
            this.checkBoxPercentStrike = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTotalDelta = new System.Windows.Forms.Label();
            this.textBoxTotalDelta = new System.Windows.Forms.TextBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonITM = new System.Windows.Forms.RadioButton();
            this.radioButtonOOM = new System.Windows.Forms.RadioButton();
            this.groupBoxClientInfo = new System.Windows.Forms.GroupBox();
            this.labelClientName = new System.Windows.Forms.Label();
            this.comboBoxClientName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxValidationCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxRemainBalance = new System.Windows.Forms.TextBox();
            this.groupBoxParam.SuspendLayout();
            this.groupBoxQuotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpreadValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPercentStrike)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBoxClientInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUnderlying
            // 
            this.labelUnderlying.AutoSize = true;
            this.labelUnderlying.Location = new System.Drawing.Point(6, 17);
            this.labelUnderlying.Name = "labelUnderlying";
            this.labelUnderlying.Size = new System.Drawing.Size(41, 12);
            this.labelUnderlying.TabIndex = 0;
            this.labelUnderlying.Text = "标的：";
            // 
            // textBoxUnderlying
            // 
            this.textBoxUnderlying.Location = new System.Drawing.Point(76, 14);
            this.textBoxUnderlying.Name = "textBoxUnderlying";
            this.textBoxUnderlying.Size = new System.Drawing.Size(100, 21);
            this.textBoxUnderlying.TabIndex = 1;
            this.textBoxUnderlying.Validated += new System.EventHandler(this.textBoxUnderlying_TextChanged);
            // 
            // labelOptionType
            // 
            this.labelOptionType.AutoSize = true;
            this.labelOptionType.Location = new System.Drawing.Point(6, 44);
            this.labelOptionType.Name = "labelOptionType";
            this.labelOptionType.Size = new System.Drawing.Size(65, 12);
            this.labelOptionType.TabIndex = 2;
            this.labelOptionType.Text = "期权类型：";
            // 
            // comboBoxOptionType
            // 
            this.comboBoxOptionType.FormattingEnabled = true;
            this.comboBoxOptionType.Location = new System.Drawing.Point(76, 41);
            this.comboBoxOptionType.Name = "comboBoxOptionType";
            this.comboBoxOptionType.Size = new System.Drawing.Size(100, 20);
            this.comboBoxOptionType.TabIndex = 2;
            this.comboBoxOptionType.SelectedIndexChanged += new System.EventHandler(this.comboBoxOptionType_SelectedIndexChanged);
            // 
            // textBoxStrike
            // 
            this.textBoxStrike.Location = new System.Drawing.Point(76, 129);
            this.textBoxStrike.Name = "textBoxStrike";
            this.textBoxStrike.Size = new System.Drawing.Size(100, 21);
            this.textBoxStrike.TabIndex = 5;
            this.textBoxStrike.Validated += new System.EventHandler(this.textBoxStrike_Validated);
            // 
            // labelStrike
            // 
            this.labelStrike.AutoSize = true;
            this.labelStrike.Location = new System.Drawing.Point(6, 132);
            this.labelStrike.Name = "labelStrike";
            this.labelStrike.Size = new System.Drawing.Size(53, 12);
            this.labelStrike.TabIndex = 4;
            this.labelStrike.Text = "执行价：";
            // 
            // dateTimePickerMaturityDate
            // 
            this.dateTimePickerMaturityDate.CustomFormat = "yyyy/MM/dd";
            this.dateTimePickerMaturityDate.Location = new System.Drawing.Point(76, 207);
            this.dateTimePickerMaturityDate.Name = "dateTimePickerMaturityDate";
            this.dateTimePickerMaturityDate.Size = new System.Drawing.Size(100, 21);
            this.dateTimePickerMaturityDate.TabIndex = 6;
            this.dateTimePickerMaturityDate.ValueChanged += new System.EventHandler(this.dateTimePickerMaturityDate_ValueChanged);
            // 
            // labelMaturityDate
            // 
            this.labelMaturityDate.AutoSize = true;
            this.labelMaturityDate.Location = new System.Drawing.Point(6, 213);
            this.labelMaturityDate.Name = "labelMaturityDate";
            this.labelMaturityDate.Size = new System.Drawing.Size(53, 12);
            this.labelMaturityDate.TabIndex = 7;
            this.labelMaturityDate.Text = "到期日：";
            // 
            // textBoxVolatility
            // 
            this.textBoxVolatility.Location = new System.Drawing.Point(76, 233);
            this.textBoxVolatility.Name = "textBoxVolatility";
            this.textBoxVolatility.Size = new System.Drawing.Size(100, 21);
            this.textBoxVolatility.TabIndex = 7;
            this.textBoxVolatility.Validated += new System.EventHandler(this.textBoxVolatility_Validated);
            // 
            // labelVolatility
            // 
            this.labelVolatility.AutoSize = true;
            this.labelVolatility.Location = new System.Drawing.Point(6, 236);
            this.labelVolatility.Name = "labelVolatility";
            this.labelVolatility.Size = new System.Drawing.Size(53, 12);
            this.labelVolatility.TabIndex = 8;
            this.labelVolatility.Text = "波动率：";
            // 
            // textBoxRate
            // 
            this.textBoxRate.Location = new System.Drawing.Point(76, 258);
            this.textBoxRate.Name = "textBoxRate";
            this.textBoxRate.Size = new System.Drawing.Size(100, 21);
            this.textBoxRate.TabIndex = 8;
            this.textBoxRate.Text = "0.015";
            this.textBoxRate.Validated += new System.EventHandler(this.textBoxRate_Validated);
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Location = new System.Drawing.Point(6, 261);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(41, 12);
            this.labelRate.TabIndex = 10;
            this.labelRate.Text = "利率：";
            // 
            // groupBoxParam
            // 
            this.groupBoxParam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxParam.Controls.Add(this.panel1);
            this.groupBoxParam.Controls.Add(this.label2);
            this.groupBoxParam.Controls.Add(this.numericUpDownPercentStrike);
            this.groupBoxParam.Controls.Add(this.checkBoxPercentStrike);
            this.groupBoxParam.Controls.Add(this.labelQuantityError);
            this.groupBoxParam.Controls.Add(this.labelQuantity);
            this.groupBoxParam.Controls.Add(this.textBoxQuantity);
            this.groupBoxParam.Controls.Add(this.labelYieldError);
            this.groupBoxParam.Controls.Add(this.textBoxYield);
            this.groupBoxParam.Controls.Add(this.labelYield);
            this.groupBoxParam.Controls.Add(this.labelBuySellError);
            this.groupBoxParam.Controls.Add(this.labelOptionTypeError);
            this.groupBoxParam.Controls.Add(this.labelMaturityDateError);
            this.groupBoxParam.Controls.Add(this.labelRateError);
            this.groupBoxParam.Controls.Add(this.labelVolatilityError);
            this.groupBoxParam.Controls.Add(this.labelStrikeError);
            this.groupBoxParam.Controls.Add(this.labelUnderlyingError);
            this.groupBoxParam.Controls.Add(this.labelBuySell);
            this.groupBoxParam.Controls.Add(this.comboBoxBuySell);
            this.groupBoxParam.Controls.Add(this.labelUnderlying);
            this.groupBoxParam.Controls.Add(this.textBoxRate);
            this.groupBoxParam.Controls.Add(this.textBoxUnderlying);
            this.groupBoxParam.Controls.Add(this.labelRate);
            this.groupBoxParam.Controls.Add(this.labelOptionType);
            this.groupBoxParam.Controls.Add(this.textBoxVolatility);
            this.groupBoxParam.Controls.Add(this.comboBoxOptionType);
            this.groupBoxParam.Controls.Add(this.labelVolatility);
            this.groupBoxParam.Controls.Add(this.labelStrike);
            this.groupBoxParam.Controls.Add(this.labelMaturityDate);
            this.groupBoxParam.Controls.Add(this.textBoxStrike);
            this.groupBoxParam.Controls.Add(this.dateTimePickerMaturityDate);
            this.groupBoxParam.Location = new System.Drawing.Point(12, 42);
            this.groupBoxParam.Name = "groupBoxParam";
            this.groupBoxParam.Size = new System.Drawing.Size(367, 328);
            this.groupBoxParam.TabIndex = 12;
            this.groupBoxParam.TabStop = false;
            this.groupBoxParam.Text = "合约参数";
            // 
            // labelQuantityError
            // 
            this.labelQuantityError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelQuantityError.AutoSize = true;
            this.labelQuantityError.ForeColor = System.Drawing.Color.Red;
            this.labelQuantityError.Location = new System.Drawing.Point(182, 105);
            this.labelQuantityError.Name = "labelQuantityError";
            this.labelQuantityError.Size = new System.Drawing.Size(65, 12);
            this.labelQuantityError.TabIndex = 26;
            this.labelQuantityError.Text = "ErrorLabel";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(6, 105);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(77, 12);
            this.labelQuantity.TabIndex = 24;
            this.labelQuantity.Text = "数量（吨）：";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(89, 102);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(87, 21);
            this.textBoxQuantity.TabIndex = 4;
            this.textBoxQuantity.Validated += new System.EventHandler(this.textBoxQuantity_Validated);
            // 
            // labelYieldError
            // 
            this.labelYieldError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelYieldError.AutoSize = true;
            this.labelYieldError.ForeColor = System.Drawing.Color.Red;
            this.labelYieldError.Location = new System.Drawing.Point(182, 288);
            this.labelYieldError.Name = "labelYieldError";
            this.labelYieldError.Size = new System.Drawing.Size(65, 12);
            this.labelYieldError.TabIndex = 23;
            this.labelYieldError.Text = "ErrorLabel";
            // 
            // textBoxYield
            // 
            this.textBoxYield.Location = new System.Drawing.Point(76, 285);
            this.textBoxYield.Name = "textBoxYield";
            this.textBoxYield.Size = new System.Drawing.Size(100, 21);
            this.textBoxYield.TabIndex = 9;
            this.textBoxYield.Text = "0";
            this.textBoxYield.Validated += new System.EventHandler(this.textBoxYield_Validated);
            // 
            // labelYield
            // 
            this.labelYield.AutoSize = true;
            this.labelYield.Location = new System.Drawing.Point(6, 288);
            this.labelYield.Name = "labelYield";
            this.labelYield.Size = new System.Drawing.Size(77, 12);
            this.labelYield.TabIndex = 21;
            this.labelYield.Text = "持有收益率：";
            // 
            // labelBuySellError
            // 
            this.labelBuySellError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBuySellError.AutoSize = true;
            this.labelBuySellError.ForeColor = System.Drawing.Color.Red;
            this.labelBuySellError.Location = new System.Drawing.Point(182, 70);
            this.labelBuySellError.Name = "labelBuySellError";
            this.labelBuySellError.Size = new System.Drawing.Size(65, 12);
            this.labelBuySellError.TabIndex = 20;
            this.labelBuySellError.Text = "ErrorLabel";
            // 
            // labelOptionTypeError
            // 
            this.labelOptionTypeError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOptionTypeError.AutoSize = true;
            this.labelOptionTypeError.ForeColor = System.Drawing.Color.Red;
            this.labelOptionTypeError.Location = new System.Drawing.Point(182, 44);
            this.labelOptionTypeError.Name = "labelOptionTypeError";
            this.labelOptionTypeError.Size = new System.Drawing.Size(65, 12);
            this.labelOptionTypeError.TabIndex = 19;
            this.labelOptionTypeError.Text = "ErrorLabel";
            // 
            // labelMaturityDateError
            // 
            this.labelMaturityDateError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMaturityDateError.AutoSize = true;
            this.labelMaturityDateError.ForeColor = System.Drawing.Color.Red;
            this.labelMaturityDateError.Location = new System.Drawing.Point(182, 213);
            this.labelMaturityDateError.Name = "labelMaturityDateError";
            this.labelMaturityDateError.Size = new System.Drawing.Size(65, 12);
            this.labelMaturityDateError.TabIndex = 18;
            this.labelMaturityDateError.Text = "ErrorLabel";
            // 
            // labelRateError
            // 
            this.labelRateError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRateError.AutoSize = true;
            this.labelRateError.ForeColor = System.Drawing.Color.Red;
            this.labelRateError.Location = new System.Drawing.Point(182, 258);
            this.labelRateError.Name = "labelRateError";
            this.labelRateError.Size = new System.Drawing.Size(65, 12);
            this.labelRateError.TabIndex = 17;
            this.labelRateError.Text = "ErrorLabel";
            // 
            // labelVolatilityError
            // 
            this.labelVolatilityError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVolatilityError.AutoSize = true;
            this.labelVolatilityError.ForeColor = System.Drawing.Color.Red;
            this.labelVolatilityError.Location = new System.Drawing.Point(182, 236);
            this.labelVolatilityError.Name = "labelVolatilityError";
            this.labelVolatilityError.Size = new System.Drawing.Size(65, 12);
            this.labelVolatilityError.TabIndex = 16;
            this.labelVolatilityError.Text = "ErrorLabel";
            // 
            // labelStrikeError
            // 
            this.labelStrikeError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStrikeError.AutoSize = true;
            this.labelStrikeError.ForeColor = System.Drawing.Color.Red;
            this.labelStrikeError.Location = new System.Drawing.Point(182, 132);
            this.labelStrikeError.Name = "labelStrikeError";
            this.labelStrikeError.Size = new System.Drawing.Size(65, 12);
            this.labelStrikeError.TabIndex = 15;
            this.labelStrikeError.Text = "ErrorLabel";
            // 
            // labelUnderlyingError
            // 
            this.labelUnderlyingError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUnderlyingError.AutoSize = true;
            this.labelUnderlyingError.ForeColor = System.Drawing.Color.Red;
            this.labelUnderlyingError.Location = new System.Drawing.Point(182, 14);
            this.labelUnderlyingError.Name = "labelUnderlyingError";
            this.labelUnderlyingError.Size = new System.Drawing.Size(65, 12);
            this.labelUnderlyingError.TabIndex = 14;
            this.labelUnderlyingError.Text = "ErrorLabel";
            // 
            // labelBuySell
            // 
            this.labelBuySell.AutoSize = true;
            this.labelBuySell.Location = new System.Drawing.Point(6, 70);
            this.labelBuySell.Name = "labelBuySell";
            this.labelBuySell.Size = new System.Drawing.Size(65, 12);
            this.labelBuySell.TabIndex = 12;
            this.labelBuySell.Text = "买卖方向：";
            // 
            // comboBoxBuySell
            // 
            this.comboBoxBuySell.FormattingEnabled = true;
            this.comboBoxBuySell.Location = new System.Drawing.Point(76, 67);
            this.comboBoxBuySell.Name = "comboBoxBuySell";
            this.comboBoxBuySell.Size = new System.Drawing.Size(100, 20);
            this.comboBoxBuySell.TabIndex = 3;
            this.comboBoxBuySell.SelectedIndexChanged += new System.EventHandler(this.comboBoxBuySell_SelectedIndexChanged);
            // 
            // groupBoxQuotes
            // 
            this.groupBoxQuotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxQuotes.Controls.Add(this.buttonStop);
            this.groupBoxQuotes.Controls.Add(this.labelTotalDelta);
            this.groupBoxQuotes.Controls.Add(this.textBoxTotalDelta);
            this.groupBoxQuotes.Controls.Add(this.numericUpDownSpreadValue);
            this.groupBoxQuotes.Controls.Add(this.checkBoxSpreadQuote);
            this.groupBoxQuotes.Controls.Add(this.labelValue);
            this.groupBoxQuotes.Controls.Add(this.textBoxValue);
            this.groupBoxQuotes.Controls.Add(this.buttonCalculate);
            this.groupBoxQuotes.Controls.Add(this.labelDelta);
            this.groupBoxQuotes.Controls.Add(this.labelPrice);
            this.groupBoxQuotes.Controls.Add(this.textBoxDelta);
            this.groupBoxQuotes.Controls.Add(this.textBoxPrice);
            this.groupBoxQuotes.Location = new System.Drawing.Point(397, 183);
            this.groupBoxQuotes.Name = "groupBoxQuotes";
            this.groupBoxQuotes.Size = new System.Drawing.Size(365, 187);
            this.groupBoxQuotes.TabIndex = 13;
            this.groupBoxQuotes.TabStop = false;
            this.groupBoxQuotes.Text = "报价";
            // 
            // numericUpDownSpreadValue
            // 
            this.numericUpDownSpreadValue.DecimalPlaces = 2;
            this.numericUpDownSpreadValue.Enabled = false;
            this.numericUpDownSpreadValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownSpreadValue.Location = new System.Drawing.Point(172, 41);
            this.numericUpDownSpreadValue.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownSpreadValue.Name = "numericUpDownSpreadValue";
            this.numericUpDownSpreadValue.Size = new System.Drawing.Size(60, 21);
            this.numericUpDownSpreadValue.TabIndex = 20;
            this.numericUpDownSpreadValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownSpreadValue.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // checkBoxSpreadQuote
            // 
            this.checkBoxSpreadQuote.AutoSize = true;
            this.checkBoxSpreadQuote.Location = new System.Drawing.Point(78, 45);
            this.checkBoxSpreadQuote.Name = "checkBoxSpreadQuote";
            this.checkBoxSpreadQuote.Size = new System.Drawing.Size(96, 16);
            this.checkBoxSpreadQuote.TabIndex = 19;
            this.checkBoxSpreadQuote.Text = "增加报价边际";
            this.checkBoxSpreadQuote.UseVisualStyleBackColor = true;
            this.checkBoxSpreadQuote.CheckedChanged += new System.EventHandler(this.checkBoxSpreadQuote_CheckedChanged);
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(8, 99);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(53, 12);
            this.labelValue.TabIndex = 17;
            this.labelValue.Text = "总价值：";
            // 
            // textBoxValue
            // 
            this.textBoxValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxValue.Location = new System.Drawing.Point(109, 96);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.ReadOnly = true;
            this.textBoxValue.Size = new System.Drawing.Size(97, 21);
            this.textBoxValue.TabIndex = 18;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCalculate.Location = new System.Drawing.Point(199, 158);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 16;
            this.buttonCalculate.Text = "计算";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelDelta
            // 
            this.labelDelta.AutoSize = true;
            this.labelDelta.Location = new System.Drawing.Point(8, 71);
            this.labelDelta.Name = "labelDelta";
            this.labelDelta.Size = new System.Drawing.Size(77, 12);
            this.labelDelta.TabIndex = 14;
            this.labelDelta.Text = "Delta(手）：";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(8, 17);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(41, 12);
            this.labelPrice.TabIndex = 12;
            this.labelPrice.Text = "价格：";
            // 
            // textBoxDelta
            // 
            this.textBoxDelta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDelta.Location = new System.Drawing.Point(109, 71);
            this.textBoxDelta.Name = "textBoxDelta";
            this.textBoxDelta.ReadOnly = true;
            this.textBoxDelta.Size = new System.Drawing.Size(97, 21);
            this.textBoxDelta.TabIndex = 15;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPrice.Location = new System.Drawing.Point(109, 14);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(97, 21);
            this.textBoxPrice.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "买一价:";
            // 
            // labelBidPrice
            // 
            this.labelBidPrice.AutoSize = true;
            this.labelBidPrice.Location = new System.Drawing.Point(73, 13);
            this.labelBidPrice.Name = "labelBidPrice";
            this.labelBidPrice.Size = new System.Drawing.Size(11, 12);
            this.labelBidPrice.TabIndex = 15;
            this.labelBidPrice.Text = "0";
            // 
            // labelAskPrice
            // 
            this.labelAskPrice.AutoSize = true;
            this.labelAskPrice.Location = new System.Drawing.Point(194, 13);
            this.labelAskPrice.Name = "labelAskPrice";
            this.labelAskPrice.Size = new System.Drawing.Size(11, 12);
            this.labelAskPrice.TabIndex = 17;
            this.labelAskPrice.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "卖一价：";
            // 
            // labelBidVolume
            // 
            this.labelBidVolume.AutoSize = true;
            this.labelBidVolume.Location = new System.Drawing.Point(316, 13);
            this.labelBidVolume.Name = "labelBidVolume";
            this.labelBidVolume.Size = new System.Drawing.Size(11, 12);
            this.labelBidVolume.TabIndex = 19;
            this.labelBidVolume.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "买一量:";
            // 
            // labelAskVolume
            // 
            this.labelAskVolume.AutoSize = true;
            this.labelAskVolume.Location = new System.Drawing.Point(444, 13);
            this.labelAskVolume.Name = "labelAskVolume";
            this.labelAskVolume.Size = new System.Drawing.Size(11, 12);
            this.labelAskVolume.TabIndex = 21;
            this.labelAskVolume.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(385, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "卖一量：";
            // 
            // numericUpDownPercentStrike
            // 
            this.numericUpDownPercentStrike.DecimalPlaces = 1;
            this.numericUpDownPercentStrike.Enabled = false;
            this.numericUpDownPercentStrike.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownPercentStrike.Location = new System.Drawing.Point(76, 178);
            this.numericUpDownPercentStrike.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownPercentStrike.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.numericUpDownPercentStrike.Name = "numericUpDownPercentStrike";
            this.numericUpDownPercentStrike.Size = new System.Drawing.Size(77, 21);
            this.numericUpDownPercentStrike.TabIndex = 28;
            this.numericUpDownPercentStrike.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkBoxPercentStrike
            // 
            this.checkBoxPercentStrike.AutoSize = true;
            this.checkBoxPercentStrike.Location = new System.Drawing.Point(76, 156);
            this.checkBoxPercentStrike.Name = "checkBoxPercentStrike";
            this.checkBoxPercentStrike.Size = new System.Drawing.Size(96, 16);
            this.checkBoxPercentStrike.TabIndex = 27;
            this.checkBoxPercentStrike.Text = "百分比执行价";
            this.checkBoxPercentStrike.UseVisualStyleBackColor = true;
            this.checkBoxPercentStrike.CheckedChanged += new System.EventHandler(this.checkBoxPercentStrike_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(158, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 14);
            this.label2.TabIndex = 29;
            this.label2.Text = "%";
            // 
            // labelTotalDelta
            // 
            this.labelTotalDelta.AutoSize = true;
            this.labelTotalDelta.Location = new System.Drawing.Point(8, 126);
            this.labelTotalDelta.Name = "labelTotalDelta";
            this.labelTotalDelta.Size = new System.Drawing.Size(95, 12);
            this.labelTotalDelta.TabIndex = 21;
            this.labelTotalDelta.Text = "总Delta（手）：";
            // 
            // textBoxTotalDelta
            // 
            this.textBoxTotalDelta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTotalDelta.Location = new System.Drawing.Point(109, 123);
            this.textBoxTotalDelta.Name = "textBoxTotalDelta";
            this.textBoxTotalDelta.ReadOnly = true;
            this.textBoxTotalDelta.Size = new System.Drawing.Size(97, 21);
            this.textBoxTotalDelta.TabIndex = 22;
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStop.Location = new System.Drawing.Point(280, 158);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 23;
            this.buttonStop.Text = "停止计算";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonOOM);
            this.panel1.Controls.Add(this.radioButtonITM);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(178, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 21);
            this.panel1.TabIndex = 30;
            // 
            // radioButtonITM
            // 
            this.radioButtonITM.AutoSize = true;
            this.radioButtonITM.Location = new System.Drawing.Point(3, 5);
            this.radioButtonITM.Name = "radioButtonITM";
            this.radioButtonITM.Size = new System.Drawing.Size(47, 16);
            this.radioButtonITM.TabIndex = 0;
            this.radioButtonITM.TabStop = true;
            this.radioButtonITM.Text = "实值";
            this.radioButtonITM.UseVisualStyleBackColor = true;
            // 
            // radioButtonOOM
            // 
            this.radioButtonOOM.AutoSize = true;
            this.radioButtonOOM.Location = new System.Drawing.Point(73, 5);
            this.radioButtonOOM.Name = "radioButtonOOM";
            this.radioButtonOOM.Size = new System.Drawing.Size(47, 16);
            this.radioButtonOOM.TabIndex = 1;
            this.radioButtonOOM.TabStop = true;
            this.radioButtonOOM.Text = "虚值";
            this.radioButtonOOM.UseVisualStyleBackColor = true;
            // 
            // groupBoxClientInfo
            // 
            this.groupBoxClientInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxClientInfo.Controls.Add(this.label7);
            this.groupBoxClientInfo.Controls.Add(this.textBoxRemainBalance);
            this.groupBoxClientInfo.Controls.Add(this.label5);
            this.groupBoxClientInfo.Controls.Add(this.textBoxBalance);
            this.groupBoxClientInfo.Controls.Add(this.label3);
            this.groupBoxClientInfo.Controls.Add(this.labelClientName);
            this.groupBoxClientInfo.Controls.Add(this.textBoxValidationCode);
            this.groupBoxClientInfo.Controls.Add(this.comboBoxClientName);
            this.groupBoxClientInfo.Location = new System.Drawing.Point(397, 42);
            this.groupBoxClientInfo.Name = "groupBoxClientInfo";
            this.groupBoxClientInfo.Size = new System.Drawing.Size(274, 134);
            this.groupBoxClientInfo.TabIndex = 24;
            this.groupBoxClientInfo.TabStop = false;
            this.groupBoxClientInfo.Text = "客户信息";
            // 
            // labelClientName
            // 
            this.labelClientName.AutoSize = true;
            this.labelClientName.Location = new System.Drawing.Point(8, 23);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(65, 12);
            this.labelClientName.TabIndex = 31;
            this.labelClientName.Text = "选择客户：";
            // 
            // comboBoxClientName
            // 
            this.comboBoxClientName.FormattingEnabled = true;
            this.comboBoxClientName.Location = new System.Drawing.Point(78, 20);
            this.comboBoxClientName.Name = "comboBoxClientName";
            this.comboBoxClientName.Size = new System.Drawing.Size(154, 20);
            this.comboBoxClientName.TabIndex = 32;
            this.comboBoxClientName.SelectedIndexChanged += new System.EventHandler(this.comboBoxClientName_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 31;
            this.label3.Text = "下单验证码：";
            // 
            // textBoxValidationCode
            // 
            this.textBoxValidationCode.Location = new System.Drawing.Point(91, 46);
            this.textBoxValidationCode.Name = "textBoxValidationCode";
            this.textBoxValidationCode.ReadOnly = true;
            this.textBoxValidationCode.Size = new System.Drawing.Size(141, 21);
            this.textBoxValidationCode.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 33;
            this.label5.Text = "账户余额：";
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Location = new System.Drawing.Point(91, 73);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.ReadOnly = true;
            this.textBoxBalance.Size = new System.Drawing.Size(141, 21);
            this.textBoxBalance.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 35;
            this.label7.Text = "剩余金额：";
            // 
            // textBoxRemainBalance
            // 
            this.textBoxRemainBalance.Location = new System.Drawing.Point(91, 102);
            this.textBoxRemainBalance.Name = "textBoxRemainBalance";
            this.textBoxRemainBalance.ReadOnly = true;
            this.textBoxRemainBalance.Size = new System.Drawing.Size(141, 21);
            this.textBoxRemainBalance.TabIndex = 36;
            // 
            // FormQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 398);
            this.Controls.Add(this.groupBoxClientInfo);
            this.Controls.Add(this.labelAskVolume);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelBidVolume);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelAskPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelBidPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxQuotes);
            this.Controls.Add(this.groupBoxParam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormQuotes";
            this.Text = "普通欧式报价";
            this.groupBoxParam.ResumeLayout(false);
            this.groupBoxParam.PerformLayout();
            this.groupBoxQuotes.ResumeLayout(false);
            this.groupBoxQuotes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpreadValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPercentStrike)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxClientInfo.ResumeLayout(false);
            this.groupBoxClientInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUnderlying;
        private System.Windows.Forms.TextBox textBoxUnderlying;
        private System.Windows.Forms.Label labelOptionType;
        private System.Windows.Forms.ComboBox comboBoxOptionType;
        private System.Windows.Forms.TextBox textBoxStrike;
        private System.Windows.Forms.Label labelStrike;
        private System.Windows.Forms.DateTimePicker dateTimePickerMaturityDate;
        private System.Windows.Forms.Label labelMaturityDate;
        private System.Windows.Forms.TextBox textBoxVolatility;
        private System.Windows.Forms.Label labelVolatility;
        private System.Windows.Forms.TextBox textBoxRate;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.GroupBox groupBoxParam;
        private System.Windows.Forms.GroupBox groupBoxQuotes;
        private System.Windows.Forms.Label labelDelta;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxDelta;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelBuySell;
        private System.Windows.Forms.ComboBox comboBoxBuySell;
        private System.Windows.Forms.Label labelUnderlyingError;
        private System.Windows.Forms.Label labelBuySellError;
        private System.Windows.Forms.Label labelOptionTypeError;
        private System.Windows.Forms.Label labelMaturityDateError;
        private System.Windows.Forms.Label labelRateError;
        private System.Windows.Forms.Label labelVolatilityError;
        private System.Windows.Forms.Label labelStrikeError;
        private System.Windows.Forms.Label labelYieldError;
        private System.Windows.Forms.TextBox textBoxYield;
        private System.Windows.Forms.Label labelYield;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBidPrice;
        private System.Windows.Forms.Label labelAskPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelBidVolume;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelAskVolume;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelQuantityError;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.CheckBox checkBoxSpreadQuote;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.NumericUpDown numericUpDownSpreadValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownPercentStrike;
        private System.Windows.Forms.CheckBox checkBoxPercentStrike;
        private System.Windows.Forms.Label labelTotalDelta;
        private System.Windows.Forms.TextBox textBoxTotalDelta;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonOOM;
        private System.Windows.Forms.RadioButton radioButtonITM;
        private System.Windows.Forms.GroupBox groupBoxClientInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxRemainBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.TextBox textBoxValidationCode;
        private System.Windows.Forms.ComboBox comboBoxClientName;
    }
}