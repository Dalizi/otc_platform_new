namespace OTC
{
    partial class FormAddClient
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
            this.labelClientId = new System.Windows.Forms.Label();
            this.labelClientName = new System.Windows.Forms.Label();
            this.labelFuturesAccount = new System.Windows.Forms.Label();
            this.textBoxClientId = new System.Windows.Forms.TextBox();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.comboBoxFuturesAccount = new System.Windows.Forms.ComboBox();
            this.groupBoxAddClient = new System.Windows.Forms.GroupBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxValidationCode = new System.Windows.Forms.TextBox();
            this.labelValidationCode = new System.Windows.Forms.Label();
            this.groupBoxAddClient.SuspendLayout();
            this.SuspendLayout();
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
            // labelClientName
            // 
            this.labelClientName.AutoSize = true;
            this.labelClientName.Location = new System.Drawing.Point(19, 54);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(65, 12);
            this.labelClientName.TabIndex = 1;
            this.labelClientName.Text = "客户名称：";
            // 
            // labelFuturesAccount
            // 
            this.labelFuturesAccount.AutoSize = true;
            this.labelFuturesAccount.Location = new System.Drawing.Point(19, 85);
            this.labelFuturesAccount.Name = "labelFuturesAccount";
            this.labelFuturesAccount.Size = new System.Drawing.Size(59, 12);
            this.labelFuturesAccount.TabIndex = 2;
            this.labelFuturesAccount.Text = "对冲账号:";
            // 
            // textBoxClientId
            // 
            this.textBoxClientId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientId.Location = new System.Drawing.Point(90, 20);
            this.textBoxClientId.Name = "textBoxClientId";
            this.textBoxClientId.ReadOnly = true;
            this.textBoxClientId.Size = new System.Drawing.Size(168, 21);
            this.textBoxClientId.TabIndex = 3;
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientName.Location = new System.Drawing.Point(90, 51);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(168, 21);
            this.textBoxClientName.TabIndex = 4;
            // 
            // comboBoxFuturesAccount
            // 
            this.comboBoxFuturesAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFuturesAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFuturesAccount.Location = new System.Drawing.Point(90, 82);
            this.comboBoxFuturesAccount.Name = "comboBoxFuturesAccount";
            this.comboBoxFuturesAccount.Size = new System.Drawing.Size(168, 20);
            this.comboBoxFuturesAccount.TabIndex = 5;
            // 
            // groupBoxAddClient
            // 
            this.groupBoxAddClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAddClient.Controls.Add(this.textBoxValidationCode);
            this.groupBoxAddClient.Controls.Add(this.labelValidationCode);
            this.groupBoxAddClient.Controls.Add(this.labelClientId);
            this.groupBoxAddClient.Controls.Add(this.comboBoxFuturesAccount);
            this.groupBoxAddClient.Controls.Add(this.textBoxClientId);
            this.groupBoxAddClient.Controls.Add(this.labelFuturesAccount);
            this.groupBoxAddClient.Controls.Add(this.textBoxClientName);
            this.groupBoxAddClient.Controls.Add(this.labelClientName);
            this.groupBoxAddClient.Location = new System.Drawing.Point(18, 11);
            this.groupBoxAddClient.Name = "groupBoxAddClient";
            this.groupBoxAddClient.Size = new System.Drawing.Size(274, 146);
            this.groupBoxAddClient.TabIndex = 6;
            this.groupBoxAddClient.TabStop = false;
            this.groupBoxAddClient.Text = "客户信息";
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(121, 180);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "确定";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(214, 180);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(78, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxValidationCode
            // 
            this.textBoxValidationCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxValidationCode.Location = new System.Drawing.Point(102, 113);
            this.textBoxValidationCode.Name = "textBoxValidationCode";
            this.textBoxValidationCode.Size = new System.Drawing.Size(156, 21);
            this.textBoxValidationCode.TabIndex = 7;
            // 
            // labelValidationCode
            // 
            this.labelValidationCode.AutoSize = true;
            this.labelValidationCode.Location = new System.Drawing.Point(19, 116);
            this.labelValidationCode.Name = "labelValidationCode";
            this.labelValidationCode.Size = new System.Drawing.Size(77, 12);
            this.labelValidationCode.TabIndex = 6;
            this.labelValidationCode.Text = "下单验证码：";
            // 
            // FormAddClient
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(308, 230);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxAddClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(328, 237);
            this.Name = "FormAddClient";
            this.Text = "添加客户";
            this.groupBoxAddClient.ResumeLayout(false);
            this.groupBoxAddClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelClientId;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.Label labelFuturesAccount;
        private System.Windows.Forms.TextBox textBoxClientId;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.ComboBox comboBoxFuturesAccount;
        private System.Windows.Forms.GroupBox groupBoxAddClient;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxValidationCode;
        private System.Windows.Forms.Label labelValidationCode;
    }
}