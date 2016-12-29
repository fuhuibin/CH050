namespace MyTestBed
{
    partial class frmOpcItemCfg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOpcItemCfg));
            this.ColModiMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContColModiMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.OpcGroupNameCboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ItemLbl_1 = new System.Windows.Forms.Label();
            this.ItemLbl_6 = new System.Windows.Forms.Label();
            this.PlcConnTxtBox = new System.Windows.Forms.TextBox();
            this.ItemNumNumedt = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.ItemLbl_5 = new System.Windows.Forms.Label();
            this.dBlockTxtBox = new System.Windows.Forms.TextBox();
            this.ItemTypeCboBox = new System.Windows.Forms.ComboBox();
            this.CommentTxtBox = new System.Windows.Forms.TextBox();
            this.ItemLbl_3 = new System.Windows.Forms.Label();
            this.ItemLbl_7 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ItemLbl_2 = new System.Windows.Forms.Label();
            this.InitValTxtBox = new System.Windows.Forms.TextBox();
            this.ItemAddrTxtBox = new System.Windows.Forms.TextBox();
            this.ItemLbl_4 = new System.Windows.Forms.Label();
            this.ItemNameTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddCheck = new System.Windows.Forms.CheckBox();
            this.btnRecAdd = new System.Windows.Forms.Button();
            this.btnRecDel = new System.Windows.Forms.Button();
            this.btnRecModi = new System.Windows.Forms.Button();
            this.btnRecUp = new System.Windows.Forms.Button();
            this.btnRecDn = new System.Windows.Forms.Button();
            this.ItemLbl_0 = new System.Windows.Forms.Label();
            this.ParCfg_DgView = new System.Windows.Forms.DataGridView();
            this.ColModiMenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemNumNumedt)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParCfg_DgView)).BeginInit();
            this.SuspendLayout();
            // 
            // ColModiMenuStrip
            // 
            this.ColModiMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContColModiMenuItem});
            this.ColModiMenuStrip.Name = "contextMenuStrip1";
            this.ColModiMenuStrip.Size = new System.Drawing.Size(154, 48);
            this.ColModiMenuStrip.Text = "列项字段修改";
            this.ColModiMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ColModiMenuStrip_ItemClicked);
            // 
            // ContColModiMenuItem
            // 
            this.ContColModiMenuItem.Name = "ContColModiMenuItem";
            this.ContColModiMenuItem.Size = new System.Drawing.Size(153, 22);
            this.ContColModiMenuItem.Text = "连续行_列修改";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 157;
            this.label1.Text = "Opc组选择";
            // 
            // OpcGroupNameCboBox
            // 
            this.OpcGroupNameCboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OpcGroupNameCboBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OpcGroupNameCboBox.FormattingEnabled = true;
            this.OpcGroupNameCboBox.Location = new System.Drawing.Point(85, 6);
            this.OpcGroupNameCboBox.Name = "OpcGroupNameCboBox";
            this.OpcGroupNameCboBox.Size = new System.Drawing.Size(173, 27);
            this.OpcGroupNameCboBox.TabIndex = 158;
            this.OpcGroupNameCboBox.SelectedIndexChanged += new System.EventHandler(this.OpcGroupNameCboBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 477);
            this.panel1.TabIndex = 160;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.groupBox1.Controls.Add(this.ItemLbl_1);
            this.groupBox1.Controls.Add(this.ItemLbl_6);
            this.groupBox1.Controls.Add(this.PlcConnTxtBox);
            this.groupBox1.Controls.Add(this.ItemNumNumedt);
            this.groupBox1.Controls.Add(this.ItemLbl_5);
            this.groupBox1.Controls.Add(this.dBlockTxtBox);
            this.groupBox1.Controls.Add(this.ItemTypeCboBox);
            this.groupBox1.Controls.Add(this.CommentTxtBox);
            this.groupBox1.Controls.Add(this.ItemLbl_3);
            this.groupBox1.Controls.Add(this.ItemLbl_7);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ItemLbl_2);
            this.groupBox1.Controls.Add(this.InitValTxtBox);
            this.groupBox1.Controls.Add(this.ItemAddrTxtBox);
            this.groupBox1.Controls.Add(this.ItemLbl_4);
            this.groupBox1.Controls.Add(this.ItemNameTxtBox);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.ItemLbl_0);
            this.groupBox1.Controls.Add(this.ParCfg_DgView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 473);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            // 
            // ItemLbl_1
            // 
            this.ItemLbl_1.AutoSize = true;
            this.ItemLbl_1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemLbl_1.Location = new System.Drawing.Point(93, 67);
            this.ItemLbl_1.Name = "ItemLbl_1";
            this.ItemLbl_1.Size = new System.Drawing.Size(62, 17);
            this.ItemLbl_1.TabIndex = 184;
            this.ItemLbl_1.Text = "Plc连接点";
            // 
            // ItemLbl_6
            // 
            this.ItemLbl_6.AutoSize = true;
            this.ItemLbl_6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemLbl_6.Location = new System.Drawing.Point(592, 35);
            this.ItemLbl_6.Name = "ItemLbl_6";
            this.ItemLbl_6.Size = new System.Drawing.Size(44, 17);
            this.ItemLbl_6.TabIndex = 183;
            this.ItemLbl_6.Text = "初始值";
            // 
            // PlcConnTxtBox
            // 
            this.PlcConnTxtBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PlcConnTxtBox.Location = new System.Drawing.Point(157, 64);
            this.PlcConnTxtBox.Name = "PlcConnTxtBox";
            this.PlcConnTxtBox.Size = new System.Drawing.Size(128, 23);
            this.PlcConnTxtBox.TabIndex = 182;
            this.PlcConnTxtBox.Text = "S7 connection_1";
            // 
            // ItemNumNumedt
            // 
            this.ItemNumNumedt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemNumNumedt.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.ItemNumNumedt.Location = new System.Drawing.Point(508, 65);
            this.ItemNumNumedt.Name = "ItemNumNumedt";
            this.ItemNumNumedt.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.ItemNumNumedt.Range = new NationalInstruments.UI.Range(1, 500);
            this.ItemNumNumedt.Size = new System.Drawing.Size(74, 23);
            this.ItemNumNumedt.TabIndex = 181;
            this.ItemNumNumedt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ItemNumNumedt.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.ItemNumNumedt.Value = 1;
            // 
            // ItemLbl_5
            // 
            this.ItemLbl_5.AutoSize = true;
            this.ItemLbl_5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemLbl_5.Location = new System.Drawing.Point(451, 68);
            this.ItemLbl_5.Name = "ItemLbl_5";
            this.ItemLbl_5.Size = new System.Drawing.Size(56, 17);
            this.ItemLbl_5.TabIndex = 180;
            this.ItemLbl_5.Text = "标签数量";
            // 
            // dBlockTxtBox
            // 
            this.dBlockTxtBox.AcceptsReturn = true;
            this.dBlockTxtBox.BackColor = System.Drawing.SystemColors.Window;
            this.dBlockTxtBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dBlockTxtBox.Location = new System.Drawing.Point(351, 32);
            this.dBlockTxtBox.Name = "dBlockTxtBox";
            this.dBlockTxtBox.Size = new System.Drawing.Size(87, 23);
            this.dBlockTxtBox.TabIndex = 178;
            this.dBlockTxtBox.Text = "DB";
            this.dBlockTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dBlockTxtBox_KeyPress);
            // 
            // ItemTypeCboBox
            // 
            this.ItemTypeCboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemTypeCboBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemTypeCboBox.FormattingEnabled = true;
            this.ItemTypeCboBox.Location = new System.Drawing.Point(351, 63);
            this.ItemTypeCboBox.Name = "ItemTypeCboBox";
            this.ItemTypeCboBox.Size = new System.Drawing.Size(87, 25);
            this.ItemTypeCboBox.TabIndex = 170;
            this.ItemTypeCboBox.SelectedIndexChanged += new System.EventHandler(this.ItemTypeCboBox_SelectedIndexChanged);
            // 
            // CommentTxtBox
            // 
            this.CommentTxtBox.BackColor = System.Drawing.SystemColors.Window;
            this.CommentTxtBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CommentTxtBox.Location = new System.Drawing.Point(636, 63);
            this.CommentTxtBox.Name = "CommentTxtBox";
            this.CommentTxtBox.Size = new System.Drawing.Size(119, 23);
            this.CommentTxtBox.TabIndex = 172;
            // 
            // ItemLbl_3
            // 
            this.ItemLbl_3.AutoSize = true;
            this.ItemLbl_3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemLbl_3.Location = new System.Drawing.Point(295, 69);
            this.ItemLbl_3.Name = "ItemLbl_3";
            this.ItemLbl_3.Size = new System.Drawing.Size(56, 17);
            this.ItemLbl_3.TabIndex = 167;
            this.ItemLbl_3.Text = "数据类型";
            // 
            // ItemLbl_7
            // 
            this.ItemLbl_7.AutoSize = true;
            this.ItemLbl_7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemLbl_7.Location = new System.Drawing.Point(600, 68);
            this.ItemLbl_7.Name = "ItemLbl_7";
            this.ItemLbl_7.Size = new System.Drawing.Size(32, 17);
            this.ItemLbl_7.TabIndex = 171;
            this.ItemLbl_7.Text = "注释";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(348, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 179;
            this.label7.Text = "(DBxxx, I, Q, M)";
            // 
            // ItemLbl_2
            // 
            this.ItemLbl_2.AutoSize = true;
            this.ItemLbl_2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemLbl_2.Location = new System.Drawing.Point(295, 36);
            this.ItemLbl_2.Name = "ItemLbl_2";
            this.ItemLbl_2.Size = new System.Drawing.Size(56, 17);
            this.ItemLbl_2.TabIndex = 175;
            this.ItemLbl_2.Text = "数据区域";
            // 
            // InitValTxtBox
            // 
            this.InitValTxtBox.BackColor = System.Drawing.SystemColors.Window;
            this.InitValTxtBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InitValTxtBox.Location = new System.Drawing.Point(636, 31);
            this.InitValTxtBox.Name = "InitValTxtBox";
            this.InitValTxtBox.Size = new System.Drawing.Size(48, 23);
            this.InitValTxtBox.TabIndex = 177;
            this.InitValTxtBox.Text = "0";
            this.InitValTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InitValTxtBox_KeyPress);
            // 
            // ItemAddrTxtBox
            // 
            this.ItemAddrTxtBox.BackColor = System.Drawing.SystemColors.Window;
            this.ItemAddrTxtBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemAddrTxtBox.Location = new System.Drawing.Point(508, 32);
            this.ItemAddrTxtBox.Name = "ItemAddrTxtBox";
            this.ItemAddrTxtBox.Size = new System.Drawing.Size(74, 23);
            this.ItemAddrTxtBox.TabIndex = 176;
            this.ItemAddrTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemAddrTxtBox_KeyPress);
            // 
            // ItemLbl_4
            // 
            this.ItemLbl_4.AutoSize = true;
            this.ItemLbl_4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemLbl_4.Location = new System.Drawing.Point(451, 37);
            this.ItemLbl_4.Name = "ItemLbl_4";
            this.ItemLbl_4.Size = new System.Drawing.Size(56, 17);
            this.ItemLbl_4.TabIndex = 169;
            this.ItemLbl_4.Text = "数据地址";
            // 
            // ItemNameTxtBox
            // 
            this.ItemNameTxtBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemNameTxtBox.Location = new System.Drawing.Point(157, 30);
            this.ItemNameTxtBox.Name = "ItemNameTxtBox";
            this.ItemNameTxtBox.Size = new System.Drawing.Size(128, 23);
            this.ItemNameTxtBox.TabIndex = 164;
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
            this.groupBox2.Location = new System.Drawing.Point(10, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(89, 317);
            this.groupBox2.TabIndex = 153;
            this.groupBox2.TabStop = false;
            // 
            // AddCheck
            // 
            this.AddCheck.AutoSize = true;
            this.AddCheck.Location = new System.Drawing.Point(12, 65);
            this.AddCheck.Name = "AddCheck";
            this.AddCheck.Size = new System.Drawing.Size(67, 20);
            this.AddCheck.TabIndex = 139;
            this.AddCheck.Text = "焦点行后";
            this.AddCheck.UseVisualStyleBackColor = true;
            // 
            // btnRecAdd
            // 
            this.btnRecAdd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRecAdd.Location = new System.Drawing.Point(9, 32);
            this.btnRecAdd.Name = "btnRecAdd";
            this.btnRecAdd.Size = new System.Drawing.Size(71, 32);
            this.btnRecAdd.TabIndex = 39;
            this.btnRecAdd.Text = "记录添加";
            this.btnRecAdd.UseVisualStyleBackColor = true;
            // 
            // btnRecDel
            // 
            this.btnRecDel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRecDel.Location = new System.Drawing.Point(12, 212);
            this.btnRecDel.Name = "btnRecDel";
            this.btnRecDel.Size = new System.Drawing.Size(65, 32);
            this.btnRecDel.TabIndex = 87;
            this.btnRecDel.Text = "记录删除";
            this.btnRecDel.UseVisualStyleBackColor = true;
            // 
            // btnRecModi
            // 
            this.btnRecModi.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRecModi.Location = new System.Drawing.Point(7, 102);
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
            this.btnRecUp.Location = new System.Drawing.Point(32, 163);
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
            this.btnRecDn.Location = new System.Drawing.Point(32, 252);
            this.btnRecDn.Name = "btnRecDn";
            this.btnRecDn.Size = new System.Drawing.Size(28, 40);
            this.btnRecDn.TabIndex = 115;
            this.btnRecDn.UseVisualStyleBackColor = false;
            // 
            // ItemLbl_0
            // 
            this.ItemLbl_0.AutoSize = true;
            this.ItemLbl_0.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemLbl_0.Location = new System.Drawing.Point(90, 35);
            this.ItemLbl_0.Name = "ItemLbl_0";
            this.ItemLbl_0.Size = new System.Drawing.Size(68, 17);
            this.ItemLbl_0.TabIndex = 140;
            this.ItemLbl_0.Text = "Opc标签名";
            // 
            // ParCfg_DgView
            // 
            this.ParCfg_DgView.AllowUserToAddRows = false;
            this.ParCfg_DgView.AllowUserToDeleteRows = false;
            this.ParCfg_DgView.BackgroundColor = System.Drawing.Color.White;
            this.ParCfg_DgView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.ParCfg_DgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ParCfg_DgView.ContextMenuStrip = this.ColModiMenuStrip;
            this.ParCfg_DgView.Location = new System.Drawing.Point(106, 97);
            this.ParCfg_DgView.Name = "ParCfg_DgView";
            this.ParCfg_DgView.ReadOnly = true;
            this.ParCfg_DgView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.ParCfg_DgView.RowTemplate.Height = 23;
            this.ParCfg_DgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ParCfg_DgView.Size = new System.Drawing.Size(651, 370);
            this.ParCfg_DgView.TabIndex = 41;
            // 
            // frmOpcItemCfg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 524);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpcGroupNameCboBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOpcItemCfg";
            this.Text = "Opc标签参数配置";
            this.ColModiMenuStrip.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemNumNumedt)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParCfg_DgView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip ColModiMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ContColModiMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox OpcGroupNameCboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox AddCheck;
        private System.Windows.Forms.Button btnRecAdd;
        private System.Windows.Forms.Button btnRecDel;
        private System.Windows.Forms.Button btnRecModi;
        private System.Windows.Forms.Button btnRecUp;
        private System.Windows.Forms.Button btnRecDn;
        private System.Windows.Forms.Label ItemLbl_0;
        private System.Windows.Forms.DataGridView ParCfg_DgView;
        private NationalInstruments.UI.WindowsForms.NumericEdit ItemNumNumedt;
        private System.Windows.Forms.Label ItemLbl_5;
        private System.Windows.Forms.TextBox dBlockTxtBox;
        private System.Windows.Forms.ComboBox ItemTypeCboBox;
        private System.Windows.Forms.TextBox CommentTxtBox;
        private System.Windows.Forms.Label ItemLbl_3;
        private System.Windows.Forms.Label ItemLbl_7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ItemLbl_2;        
        private System.Windows.Forms.TextBox InitValTxtBox;
        private System.Windows.Forms.TextBox ItemAddrTxtBox;
        private System.Windows.Forms.Label ItemLbl_4;        
        public System.Windows.Forms.TextBox ItemNameTxtBox;
        public System.Windows.Forms.TextBox PlcConnTxtBox;
        private System.Windows.Forms.Label ItemLbl_6;
        private System.Windows.Forms.Label ItemLbl_1;
    }
}