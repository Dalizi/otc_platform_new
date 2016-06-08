namespace OTC
{
    partial class FormTradingDatesSetting
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
            this.panelTradeDay = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.listBoxNonTradeDay = new System.Windows.Forms.ListBox();
            this.buttonAddDay = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelTradeDay.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTradeDay
            // 
            this.panelTradeDay.Controls.Add(this.buttonSave);
            this.panelTradeDay.Controls.Add(this.buttonDelete);
            this.panelTradeDay.Controls.Add(this.listBoxNonTradeDay);
            this.panelTradeDay.Controls.Add(this.buttonAddDay);
            this.panelTradeDay.Controls.Add(this.dateTimePicker1);
            this.panelTradeDay.Controls.Add(this.buttonClose);
            this.panelTradeDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTradeDay.Location = new System.Drawing.Point(0, 0);
            this.panelTradeDay.Name = "panelTradeDay";
            this.panelTradeDay.Size = new System.Drawing.Size(398, 193);
            this.panelTradeDay.TabIndex = 0;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(154, 54);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(88, 23);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "删除非交易日";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // listBoxNonTradeDay
            // 
            this.listBoxNonTradeDay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxNonTradeDay.FormattingEnabled = true;
            this.listBoxNonTradeDay.ItemHeight = 12;
            this.listBoxNonTradeDay.Location = new System.Drawing.Point(13, 13);
            this.listBoxNonTradeDay.Name = "listBoxNonTradeDay";
            this.listBoxNonTradeDay.Size = new System.Drawing.Size(119, 148);
            this.listBoxNonTradeDay.TabIndex = 5;
            // 
            // buttonAddDay
            // 
            this.buttonAddDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddDay.Location = new System.Drawing.Point(292, 13);
            this.buttonAddDay.Name = "buttonAddDay";
            this.buttonAddDay.Size = new System.Drawing.Size(91, 23);
            this.buttonAddDay.TabIndex = 4;
            this.buttonAddDay.Text = "添加非交易日";
            this.buttonAddDay.UseVisualStyleBackColor = true;
            this.buttonAddDay.Click += new System.EventHandler(this.buttonAddDay_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(154, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(129, 21);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(308, 158);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "关闭";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(227, 158);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormTradingDatesSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 193);
            this.Controls.Add(this.panelTradeDay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTradingDatesSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "非交易日设定";
            this.panelTradeDay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTradeDay;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonAddDay;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox listBoxNonTradeDay;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
    }
}