namespace OTC
{
    partial class FromModifyGrants
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelPrevGrants = new System.Windows.Forms.Label();
            this.textBoxPrevGrants = new System.Windows.Forms.TextBox();
            this.textBoxNewGrants = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(98, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(179, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelPrevGrants
            // 
            this.labelPrevGrants.AutoSize = true;
            this.labelPrevGrants.Location = new System.Drawing.Point(12, 20);
            this.labelPrevGrants.Name = "labelPrevGrants";
            this.labelPrevGrants.Size = new System.Drawing.Size(77, 12);
            this.labelPrevGrants.TabIndex = 2;
            this.labelPrevGrants.Text = "原占用额度：";
            // 
            // textBoxPrevGrants
            // 
            this.textBoxPrevGrants.Location = new System.Drawing.Point(95, 17);
            this.textBoxPrevGrants.Name = "textBoxPrevGrants";
            this.textBoxPrevGrants.ReadOnly = true;
            this.textBoxPrevGrants.Size = new System.Drawing.Size(155, 21);
            this.textBoxPrevGrants.TabIndex = 3;
            this.textBoxPrevGrants.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxNewGrants
            // 
            this.textBoxNewGrants.Location = new System.Drawing.Point(95, 50);
            this.textBoxNewGrants.Name = "textBoxNewGrants";
            this.textBoxNewGrants.Size = new System.Drawing.Size(155, 21);
            this.textBoxNewGrants.TabIndex = 5;
            this.textBoxNewGrants.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "新占用额度：";
            // 
            // FromModifyGrants
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(262, 129);
            this.Controls.Add(this.textBoxNewGrants);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPrevGrants);
            this.Controls.Add(this.labelPrevGrants);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FromModifyGrants";
            this.Text = "变更占用额度";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelPrevGrants;
        private System.Windows.Forms.TextBox textBoxPrevGrants;
        private System.Windows.Forms.TextBox textBoxNewGrants;
        private System.Windows.Forms.Label label1;
    }
}