namespace OTC
{
    partial class FormSettlement
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxSettleInfo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewOptionInfo = new System.Windows.Forms.DataGridView();
            this.dataGridViewFutureInfo = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonGetFutureSettlePrice = new System.Windows.Forms.Button();
            this.dateTimePickerSettleDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxSettleInfo.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOptionInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFutureInfo)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBoxSettleInfo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1072, 402);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBoxSettleInfo
            // 
            this.groupBoxSettleInfo.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxSettleInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSettleInfo.Location = new System.Drawing.Point(3, 33);
            this.groupBoxSettleInfo.Name = "groupBoxSettleInfo";
            this.groupBoxSettleInfo.Size = new System.Drawing.Size(1066, 326);
            this.groupBoxSettleInfo.TabIndex = 0;
            this.groupBoxSettleInfo.TabStop = false;
            this.groupBoxSettleInfo.Text = "结算信息一览";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewOptionInfo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewFutureInfo, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1060, 306);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dataGridViewOptionInfo
            // 
            this.dataGridViewOptionInfo.AllowUserToAddRows = false;
            this.dataGridViewOptionInfo.AllowUserToDeleteRows = false;
            this.dataGridViewOptionInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewOptionInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOptionInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOptionInfo.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewOptionInfo.Name = "dataGridViewOptionInfo";
            this.dataGridViewOptionInfo.RowTemplate.Height = 23;
            this.dataGridViewOptionInfo.Size = new System.Drawing.Size(651, 300);
            this.dataGridViewOptionInfo.TabIndex = 0;
            // 
            // dataGridViewFutureInfo
            // 
            this.dataGridViewFutureInfo.AllowUserToAddRows = false;
            this.dataGridViewFutureInfo.AllowUserToDeleteRows = false;
            this.dataGridViewFutureInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewFutureInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFutureInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFutureInfo.Location = new System.Drawing.Point(660, 3);
            this.dataGridViewFutureInfo.Name = "dataGridViewFutureInfo";
            this.dataGridViewFutureInfo.RowTemplate.Height = 23;
            this.dataGridViewFutureInfo.Size = new System.Drawing.Size(397, 300);
            this.dataGridViewFutureInfo.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.Controls.Add(this.buttonOK, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonCancel, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 365);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1066, 34);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // buttonOK
            // 
            this.buttonOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOK.Location = new System.Drawing.Point(869, 3);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(94, 28);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "结算";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCancel.Location = new System.Drawing.Point(969, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 28);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelError);
            this.panel1.Controls.Add(this.buttonGetFutureSettlePrice);
            this.panel1.Controls.Add(this.dateTimePickerSettleDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 24);
            this.panel1.TabIndex = 2;
            // 
            // buttonGetFutureSettlePrice
            // 
            this.buttonGetFutureSettlePrice.Location = new System.Drawing.Point(960, 1);
            this.buttonGetFutureSettlePrice.Name = "buttonGetFutureSettlePrice";
            this.buttonGetFutureSettlePrice.Size = new System.Drawing.Size(103, 23);
            this.buttonGetFutureSettlePrice.TabIndex = 2;
            this.buttonGetFutureSettlePrice.Text = "获取期货结算价";
            this.buttonGetFutureSettlePrice.UseVisualStyleBackColor = true;
            this.buttonGetFutureSettlePrice.Click += new System.EventHandler(this.buttonGetFutureSettlePrice_Click);
            // 
            // dateTimePickerSettleDate
            // 
            this.dateTimePickerSettleDate.Location = new System.Drawing.Point(80, 0);
            this.dateTimePickerSettleDate.Name = "dateTimePickerSettleDate";
            this.dateTimePickerSettleDate.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerSettleDate.TabIndex = 1;
            this.dateTimePickerSettleDate.ValueChanged += new System.EventHandler(this.dateTimePickerSettleDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "结算日期：";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(287, 4);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(185, 12);
            this.labelError.TabIndex = 3;
            this.labelError.Text = "该日期之前存在未确认的结算数据";
            // 
            // FormSettlement
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(1072, 402);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettlement";
            this.Text = "结算";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxSettleInfo.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOptionInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFutureInfo)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxSettleInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridViewOptionInfo;
        private System.Windows.Forms.DataGridView dataGridViewFutureInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePickerSettleDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGetFutureSettlePrice;
        private System.Windows.Forms.Label labelError;
    }
}