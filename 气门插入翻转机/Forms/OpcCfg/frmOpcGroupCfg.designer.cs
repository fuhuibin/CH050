namespace MyTestBed
{
    partial class frmOpcGroupCfg
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOpcGroupCfg));
            this.ColModiMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContColModiMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ItemCon_2 = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.ItemCon_3 = new System.Windows.Forms.TextBox();
            this.ItemLbl_3 = new System.Windows.Forms.Label();
            this.ItemCon_0 = new System.Windows.Forms.TextBox();
            this.ItemLbl_1 = new System.Windows.Forms.Label();
            this.ItemLbl_0 = new System.Windows.Forms.Label();
            this.ItemLbl_2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddCheck = new System.Windows.Forms.CheckBox();
            this.btnRecAdd = new System.Windows.Forms.Button();
            this.btnRecDel = new System.Windows.Forms.Button();
            this.btnRecModi = new System.Windows.Forms.Button();
            this.btnRecUp = new System.Windows.Forms.Button();
            this.btnRecDn = new System.Windows.Forms.Button();
            this.ItemCon_1 = new System.Windows.Forms.ComboBox();
            this.ParCfg_DgView = new System.Windows.Forms.DataGridView();
            this.ColModiMenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCon_2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParCfg_DgView)).BeginInit();
            this.SuspendLayout();
            // 
            // ColModiMenuStrip
            // 
            this.ColModiMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContColModiMenuItem});
            this.ColModiMenuStrip.Name = "contextMenuStrip1";
            this.ColModiMenuStrip.Size = new System.Drawing.Size(154, 26);
            this.ColModiMenuStrip.Text = "列项字段修改";
            this.ColModiMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ColModiMenuStrip_ItemClicked);
            // 
            // ContColModiMenuItem
            // 
            this.ContColModiMenuItem.Name = "ContColModiMenuItem";
            this.ContColModiMenuItem.Size = new System.Drawing.Size(153, 22);
            this.ContColModiMenuItem.Text = "连续行_列修改";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 383);
            this.panel1.TabIndex = 160;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.groupBox1.Controls.Add(this.ItemCon_2);
            this.groupBox1.Controls.Add(this.ItemCon_3);
            this.groupBox1.Controls.Add(this.ItemLbl_3);
            this.groupBox1.Controls.Add(this.ItemCon_0);
            this.groupBox1.Controls.Add(this.ItemLbl_1);
            this.groupBox1.Controls.Add(this.ItemLbl_0);
            this.groupBox1.Controls.Add(this.ItemLbl_2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.ItemCon_1);
            this.groupBox1.Controls.Add(this.ParCfg_DgView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 379);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            // 
            // ItemCon_2
            // 
            this.ItemCon_2.CoercionInterval = 50;
            this.ItemCon_2.CoercionMode = NationalInstruments.UI.NumericCoercionMode.ToInterval;
            this.ItemCon_2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCon_2.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.ItemCon_2.Location = new System.Drawing.Point(408, 39);
            this.ItemCon_2.Name = "ItemCon_2";
            this.ItemCon_2.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.ItemCon_2.Range = new NationalInstruments.UI.Range(100, 2000);
            this.ItemCon_2.Size = new System.Drawing.Size(90, 29);
            this.ItemCon_2.TabIndex = 164;
            this.ItemCon_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ItemCon_2.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.ItemCon_2.Value = 200;
            // 
            // ItemCon_3
            // 
            this.ItemCon_3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemCon_3.Location = new System.Drawing.Point(511, 38);
            this.ItemCon_3.Name = "ItemCon_3";
            this.ItemCon_3.Size = new System.Drawing.Size(127, 29);
            this.ItemCon_3.TabIndex = 164;
            // 
            // ItemLbl_3
            // 
            this.ItemLbl_3.AutoSize = true;
            this.ItemLbl_3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemLbl_3.Location = new System.Drawing.Point(507, 17);
            this.ItemLbl_3.Name = "ItemLbl_3";
            this.ItemLbl_3.Size = new System.Drawing.Size(37, 20);
            this.ItemLbl_3.TabIndex = 162;
            this.ItemLbl_3.Text = "注释";
            // 
            // ItemCon_0
            // 
            this.ItemCon_0.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemCon_0.Location = new System.Drawing.Point(111, 38);
            this.ItemCon_0.Name = "ItemCon_0";
            this.ItemCon_0.Size = new System.Drawing.Size(135, 29);
            this.ItemCon_0.TabIndex = 156;
            // 
            // ItemLbl_1
            // 
            this.ItemLbl_1.AutoSize = true;
            this.ItemLbl_1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemLbl_1.Location = new System.Drawing.Point(254, 16);
            this.ItemLbl_1.Name = "ItemLbl_1";
            this.ItemLbl_1.Size = new System.Drawing.Size(78, 20);
            this.ItemLbl_1.TabIndex = 140;
            this.ItemLbl_1.Text = "Opc组模式";
            // 
            // ItemLbl_0
            // 
            this.ItemLbl_0.AutoSize = true;
            this.ItemLbl_0.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemLbl_0.Location = new System.Drawing.Point(106, 16);
            this.ItemLbl_0.Name = "ItemLbl_0";
            this.ItemLbl_0.Size = new System.Drawing.Size(64, 20);
            this.ItemLbl_0.TabIndex = 155;
            this.ItemLbl_0.Text = "Opc组名";
            // 
            // ItemLbl_2
            // 
            this.ItemLbl_2.AutoSize = true;
            this.ItemLbl_2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemLbl_2.Location = new System.Drawing.Point(402, 17);
            this.ItemLbl_2.Name = "ItemLbl_2";
            this.ItemLbl_2.Size = new System.Drawing.Size(94, 20);
            this.ItemLbl_2.TabIndex = 160;
            this.ItemLbl_2.Text = "更新速率(ms)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AddCheck);
            this.groupBox2.Controls.Add(this.btnRecAdd);
            this.groupBox2.Controls.Add(this.btnRecDel);
            this.groupBox2.Controls.Add(this.btnRecModi);
            this.groupBox2.Controls.Add(this.btnRecUp);
            this.groupBox2.Controls.Add(this.btnRecDn);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(11, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(89, 288);
            this.groupBox2.TabIndex = 153;
            this.groupBox2.TabStop = false;
            // 
            // AddCheck
            // 
            this.AddCheck.AutoSize = true;
            this.AddCheck.Location = new System.Drawing.Point(11, 51);
            this.AddCheck.Name = "AddCheck";
            this.AddCheck.Size = new System.Drawing.Size(67, 20);
            this.AddCheck.TabIndex = 139;
            this.AddCheck.Text = "焦点行后";
            this.AddCheck.UseVisualStyleBackColor = true;
            // 
            // btnRecAdd
            // 
            this.btnRecAdd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRecAdd.Location = new System.Drawing.Point(8, 18);
            this.btnRecAdd.Name = "btnRecAdd";
            this.btnRecAdd.Size = new System.Drawing.Size(71, 32);
            this.btnRecAdd.TabIndex = 39;
            this.btnRecAdd.Text = "记录添加";
            this.btnRecAdd.UseVisualStyleBackColor = true;
            // 
            // btnRecDel
            // 
            this.btnRecDel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRecDel.Location = new System.Drawing.Point(8, 194);
            this.btnRecDel.Name = "btnRecDel";
            this.btnRecDel.Size = new System.Drawing.Size(65, 32);
            this.btnRecDel.TabIndex = 87;
            this.btnRecDel.Text = "记录删除";
            this.btnRecDel.UseVisualStyleBackColor = true;
            // 
            // btnRecModi
            // 
            this.btnRecModi.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRecModi.Location = new System.Drawing.Point(6, 84);
            this.btnRecModi.Name = "btnRecModi";
            this.btnRecModi.Size = new System.Drawing.Size(71, 30);
            this.btnRecModi.TabIndex = 42;
            this.btnRecModi.Text = "记录修改";
            this.btnRecModi.UseVisualStyleBackColor = true;
            // 
            // btnRecUp
            // 
            this.btnRecUp.BackColor = System.Drawing.Color.Transparent;
            this.btnRecUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRecUp.Image = ((System.Drawing.Image)(resources.GetObject("btnRecUp.Image")));
            this.btnRecUp.Location = new System.Drawing.Point(28, 145);
            this.btnRecUp.Name = "btnRecUp";
            this.btnRecUp.Size = new System.Drawing.Size(28, 42);
            this.btnRecUp.TabIndex = 114;
            this.btnRecUp.UseVisualStyleBackColor = false;
            // 
            // btnRecDn
            // 
            this.btnRecDn.BackColor = System.Drawing.Color.White;
            this.btnRecDn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRecDn.Image = ((System.Drawing.Image)(resources.GetObject("btnRecDn.Image")));
            this.btnRecDn.Location = new System.Drawing.Point(28, 234);
            this.btnRecDn.Name = "btnRecDn";
            this.btnRecDn.Size = new System.Drawing.Size(28, 40);
            this.btnRecDn.TabIndex = 115;
            this.btnRecDn.UseVisualStyleBackColor = false;
            // 
            // ItemCon_1
            // 
            this.ItemCon_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemCon_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCon_1.FormattingEnabled = true;
            this.ItemCon_1.Items.AddRange(new object[] {
            "NormalGroup",
            "AsyncGroup"});
            this.ItemCon_1.Location = new System.Drawing.Point(258, 39);
            this.ItemCon_1.Name = "ItemCon_1";
            this.ItemCon_1.Size = new System.Drawing.Size(137, 28);
            this.ItemCon_1.TabIndex = 159;
            // 
            // ParCfg_DgView
            // 
            this.ParCfg_DgView.AllowUserToAddRows = false;
            this.ParCfg_DgView.AllowUserToDeleteRows = false;
            this.ParCfg_DgView.BackgroundColor = System.Drawing.Color.White;
            this.ParCfg_DgView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.ParCfg_DgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ParCfg_DgView.ContextMenuStrip = this.ColModiMenuStrip;
            this.ParCfg_DgView.Location = new System.Drawing.Point(111, 77);
            this.ParCfg_DgView.Name = "ParCfg_DgView";
            this.ParCfg_DgView.ReadOnly = true;
            this.ParCfg_DgView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.ParCfg_DgView.RowTemplate.Height = 23;
            this.ParCfg_DgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ParCfg_DgView.Size = new System.Drawing.Size(528, 282);
            this.ParCfg_DgView.TabIndex = 41;
            // 
            // frmOpcGroupCfg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 389);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOpcGroupCfg";
            this.Text = "Opc组参数配置";
            this.ColModiMenuStrip.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCon_2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParCfg_DgView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip ColModiMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ContColModiMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox AddCheck;
        private System.Windows.Forms.Button btnRecAdd;
        private System.Windows.Forms.Button btnRecDel;
        private System.Windows.Forms.Button btnRecModi;
        private System.Windows.Forms.Button btnRecUp;
        private System.Windows.Forms.Button btnRecDn;
        private System.Windows.Forms.DataGridView ParCfg_DgView;
        public System.Windows.Forms.TextBox ItemCon_0;
        private System.Windows.Forms.Label ItemLbl_0;
        private NationalInstruments.UI.WindowsForms.NumericEdit ItemCon_2;
        public System.Windows.Forms.TextBox ItemCon_3;
        private System.Windows.Forms.Label ItemLbl_3;
        private System.Windows.Forms.Label ItemLbl_1;
        private System.Windows.Forms.Label ItemLbl_2;
        private System.Windows.Forms.ComboBox ItemCon_1;
    }
}