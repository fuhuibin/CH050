namespace MyTestBed
{
    partial class frmAlarmRec
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
            this.AlarmRec_DgView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.StartDtPicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.EndDtPicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmRec_DgView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // AlarmRec_DgView
            // 
            this.AlarmRec_DgView.AllowUserToAddRows = false;
            this.AlarmRec_DgView.AllowUserToDeleteRows = false;
            this.AlarmRec_DgView.BackgroundColor = System.Drawing.Color.White;
            this.AlarmRec_DgView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.AlarmRec_DgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlarmRec_DgView.Location = new System.Drawing.Point(5, 57);
            this.AlarmRec_DgView.Name = "AlarmRec_DgView";
            this.AlarmRec_DgView.ReadOnly = true;
            this.AlarmRec_DgView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.AlarmRec_DgView.RowTemplate.Height = 23;
            this.AlarmRec_DgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AlarmRec_DgView.Size = new System.Drawing.Size(457, 343);
            this.AlarmRec_DgView.TabIndex = 42;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.StartDtPicker);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.EndDtPicker);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(5, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(457, 50);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "查询时间范围";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(9, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 14);
            this.label8.TabIndex = 2;
            this.label8.Text = "起始时间";
            // 
            // StartDtPicker
            // 
            this.StartDtPicker.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StartDtPicker.Location = new System.Drawing.Point(76, 17);
            this.StartDtPicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.StartDtPicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.StartDtPicker.Name = "StartDtPicker";
            this.StartDtPicker.Size = new System.Drawing.Size(144, 26);
            this.StartDtPicker.TabIndex = 3;
            this.StartDtPicker.Value = new System.DateTime(2009, 11, 10, 0, 0, 0, 0);
            this.StartDtPicker.CloseUp += new System.EventHandler(this.StartDtPicker_CloseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(235, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 14);
            this.label7.TabIndex = 4;
            this.label7.Text = "终止时间";
            // 
            // EndDtPicker
            // 
            this.EndDtPicker.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EndDtPicker.Location = new System.Drawing.Point(301, 17);
            this.EndDtPicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.EndDtPicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.EndDtPicker.Name = "EndDtPicker";
            this.EndDtPicker.Size = new System.Drawing.Size(144, 26);
            this.EndDtPicker.TabIndex = 5;
            this.EndDtPicker.Value = new System.DateTime(2009, 11, 10, 0, 0, 0, 0);
            this.EndDtPicker.CloseUp += new System.EventHandler(this.StartDtPicker_CloseUp);
            // 
            // frmAlarmRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 402);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.AlarmRec_DgView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAlarmRec";
            this.Text = "报警历史记录";
            this.Load += new System.EventHandler(this.frmAlarmRec_Load);
            this.Activated += new System.EventHandler(this.frmAlarmRec_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.AlarmRec_DgView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AlarmRec_DgView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker StartDtPicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker EndDtPicker;
    }
}