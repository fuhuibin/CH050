namespace MyTestBed
{
    partial class frmReadItems
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FileSeleBtn = new System.Windows.Forms.Button();
            this.neEndCol = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.neEndRow = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.neStartCol = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.buttCancel = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttDeleAdd = new System.Windows.Forms.RadioButton();
            this.buttKeepAdd = new System.Windows.Forms.RadioButton();
            this.buttOk = new System.Windows.Forms.Button();
            this.txtXlsForm = new System.Windows.Forms.TextBox();
            this.txtXlsFileName = new System.Windows.Forms.TextBox();
            this.neStartRow = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.StartRowLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ItemLbl_0 = new System.Windows.Forms.Label();
            this.FileSeleDialog = new System.Windows.Forms.OpenFileDialog();
            this.cmbOpcGroupName = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neEndCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neEndRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neStartCol)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neStartRow)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FileSeleBtn);
            this.groupBox3.Controls.Add(this.neEndCol);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.neEndRow);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.neStartCol);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.buttCancel);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.buttOk);
            this.groupBox3.Controls.Add(this.txtXlsForm);
            this.groupBox3.Controls.Add(this.txtXlsFileName);
            this.groupBox3.Controls.Add(this.neStartRow);
            this.groupBox3.Controls.Add(this.StartRowLbl);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(4, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 215);
            this.groupBox3.TabIndex = 183;
            this.groupBox3.TabStop = false;
            // 
            // FileSeleBtn
            // 
            this.FileSeleBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FileSeleBtn.Location = new System.Drawing.Point(8, 85);
            this.FileSeleBtn.Name = "FileSeleBtn";
            this.FileSeleBtn.Size = new System.Drawing.Size(88, 29);
            this.FileSeleBtn.TabIndex = 191;
            this.FileSeleBtn.Text = "Xls文件选择";
            this.FileSeleBtn.UseVisualStyleBackColor = true;
            this.FileSeleBtn.Click += new System.EventHandler(this.FileSeleBtn_Click);
            // 
            // neEndCol
            // 
            this.neEndCol.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.neEndCol.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.neEndCol.Location = new System.Drawing.Point(262, 176);
            this.neEndCol.Name = "neEndCol";
            this.neEndCol.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.neEndCol.Range = new NationalInstruments.UI.Range(1, 500);
            this.neEndCol.Size = new System.Drawing.Size(82, 29);
            this.neEndCol.TabIndex = 190;
            this.neEndCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.neEndCol.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.neEndCol.Value = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(259, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 189;
            this.label5.Text = "标签结束列";
            // 
            // neEndRow
            // 
            this.neEndRow.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.neEndRow.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.neEndRow.Location = new System.Drawing.Point(261, 119);
            this.neEndRow.Name = "neEndRow";
            this.neEndRow.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.neEndRow.Range = new NationalInstruments.UI.Range(1, 500);
            this.neEndRow.Size = new System.Drawing.Size(83, 29);
            this.neEndRow.TabIndex = 188;
            this.neEndRow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.neEndRow.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.neEndRow.Value = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(259, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 187;
            this.label4.Text = "标签结束行";
            // 
            // neStartCol
            // 
            this.neStartCol.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.neStartCol.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.neStartCol.Location = new System.Drawing.Point(175, 176);
            this.neStartCol.Name = "neStartCol";
            this.neStartCol.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.neStartCol.Range = new NationalInstruments.UI.Range(1, 500);
            this.neStartCol.Size = new System.Drawing.Size(79, 29);
            this.neStartCol.TabIndex = 186;
            this.neStartCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.neStartCol.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.neStartCol.Value = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(169, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 185;
            this.label3.Text = "标签起始列";
            // 
            // buttCancel
            // 
            this.buttCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttCancel.Location = new System.Drawing.Point(261, 32);
            this.buttCancel.Name = "buttCancel";
            this.buttCancel.Size = new System.Drawing.Size(77, 32);
            this.buttCancel.TabIndex = 184;
            this.buttCancel.Text = "取消&&返回";
            this.buttCancel.UseVisualStyleBackColor = true;
            this.buttCancel.Click += new System.EventHandler(this.buttCancel_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttDeleAdd);
            this.groupBox4.Controls.Add(this.buttKeepAdd);
            this.groupBox4.Location = new System.Drawing.Point(10, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(97, 68);
            this.groupBox4.TabIndex = 183;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "标签添加模式";
            // 
            // buttDeleAdd
            // 
            this.buttDeleAdd.AutoSize = true;
            this.buttDeleAdd.Checked = true;
            this.buttDeleAdd.Location = new System.Drawing.Point(10, 42);
            this.buttDeleAdd.Name = "buttDeleAdd";
            this.buttDeleAdd.Size = new System.Drawing.Size(75, 20);
            this.buttDeleAdd.TabIndex = 1;
            this.buttDeleAdd.TabStop = true;
            this.buttDeleAdd.Text = "删除&&添加";
            this.buttDeleAdd.UseVisualStyleBackColor = true;
            // 
            // buttKeepAdd
            // 
            this.buttKeepAdd.AutoSize = true;
            this.buttKeepAdd.Location = new System.Drawing.Point(11, 21);
            this.buttKeepAdd.Name = "buttKeepAdd";
            this.buttKeepAdd.Size = new System.Drawing.Size(75, 20);
            this.buttKeepAdd.TabIndex = 0;
            this.buttKeepAdd.Text = "保留&&添加";
            this.buttKeepAdd.UseVisualStyleBackColor = true;
            // 
            // buttOk
            // 
            this.buttOk.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttOk.Location = new System.Drawing.Point(175, 32);
            this.buttOk.Name = "buttOk";
            this.buttOk.Size = new System.Drawing.Size(77, 32);
            this.buttOk.TabIndex = 39;
            this.buttOk.Text = "读取确认";
            this.buttOk.UseVisualStyleBackColor = true;
            this.buttOk.Click += new System.EventHandler(this.buttOk_Click);
            // 
            // txtXlsForm
            // 
            this.txtXlsForm.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtXlsForm.Location = new System.Drawing.Point(8, 175);
            this.txtXlsForm.Name = "txtXlsForm";
            this.txtXlsForm.Size = new System.Drawing.Size(153, 29);
            this.txtXlsForm.TabIndex = 166;
            this.txtXlsForm.Text = "标签配置";
            // 
            // txtXlsFileName
            // 
            this.txtXlsFileName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtXlsFileName.Location = new System.Drawing.Point(8, 118);
            this.txtXlsFileName.Name = "txtXlsFileName";
            this.txtXlsFileName.ReadOnly = true;
            this.txtXlsFileName.Size = new System.Drawing.Size(153, 29);
            this.txtXlsFileName.TabIndex = 164;
            // 
            // neStartRow
            // 
            this.neStartRow.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.neStartRow.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.neStartRow.Location = new System.Drawing.Point(173, 119);
            this.neStartRow.Name = "neStartRow";
            this.neStartRow.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.neStartRow.Range = new NationalInstruments.UI.Range(1, 500);
            this.neStartRow.Size = new System.Drawing.Size(81, 29);
            this.neStartRow.TabIndex = 181;
            this.neStartRow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.neStartRow.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.neStartRow.Value = 3;
            // 
            // StartRowLbl
            // 
            this.StartRowLbl.AutoSize = true;
            this.StartRowLbl.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StartRowLbl.Location = new System.Drawing.Point(169, 96);
            this.StartRowLbl.Name = "StartRowLbl";
            this.StartRowLbl.Size = new System.Drawing.Size(79, 20);
            this.StartRowLbl.TabIndex = 180;
            this.StartRowLbl.Text = "标签起始行";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(6, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 165;
            this.label2.Text = "表单名";
            // 
            // ItemLbl_0
            // 
            this.ItemLbl_0.AutoSize = true;
            this.ItemLbl_0.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemLbl_0.Location = new System.Drawing.Point(3, 20);
            this.ItemLbl_0.Name = "ItemLbl_0";
            this.ItemLbl_0.Size = new System.Drawing.Size(64, 19);
            this.ItemLbl_0.TabIndex = 184;
            this.ItemLbl_0.Text = "Opc组名";
            // 
            // FileSeleDialog
            // 
            this.FileSeleDialog.FileName = "openFileDialog1";
            // 
            // cmbOpcGroupName
            // 
            this.cmbOpcGroupName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOpcGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOpcGroupName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmbOpcGroupName.FormattingEnabled = true;
            this.cmbOpcGroupName.Location = new System.Drawing.Point(69, 15);
            this.cmbOpcGroupName.Name = "cmbOpcGroupName";
            this.cmbOpcGroupName.Size = new System.Drawing.Size(200, 28);
            this.cmbOpcGroupName.TabIndex = 186;
            // 
            // frmReadItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 276);
            this.Controls.Add(this.cmbOpcGroupName);
            this.Controls.Add(this.ItemLbl_0);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmReadItems";
            this.Text = "ReadItemsFromExcel";
            this.Load += new System.EventHandler(this.frmReadItems_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neEndCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neEndRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neStartCol)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neStartRow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private NationalInstruments.UI.WindowsForms.NumericEdit neStartCol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttCancel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton buttDeleAdd;
        private System.Windows.Forms.RadioButton buttKeepAdd;
        private System.Windows.Forms.Button buttOk;
        public System.Windows.Forms.TextBox txtXlsForm;
        public System.Windows.Forms.TextBox txtXlsFileName;
        private NationalInstruments.UI.WindowsForms.NumericEdit neStartRow;
        private System.Windows.Forms.Label StartRowLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ItemLbl_0;
        private System.Windows.Forms.OpenFileDialog FileSeleDialog;
        private NationalInstruments.UI.WindowsForms.NumericEdit neEndCol;
        private System.Windows.Forms.Label label5;
        private NationalInstruments.UI.WindowsForms.NumericEdit neEndRow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbOpcGroupName;
        private System.Windows.Forms.Button FileSeleBtn;
    }
}