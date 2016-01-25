namespace OTC
{
    partial class FormFuturesAccountCashflow
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
            this.groupBoxClientCashFlow = new System.Windows.Forms.GroupBox();
            this.comboBoxFuturesAccount = new System.Windows.Forms.ComboBox();
            this.labelClientID = new System.Windows.Forms.Label();
            this.maskedTextBoxValue = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCashFlowType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBoxMemo = new System.Windows.Forms.GroupBox();
            this.richTextBoxMemo = new System.Windows.Forms.RichTextBox();
            this.groupBoxClientCashFlow.SuspendLayout();
            this.groupBoxMemo.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(414, 167);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(81, 22);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBoxClientCashFlow
            // 
            this.groupBoxClientCashFlow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxClientCashFlow.Controls.Add(this.comboBoxFuturesAccount);
            this.groupBoxClientCashFlow.Controls.Add(this.labelClientID);
            this.groupBoxClientCashFlow.Controls.Add(this.maskedTextBoxValue);
            this.groupBoxClientCashFlow.Controls.Add(this.label2);
            this.groupBoxClientCashFlow.Controls.Add(this.comboBoxCashFlowType);
            this.groupBoxClientCashFlow.Controls.Add(this.label1);
            this.groupBoxClientCashFlow.Location = new System.Drawing.Point(12, 16);
            this.groupBoxClientCashFlow.Name = "groupBoxClientCashFlow";
            this.groupBoxClientCashFlow.Size = new System.Drawing.Size(251, 125);
            this.groupBoxClientCashFlow.TabIndex = 14;
            this.groupBoxClientCashFlow.TabStop = false;
            this.groupBoxClientCashFlow.Text = "出入资信息";
            // 
            // comboBoxFuturesAccount
            // 
            this.comboBoxFuturesAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFuturesAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFuturesAccount.FormattingEnabled = true;
            this.comboBoxFuturesAccount.Location = new System.Drawing.Point(88, 46);
            this.comboBoxFuturesAccount.Name = "comboBoxFuturesAccount";
            this.comboBoxFuturesAccount.Size = new System.Drawing.Size(157, 20);
            this.comboBoxFuturesAccount.TabIndex = 5;
            // 
            // labelClientID
            // 
            this.labelClientID.AutoSize = true;
            this.labelClientID.Location = new System.Drawing.Point(25, 49);
            this.labelClientID.Name = "labelClientID";
            this.labelClientID.Size = new System.Drawing.Size(65, 12);
            this.labelClientID.TabIndex = 4;
            this.labelClientID.Text = "期货账号：";
            // 
            // maskedTextBoxValue
            // 
            this.maskedTextBoxValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxValue.Location = new System.Drawing.Point(88, 76);
            this.maskedTextBoxValue.Name = "maskedTextBoxValue";
            this.maskedTextBoxValue.Size = new System.Drawing.Size(157, 21);
            this.maskedTextBoxValue.TabIndex = 3;
            this.maskedTextBoxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "金额：";
            // 
            // comboBoxCashFlowType
            // 
            this.comboBoxCashFlowType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCashFlowType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCashFlowType.FormattingEnabled = true;
            this.comboBoxCashFlowType.Items.AddRange(new object[] {
            "入金",
            "出金"});
            this.comboBoxCashFlowType.Location = new System.Drawing.Point(88, 18);
            this.comboBoxCashFlowType.Name = "comboBoxCashFlowType";
            this.comboBoxCashFlowType.Size = new System.Drawing.Size(157, 20);
            this.comboBoxCashFlowType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "种类：";
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(332, 167);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 22);
            this.buttonOK.TabIndex = 15;
            this.buttonOK.Text = "确定";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // groupBoxMemo
            // 
            this.groupBoxMemo.Controls.Add(this.richTextBoxMemo);
            this.groupBoxMemo.Location = new System.Drawing.Point(286, 16);
            this.groupBoxMemo.Name = "groupBoxMemo";
            this.groupBoxMemo.Size = new System.Drawing.Size(209, 125);
            this.groupBoxMemo.TabIndex = 17;
            this.groupBoxMemo.TabStop = false;
            this.groupBoxMemo.Text = "备注(限100字）";
            // 
            // richTextBoxMemo
            // 
            this.richTextBoxMemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxMemo.Location = new System.Drawing.Point(3, 17);
            this.richTextBoxMemo.Name = "richTextBoxMemo";
            this.richTextBoxMemo.Size = new System.Drawing.Size(203, 105);
            this.richTextBoxMemo.TabIndex = 0;
            this.richTextBoxMemo.Text = "";
            // 
            // FormFuturesAccountCashflow
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(507, 205);
            this.Controls.Add(this.groupBoxMemo);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBoxClientCashFlow);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFuturesAccountCashflow";
            this.Text = "期货账户出入资";
            this.groupBoxClientCashFlow.ResumeLayout(false);
            this.groupBoxClientCashFlow.PerformLayout();
            this.groupBoxMemo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxClientCashFlow;
        private System.Windows.Forms.ComboBox comboBoxFuturesAccount;
        private System.Windows.Forms.Label labelClientID;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCashFlowType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.GroupBox groupBoxMemo;
        private System.Windows.Forms.RichTextBox richTextBoxMemo;
    }
}