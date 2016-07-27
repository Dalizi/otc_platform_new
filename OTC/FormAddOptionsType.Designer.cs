namespace OTC
{
    partial class FormAddOptionsType
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
            this.groupBoxAddOptionsType = new System.Windows.Forms.GroupBox();
            this.labelOptionsTypeCode = new System.Windows.Forms.Label();
            this.textBoxOptionsTypeCode = new System.Windows.Forms.TextBox();
            this.textBoxOptionsTypeName = new System.Windows.Forms.TextBox();
            this.labelOptionsTypeName = new System.Windows.Forms.Label();
            this.groupBoxAddOptionsType.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(189, 115);
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
            this.buttonOK.Location = new System.Drawing.Point(100, 115);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "确定";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // groupBoxAddOptionsType
            // 
            this.groupBoxAddOptionsType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAddOptionsType.Controls.Add(this.labelOptionsTypeCode);
            this.groupBoxAddOptionsType.Controls.Add(this.textBoxOptionsTypeCode);
            this.groupBoxAddOptionsType.Controls.Add(this.textBoxOptionsTypeName);
            this.groupBoxAddOptionsType.Controls.Add(this.labelOptionsTypeName);
            this.groupBoxAddOptionsType.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAddOptionsType.Name = "groupBoxAddOptionsType";
            this.groupBoxAddOptionsType.Size = new System.Drawing.Size(254, 89);
            this.groupBoxAddOptionsType.TabIndex = 9;
            this.groupBoxAddOptionsType.TabStop = false;
            this.groupBoxAddOptionsType.Text = "期权信息";
            // 
            // labelOptionsTypeCode
            // 
            this.labelOptionsTypeCode.AutoSize = true;
            this.labelOptionsTypeCode.Location = new System.Drawing.Point(19, 23);
            this.labelOptionsTypeCode.Name = "labelOptionsTypeCode";
            this.labelOptionsTypeCode.Size = new System.Drawing.Size(89, 12);
            this.labelOptionsTypeCode.TabIndex = 0;
            this.labelOptionsTypeCode.Text = "期权类型代码：";
            // 
            // textBoxOptionsTypeCode
            // 
            this.textBoxOptionsTypeCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOptionsTypeCode.Location = new System.Drawing.Point(114, 20);
            this.textBoxOptionsTypeCode.Name = "textBoxOptionsTypeCode";
            this.textBoxOptionsTypeCode.Size = new System.Drawing.Size(130, 21);
            this.textBoxOptionsTypeCode.TabIndex = 3;
            // 
            // textBoxOptionsTypeName
            // 
            this.textBoxOptionsTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOptionsTypeName.Location = new System.Drawing.Point(114, 51);
            this.textBoxOptionsTypeName.Name = "textBoxOptionsTypeName";
            this.textBoxOptionsTypeName.Size = new System.Drawing.Size(131, 21);
            this.textBoxOptionsTypeName.TabIndex = 4;
            // 
            // labelOptionsTypeName
            // 
            this.labelOptionsTypeName.AutoSize = true;
            this.labelOptionsTypeName.Location = new System.Drawing.Point(19, 54);
            this.labelOptionsTypeName.Name = "labelOptionsTypeName";
            this.labelOptionsTypeName.Size = new System.Drawing.Size(89, 12);
            this.labelOptionsTypeName.TabIndex = 1;
            this.labelOptionsTypeName.Text = "期权类型名称：";
            // 
            // FormAddOptionsType
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(271, 149);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxAddOptionsType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddOptionsType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加期权种类";
            this.groupBoxAddOptionsType.ResumeLayout(false);
            this.groupBoxAddOptionsType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.GroupBox groupBoxAddOptionsType;
        private System.Windows.Forms.TextBox textBoxOptionsTypeCode;
        private System.Windows.Forms.TextBox textBoxOptionsTypeName;
        private System.Windows.Forms.Label labelOptionsTypeName;
        private System.Windows.Forms.Label labelOptionsTypeCode;
    }
}