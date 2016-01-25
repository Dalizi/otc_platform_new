namespace OTC
{
    partial class FormLoginConfig
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
            this.labelHostAddress = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxDatabase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxConfig = new System.Windows.Forms.GroupBox();
            this.textBoxHost = new System.Windows.Forms.TextBox();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHostAddress
            // 
            this.labelHostAddress.AutoSize = true;
            this.labelHostAddress.Location = new System.Drawing.Point(20, 17);
            this.labelHostAddress.Name = "labelHostAddress";
            this.labelHostAddress.Size = new System.Drawing.Size(59, 12);
            this.labelHostAddress.TabIndex = 0;
            this.labelHostAddress.Text = "主机地址:";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(20, 52);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(41, 12);
            this.labelPort.TabIndex = 2;
            this.labelPort.Text = "端口：";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(85, 49);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(100, 21);
            this.textBoxPort.TabIndex = 2;
            // 
            // textBoxDatabase
            // 
            this.textBoxDatabase.Location = new System.Drawing.Point(85, 78);
            this.textBoxDatabase.Name = "textBoxDatabase";
            this.textBoxDatabase.Size = new System.Drawing.Size(100, 21);
            this.textBoxDatabase.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "数据库：";
            // 
            // groupBoxConfig
            // 
            this.groupBoxConfig.Controls.Add(this.textBoxHost);
            this.groupBoxConfig.Controls.Add(this.labelHostAddress);
            this.groupBoxConfig.Controls.Add(this.textBoxDatabase);
            this.groupBoxConfig.Controls.Add(this.label3);
            this.groupBoxConfig.Controls.Add(this.labelPort);
            this.groupBoxConfig.Controls.Add(this.textBoxPort);
            this.groupBoxConfig.Location = new System.Drawing.Point(12, 12);
            this.groupBoxConfig.Name = "groupBoxConfig";
            this.groupBoxConfig.Size = new System.Drawing.Size(215, 121);
            this.groupBoxConfig.TabIndex = 6;
            this.groupBoxConfig.TabStop = false;
            this.groupBoxConfig.Text = "配置";
            // 
            // textBoxHost
            // 
            this.textBoxHost.Location = new System.Drawing.Point(85, 14);
            this.textBoxHost.Name = "textBoxHost";
            this.textBoxHost.Size = new System.Drawing.Size(100, 21);
            this.textBoxHost.TabIndex = 1;
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(80, 149);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 7;
            this.buttonAccept.Text = "确定";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(161, 149);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormLoginConfig
            // 
            this.AcceptButton = this.buttonAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(248, 187);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.groupBoxConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(264, 226);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(264, 226);
            this.Name = "FormLoginConfig";
            this.Text = "登录配置";
            this.groupBoxConfig.ResumeLayout(false);
            this.groupBoxConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelHostAddress;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxDatabase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxConfig;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxHost;
    }
}