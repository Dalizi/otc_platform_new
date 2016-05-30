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
            this.groupBoxRedisConfig = new System.Windows.Forms.GroupBox();
            this.textBoxRedisHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRedisPort = new System.Windows.Forms.TextBox();
            this.labelRedisPassword = new System.Windows.Forms.Label();
            this.textBoxRedisPassword = new System.Windows.Forms.TextBox();
            this.groupBoxConfig.SuspendLayout();
            this.groupBoxRedisConfig.SuspendLayout();
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
            this.labelPort.Location = new System.Drawing.Point(20, 46);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(41, 12);
            this.labelPort.TabIndex = 2;
            this.labelPort.Text = "端口：";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(85, 43);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(100, 21);
            this.textBoxPort.TabIndex = 2;
            // 
            // textBoxDatabase
            // 
            this.textBoxDatabase.Location = new System.Drawing.Point(85, 70);
            this.textBoxDatabase.Name = "textBoxDatabase";
            this.textBoxDatabase.Size = new System.Drawing.Size(100, 21);
            this.textBoxDatabase.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 73);
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
            this.groupBoxConfig.Size = new System.Drawing.Size(215, 102);
            this.groupBoxConfig.TabIndex = 6;
            this.groupBoxConfig.TabStop = false;
            this.groupBoxConfig.Text = "MySQL配置";
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
            this.buttonAccept.Location = new System.Drawing.Point(292, 144);
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
            this.buttonCancel.Location = new System.Drawing.Point(373, 144);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBoxRedisConfig
            // 
            this.groupBoxRedisConfig.Controls.Add(this.labelRedisPassword);
            this.groupBoxRedisConfig.Controls.Add(this.textBoxRedisPassword);
            this.groupBoxRedisConfig.Controls.Add(this.textBoxRedisHost);
            this.groupBoxRedisConfig.Controls.Add(this.label1);
            this.groupBoxRedisConfig.Controls.Add(this.label4);
            this.groupBoxRedisConfig.Controls.Add(this.textBoxRedisPort);
            this.groupBoxRedisConfig.Location = new System.Drawing.Point(233, 12);
            this.groupBoxRedisConfig.Name = "groupBoxRedisConfig";
            this.groupBoxRedisConfig.Size = new System.Drawing.Size(215, 102);
            this.groupBoxRedisConfig.TabIndex = 7;
            this.groupBoxRedisConfig.TabStop = false;
            this.groupBoxRedisConfig.Text = "Redis配置";
            // 
            // textBoxRedisHost
            // 
            this.textBoxRedisHost.Location = new System.Drawing.Point(85, 14);
            this.textBoxRedisHost.Name = "textBoxRedisHost";
            this.textBoxRedisHost.Size = new System.Drawing.Size(100, 21);
            this.textBoxRedisHost.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "主机地址:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "端口：";
            // 
            // textBoxRedisPort
            // 
            this.textBoxRedisPort.Location = new System.Drawing.Point(85, 43);
            this.textBoxRedisPort.Name = "textBoxRedisPort";
            this.textBoxRedisPort.Size = new System.Drawing.Size(100, 21);
            this.textBoxRedisPort.TabIndex = 2;
            // 
            // labelRedisPassword
            // 
            this.labelRedisPassword.AutoSize = true;
            this.labelRedisPassword.Location = new System.Drawing.Point(20, 73);
            this.labelRedisPassword.Name = "labelRedisPassword";
            this.labelRedisPassword.Size = new System.Drawing.Size(41, 12);
            this.labelRedisPassword.TabIndex = 3;
            this.labelRedisPassword.Text = "密码：";
            // 
            // textBoxRedisPassword
            // 
            this.textBoxRedisPassword.Location = new System.Drawing.Point(85, 70);
            this.textBoxRedisPassword.Name = "textBoxRedisPassword";
            this.textBoxRedisPassword.Size = new System.Drawing.Size(100, 21);
            this.textBoxRedisPassword.TabIndex = 4;
            this.textBoxRedisPassword.UseSystemPasswordChar = true;
            // 
            // FormLoginConfig
            // 
            this.AcceptButton = this.buttonAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(460, 179);
            this.Controls.Add(this.groupBoxRedisConfig);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.groupBoxConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLoginConfig";
            this.Text = "登录配置";
            this.groupBoxConfig.ResumeLayout(false);
            this.groupBoxConfig.PerformLayout();
            this.groupBoxRedisConfig.ResumeLayout(false);
            this.groupBoxRedisConfig.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxRedisConfig;
        private System.Windows.Forms.TextBox textBoxRedisHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRedisPort;
        private System.Windows.Forms.Label labelRedisPassword;
        private System.Windows.Forms.TextBox textBoxRedisPassword;
    }
}