namespace OTC
{
    partial class FormModifyCommodity
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
            this.groupBoxAddCommodity = new System.Windows.Forms.GroupBox();
            this.comboBoxCommodityCode = new System.Windows.Forms.ComboBox();
            this.labelCommodityCode = new System.Windows.Forms.Label();
            this.textBoxCommodityName = new System.Windows.Forms.TextBox();
            this.labelCommodityName = new System.Windows.Forms.Label();
            this.groupBoxAddCommodity.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(200, 107);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(76, 23);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(111, 107);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 13;
            this.buttonOK.Text = "确定";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // groupBoxAddCommodity
            // 
            this.groupBoxAddCommodity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAddCommodity.Controls.Add(this.comboBoxCommodityCode);
            this.groupBoxAddCommodity.Controls.Add(this.labelCommodityCode);
            this.groupBoxAddCommodity.Controls.Add(this.textBoxCommodityName);
            this.groupBoxAddCommodity.Controls.Add(this.labelCommodityName);
            this.groupBoxAddCommodity.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAddCommodity.Name = "groupBoxAddCommodity";
            this.groupBoxAddCommodity.Size = new System.Drawing.Size(265, 89);
            this.groupBoxAddCommodity.TabIndex = 12;
            this.groupBoxAddCommodity.TabStop = false;
            this.groupBoxAddCommodity.Text = "商品信息";
            // 
            // comboBoxCommodityCode
            // 
            this.comboBoxCommodityCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCommodityCode.FormattingEnabled = true;
            this.comboBoxCommodityCode.Location = new System.Drawing.Point(90, 20);
            this.comboBoxCommodityCode.Name = "comboBoxCommodityCode";
            this.comboBoxCommodityCode.Size = new System.Drawing.Size(169, 20);
            this.comboBoxCommodityCode.TabIndex = 5;
            this.comboBoxCommodityCode.SelectedIndexChanged += new System.EventHandler(this.comboBoxCommodityCode_SelectedIndexChanged);
            // 
            // labelCommodityCode
            // 
            this.labelCommodityCode.AutoSize = true;
            this.labelCommodityCode.Location = new System.Drawing.Point(19, 23);
            this.labelCommodityCode.Name = "labelCommodityCode";
            this.labelCommodityCode.Size = new System.Drawing.Size(65, 12);
            this.labelCommodityCode.TabIndex = 0;
            this.labelCommodityCode.Text = "商品代码：";
            // 
            // textBoxCommodityName
            // 
            this.textBoxCommodityName.Location = new System.Drawing.Point(90, 51);
            this.textBoxCommodityName.Name = "textBoxCommodityName";
            this.textBoxCommodityName.Size = new System.Drawing.Size(169, 21);
            this.textBoxCommodityName.TabIndex = 4;
            // 
            // labelCommodityName
            // 
            this.labelCommodityName.AutoSize = true;
            this.labelCommodityName.Location = new System.Drawing.Point(19, 54);
            this.labelCommodityName.Name = "labelCommodityName";
            this.labelCommodityName.Size = new System.Drawing.Size(65, 12);
            this.labelCommodityName.TabIndex = 1;
            this.labelCommodityName.Text = "商品名称：";
            // 
            // FormModifyCommodity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 149);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxAddCommodity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormModifyCommodity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改商品种类";
            this.groupBoxAddCommodity.ResumeLayout(false);
            this.groupBoxAddCommodity.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.GroupBox groupBoxAddCommodity;
        private System.Windows.Forms.Label labelCommodityCode;
        private System.Windows.Forms.TextBox textBoxCommodityName;
        private System.Windows.Forms.Label labelCommodityName;
        private System.Windows.Forms.ComboBox comboBoxCommodityCode;
    }
}