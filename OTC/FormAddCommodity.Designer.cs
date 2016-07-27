namespace OTC
{
    partial class FormAddCommodity
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
            this.labelCommodityCode = new System.Windows.Forms.Label();
            this.textBoxCommodityCode = new System.Windows.Forms.TextBox();
            this.textBoxCommodityName = new System.Windows.Forms.TextBox();
            this.labelCommodityName = new System.Windows.Forms.Label();
            this.groupBoxAddCommodity.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(187, 115);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(76, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(98, 115);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "确定";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // groupBoxAddCommodity
            // 
            this.groupBoxAddCommodity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAddCommodity.Controls.Add(this.labelCommodityCode);
            this.groupBoxAddCommodity.Controls.Add(this.textBoxCommodityCode);
            this.groupBoxAddCommodity.Controls.Add(this.textBoxCommodityName);
            this.groupBoxAddCommodity.Controls.Add(this.labelCommodityName);
            this.groupBoxAddCommodity.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAddCommodity.Name = "groupBoxAddCommodity";
            this.groupBoxAddCommodity.Size = new System.Drawing.Size(252, 89);
            this.groupBoxAddCommodity.TabIndex = 9;
            this.groupBoxAddCommodity.TabStop = false;
            this.groupBoxAddCommodity.Text = "商品信息";
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
            // textBoxCommodityCode
            // 
            this.textBoxCommodityCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCommodityCode.Location = new System.Drawing.Point(90, 20);
            this.textBoxCommodityCode.Name = "textBoxCommodityCode";
            this.textBoxCommodityCode.Size = new System.Drawing.Size(152, 21);
            this.textBoxCommodityCode.TabIndex = 3;
            // 
            // textBoxCommodityName
            // 
            this.textBoxCommodityName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCommodityName.Location = new System.Drawing.Point(90, 51);
            this.textBoxCommodityName.Name = "textBoxCommodityName";
            this.textBoxCommodityName.Size = new System.Drawing.Size(153, 21);
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
            // FormAddCommodity
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(269, 149);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxAddCommodity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddCommodity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加商品种类";
            this.groupBoxAddCommodity.ResumeLayout(false);
            this.groupBoxAddCommodity.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.GroupBox groupBoxAddCommodity;
        private System.Windows.Forms.TextBox textBoxCommodityCode;
        private System.Windows.Forms.TextBox textBoxCommodityName;
        private System.Windows.Forms.Label labelCommodityName;
        private System.Windows.Forms.Label labelCommodityCode;
    }
}