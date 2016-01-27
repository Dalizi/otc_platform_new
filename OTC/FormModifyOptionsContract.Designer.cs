namespace OTC
{
    partial class FormModifyOptionsContract
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBoxAddFuturesContract = new System.Windows.Forms.GroupBox();
            this.textBoxSettle = new System.Windows.Forms.TextBox();
            this.labelSettle = new System.Windows.Forms.Label();
            this.comboBoxOptionsContractCode = new System.Windows.Forms.ComboBox();
            this.textBoxStrikePrice = new System.Windows.Forms.TextBox();
            this.dateTimePickerMaturityDate = new System.Windows.Forms.DateTimePicker();
            this.labelStrikePrice = new System.Windows.Forms.Label();
            this.labelMaturityDate = new System.Windows.Forms.Label();
            this.comboBoxOptionsDirection = new System.Windows.Forms.ComboBox();
            this.labelOptionDirect = new System.Windows.Forms.Label();
            this.comboBoxOptionsType = new System.Windows.Forms.ComboBox();
            this.labelOptionsType = new System.Windows.Forms.Label();
            this.textBoxMultiplier = new System.Windows.Forms.TextBox();
            this.labelMultiplier = new System.Windows.Forms.Label();
            this.textBoxMarginRate = new System.Windows.Forms.TextBox();
            this.labelMarginRate = new System.Windows.Forms.Label();
            this.labelFuturesContractCode = new System.Windows.Forms.Label();
            this.comboBoxUnderlyingCode = new System.Windows.Forms.ComboBox();
            this.labelUnderlyingCode = new System.Windows.Forms.Label();
            this.textBoxCommission = new System.Windows.Forms.TextBox();
            this.labelCommission = new System.Windows.Forms.Label();
            this.textBoxVolatility = new System.Windows.Forms.TextBox();
            this.labelVolatility = new System.Windows.Forms.Label();
            this.groupBoxAddFuturesContract.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(237, 404);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(80, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(156, 404);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "确定";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // groupBoxAddFuturesContract
            // 
            this.groupBoxAddFuturesContract.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAddFuturesContract.Controls.Add(this.textBoxVolatility);
            this.groupBoxAddFuturesContract.Controls.Add(this.labelVolatility);
            this.groupBoxAddFuturesContract.Controls.Add(this.textBoxSettle);
            this.groupBoxAddFuturesContract.Controls.Add(this.labelSettle);
            this.groupBoxAddFuturesContract.Controls.Add(this.comboBoxOptionsContractCode);
            this.groupBoxAddFuturesContract.Controls.Add(this.textBoxStrikePrice);
            this.groupBoxAddFuturesContract.Controls.Add(this.dateTimePickerMaturityDate);
            this.groupBoxAddFuturesContract.Controls.Add(this.labelStrikePrice);
            this.groupBoxAddFuturesContract.Controls.Add(this.labelMaturityDate);
            this.groupBoxAddFuturesContract.Controls.Add(this.comboBoxOptionsDirection);
            this.groupBoxAddFuturesContract.Controls.Add(this.labelOptionDirect);
            this.groupBoxAddFuturesContract.Controls.Add(this.comboBoxOptionsType);
            this.groupBoxAddFuturesContract.Controls.Add(this.labelOptionsType);
            this.groupBoxAddFuturesContract.Controls.Add(this.textBoxMultiplier);
            this.groupBoxAddFuturesContract.Controls.Add(this.labelMultiplier);
            this.groupBoxAddFuturesContract.Controls.Add(this.textBoxMarginRate);
            this.groupBoxAddFuturesContract.Controls.Add(this.labelMarginRate);
            this.groupBoxAddFuturesContract.Controls.Add(this.labelFuturesContractCode);
            this.groupBoxAddFuturesContract.Controls.Add(this.comboBoxUnderlyingCode);
            this.groupBoxAddFuturesContract.Controls.Add(this.labelUnderlyingCode);
            this.groupBoxAddFuturesContract.Controls.Add(this.textBoxCommission);
            this.groupBoxAddFuturesContract.Controls.Add(this.labelCommission);
            this.groupBoxAddFuturesContract.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAddFuturesContract.Name = "groupBoxAddFuturesContract";
            this.groupBoxAddFuturesContract.Size = new System.Drawing.Size(316, 371);
            this.groupBoxAddFuturesContract.TabIndex = 9;
            this.groupBoxAddFuturesContract.TabStop = false;
            this.groupBoxAddFuturesContract.Text = "客户信息";
            // 
            // textBoxSettle
            // 
            this.textBoxSettle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSettle.Location = new System.Drawing.Point(114, 236);
            this.textBoxSettle.Name = "textBoxSettle";
            this.textBoxSettle.Size = new System.Drawing.Size(191, 21);
            this.textBoxSettle.TabIndex = 23;
            this.textBoxSettle.Text = "0.00";
            // 
            // labelSettle
            // 
            this.labelSettle.AutoSize = true;
            this.labelSettle.Location = new System.Drawing.Point(19, 239);
            this.labelSettle.Name = "labelSettle";
            this.labelSettle.Size = new System.Drawing.Size(53, 12);
            this.labelSettle.TabIndex = 22;
            this.labelSettle.Text = "结算价：";
            // 
            // comboBoxOptionsContractCode
            // 
            this.comboBoxOptionsContractCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOptionsContractCode.FormattingEnabled = true;
            this.comboBoxOptionsContractCode.Location = new System.Drawing.Point(114, 20);
            this.comboBoxOptionsContractCode.Name = "comboBoxOptionsContractCode";
            this.comboBoxOptionsContractCode.Size = new System.Drawing.Size(191, 20);
            this.comboBoxOptionsContractCode.TabIndex = 21;
            this.comboBoxOptionsContractCode.SelectedIndexChanged += new System.EventHandler(this.comboBoxOptionsContractCode_SelectedIndexChanged);
            // 
            // textBoxStrikePrice
            // 
            this.textBoxStrikePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStrikePrice.Enabled = false;
            this.textBoxStrikePrice.Location = new System.Drawing.Point(114, 206);
            this.textBoxStrikePrice.Name = "textBoxStrikePrice";
            this.textBoxStrikePrice.Size = new System.Drawing.Size(191, 21);
            this.textBoxStrikePrice.TabIndex = 20;
            this.textBoxStrikePrice.Text = "0.00";
            // 
            // dateTimePickerMaturityDate
            // 
            this.dateTimePickerMaturityDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerMaturityDate.Enabled = false;
            this.dateTimePickerMaturityDate.Location = new System.Drawing.Point(114, 176);
            this.dateTimePickerMaturityDate.Name = "dateTimePickerMaturityDate";
            this.dateTimePickerMaturityDate.Size = new System.Drawing.Size(191, 21);
            this.dateTimePickerMaturityDate.TabIndex = 19;
            this.dateTimePickerMaturityDate.Value = new System.DateTime(2016, 1, 21, 16, 26, 51, 0);
            // 
            // labelStrikePrice
            // 
            this.labelStrikePrice.AutoSize = true;
            this.labelStrikePrice.Location = new System.Drawing.Point(19, 209);
            this.labelStrikePrice.Name = "labelStrikePrice";
            this.labelStrikePrice.Size = new System.Drawing.Size(53, 12);
            this.labelStrikePrice.TabIndex = 18;
            this.labelStrikePrice.Text = "执行价：";
            // 
            // labelMaturityDate
            // 
            this.labelMaturityDate.AutoSize = true;
            this.labelMaturityDate.Location = new System.Drawing.Point(19, 182);
            this.labelMaturityDate.Name = "labelMaturityDate";
            this.labelMaturityDate.Size = new System.Drawing.Size(53, 12);
            this.labelMaturityDate.TabIndex = 16;
            this.labelMaturityDate.Text = "到期日：";
            // 
            // comboBoxOptionsDirection
            // 
            this.comboBoxOptionsDirection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxOptionsDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOptionsDirection.Enabled = false;
            this.comboBoxOptionsDirection.Location = new System.Drawing.Point(114, 144);
            this.comboBoxOptionsDirection.Name = "comboBoxOptionsDirection";
            this.comboBoxOptionsDirection.Size = new System.Drawing.Size(191, 20);
            this.comboBoxOptionsDirection.TabIndex = 13;
            // 
            // labelOptionDirect
            // 
            this.labelOptionDirect.AutoSize = true;
            this.labelOptionDirect.Location = new System.Drawing.Point(19, 147);
            this.labelOptionDirect.Name = "labelOptionDirect";
            this.labelOptionDirect.Size = new System.Drawing.Size(65, 12);
            this.labelOptionDirect.TabIndex = 14;
            this.labelOptionDirect.Text = "期权方向：";
            // 
            // comboBoxOptionsType
            // 
            this.comboBoxOptionsType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxOptionsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOptionsType.Enabled = false;
            this.comboBoxOptionsType.Location = new System.Drawing.Point(114, 115);
            this.comboBoxOptionsType.Name = "comboBoxOptionsType";
            this.comboBoxOptionsType.Size = new System.Drawing.Size(191, 20);
            this.comboBoxOptionsType.TabIndex = 11;
            // 
            // labelOptionsType
            // 
            this.labelOptionsType.AutoSize = true;
            this.labelOptionsType.Location = new System.Drawing.Point(19, 118);
            this.labelOptionsType.Name = "labelOptionsType";
            this.labelOptionsType.Size = new System.Drawing.Size(65, 12);
            this.labelOptionsType.TabIndex = 12;
            this.labelOptionsType.Text = "期权类型：";
            // 
            // textBoxMultiplier
            // 
            this.textBoxMultiplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMultiplier.Enabled = false;
            this.textBoxMultiplier.Location = new System.Drawing.Point(114, 84);
            this.textBoxMultiplier.Name = "textBoxMultiplier";
            this.textBoxMultiplier.Size = new System.Drawing.Size(191, 21);
            this.textBoxMultiplier.TabIndex = 4;
            this.textBoxMultiplier.Text = "1";
            // 
            // labelMultiplier
            // 
            this.labelMultiplier.AutoSize = true;
            this.labelMultiplier.Location = new System.Drawing.Point(19, 87);
            this.labelMultiplier.Name = "labelMultiplier";
            this.labelMultiplier.Size = new System.Drawing.Size(65, 12);
            this.labelMultiplier.TabIndex = 10;
            this.labelMultiplier.Text = "合约乘数：";
            // 
            // textBoxMarginRate
            // 
            this.textBoxMarginRate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMarginRate.Location = new System.Drawing.Point(114, 303);
            this.textBoxMarginRate.Name = "textBoxMarginRate";
            this.textBoxMarginRate.Size = new System.Drawing.Size(191, 21);
            this.textBoxMarginRate.TabIndex = 3;
            this.textBoxMarginRate.Text = "0.00";
            // 
            // labelMarginRate
            // 
            this.labelMarginRate.AutoSize = true;
            this.labelMarginRate.Location = new System.Drawing.Point(19, 306);
            this.labelMarginRate.Name = "labelMarginRate";
            this.labelMarginRate.Size = new System.Drawing.Size(65, 12);
            this.labelMarginRate.TabIndex = 6;
            this.labelMarginRate.Text = "保证金率：";
            // 
            // labelFuturesContractCode
            // 
            this.labelFuturesContractCode.AutoSize = true;
            this.labelFuturesContractCode.Location = new System.Drawing.Point(19, 23);
            this.labelFuturesContractCode.Name = "labelFuturesContractCode";
            this.labelFuturesContractCode.Size = new System.Drawing.Size(89, 12);
            this.labelFuturesContractCode.TabIndex = 0;
            this.labelFuturesContractCode.Text = "期权合约代码：";
            // 
            // comboBoxUnderlyingCode
            // 
            this.comboBoxUnderlyingCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxUnderlyingCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUnderlyingCode.Enabled = false;
            this.comboBoxUnderlyingCode.Location = new System.Drawing.Point(114, 54);
            this.comboBoxUnderlyingCode.Name = "comboBoxUnderlyingCode";
            this.comboBoxUnderlyingCode.Size = new System.Drawing.Size(191, 20);
            this.comboBoxUnderlyingCode.TabIndex = 1;
            // 
            // labelUnderlyingCode
            // 
            this.labelUnderlyingCode.AutoSize = true;
            this.labelUnderlyingCode.Location = new System.Drawing.Point(19, 57);
            this.labelUnderlyingCode.Name = "labelUnderlyingCode";
            this.labelUnderlyingCode.Size = new System.Drawing.Size(65, 12);
            this.labelUnderlyingCode.TabIndex = 2;
            this.labelUnderlyingCode.Text = "标的代码：";
            // 
            // textBoxCommission
            // 
            this.textBoxCommission.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCommission.Location = new System.Drawing.Point(114, 270);
            this.textBoxCommission.Name = "textBoxCommission";
            this.textBoxCommission.Size = new System.Drawing.Size(191, 21);
            this.textBoxCommission.TabIndex = 2;
            this.textBoxCommission.Text = "0.00";
            // 
            // labelCommission
            // 
            this.labelCommission.AutoSize = true;
            this.labelCommission.Location = new System.Drawing.Point(19, 273);
            this.labelCommission.Name = "labelCommission";
            this.labelCommission.Size = new System.Drawing.Size(65, 12);
            this.labelCommission.TabIndex = 1;
            this.labelCommission.Text = "手续费率：";
            // 
            // textBoxVolatility
            // 
            this.textBoxVolatility.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVolatility.Location = new System.Drawing.Point(114, 334);
            this.textBoxVolatility.Name = "textBoxVolatility";
            this.textBoxVolatility.Size = new System.Drawing.Size(191, 21);
            this.textBoxVolatility.TabIndex = 24;
            this.textBoxVolatility.Text = "0.00";
            // 
            // labelVolatility
            // 
            this.labelVolatility.AutoSize = true;
            this.labelVolatility.Location = new System.Drawing.Point(19, 337);
            this.labelVolatility.Name = "labelVolatility";
            this.labelVolatility.Size = new System.Drawing.Size(53, 12);
            this.labelVolatility.TabIndex = 25;
            this.labelVolatility.Text = "波动率：";
            // 
            // FormModifyOptionsContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 452);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxAddFuturesContract);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormModifyOptionsContract";
            this.Text = "添加期权合约";
            this.groupBoxAddFuturesContract.ResumeLayout(false);
            this.groupBoxAddFuturesContract.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.GroupBox groupBoxAddFuturesContract;
        private System.Windows.Forms.Label labelFuturesContractCode;
        private System.Windows.Forms.ComboBox comboBoxUnderlyingCode;
        private System.Windows.Forms.Label labelUnderlyingCode;
        private System.Windows.Forms.TextBox textBoxCommission;
        private System.Windows.Forms.Label labelCommission;
        private System.Windows.Forms.TextBox textBoxMultiplier;
        private System.Windows.Forms.Label labelMultiplier;
        private System.Windows.Forms.TextBox textBoxMarginRate;
        private System.Windows.Forms.Label labelMarginRate;
        private System.Windows.Forms.TextBox textBoxStrikePrice;
        private System.Windows.Forms.DateTimePicker dateTimePickerMaturityDate;
        private System.Windows.Forms.Label labelStrikePrice;
        private System.Windows.Forms.Label labelMaturityDate;
        private System.Windows.Forms.ComboBox comboBoxOptionsDirection;
        private System.Windows.Forms.Label labelOptionDirect;
        private System.Windows.Forms.ComboBox comboBoxOptionsType;
        private System.Windows.Forms.Label labelOptionsType;
        private System.Windows.Forms.TextBox textBoxSettle;
        private System.Windows.Forms.Label labelSettle;
        private System.Windows.Forms.ComboBox comboBoxOptionsContractCode;
        private System.Windows.Forms.TextBox textBoxVolatility;
        private System.Windows.Forms.Label labelVolatility;
    }
}