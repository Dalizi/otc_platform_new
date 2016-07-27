namespace OTC
{
    partial class FormAddFuturesContract
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
            this.textBoxPreSettle = new System.Windows.Forms.TextBox();
            this.labelPreSettle = new System.Windows.Forms.Label();
            this.textBoxVolatility = new System.Windows.Forms.TextBox();
            this.labelVolatility = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonPctCommission = new System.Windows.Forms.RadioButton();
            this.radioButtonAbsCommission = new System.Windows.Forms.RadioButton();
            this.labelCommissionMode = new System.Windows.Forms.Label();
            this.textBoxMultiplier = new System.Windows.Forms.TextBox();
            this.labelMultiplier = new System.Windows.Forms.Label();
            this.textBoxMarginRate = new System.Windows.Forms.TextBox();
            this.labelMarginRate = new System.Windows.Forms.Label();
            this.labelFuturesContractCode = new System.Windows.Forms.Label();
            this.comboBoxUnderlyingCode = new System.Windows.Forms.ComboBox();
            this.textBoxFuturesContractCode = new System.Windows.Forms.TextBox();
            this.labelUnderlyingCode = new System.Windows.Forms.Label();
            this.textBoxCommission = new System.Windows.Forms.TextBox();
            this.labelCommission = new System.Windows.Forms.Label();
            this.groupBoxAddFuturesContract.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(237, 266);
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
            this.buttonOK.Location = new System.Drawing.Point(156, 266);
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
            this.groupBoxAddFuturesContract.Controls.Add(this.textBoxPreSettle);
            this.groupBoxAddFuturesContract.Controls.Add(this.labelPreSettle);
            this.groupBoxAddFuturesContract.Controls.Add(this.textBoxVolatility);
            this.groupBoxAddFuturesContract.Controls.Add(this.labelVolatility);
            this.groupBoxAddFuturesContract.Controls.Add(this.panel1);
            this.groupBoxAddFuturesContract.Controls.Add(this.labelCommissionMode);
            this.groupBoxAddFuturesContract.Controls.Add(this.textBoxMultiplier);
            this.groupBoxAddFuturesContract.Controls.Add(this.labelMultiplier);
            this.groupBoxAddFuturesContract.Controls.Add(this.textBoxMarginRate);
            this.groupBoxAddFuturesContract.Controls.Add(this.labelMarginRate);
            this.groupBoxAddFuturesContract.Controls.Add(this.labelFuturesContractCode);
            this.groupBoxAddFuturesContract.Controls.Add(this.comboBoxUnderlyingCode);
            this.groupBoxAddFuturesContract.Controls.Add(this.textBoxFuturesContractCode);
            this.groupBoxAddFuturesContract.Controls.Add(this.labelUnderlyingCode);
            this.groupBoxAddFuturesContract.Controls.Add(this.textBoxCommission);
            this.groupBoxAddFuturesContract.Controls.Add(this.labelCommission);
            this.groupBoxAddFuturesContract.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAddFuturesContract.Name = "groupBoxAddFuturesContract";
            this.groupBoxAddFuturesContract.Size = new System.Drawing.Size(316, 248);
            this.groupBoxAddFuturesContract.TabIndex = 9;
            this.groupBoxAddFuturesContract.TabStop = false;
            this.groupBoxAddFuturesContract.Text = "客户信息";
            // 
            // textBoxPreSettle
            // 
            this.textBoxPreSettle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPreSettle.Location = new System.Drawing.Point(114, 221);
            this.textBoxPreSettle.Name = "textBoxPreSettle";
            this.textBoxPreSettle.Size = new System.Drawing.Size(191, 21);
            this.textBoxPreSettle.TabIndex = 15;
            this.textBoxPreSettle.Text = "0";
            // 
            // labelPreSettle
            // 
            this.labelPreSettle.AutoSize = true;
            this.labelPreSettle.Location = new System.Drawing.Point(19, 224);
            this.labelPreSettle.Name = "labelPreSettle";
            this.labelPreSettle.Size = new System.Drawing.Size(65, 12);
            this.labelPreSettle.TabIndex = 16;
            this.labelPreSettle.Text = "前结算价：";
            // 
            // textBoxVolatility
            // 
            this.textBoxVolatility.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVolatility.Location = new System.Drawing.Point(114, 193);
            this.textBoxVolatility.Name = "textBoxVolatility";
            this.textBoxVolatility.Size = new System.Drawing.Size(191, 21);
            this.textBoxVolatility.TabIndex = 13;
            this.textBoxVolatility.Text = "0.00";
            // 
            // labelVolatility
            // 
            this.labelVolatility.AutoSize = true;
            this.labelVolatility.Location = new System.Drawing.Point(19, 196);
            this.labelVolatility.Name = "labelVolatility";
            this.labelVolatility.Size = new System.Drawing.Size(53, 12);
            this.labelVolatility.TabIndex = 14;
            this.labelVolatility.Text = "波动率：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonPctCommission);
            this.panel1.Controls.Add(this.radioButtonAbsCommission);
            this.panel1.Location = new System.Drawing.Point(114, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 30);
            this.panel1.TabIndex = 12;
            // 
            // radioButtonPctCommission
            // 
            this.radioButtonPctCommission.AutoSize = true;
            this.radioButtonPctCommission.Location = new System.Drawing.Point(96, 2);
            this.radioButtonPctCommission.Name = "radioButtonPctCommission";
            this.radioButtonPctCommission.Size = new System.Drawing.Size(59, 16);
            this.radioButtonPctCommission.TabIndex = 1;
            this.radioButtonPctCommission.TabStop = true;
            this.radioButtonPctCommission.Text = "相对值";
            this.radioButtonPctCommission.UseVisualStyleBackColor = true;
            // 
            // radioButtonAbsCommission
            // 
            this.radioButtonAbsCommission.AutoSize = true;
            this.radioButtonAbsCommission.Location = new System.Drawing.Point(3, 2);
            this.radioButtonAbsCommission.Name = "radioButtonAbsCommission";
            this.radioButtonAbsCommission.Size = new System.Drawing.Size(59, 16);
            this.radioButtonAbsCommission.TabIndex = 0;
            this.radioButtonAbsCommission.TabStop = true;
            this.radioButtonAbsCommission.Text = "固定值";
            this.radioButtonAbsCommission.UseVisualStyleBackColor = true;
            // 
            // labelCommissionMode
            // 
            this.labelCommissionMode.AutoSize = true;
            this.labelCommissionMode.Location = new System.Drawing.Point(19, 80);
            this.labelCommissionMode.Name = "labelCommissionMode";
            this.labelCommissionMode.Size = new System.Drawing.Size(77, 12);
            this.labelCommissionMode.TabIndex = 11;
            this.labelCommissionMode.Text = "手续费模式：";
            // 
            // textBoxMultiplier
            // 
            this.textBoxMultiplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMultiplier.Location = new System.Drawing.Point(114, 166);
            this.textBoxMultiplier.Name = "textBoxMultiplier";
            this.textBoxMultiplier.Size = new System.Drawing.Size(191, 21);
            this.textBoxMultiplier.TabIndex = 4;
            this.textBoxMultiplier.Text = "10";
            // 
            // labelMultiplier
            // 
            this.labelMultiplier.AutoSize = true;
            this.labelMultiplier.Location = new System.Drawing.Point(19, 169);
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
            this.textBoxMarginRate.Location = new System.Drawing.Point(114, 139);
            this.textBoxMarginRate.Name = "textBoxMarginRate";
            this.textBoxMarginRate.Size = new System.Drawing.Size(191, 21);
            this.textBoxMarginRate.TabIndex = 3;
            this.textBoxMarginRate.Text = "0.00";
            this.textBoxMarginRate.TextChanged += new System.EventHandler(this.textBoxMarginRate_TextChanged);
            // 
            // labelMarginRate
            // 
            this.labelMarginRate.AutoSize = true;
            this.labelMarginRate.Location = new System.Drawing.Point(19, 142);
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
            this.labelFuturesContractCode.Text = "期货合约代码：";
            // 
            // comboBoxUnderlyingCode
            // 
            this.comboBoxUnderlyingCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxUnderlyingCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUnderlyingCode.Location = new System.Drawing.Point(114, 47);
            this.comboBoxUnderlyingCode.Name = "comboBoxUnderlyingCode";
            this.comboBoxUnderlyingCode.Size = new System.Drawing.Size(191, 20);
            this.comboBoxUnderlyingCode.TabIndex = 1;
            // 
            // textBoxFuturesContractCode
            // 
            this.textBoxFuturesContractCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFuturesContractCode.Location = new System.Drawing.Point(114, 20);
            this.textBoxFuturesContractCode.Name = "textBoxFuturesContractCode";
            this.textBoxFuturesContractCode.Size = new System.Drawing.Size(191, 21);
            this.textBoxFuturesContractCode.TabIndex = 0;
            // 
            // labelUnderlyingCode
            // 
            this.labelUnderlyingCode.AutoSize = true;
            this.labelUnderlyingCode.Location = new System.Drawing.Point(19, 50);
            this.labelUnderlyingCode.Name = "labelUnderlyingCode";
            this.labelUnderlyingCode.Size = new System.Drawing.Size(65, 12);
            this.labelUnderlyingCode.TabIndex = 2;
            this.labelUnderlyingCode.Text = "期货标的：";
            // 
            // textBoxCommission
            // 
            this.textBoxCommission.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCommission.Location = new System.Drawing.Point(114, 112);
            this.textBoxCommission.Name = "textBoxCommission";
            this.textBoxCommission.Size = new System.Drawing.Size(191, 21);
            this.textBoxCommission.TabIndex = 2;
            this.textBoxCommission.Text = "0.00";
            // 
            // labelCommission
            // 
            this.labelCommission.AutoSize = true;
            this.labelCommission.Location = new System.Drawing.Point(19, 115);
            this.labelCommission.Name = "labelCommission";
            this.labelCommission.Size = new System.Drawing.Size(65, 12);
            this.labelCommission.TabIndex = 1;
            this.labelCommission.Text = "手续费率：";
            // 
            // FormAddFuturesContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 314);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxAddFuturesContract);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddFuturesContract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加期货合约";
            this.groupBoxAddFuturesContract.ResumeLayout(false);
            this.groupBoxAddFuturesContract.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.GroupBox groupBoxAddFuturesContract;
        private System.Windows.Forms.Label labelFuturesContractCode;
        private System.Windows.Forms.ComboBox comboBoxUnderlyingCode;
        private System.Windows.Forms.TextBox textBoxFuturesContractCode;
        private System.Windows.Forms.Label labelUnderlyingCode;
        private System.Windows.Forms.TextBox textBoxCommission;
        private System.Windows.Forms.Label labelCommission;
        private System.Windows.Forms.TextBox textBoxMultiplier;
        private System.Windows.Forms.Label labelMultiplier;
        private System.Windows.Forms.TextBox textBoxMarginRate;
        private System.Windows.Forms.Label labelMarginRate;
        private System.Windows.Forms.Label labelCommissionMode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonPctCommission;
        private System.Windows.Forms.RadioButton radioButtonAbsCommission;
        private System.Windows.Forms.TextBox textBoxVolatility;
        private System.Windows.Forms.Label labelVolatility;
        private System.Windows.Forms.TextBox textBoxPreSettle;
        private System.Windows.Forms.Label labelPreSettle;
    }
}