namespace MyTestBed
{
    partial class frmSysParCfg
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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.neMeasSpan = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.neCaliSpan = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbDispChan = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.manulSpeed = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.fastSpeed = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.slowSpeed = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neMeasSpan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neCaliSpan)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manulSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slowSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox7.Controls.Add(this.neMeasSpan);
            this.groupBox7.Controls.Add(this.neCaliSpan);
            this.groupBox7.Controls.Add(this.label37);
            this.groupBox7.Controls.Add(this.label36);
            this.groupBox7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox7.ForeColor = System.Drawing.Color.Black;
            this.groupBox7.Location = new System.Drawing.Point(12, 71);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Size = new System.Drawing.Size(413, 149);
            this.groupBox7.TabIndex = 167;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "传感器标定/测量时间(s)";
            // 
            // neMeasSpan
            // 
            this.neMeasSpan.CoercionInterval = 0.5;
            this.neMeasSpan.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.neMeasSpan.Location = new System.Drawing.Point(204, 81);
            this.neMeasSpan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.neMeasSpan.Name = "neMeasSpan";
            this.neMeasSpan.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.neMeasSpan.Range = new NationalInstruments.UI.Range(0, 1000);
            this.neMeasSpan.Size = new System.Drawing.Size(107, 34);
            this.neMeasSpan.TabIndex = 199;
            this.neMeasSpan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.neMeasSpan.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // neCaliSpan
            // 
            this.neCaliSpan.CoercionInterval = 0.5;
            this.neCaliSpan.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.neCaliSpan.Location = new System.Drawing.Point(56, 81);
            this.neCaliSpan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.neCaliSpan.Name = "neCaliSpan";
            this.neCaliSpan.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.neCaliSpan.Range = new NationalInstruments.UI.Range(0, 1000);
            this.neCaliSpan.Size = new System.Drawing.Size(107, 34);
            this.neCaliSpan.TabIndex = 198;
            this.neCaliSpan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.neCaliSpan.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label37.Location = new System.Drawing.Point(199, 49);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(82, 24);
            this.label37.TabIndex = 194;
            this.label37.Text = "测量时间";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label36.Location = new System.Drawing.Point(51, 49);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(82, 24);
            this.label36.TabIndex = 182;
            this.label36.Text = "标定时间";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(24, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 24);
            this.label8.TabIndex = 199;
            this.label8.Text = "位移传感器端口";
            // 
            // cmbDispChan
            // 
            this.cmbDispChan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDispChan.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbDispChan.FormattingEnabled = true;
            this.cmbDispChan.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4"});
            this.cmbDispChan.Location = new System.Drawing.Point(171, 21);
            this.cmbDispChan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDispChan.Name = "cmbDispChan";
            this.cmbDispChan.Size = new System.Drawing.Size(140, 33);
            this.cmbDispChan.TabIndex = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.slowSpeed);
            this.groupBox1.Controls.Add(this.fastSpeed);
            this.groupBox1.Controls.Add(this.manulSpeed);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 200);
            this.groupBox1.TabIndex = 201;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "变频器速率设定";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(16, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "变频器手动频率";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(16, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "变频器快速频率";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(16, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "变频器慢速频率";
            // 
            // manulSpeed
            // 
            this.manulSpeed.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.manulSpeed.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3);
            this.manulSpeed.Location = new System.Drawing.Point(204, 44);
            this.manulSpeed.Name = "manulSpeed";
            this.manulSpeed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.manulSpeed.Size = new System.Drawing.Size(120, 31);
            this.manulSpeed.TabIndex = 3;
            this.manulSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fastSpeed
            // 
            this.fastSpeed.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fastSpeed.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3);
            this.fastSpeed.Location = new System.Drawing.Point(204, 85);
            this.fastSpeed.Name = "fastSpeed";
            this.fastSpeed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fastSpeed.Size = new System.Drawing.Size(120, 31);
            this.fastSpeed.TabIndex = 4;
            this.fastSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // slowSpeed
            // 
            this.slowSpeed.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.slowSpeed.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3);
            this.slowSpeed.Location = new System.Drawing.Point(203, 129);
            this.slowSpeed.Name = "slowSpeed";
            this.slowSpeed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.slowSpeed.Size = new System.Drawing.Size(120, 31);
            this.slowSpeed.TabIndex = 5;
            this.slowSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmSysParCfg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 462);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbDispChan);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSysParCfg";
            this.Text = "系统参数设置";
            this.Load += new System.EventHandler(this.frmSysParCfg_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSysParCfg_FormClosing);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neMeasSpan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neCaliSpan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manulSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slowSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private NationalInstruments.UI.WindowsForms.NumericEdit neMeasSpan;
        private NationalInstruments.UI.WindowsForms.NumericEdit neCaliSpan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbDispChan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private NationalInstruments.UI.WindowsForms.NumericEdit slowSpeed;
        private NationalInstruments.UI.WindowsForms.NumericEdit fastSpeed;
        private NationalInstruments.UI.WindowsForms.NumericEdit manulSpeed;

    }
}