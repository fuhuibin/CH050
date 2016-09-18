namespace MyTestBed
{
    partial class frmTestRecView
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
            this.QueryBtn = new System.Windows.Forms.Button();
            this.ProdNameChk = new System.Windows.Forms.CheckBox();
            this.ProdNameCmoBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.StartDtPicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.EndDtPicker = new System.Windows.Forms.DateTimePicker();
            this.TestRecDgView = new System.Windows.Forms.DataGridView();
            this.ExcelOutBtn = new System.Windows.Forms.Button();
            this.ParTranHintGrpBox = new System.Windows.Forms.GroupBox();
            this.SendingLbl = new System.Windows.Forms.Label();
            this.ParaSendProgBar = new System.Windows.Forms.ProgressBar();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestRecDgView)).BeginInit();
            this.ParTranHintGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.QueryBtn);
            this.groupBox3.Controls.Add(this.ProdNameChk);
            this.groupBox3.Controls.Add(this.ProdNameCmoBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.StartDtPicker);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.EndDtPicker);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(9, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1067, 102);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "查询条件组合";
            // 
            // QueryBtn
            // 
            this.QueryBtn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.QueryBtn.Location = new System.Drawing.Point(826, 42);
            this.QueryBtn.Margin = new System.Windows.Forms.Padding(4);
            this.QueryBtn.Name = "QueryBtn";
            this.QueryBtn.Size = new System.Drawing.Size(107, 34);
            this.QueryBtn.TabIndex = 47;
            this.QueryBtn.Text = "查询确认";
            this.QueryBtn.UseVisualStyleBackColor = true;
            this.QueryBtn.Click += new System.EventHandler(this.QueryBtn_Click);
            // 
            // ProdNameChk
            // 
            this.ProdNameChk.AutoSize = true;
            this.ProdNameChk.Location = new System.Drawing.Point(121, 32);
            this.ProdNameChk.Margin = new System.Windows.Forms.Padding(4);
            this.ProdNameChk.Name = "ProdNameChk";
            this.ProdNameChk.Size = new System.Drawing.Size(18, 17);
            this.ProdNameChk.TabIndex = 161;
            this.ProdNameChk.UseVisualStyleBackColor = true;
            // 
            // ProdNameCmoBox
            // 
            this.ProdNameCmoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProdNameCmoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdNameCmoBox.FormattingEnabled = true;
            this.ProdNameCmoBox.Location = new System.Drawing.Point(13, 56);
            this.ProdNameCmoBox.Margin = new System.Windows.Forms.Padding(4);
            this.ProdNameCmoBox.Name = "ProdNameCmoBox";
            this.ProdNameCmoBox.Size = new System.Drawing.Size(188, 33);
            this.ProdNameCmoBox.TabIndex = 160;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "产品型号";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(299, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "起始时间";
            // 
            // StartDtPicker
            // 
            this.StartDtPicker.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StartDtPicker.Location = new System.Drawing.Point(401, 21);
            this.StartDtPicker.Margin = new System.Windows.Forms.Padding(4);
            this.StartDtPicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.StartDtPicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.StartDtPicker.Name = "StartDtPicker";
            this.StartDtPicker.Size = new System.Drawing.Size(244, 31);
            this.StartDtPicker.TabIndex = 3;
            this.StartDtPicker.Value = new System.DateTime(2009, 11, 10, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(300, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "终止时间";
            // 
            // EndDtPicker
            // 
            this.EndDtPicker.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EndDtPicker.Location = new System.Drawing.Point(401, 61);
            this.EndDtPicker.Margin = new System.Windows.Forms.Padding(4);
            this.EndDtPicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.EndDtPicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.EndDtPicker.Name = "EndDtPicker";
            this.EndDtPicker.Size = new System.Drawing.Size(244, 31);
            this.EndDtPicker.TabIndex = 5;
            this.EndDtPicker.Value = new System.DateTime(2009, 11, 10, 0, 0, 0, 0);
            // 
            // TestRecDgView
            // 
            this.TestRecDgView.AllowUserToAddRows = false;
            this.TestRecDgView.AllowUserToDeleteRows = false;
            this.TestRecDgView.BackgroundColor = System.Drawing.Color.White;
            this.TestRecDgView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.TestRecDgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TestRecDgView.Location = new System.Drawing.Point(12, 108);
            this.TestRecDgView.Margin = new System.Windows.Forms.Padding(4);
            this.TestRecDgView.Name = "TestRecDgView";
            this.TestRecDgView.ReadOnly = true;
            this.TestRecDgView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.TestRecDgView.RowTemplate.Height = 23;
            this.TestRecDgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TestRecDgView.Size = new System.Drawing.Size(1064, 416);
            this.TestRecDgView.TabIndex = 44;
            // 
            // ExcelOutBtn
            // 
            this.ExcelOutBtn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExcelOutBtn.Location = new System.Drawing.Point(12, 532);
            this.ExcelOutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ExcelOutBtn.Name = "ExcelOutBtn";
            this.ExcelOutBtn.Size = new System.Drawing.Size(107, 34);
            this.ExcelOutBtn.TabIndex = 46;
            this.ExcelOutBtn.Text = "Excel输出";
            this.ExcelOutBtn.UseVisualStyleBackColor = true;
            this.ExcelOutBtn.Click += new System.EventHandler(this.ExcelOutBtn_Click);
            // 
            // ParTranHintGrpBox
            // 
            this.ParTranHintGrpBox.BackColor = System.Drawing.Color.White;
            this.ParTranHintGrpBox.Controls.Add(this.SendingLbl);
            this.ParTranHintGrpBox.Controls.Add(this.ParaSendProgBar);
            this.ParTranHintGrpBox.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ParTranHintGrpBox.Location = new System.Drawing.Point(209, 211);
            this.ParTranHintGrpBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ParTranHintGrpBox.Name = "ParTranHintGrpBox";
            this.ParTranHintGrpBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ParTranHintGrpBox.Size = new System.Drawing.Size(299, 82);
            this.ParTranHintGrpBox.TabIndex = 161;
            this.ParTranHintGrpBox.TabStop = false;
            this.ParTranHintGrpBox.Visible = false;
            // 
            // SendingLbl
            // 
            this.SendingLbl.AutoSize = true;
            this.SendingLbl.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SendingLbl.Location = new System.Drawing.Point(51, 18);
            this.SendingLbl.Name = "SendingLbl";
            this.SendingLbl.Size = new System.Drawing.Size(196, 15);
            this.SendingLbl.TabIndex = 11;
            this.SendingLbl.Text = "记录转换输出中...请稍候！";
            // 
            // ParaSendProgBar
            // 
            this.ParaSendProgBar.Location = new System.Drawing.Point(13, 46);
            this.ParaSendProgBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ParaSendProgBar.Name = "ParaSendProgBar";
            this.ParaSendProgBar.Size = new System.Drawing.Size(267, 24);
            this.ParaSendProgBar.TabIndex = 10;
            this.ParaSendProgBar.Value = 50;
            // 
            // frmTestRecView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 579);
            this.Controls.Add(this.ParTranHintGrpBox);
            this.Controls.Add(this.ExcelOutBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.TestRecDgView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTestRecView";
            this.Text = "测量历史记录查询";
            this.Load += new System.EventHandler(this.frmTestRecView_Load);
            this.Activated += new System.EventHandler(this.frmTestRecView_Activated);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestRecDgView)).EndInit();
            this.ParTranHintGrpBox.ResumeLayout(false);
            this.ParTranHintGrpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker StartDtPicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker EndDtPicker;
        private System.Windows.Forms.DataGridView TestRecDgView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ProdNameCmoBox;
        private System.Windows.Forms.CheckBox ProdNameChk;
        private System.Windows.Forms.Button ExcelOutBtn;
        private System.Windows.Forms.Button QueryBtn;
        private System.Windows.Forms.GroupBox ParTranHintGrpBox;
        private System.Windows.Forms.Label SendingLbl;
        private System.Windows.Forms.ProgressBar ParaSendProgBar;
    }
}