namespace OTC
{
    partial class FormPlaceOrder
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
            this.components = new System.ComponentModel.Container();
            this.labelEntityInfo = new System.Windows.Forms.Label();
            this.comboBoxEntityCode = new System.Windows.Forms.ComboBox();
            this.groupBoxMainInfo = new System.Windows.Forms.GroupBox();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.labelBalance = new System.Windows.Forms.Label();
            this.comboBoxTargetID = new System.Windows.Forms.ComboBox();
            this.labelTargetID = new System.Windows.Forms.Label();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.labelClientName = new System.Windows.Forms.Label();
            this.groupBoxContractInfo = new System.Windows.Forms.GroupBox();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.buttonMaxQuantity = new System.Windows.Forms.Button();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelOpenClose = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.comboBoxOpenClose = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxLongShort = new System.Windows.Forms.ComboBox();
            this.labelContractCode = new System.Windows.Forms.Label();
            this.comboBoxContractCode = new System.Windows.Forms.ComboBox();
            this.labelOrderType = new System.Windows.Forms.Label();
            this.comboBoxOrderType = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.textBoxUnderlyingPrice = new System.Windows.Forms.TextBox();
            this.labelUnderlyingPrice = new System.Windows.Forms.Label();
            this.groupBoxMainInfo.SuspendLayout();
            this.groupBoxContractInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEntityInfo
            // 
            this.labelEntityInfo.AutoSize = true;
            this.labelEntityInfo.Location = new System.Drawing.Point(6, 22);
            this.labelEntityInfo.Name = "labelEntityInfo";
            this.labelEntityInfo.Size = new System.Drawing.Size(65, 12);
            this.labelEntityInfo.TabIndex = 0;
            this.labelEntityInfo.Text = "客户编号：";
            // 
            // comboBoxEntityCode
            // 
            this.comboBoxEntityCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEntityCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEntityCode.FormattingEnabled = true;
            this.comboBoxEntityCode.Location = new System.Drawing.Point(77, 19);
            this.comboBoxEntityCode.Name = "comboBoxEntityCode";
            this.comboBoxEntityCode.Size = new System.Drawing.Size(155, 20);
            this.comboBoxEntityCode.TabIndex = 2;
            this.comboBoxEntityCode.SelectedIndexChanged += new System.EventHandler(this.comboBoxEntityCode_SelectedIndexChanged);
            // 
            // groupBoxMainInfo
            // 
            this.groupBoxMainInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMainInfo.Controls.Add(this.textBoxBalance);
            this.groupBoxMainInfo.Controls.Add(this.labelBalance);
            this.groupBoxMainInfo.Controls.Add(this.comboBoxTargetID);
            this.groupBoxMainInfo.Controls.Add(this.labelTargetID);
            this.groupBoxMainInfo.Controls.Add(this.textBoxClientName);
            this.groupBoxMainInfo.Controls.Add(this.labelClientName);
            this.groupBoxMainInfo.Controls.Add(this.labelEntityInfo);
            this.groupBoxMainInfo.Controls.Add(this.comboBoxEntityCode);
            this.groupBoxMainInfo.Location = new System.Drawing.Point(12, 40);
            this.groupBoxMainInfo.Name = "groupBoxMainInfo";
            this.groupBoxMainInfo.Size = new System.Drawing.Size(250, 219);
            this.groupBoxMainInfo.TabIndex = 2;
            this.groupBoxMainInfo.TabStop = false;
            this.groupBoxMainInfo.Text = "账号信息";
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Location = new System.Drawing.Point(77, 107);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.ReadOnly = true;
            this.textBoxBalance.Size = new System.Drawing.Size(155, 21);
            this.textBoxBalance.TabIndex = 8;
            this.textBoxBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(6, 111);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(65, 12);
            this.labelBalance.TabIndex = 7;
            this.labelBalance.Text = "资金余额：";
            // 
            // comboBoxTargetID
            // 
            this.comboBoxTargetID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTargetID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTargetID.FormattingEnabled = true;
            this.comboBoxTargetID.Location = new System.Drawing.Point(101, 74);
            this.comboBoxTargetID.Name = "comboBoxTargetID";
            this.comboBoxTargetID.Size = new System.Drawing.Size(131, 20);
            this.comboBoxTargetID.TabIndex = 4;
            // 
            // labelTargetID
            // 
            this.labelTargetID.AutoSize = true;
            this.labelTargetID.Location = new System.Drawing.Point(6, 78);
            this.labelTargetID.Name = "labelTargetID";
            this.labelTargetID.Size = new System.Drawing.Size(89, 12);
            this.labelTargetID.TabIndex = 6;
            this.labelTargetID.Text = "目标客户编号：";
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Location = new System.Drawing.Point(77, 45);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.ReadOnly = true;
            this.textBoxClientName.Size = new System.Drawing.Size(155, 21);
            this.textBoxClientName.TabIndex = 3;
            // 
            // labelClientName
            // 
            this.labelClientName.AutoSize = true;
            this.labelClientName.Location = new System.Drawing.Point(6, 50);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(65, 12);
            this.labelClientName.TabIndex = 4;
            this.labelClientName.Text = "客户名称：";
            // 
            // groupBoxContractInfo
            // 
            this.groupBoxContractInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxContractInfo.Controls.Add(this.textBoxUnderlyingPrice);
            this.groupBoxContractInfo.Controls.Add(this.labelUnderlyingPrice);
            this.groupBoxContractInfo.Controls.Add(this.textBoxValue);
            this.groupBoxContractInfo.Controls.Add(this.labelValue);
            this.groupBoxContractInfo.Controls.Add(this.numericUpDownPrice);
            this.groupBoxContractInfo.Controls.Add(this.buttonMaxQuantity);
            this.groupBoxContractInfo.Controls.Add(this.numericUpDownQuantity);
            this.groupBoxContractInfo.Controls.Add(this.labelQuantity);
            this.groupBoxContractInfo.Controls.Add(this.labelOpenClose);
            this.groupBoxContractInfo.Controls.Add(this.labelPrice);
            this.groupBoxContractInfo.Controls.Add(this.comboBoxOpenClose);
            this.groupBoxContractInfo.Controls.Add(this.label1);
            this.groupBoxContractInfo.Controls.Add(this.comboBoxLongShort);
            this.groupBoxContractInfo.Controls.Add(this.labelContractCode);
            this.groupBoxContractInfo.Controls.Add(this.comboBoxContractCode);
            this.groupBoxContractInfo.Location = new System.Drawing.Point(302, 40);
            this.groupBoxContractInfo.Name = "groupBoxContractInfo";
            this.groupBoxContractInfo.Size = new System.Drawing.Size(284, 220);
            this.groupBoxContractInfo.TabIndex = 3;
            this.groupBoxContractInfo.TabStop = false;
            this.groupBoxContractInfo.Text = "合约信息";
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(77, 193);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.ReadOnly = true;
            this.textBoxValue.Size = new System.Drawing.Size(85, 21);
            this.textBoxValue.TabIndex = 13;
            this.textBoxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(6, 196);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(65, 12);
            this.labelValue.TabIndex = 12;
            this.labelValue.Text = "所需资金：";
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.DecimalPlaces = 2;
            this.numericUpDownPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownPrice.Location = new System.Drawing.Point(77, 108);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDownPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(100, 21);
            this.numericUpDownPrice.TabIndex = 8;
            this.numericUpDownPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // buttonMaxQuantity
            // 
            this.buttonMaxQuantity.Location = new System.Drawing.Point(199, 134);
            this.buttonMaxQuantity.Name = "buttonMaxQuantity";
            this.buttonMaxQuantity.Size = new System.Drawing.Size(75, 21);
            this.buttonMaxQuantity.TabIndex = 11;
            this.buttonMaxQuantity.Text = "最大数量";
            this.buttonMaxQuantity.UseVisualStyleBackColor = true;
            this.buttonMaxQuantity.Click += new System.EventHandler(this.buttonMaxQuantity_Click);
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(77, 134);
            this.numericUpDownQuantity.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDownQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(100, 21);
            this.numericUpDownQuantity.TabIndex = 9;
            this.numericUpDownQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(6, 136);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(41, 12);
            this.labelQuantity.TabIndex = 10;
            this.labelQuantity.Text = "数量：";
            // 
            // labelOpenClose
            // 
            this.labelOpenClose.AutoSize = true;
            this.labelOpenClose.Location = new System.Drawing.Point(6, 78);
            this.labelOpenClose.Name = "labelOpenClose";
            this.labelOpenClose.Size = new System.Drawing.Size(41, 12);
            this.labelOpenClose.TabIndex = 8;
            this.labelOpenClose.Text = "开平：";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(6, 111);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(41, 12);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "价格：";
            // 
            // comboBoxOpenClose
            // 
            this.comboBoxOpenClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxOpenClose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOpenClose.FormattingEnabled = true;
            this.comboBoxOpenClose.Location = new System.Drawing.Point(77, 75);
            this.comboBoxOpenClose.Name = "comboBoxOpenClose";
            this.comboBoxOpenClose.Size = new System.Drawing.Size(201, 20);
            this.comboBoxOpenClose.TabIndex = 7;
            this.comboBoxOpenClose.SelectedIndexChanged += new System.EventHandler(this.comboBoxOpenClose_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "买卖方向：";
            // 
            // comboBoxLongShort
            // 
            this.comboBoxLongShort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLongShort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLongShort.FormattingEnabled = true;
            this.comboBoxLongShort.Location = new System.Drawing.Point(77, 47);
            this.comboBoxLongShort.Name = "comboBoxLongShort";
            this.comboBoxLongShort.Size = new System.Drawing.Size(201, 20);
            this.comboBoxLongShort.TabIndex = 6;
            // 
            // labelContractCode
            // 
            this.labelContractCode.AutoSize = true;
            this.labelContractCode.Location = new System.Drawing.Point(6, 22);
            this.labelContractCode.Name = "labelContractCode";
            this.labelContractCode.Size = new System.Drawing.Size(65, 12);
            this.labelContractCode.TabIndex = 4;
            this.labelContractCode.Text = "合约代码：";
            // 
            // comboBoxContractCode
            // 
            this.comboBoxContractCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxContractCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxContractCode.FormattingEnabled = true;
            this.comboBoxContractCode.Location = new System.Drawing.Point(77, 19);
            this.comboBoxContractCode.Name = "comboBoxContractCode";
            this.comboBoxContractCode.Size = new System.Drawing.Size(201, 20);
            this.comboBoxContractCode.TabIndex = 5;
            // 
            // labelOrderType
            // 
            this.labelOrderType.AutoSize = true;
            this.labelOrderType.Location = new System.Drawing.Point(18, 9);
            this.labelOrderType.Name = "labelOrderType";
            this.labelOrderType.Size = new System.Drawing.Size(59, 12);
            this.labelOrderType.TabIndex = 2;
            this.labelOrderType.Text = "订单类型:";
            // 
            // comboBoxOrderType
            // 
            this.comboBoxOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrderType.FormattingEnabled = true;
            this.comboBoxOrderType.Location = new System.Drawing.Point(83, 6);
            this.comboBoxOrderType.Name = "comboBoxOrderType";
            this.comboBoxOrderType.Size = new System.Drawing.Size(86, 20);
            this.comboBoxOrderType.TabIndex = 1;
            this.comboBoxOrderType.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrderType_SelectedIndexChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(524, 275);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(78, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(431, 275);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "下单";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxUnderlyingPrice
            // 
            this.textBoxUnderlyingPrice.Location = new System.Drawing.Point(77, 164);
            this.textBoxUnderlyingPrice.Name = "textBoxUnderlyingPrice";
            this.textBoxUnderlyingPrice.ReadOnly = true;
            this.textBoxUnderlyingPrice.Size = new System.Drawing.Size(85, 21);
            this.textBoxUnderlyingPrice.TabIndex = 15;
            this.textBoxUnderlyingPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelUnderlyingPrice
            // 
            this.labelUnderlyingPrice.AutoSize = true;
            this.labelUnderlyingPrice.Location = new System.Drawing.Point(6, 167);
            this.labelUnderlyingPrice.Name = "labelUnderlyingPrice";
            this.labelUnderlyingPrice.Size = new System.Drawing.Size(65, 12);
            this.labelUnderlyingPrice.TabIndex = 14;
            this.labelUnderlyingPrice.Text = "标的价格：";
            // 
            // FormPlaceOrder
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(619, 310);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelOrderType);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.comboBoxOrderType);
            this.Controls.Add(this.groupBoxContractInfo);
            this.Controls.Add(this.groupBoxMainInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPlaceOrder";
            this.Text = "下单";
            this.groupBoxMainInfo.ResumeLayout(false);
            this.groupBoxMainInfo.PerformLayout();
            this.groupBoxContractInfo.ResumeLayout(false);
            this.groupBoxContractInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEntityInfo;
        private System.Windows.Forms.ComboBox comboBoxEntityCode;
        private System.Windows.Forms.GroupBox groupBoxMainInfo;
        private System.Windows.Forms.ComboBox comboBoxTargetID;
        private System.Windows.Forms.Label labelTargetID;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.GroupBox groupBoxContractInfo;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelOpenClose;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.ComboBox comboBoxOpenClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxLongShort;
        private System.Windows.Forms.Label labelContractCode;
        private System.Windows.Forms.ComboBox comboBoxContractCode;
        private System.Windows.Forms.Label labelOrderType;
        private System.Windows.Forms.ComboBox comboBoxOrderType;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonMaxQuantity;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.TextBox textBoxUnderlyingPrice;
        private System.Windows.Forms.Label labelUnderlyingPrice;
    }
}