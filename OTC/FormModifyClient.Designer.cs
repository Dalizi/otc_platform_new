namespace OTC
{
    partial class FormModifyClient
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
            this.groupBoxAddClient = new System.Windows.Forms.GroupBox();
            this.comboBoxClientID = new System.Windows.Forms.ComboBox();
            this.labelClientId = new System.Windows.Forms.Label();
            this.comboBoxFuturesAccount = new System.Windows.Forms.ComboBox();
            this.labelFuturesAccount = new System.Windows.Forms.Label();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.labelClientName = new System.Windows.Forms.Label();
            this.textBoxValidationCode = new System.Windows.Forms.TextBox();
            this.labelValidationCode = new System.Windows.Forms.Label();
            this.groupBoxAddClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(224, 175);
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
            this.buttonOK.Location = new System.Drawing.Point(131, 175);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "确定";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // groupBoxAddClient
            // 
            this.groupBoxAddClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAddClient.Controls.Add(this.textBoxValidationCode);
            this.groupBoxAddClient.Controls.Add(this.labelValidationCode);
            this.groupBoxAddClient.Controls.Add(this.comboBoxClientID);
            this.groupBoxAddClient.Controls.Add(this.labelClientId);
            this.groupBoxAddClient.Controls.Add(this.comboBoxFuturesAccount);
            this.groupBoxAddClient.Controls.Add(this.labelFuturesAccount);
            this.groupBoxAddClient.Controls.Add(this.textBoxClientName);
            this.groupBoxAddClient.Controls.Add(this.labelClientName);
            this.groupBoxAddClient.Location = new System.Drawing.Point(22, 17);
            this.groupBoxAddClient.Name = "groupBoxAddClient";
            this.groupBoxAddClient.Size = new System.Drawing.Size(280, 140);
            this.groupBoxAddClient.TabIndex = 9;
            this.groupBoxAddClient.TabStop = false;
            this.groupBoxAddClient.Text = "客户信息";
            // 
            // comboBoxClientID
            // 
            this.comboBoxClientID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClientID.FormattingEnabled = true;
            this.comboBoxClientID.Location = new System.Drawing.Point(91, 21);
            this.comboBoxClientID.Name = "comboBoxClientID";
            this.comboBoxClientID.Size = new System.Drawing.Size(183, 20);
            this.comboBoxClientID.TabIndex = 6;
            this.comboBoxClientID.SelectedIndexChanged += new System.EventHandler(this.comboBoxClientID_SelectedIndexChanged);
            // 
            // labelClientId
            // 
            this.labelClientId.AutoSize = true;
            this.labelClientId.Location = new System.Drawing.Point(19, 23);
            this.labelClientId.Name = "labelClientId";
            this.labelClientId.Size = new System.Drawing.Size(65, 12);
            this.labelClientId.TabIndex = 0;
            this.labelClientId.Text = "客户编号：";
            // 
            // comboBoxFuturesAccount
            // 
            this.comboBoxFuturesAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFuturesAccount.Location = new System.Drawing.Point(90, 82);
            this.comboBoxFuturesAccount.Name = "comboBoxFuturesAccount";
            this.comboBoxFuturesAccount.Size = new System.Drawing.Size(184, 20);
            this.comboBoxFuturesAccount.TabIndex = 5;
            // 
            // labelFuturesAccount
            // 
            this.labelFuturesAccount.AutoSize = true;
            this.labelFuturesAccount.Location = new System.Drawing.Point(19, 85);
            this.labelFuturesAccount.Name = "labelFuturesAccount";
            this.labelFuturesAccount.Size = new System.Drawing.Size(59, 12);
            this.labelFuturesAccount.TabIndex = 2;
            this.labelFuturesAccount.Text = "期货账号:";
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Location = new System.Drawing.Point(90, 51);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(184, 21);
            this.textBoxClientName.TabIndex = 4;
            // 
            // labelClientName
            // 
            this.labelClientName.AutoSize = true;
            this.labelClientName.Location = new System.Drawing.Point(19, 54);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(65, 12);
            this.labelClientName.TabIndex = 1;
            this.labelClientName.Text = "客户名称：";
            // 
            // textBoxValidationCode
            // 
            this.textBoxValidationCode.Location = new System.Drawing.Point(102, 108);
            this.textBoxValidationCode.Name = "textBoxValidationCode";
            this.textBoxValidationCode.Size = new System.Drawing.Size(172, 21);
            this.textBoxValidationCode.TabIndex = 8;
            // 
            // labelValidationCode
            // 
            this.labelValidationCode.AutoSize = true;
            this.labelValidationCode.Location = new System.Drawing.Point(19, 111);
            this.labelValidationCode.Name = "labelValidationCode";
            this.labelValidationCode.Size = new System.Drawing.Size(77, 12);
            this.labelValidationCode.TabIndex = 7;
            this.labelValidationCode.Text = "下单验证码：";
            // 
            // FormModifyClient
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(324, 218);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxAddClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormModifyClient";
            this.Text = "客户信息修改";
            this.groupBoxAddClient.ResumeLayout(false);
            this.groupBoxAddClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.GroupBox groupBoxAddClient;
        private System.Windows.Forms.Label labelClientId;
        private System.Windows.Forms.ComboBox comboBoxFuturesAccount;
        private System.Windows.Forms.Label labelFuturesAccount;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.ComboBox comboBoxClientID;
        private System.Windows.Forms.TextBox textBoxValidationCode;
        private System.Windows.Forms.Label labelValidationCode;
    }
}