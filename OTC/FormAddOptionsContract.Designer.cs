namespace OTC
{
    partial class FormAddOptionsContract
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
            this.textBoxVolatility = new System.Windows.Forms.TextBox();
            this.labelVolatility = new System.Windows.Forms.Label();
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
            this.textBoxOptionsContractCode = new System.Windows.Forms.TextBox();
            this.labelUnderlyingCode = new System.Windows.Forms.Label();
            this.textBoxCommission = new System.Windows.Forms.TextBox();
            this.labelCommission = new System.Windows.Forms.Label();
            this.groupBoxAddFuturesContract.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(237, 364);
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
            this.buttonOK.Location = new System.Drawing.Point(156, 364);
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
            this.groupBoxAddFuturesContract.Controls.Add(this.textBoxOptionsContractCode);
            this.groupBoxAddFuturesContract.Controls.Add(this.labelUnderlyingCode);
            this.groupBoxAddFuturesContract.Controls.Add(this.textBoxCommission);
            this.groupBoxAddFuturesContract.Controls.Add(this.labelCommission);
            this.groupBoxAddFuturesContract.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAddFuturesContract.Name = "groupBoxAddFuturesContract";
            this.groupBoxAddFuturesContract.Size = new System.Drawing.Size(316, 331);
            this.groupBoxAddFuturesContract.TabIndex = 9;
            this.groupBoxAddFuturesContract.TabStop = false;
            this.groupBoxAddFuturesContract.Text = "客户信息";
            // 
            // textBoxVolatility
            // 
            this.textBoxVolatility.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVolatility.Location = new System.Drawing.Point(114, 300);
            this.textBoxVolatility.Name = "textBoxVolatility";
            this.textBoxVolatility.Size = new System.Drawing.Size(191, 21);
            this.textBoxVolatility.TabIndex = 21;
            this.textBoxVolatility.Text = "0.00";
            // 
            // labelVolatility
            // 
            this.labelVolatility.AutoSize = true;
            this.labelVolatility.Location = new System.Drawing.Point(19, 303);
            this.labelVolatility.Name = "labelVolatility";
            this.labelVolatility.Size = new System.Drawing.Size(53, 12);
            this.labelVolatility.TabIndex = 22;
            this.labelVolatility.Text = "波动率：";
            // 
            // textBoxStrikePrice
            // 
            this.textBoxStrikePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStrikePrice.Location = new System.Drawing.Point(114, 202);
            this.textBoxStrikePrice.Name = "textBoxStrikePrice";
            this.textBoxStrikePrice.Size = new System.Drawing.Size(191, 21);
            this.textBoxStrikePrice.TabIndex = 20;
            this.textBoxStrikePrice.Text = "0.00";
            this.textBoxStrikePrice.TextChanged += new System.EventHandler(this.textBoxStrikePrice_TextChanged);
            // 
            // dateTimePickerMaturityDate
            // 
            this.dateTimePickerMaturityDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerMaturityDate.Location = new System.Drawing.Point(114, 172);
            this.dateTimePickerMaturityDate.Name = "dateTimePickerMaturityDate";
            this.dateTimePickerMaturityDate.Size = new System.Drawing.Size(191, 21);
            this.dateTimePickerMaturityDate.TabIndex = 19;
            this.dateTimePickerMaturityDate.Value = new System.DateTime(2016, 1, 21, 16, 26, 51, 0);
            this.dateTimePickerMaturityDate.ValueChanged += new System.EventHandler(this.dateTimePickerMaturityDate_ValueChanged);
            // 
            // labelStrikePrice
            // 
            this.labelStrikePrice.AutoSize = true;
            this.labelStrikePrice.Location = new System.Drawing.Point(19, 205);
            this.labelStrikePrice.Name = "labelStrikePrice";
            this.labelStrikePrice.Size = new System.Drawing.Size(53, 12);
            this.labelStrikePrice.TabIndex = 18;
            this.labelStrikePrice.Text = "执行价：";
            // 
            // labelMaturityDate
            // 
            this.labelMaturityDate.AutoSize = true;
            this.labelMaturityDate.Location = new System.Drawing.Point(19, 178);
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
            this.comboBoxOptionsDirection.Location = new System.Drawing.Point(114, 143);
            this.comboBoxOptionsDirection.Name = "comboBoxOptionsDirection";
            this.comboBoxOptionsDirection.Size = new System.Drawing.Size(191, 20);
            this.comboBoxOptionsDirection.TabIndex = 13;
            this.comboBoxOptionsDirection.SelectedIndexChanged += new System.EventHandler(this.comboBoxOptionsDirection_SelectedIndexChanged);
            // 
            // labelOptionDirect
            // 
            this.labelOptionDirect.AutoSize = true;
            this.labelOptionDirect.Location = new System.Drawing.Point(19, 146);
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
            this.comboBoxOptionsType.Location = new System.Drawing.Point(114, 114);
            this.comboBoxOptionsType.Name = "comboBoxOptionsType";
            this.comboBoxOptionsType.Size = new System.Drawing.Size(191, 20);
            this.comboBoxOptionsType.TabIndex = 11;
            this.comboBoxOptionsType.SelectedIndexChanged += new System.EventHandler(this.comboBoxOptionsType_SelectedIndexChanged);
            // 
            // labelOptionsType
            // 
            this.labelOptionsType.AutoSize = true;
            this.labelOptionsType.Location = new System.Drawing.Point(19, 117);
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
            this.textBoxMultiplier.Location = new System.Drawing.Point(114, 83);
            this.textBoxMultiplier.Name = "textBoxMultiplier";
            this.textBoxMultiplier.ReadOnly = true;
            this.textBoxMultiplier.Size = new System.Drawing.Size(191, 21);
            this.textBoxMultiplier.TabIndex = 4;
            this.textBoxMultiplier.Text = "1";
            this.textBoxMultiplier.TextChanged += new System.EventHandler(this.textBoxMultiplier_TextChanged);
            // 
            // labelMultiplier
            // 
            this.labelMultiplier.AutoSize = true;
            this.labelMultiplier.Location = new System.Drawing.Point(19, 86);
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
            this.textBoxMarginRate.Location = new System.Drawing.Point(114, 267);
            this.textBoxMarginRate.Name = "textBoxMarginRate";
            this.textBoxMarginRate.Size = new System.Drawing.Size(191, 21);
            this.textBoxMarginRate.TabIndex = 3;
            this.textBoxMarginRate.Text = "0.00";
            // 
            // labelMarginRate
            // 
            this.labelMarginRate.AutoSize = true;
            this.labelMarginRate.Location = new System.Drawing.Point(19, 270);
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
            this.comboBoxUnderlyingCode.Location = new System.Drawing.Point(114, 54);
            this.comboBoxUnderlyingCode.Name = "comboBoxUnderlyingCode";
            this.comboBoxUnderlyingCode.Size = new System.Drawing.Size(191, 20);
            this.comboBoxUnderlyingCode.TabIndex = 1;
            this.comboBoxUnderlyingCode.SelectedIndexChanged += new System.EventHandler(this.comboBoxUnderlyingCode_SelectedIndexChanged);
            // 
            // textBoxOptionsContractCode
            // 
            this.textBoxOptionsContractCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOptionsContractCode.Location = new System.Drawing.Point(114, 20);
            this.textBoxOptionsContractCode.Name = "textBoxOptionsContractCode";
            this.textBoxOptionsContractCode.Size = new System.Drawing.Size(191, 21);
            this.textBoxOptionsContractCode.TabIndex = 0;
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
            this.textBoxCommission.Location = new System.Drawing.Point(114, 234);
            this.textBoxCommission.Name = "textBoxCommission";
            this.textBoxCommission.Size = new System.Drawing.Size(191, 21);
            this.textBoxCommission.TabIndex = 2;
            this.textBoxCommission.Text = "0.00";
            // 
            // labelCommission
            // 
            this.labelCommission.AutoSize = true;
            this.labelCommission.Location = new System.Drawing.Point(19, 237);
            this.labelCommission.Name = "labelCommission";
            this.labelCommission.Size = new System.Drawing.Size(65, 12);
            this.labelCommission.TabIndex = 1;
            this.labelCommission.Text = "手续费率：";
            // 
            // FormAddOptionsContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 412);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxAddFuturesContract);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddOptionsContract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.TextBox textBoxOptionsContractCode;
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
        private System.Windows.Forms.TextBox textBoxVolatility;
        private System.Windows.Forms.Label labelVolatility;
    }
}