namespace OTC
{
    partial class Login
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
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.loginInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonConfig = new System.Windows.Forms.Button();
            this.checkBoxRememberLoginInfo = new System.Windows.Forms.CheckBox();
            this.loginInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelUserName.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelUserName.Location = new System.Drawing.Point(9, 23);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(53, 12);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "用户名：";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(21, 46);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(41, 12);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "密码：";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(78, 16);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(197, 21);
            this.textBoxUserName.TabIndex = 1;
            this.textBoxUserName.Text = "tanzehuan";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(78, 43);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(197, 21);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.Text = "80027111t";
            // 
            // loginInfoGroupBox
            // 
            this.loginInfoGroupBox.Controls.Add(this.checkBoxRememberLoginInfo);
            this.loginInfoGroupBox.Controls.Add(this.labelUserName);
            this.loginInfoGroupBox.Controls.Add(this.textBoxPassword);
            this.loginInfoGroupBox.Controls.Add(this.textBoxUserName);
            this.loginInfoGroupBox.Controls.Add(this.labelPassword);
            this.loginInfoGroupBox.Location = new System.Drawing.Point(12, 12);
            this.loginInfoGroupBox.Name = "loginInfoGroupBox";
            this.loginInfoGroupBox.Size = new System.Drawing.Size(301, 100);
            this.loginInfoGroupBox.TabIndex = 4;
            this.loginInfoGroupBox.TabStop = false;
            this.loginInfoGroupBox.Text = "登录信息";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogin.Location = new System.Drawing.Point(146, 130);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "登录";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(227, 130);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonConfig
            // 
            this.buttonConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonConfig.Location = new System.Drawing.Point(12, 130);
            this.buttonConfig.Name = "buttonConfig";
            this.buttonConfig.Size = new System.Drawing.Size(75, 23);
            this.buttonConfig.TabIndex = 3;
            this.buttonConfig.Text = "配置";
            this.buttonConfig.UseVisualStyleBackColor = true;
            this.buttonConfig.Click += new System.EventHandler(this.buttonConfig_Click);
            // 
            // checkBoxRememberLoginInfo
            // 
            this.checkBoxRememberLoginInfo.AutoSize = true;
            this.checkBoxRememberLoginInfo.Location = new System.Drawing.Point(197, 78);
            this.checkBoxRememberLoginInfo.Name = "checkBoxRememberLoginInfo";
            this.checkBoxRememberLoginInfo.Size = new System.Drawing.Size(96, 16);
            this.checkBoxRememberLoginInfo.TabIndex = 3;
            this.checkBoxRememberLoginInfo.Text = "记住登录信息";
            this.checkBoxRememberLoginInfo.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(331, 164);
            this.Controls.Add(this.buttonConfig);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.loginInfoGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "用户登录";
            this.loginInfoGroupBox.ResumeLayout(false);
            this.loginInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.GroupBox loginInfoGroupBox;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonConfig;
        private System.Windows.Forms.CheckBox checkBoxRememberLoginInfo;
    }
}