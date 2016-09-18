namespace MyTestBed
{
    partial class frmAlarmMsgCfg 
    {
        /// <summary>
        /// 必需的设计器变量。 
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源 。
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlarmMsgCfg));
            this.ColModiMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContColModiMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ParCfg_DgView = new System.Windows.Forms.DataGridView();
            this.ItemLbl_1 = new System.Windows.Forms.Label();
            this.ItemCon_1 = new System.Windows.Forms.ComboBox();
            this.CommentTxt = new System.Windows.Forms.TextBox();
            this.ItemCon_2 = new System.Windows.Forms.TextBox();
            this.ItemLbl_2 = new System.Windows.Forms.Label();
            this.ItemLbl_0 = new System.Windows.Forms.Label();
            this.ItemCon_0 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddCheck = new System.Windows.Forms.CheckBox();
            this.btnRecAdd = new System.Windows.Forms.Button();
            this.btnRecDel = new System.Windows.Forms.Button();
            this.btnRecModi = new System.Windows.Forms.Button();
            this.btnRecUp = new System.Windows.Forms.Button();
            this.btnRecDn = new System.Windows.Forms.Button();
            this.CommentCboBox = new System.Windows.Forms.ComboBox();
            this.ColModiMenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParCfg_DgView)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 410);
            this.panel1.TabIndex = 160;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.groupBox1.Controls.Add(this.ParCfg_DgView);
            this.groupBox1.Controls.Add(this.ItemLbl_1);
            this.groupBox1.Controls.Add(this.ItemCon_1);
            this.groupBox1.Controls.Add(this.CommentTxt);
            this.groupBox1.Controls.Add(this.ItemCon_2);
            this.groupBox1.Controls.Add(this.ItemLbl_2);
            this.groupBox1.Controls.Add(this.ItemLbl_0);
            this.groupBox1.Controls.Add(this.ItemCon_0);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 406);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            // 
            // ParCfg_DgView
            // 
            this.ParCfg_DgView.AllowUserToAddRows = false;
            this.ParCfg_DgView.AllowUserToDeleteRows = false;
            this.ParCfg_DgView.BackgroundColor = System.Drawing.Color.White;
            this.ParCfg_DgView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.ParCfg_DgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ParCfg_DgView.ContextMenuStrip = this.ColModiMenuStrip;
            this.ParCfg_DgView.Location = new System.Drawing.Point(127, 95);
            this.ParCfg_DgView.Name = "ParCfg_DgView";
            this.ParCfg_DgView.ReadOnly = true;
            this.ParCfg_DgView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.ParCfg_DgView.RowTemplate.Height = 23;
            this.ParCfg_DgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ParCfg_DgView.Size = new System.Drawing.Size(444, 305);
            this.ParCfg_DgView.TabIndex = 41;
            // 
            // ItemLbl_1
            // 
            this.ItemLbl_1.AutoSize = true;
            this.ItemLbl_1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemLbl_1.Location = new System.Drawing.Point(133, 17);
            this.ItemLbl_1.Name = "ItemLbl_1";
            this.ItemLbl_1.Size = new System.Drawing.Size(56, 17);
            this.ItemLbl_1.TabIndex = 169;
            this.ItemLbl_1.Text = "信息类型";
            // 
            // ItemCon_1
            // 
            this.ItemCon_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemCon_1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemCon_1.FormattingEnabled = true;
            this.ItemCon_1.Items.AddRange(new object[] {
            "故障",
            "报警",
            "消息"});
            this.ItemCon_1.Location = new System.Drawing.Point(136, 37);
            this.ItemCon_1.Name = "ItemCon_1";
            this.ItemCon_1.Size = new System.Drawing.Size(80, 28);
            this.ItemCon_1.TabIndex = 168;
            // 
            // CommentTxt
            // 
            this.CommentTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.CommentTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CommentTxt.Enabled = false;
            this.CommentTxt.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CommentTxt.Location = new System.Drawing.Point(127, 70);
            this.CommentTxt.Name = "CommentTxt";
            this.CommentTxt.Size = new System.Drawing.Size(444, 19);
            this.CommentTxt.TabIndex = 167;
            // 
            // ItemCon_2
            // 
            this.ItemCon_2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemCon_2.Location = new System.Drawing.Point(237, 39);
            this.ItemCon_2.Name = "ItemCon_2";
            this.ItemCon_2.Size = new System.Drawing.Size(334, 26);
            this.ItemCon_2.TabIndex = 161;
            // 
            // ItemLbl_2
            // 
            this.ItemLbl_2.AutoSize = true;
            this.ItemLbl_2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemLbl_2.Location = new System.Drawing.Point(234, 21);
            this.ItemLbl_2.Name = "ItemLbl_2";
            this.ItemLbl_2.Size = new System.Drawing.Size(56, 17);
            this.ItemLbl_2.TabIndex = 160;
            this.ItemLbl_2.Text = "信息内容";
            // 
            // ItemLbl_0
            // 
            this.ItemLbl_0.AutoSize = true;
            this.ItemLbl_0.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemLbl_0.Location = new System.Drawing.Point(11, 17);
            this.ItemLbl_0.Name = "ItemLbl_0";
            this.ItemLbl_0.Size = new System.Drawing.Size(44, 17);
            this.ItemLbl_0.TabIndex = 158;
            this.ItemLbl_0.Text = "标签名";
            // 
            // ItemCon_0
            // 
            this.ItemCon_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemCon_0.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemCon_0.FormattingEnabled = true;
            this.ItemCon_0.Location = new System.Drawing.Point(9, 37);
            this.ItemCon_0.Name = "ItemCon_0";
            this.ItemCon_0.Size = new System.Drawing.Size(109, 28);
            this.ItemCon_0.TabIndex = 157;
            this.ItemCon_0.SelectedIndexChanged += new System.EventHandler(this.ItemCon_0_SelectedIndexChanged);
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
            this.groupBox2.Location = new System.Drawing.Point(9, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(109, 313);
            this.groupBox2.TabIndex = 153;
            this.groupBox2.TabStop = false;
            // 
            // AddCheck
            // 
            this.AddCheck.AutoSize = true;
            this.AddCheck.Location = new System.Drawing.Point(10, 54);
            this.AddCheck.Name = "AddCheck";
            this.AddCheck.Size = new System.Drawing.Size(67, 20);
            this.AddCheck.TabIndex = 139;
            this.AddCheck.Text = "焦点行后";
            this.AddCheck.UseVisualStyleBackColor = true;
            // 
            // btnRecAdd
            // 
            this.btnRecAdd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRecAdd.Location = new System.Drawing.Point(7, 21);
            this.btnRecAdd.Name = "btnRecAdd";
            this.btnRecAdd.Size = new System.Drawing.Size(71, 32);
            this.btnRecAdd.TabIndex = 39;
            this.btnRecAdd.Text = "记录添加";
            this.btnRecAdd.UseVisualStyleBackColor = true;
            // 
            // btnRecDel
            // 
            this.btnRecDel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRecDel.Location = new System.Drawing.Point(7, 212);
            this.btnRecDel.Name = "btnRecDel";
            this.btnRecDel.Size = new System.Drawing.Size(65, 32);
            this.btnRecDel.TabIndex = 87;
            this.btnRecDel.Text = "记录删除";
            this.btnRecDel.UseVisualStyleBackColor = true;
            // 
            // btnRecModi
            // 
            this.btnRecModi.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRecModi.Location = new System.Drawing.Point(5, 80);
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
            this.btnRecUp.Location = new System.Drawing.Point(27, 163);
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
            this.btnRecDn.Location = new System.Drawing.Point(27, 252);
            this.btnRecDn.Name = "btnRecDn";
            this.btnRecDn.Size = new System.Drawing.Size(28, 40);
            this.btnRecDn.TabIndex = 115;
            this.btnRecDn.UseVisualStyleBackColor = false;
            // 
            // CommentCboBox
            // 
            this.CommentCboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CommentCboBox.Enabled = false;
            this.CommentCboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentCboBox.FormattingEnabled = true;
            this.CommentCboBox.Location = new System.Drawing.Point(3, 418);
            this.CommentCboBox.Name = "CommentCboBox";
            this.CommentCboBox.Size = new System.Drawing.Size(244, 28);
            this.CommentCboBox.TabIndex = 165;
            this.CommentCboBox.Visible = false;
            // 
            // frmAlarmMsgCfg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CommentCboBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAlarmMsgCfg";
            this.Text = "报警/消息配置";
            this.ColModiMenuStrip.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParCfg_DgView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Label ItemLbl_0;
        private System.Windows.Forms.ComboBox ItemCon_0;
        private System.Windows.Forms.Label ItemLbl_2;
        public System.Windows.Forms.TextBox ItemCon_2;
        public System.Windows.Forms.TextBox CommentTxt;
        private System.Windows.Forms.ComboBox CommentCboBox;
        private System.Windows.Forms.Label ItemLbl_1;
        private System.Windows.Forms.ComboBox ItemCon_1;
    }
}