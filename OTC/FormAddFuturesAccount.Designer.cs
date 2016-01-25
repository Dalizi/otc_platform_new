namespace OTC
{
    partial class FormAddFuturesAccount
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
            this.groupBoxAddFutuersAccount = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxFuturesAccount = new System.Windows.Forms.MaskedTextBox();
            this.labelFuturesAccountNO = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxAddFutuersAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAddFutuersAccount
            // 
            this.groupBoxAddFutuersAccount.Controls.Add(this.maskedTextBoxFuturesAccount);
            this.groupBoxAddFutuersAccount.Controls.Add(this.labelFuturesAccountNO);
            this.groupBoxAddFutuersAccount.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAddFutuersAccount.Name = "groupBoxAddFutuersAccount";
            this.groupBoxAddFutuersAccount.Size = new System.Drawing.Size(179, 55);
            this.groupBoxAddFutuersAccount.TabIndex = 0;
            this.groupBoxAddFutuersAccount.TabStop = false;
            this.groupBoxAddFutuersAccount.Text = "期货账户信息";
            // 
            // maskedTextBoxFuturesAccount
            // 
            this.maskedTextBoxFuturesAccount.Location = new System.Drawing.Point(98, 18);
            this.maskedTextBoxFuturesAccount.Mask = "99999999";
            this.maskedTextBoxFuturesAccount.Name = "maskedTextBoxFuturesAccount";
            this.maskedTextBoxFuturesAccount.Size = new System.Drawing.Size(60, 21);
            this.maskedTextBoxFuturesAccount.TabIndex = 1;
            this.maskedTextBoxFuturesAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelFuturesAccountNO
            // 
            this.labelFuturesAccountNO.AutoSize = true;
            this.labelFuturesAccountNO.Location = new System.Drawing.Point(7, 21);
            this.labelFuturesAccountNO.Name = "labelFuturesAccountNO";
            this.labelFuturesAccountNO.Size = new System.Drawing.Size(65, 12);
            this.labelFuturesAccountNO.TabIndex = 0;
            this.labelFuturesAccountNO.Text = "期货账号：";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(21, 73);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "添加";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(110, 72);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormAddFuturesAccount
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(201, 107);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxAddFutuersAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddFuturesAccount";
            this.Text = "添加期货账号";
            this.groupBoxAddFutuersAccount.ResumeLayout(false);
            this.groupBoxAddFutuersAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAddFutuersAccount;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFuturesAccount;
        private System.Windows.Forms.Label labelFuturesAccountNO;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}