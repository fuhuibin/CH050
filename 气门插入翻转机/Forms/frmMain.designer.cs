namespace MyTestBed
{
    partial class frmMain
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
            System.Windows.Forms.TabPage tpCaliMeasVal;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtRealVal4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtCycleTime = new System.Windows.Forms.TextBox();
            this.txtRealVal3 = new System.Windows.Forms.TextBox();
            this.txtCaliVal3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMeasVal3 = new System.Windows.Forms.TextBox();
            this.txtRealVal2 = new System.Windows.Forms.TextBox();
            this.txtCaliVal2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbProdName = new System.Windows.Forms.ComboBox();
            this.txtMeasVal2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtScanBar = new System.Windows.Forms.TextBox();
            this.txtCaliVal1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMeasVal1 = new System.Windows.Forms.TextBox();
            this.txtRealVal1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.cmbProdNameID = new System.Windows.Forms.ComboBox();
            this.mySkinEngine = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.RsPlotTimer = new System.Windows.Forms.Timer(this.components);
            this.label19 = new System.Windows.Forms.Label();
            this.neSpin_C = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.neSpin_A = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.label47 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.neSpin_B = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.label48 = new System.Windows.Forms.Label();
            this.tcDispPlot = new System.Windows.Forms.TabControl();
            this.tpDispPlot = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSensor3 = new System.Windows.Forms.CheckBox();
            this.cbSensor2 = new System.Windows.Forms.CheckBox();
            this.cbSensor1 = new System.Windows.Forms.CheckBox();
            this.wfDataPlot = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.wfSpin_A = new NationalInstruments.UI.WaveformPlot();
            this.xAxis = new NationalInstruments.UI.XAxis();
            this.yDispAxis = new NationalInstruments.UI.YAxis();
            this.wfSpin_B = new NationalInstruments.UI.WaveformPlot();
            this.wfSpin_C = new NationalInstruments.UI.WaveformPlot();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtWorkMode = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.StatusTabPage = new System.Windows.Forms.TabPage();
            this.lstBoxStatusInfo = new System.Windows.Forms.ListBox();
            this.Alarm = new System.Windows.Forms.TabPage();
            this.lstBoxAlarmInfo1 = new System.Windows.Forms.ListBox();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcParCfgMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcGroupCfgMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcItemCfgMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AlarmInfoPar = new System.Windows.Forms.ToolStripMenuItem();
            this.DebugPar = new System.Windows.Forms.ToolStripMenuItem();
            this.SysParMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TestRecViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AlarmInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMmenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitWinMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShutDownMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.ParSetMmenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProdParMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSysTools = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiScreenKeyboard = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCalculator = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNotepad = new System.Windows.Forms.ToolStripMenuItem();
            this.tcMainCaliMeas = new System.Windows.Forms.TabControl();
            this.tcSlaveCaliMeas = new System.Windows.Forms.TabControl();
            this.tbMeasRec = new System.Windows.Forms.TabPage();
            this.dgvDataRec = new System.Windows.Forms.DataGridView();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ModeChoose = new System.Windows.Forms.ComboBox();
            this.手动调试界面 = new System.Windows.Forms.GroupBox();
            this.DebugButton = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.Stop_Button = new System.Windows.Forms.Button();
            this.Start_Button = new System.Windows.Forms.Button();
            this.Release = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.ledHeartBeat = new NationalInstruments.UI.WindowsForms.Led();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ledPlcAlarm = new NationalInstruments.UI.WindowsForms.Led();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstBoxAlarmInfo = new System.Windows.Forms.ListBox();
            tpCaliMeasVal = new System.Windows.Forms.TabPage();
            tpCaliMeasVal.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neSpin_C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neSpin_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neSpin_B)).BeginInit();
            this.tcDispPlot.SuspendLayout();
            this.tpDispPlot.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wfDataPlot)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.StatusTabPage.SuspendLayout();
            this.Alarm.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.tcMainCaliMeas.SuspendLayout();
            this.tcSlaveCaliMeas.SuspendLayout();
            this.tbMeasRec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataRec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.手动调试界面.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledHeartBeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledPlcAlarm)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpCaliMeasVal
            // 
            tpCaliMeasVal.BackColor = System.Drawing.Color.Transparent;
            tpCaliMeasVal.Controls.Add(this.groupBox3);
            tpCaliMeasVal.Location = new System.Drawing.Point(4, 29);
            tpCaliMeasVal.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            tpCaliMeasVal.Name = "tpCaliMeasVal";
            tpCaliMeasVal.Size = new System.Drawing.Size(563, 411);
            tpCaliMeasVal.TabIndex = 2;
            tpCaliMeasVal.Text = "测量结果( 单位:mm)";
            tpCaliMeasVal.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.txtRealVal4);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.txtRealVal3);
            this.groupBox3.Controls.Add(this.txtCaliVal3);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtMeasVal3);
            this.groupBox3.Controls.Add(this.txtRealVal2);
            this.groupBox3.Controls.Add(this.txtCaliVal2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cmbProdName);
            this.groupBox3.Controls.Add(this.txtMeasVal2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.txtScanBar);
            this.groupBox3.Controls.Add(this.txtCaliVal1);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtMeasVal1);
            this.groupBox3.Controls.Add(this.txtRealVal1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.cmbProdNameID);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(563, 412);
            this.groupBox3.TabIndex = 165;
            this.groupBox3.TabStop = false;
            // 
            // txtRealVal4
            // 
            this.txtRealVal4.BackColor = System.Drawing.Color.White;
            this.txtRealVal4.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRealVal4.ForeColor = System.Drawing.Color.Black;
            this.txtRealVal4.Location = new System.Drawing.Point(423, 348);
            this.txtRealVal4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRealVal4.Name = "txtRealVal4";
            this.txtRealVal4.ReadOnly = true;
            this.txtRealVal4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRealVal4.Size = new System.Drawing.Size(103, 42);
            this.txtRealVal4.TabIndex = 225;
            this.txtRealVal4.TabStop = false;
            this.txtRealVal4.Text = "*";
            this.txtRealVal4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(423, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 224;
            this.label9.Text = "气门凸出量_4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(317, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 223;
            this.label8.Text = "气门凸出量_3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(211, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 222;
            this.label6.Text = "气门凸出量_2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(104, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 221;
            this.label2.Text = "气门凸出量_1";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox6.Controls.Add(this.txtCycleTime);
            this.groupBox6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox6.ForeColor = System.Drawing.Color.Black;
            this.groupBox6.Location = new System.Drawing.Point(447, 24);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox6.Size = new System.Drawing.Size(109, 68);
            this.groupBox6.TabIndex = 178;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "循环时间:s";
            // 
            // txtCycleTime
            // 
            this.txtCycleTime.BackColor = System.Drawing.Color.White;
            this.txtCycleTime.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCycleTime.ForeColor = System.Drawing.Color.Black;
            this.txtCycleTime.Location = new System.Drawing.Point(23, 25);
            this.txtCycleTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCycleTime.Name = "txtCycleTime";
            this.txtCycleTime.ReadOnly = true;
            this.txtCycleTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCycleTime.Size = new System.Drawing.Size(59, 31);
            this.txtCycleTime.TabIndex = 183;
            this.txtCycleTime.TabStop = false;
            this.txtCycleTime.Text = "*";
            this.txtCycleTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRealVal3
            // 
            this.txtRealVal3.BackColor = System.Drawing.Color.White;
            this.txtRealVal3.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRealVal3.ForeColor = System.Drawing.Color.Black;
            this.txtRealVal3.Location = new System.Drawing.Point(317, 348);
            this.txtRealVal3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRealVal3.Name = "txtRealVal3";
            this.txtRealVal3.ReadOnly = true;
            this.txtRealVal3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRealVal3.Size = new System.Drawing.Size(96, 42);
            this.txtRealVal3.TabIndex = 220;
            this.txtRealVal3.TabStop = false;
            this.txtRealVal3.Text = "*";
            this.txtRealVal3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCaliVal3
            // 
            this.txtCaliVal3.BackColor = System.Drawing.Color.White;
            this.txtCaliVal3.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaliVal3.ForeColor = System.Drawing.Color.Black;
            this.txtCaliVal3.Location = new System.Drawing.Point(408, 160);
            this.txtCaliVal3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCaliVal3.Name = "txtCaliVal3";
            this.txtCaliVal3.ReadOnly = true;
            this.txtCaliVal3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCaliVal3.Size = new System.Drawing.Size(117, 42);
            this.txtCaliVal3.TabIndex = 218;
            this.txtCaliVal3.TabStop = false;
            this.txtCaliVal3.Text = "*";
            this.txtCaliVal3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(421, 125);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 216;
            this.label7.Text = "传感器3";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMeasVal3
            // 
            this.txtMeasVal3.BackColor = System.Drawing.Color.White;
            this.txtMeasVal3.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeasVal3.ForeColor = System.Drawing.Color.Black;
            this.txtMeasVal3.Location = new System.Drawing.Point(408, 230);
            this.txtMeasVal3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMeasVal3.Name = "txtMeasVal3";
            this.txtMeasVal3.ReadOnly = true;
            this.txtMeasVal3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMeasVal3.Size = new System.Drawing.Size(117, 42);
            this.txtMeasVal3.TabIndex = 219;
            this.txtMeasVal3.TabStop = false;
            this.txtMeasVal3.Text = "*";
            this.txtMeasVal3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRealVal2
            // 
            this.txtRealVal2.BackColor = System.Drawing.Color.White;
            this.txtRealVal2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRealVal2.ForeColor = System.Drawing.Color.Black;
            this.txtRealVal2.Location = new System.Drawing.Point(211, 348);
            this.txtRealVal2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRealVal2.Name = "txtRealVal2";
            this.txtRealVal2.ReadOnly = true;
            this.txtRealVal2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRealVal2.Size = new System.Drawing.Size(96, 42);
            this.txtRealVal2.TabIndex = 211;
            this.txtRealVal2.TabStop = false;
            this.txtRealVal2.Text = "*";
            this.txtRealVal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCaliVal2
            // 
            this.txtCaliVal2.BackColor = System.Drawing.Color.White;
            this.txtCaliVal2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaliVal2.ForeColor = System.Drawing.Color.Black;
            this.txtCaliVal2.Location = new System.Drawing.Point(251, 160);
            this.txtCaliVal2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCaliVal2.Name = "txtCaliVal2";
            this.txtCaliVal2.ReadOnly = true;
            this.txtCaliVal2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCaliVal2.Size = new System.Drawing.Size(124, 42);
            this.txtCaliVal2.TabIndex = 209;
            this.txtCaliVal2.TabStop = false;
            this.txtCaliVal2.Text = "*";
            this.txtCaliVal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(277, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 186;
            this.label3.Text = "传感器2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbProdName
            // 
            this.cmbProdName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProdName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbProdName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmbProdName.FormattingEnabled = true;
            this.cmbProdName.Location = new System.Drawing.Point(99, 18);
            this.cmbProdName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cmbProdName.Name = "cmbProdName";
            this.cmbProdName.Size = new System.Drawing.Size(229, 35);
            this.cmbProdName.TabIndex = 182;
            this.cmbProdName.SelectedIndexChanged += new System.EventHandler(this.cmbProdName_SelectedIndexChanged);
            // 
            // txtMeasVal2
            // 
            this.txtMeasVal2.BackColor = System.Drawing.Color.White;
            this.txtMeasVal2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeasVal2.ForeColor = System.Drawing.Color.Black;
            this.txtMeasVal2.Location = new System.Drawing.Point(251, 230);
            this.txtMeasVal2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMeasVal2.Name = "txtMeasVal2";
            this.txtMeasVal2.ReadOnly = true;
            this.txtMeasVal2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMeasVal2.Size = new System.Drawing.Size(124, 42);
            this.txtMeasVal2.TabIndex = 210;
            this.txtMeasVal2.TabStop = false;
            this.txtMeasVal2.Text = "*";
            this.txtMeasVal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(121, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 160;
            this.label1.Text = "传感器1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(8, 24);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(82, 24);
            this.label26.TabIndex = 173;
            this.label26.Text = "产品型号";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtScanBar
            // 
            this.txtScanBar.BackColor = System.Drawing.Color.White;
            this.txtScanBar.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtScanBar.ForeColor = System.Drawing.Color.Black;
            this.txtScanBar.Location = new System.Drawing.Point(99, 68);
            this.txtScanBar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtScanBar.Name = "txtScanBar";
            this.txtScanBar.ReadOnly = true;
            this.txtScanBar.Size = new System.Drawing.Size(333, 39);
            this.txtScanBar.TabIndex = 201;
            this.txtScanBar.TabStop = false;
            this.txtScanBar.Text = "***";
            this.txtScanBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCaliVal1
            // 
            this.txtCaliVal1.BackColor = System.Drawing.Color.White;
            this.txtCaliVal1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCaliVal1.ForeColor = System.Drawing.Color.Black;
            this.txtCaliVal1.Location = new System.Drawing.Point(104, 162);
            this.txtCaliVal1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCaliVal1.Name = "txtCaliVal1";
            this.txtCaliVal1.ReadOnly = true;
            this.txtCaliVal1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCaliVal1.Size = new System.Drawing.Size(117, 40);
            this.txtCaliVal1.TabIndex = 205;
            this.txtCaliVal1.TabStop = false;
            this.txtCaliVal1.Text = "*";
            this.txtCaliVal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(9, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 24);
            this.label13.TabIndex = 200;
            this.label13.Text = "产品条码";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMeasVal1
            // 
            this.txtMeasVal1.BackColor = System.Drawing.Color.White;
            this.txtMeasVal1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeasVal1.ForeColor = System.Drawing.Color.Black;
            this.txtMeasVal1.Location = new System.Drawing.Point(104, 230);
            this.txtMeasVal1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMeasVal1.Name = "txtMeasVal1";
            this.txtMeasVal1.ReadOnly = true;
            this.txtMeasVal1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMeasVal1.Size = new System.Drawing.Size(117, 42);
            this.txtMeasVal1.TabIndex = 206;
            this.txtMeasVal1.TabStop = false;
            this.txtMeasVal1.Text = "*";
            this.txtMeasVal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRealVal1
            // 
            this.txtRealVal1.AcceptsReturn = true;
            this.txtRealVal1.BackColor = System.Drawing.Color.White;
            this.txtRealVal1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRealVal1.ForeColor = System.Drawing.Color.Black;
            this.txtRealVal1.Location = new System.Drawing.Point(104, 348);
            this.txtRealVal1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRealVal1.Name = "txtRealVal1";
            this.txtRealVal1.ReadOnly = true;
            this.txtRealVal1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRealVal1.Size = new System.Drawing.Size(96, 42);
            this.txtRealVal1.TabIndex = 207;
            this.txtRealVal1.TabStop = false;
            this.txtRealVal1.Text = "*";
            this.txtRealVal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(17, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 166;
            this.label5.Text = "标定值";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(17, 235);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 169;
            this.label4.Text = "测量值";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label30.Location = new System.Drawing.Point(4, 355);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(100, 24);
            this.label30.TabIndex = 168;
            this.label30.Text = "气门凸出量";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbProdNameID
            // 
            this.cmbProdNameID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProdNameID.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbProdNameID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmbProdNameID.FormattingEnabled = true;
            this.cmbProdNameID.Location = new System.Drawing.Point(99, 18);
            this.cmbProdNameID.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cmbProdNameID.Name = "cmbProdNameID";
            this.cmbProdNameID.Size = new System.Drawing.Size(133, 35);
            this.cmbProdNameID.TabIndex = 183;
            this.cmbProdNameID.Visible = false;
            // 
            // mySkinEngine
            // 
            this.mySkinEngine.SerialNumber = "";
            this.mySkinEngine.SkinFile = null;
            // 
            // RsPlotTimer
            // 
            this.RsPlotTimer.Interval = 125;
            this.RsPlotTimer.Tick += new System.EventHandler(this.RsPlotTimer_Tick);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.ForeColor = System.Drawing.Color.DarkCyan;
            this.label19.Location = new System.Drawing.Point(540, 46);
            this.label19.Name = "label19";
            this.label19.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label19.Size = new System.Drawing.Size(331, 52);
            this.label19.TabIndex = 148;
            this.label19.Text = "气门插入翻转机";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // neSpin_C
            // 
            this.neSpin_C.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.neSpin_C.CoercionInterval = 5;
            this.neSpin_C.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neSpin_C.ForeColor = System.Drawing.Color.White;
            this.neSpin_C.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3);
            this.neSpin_C.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.neSpin_C.Location = new System.Drawing.Point(19, 306);
            this.neSpin_C.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.neSpin_C.Name = "neSpin_C";
            this.neSpin_C.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.neSpin_C.Size = new System.Drawing.Size(123, 35);
            this.neSpin_C.TabIndex = 156;
            this.neSpin_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.neSpin_C.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // neSpin_A
            // 
            this.neSpin_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.neSpin_A.CoercionInterval = 5;
            this.neSpin_A.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neSpin_A.ForeColor = System.Drawing.Color.White;
            this.neSpin_A.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3);
            this.neSpin_A.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.neSpin_A.Location = new System.Drawing.Point(17, 60);
            this.neSpin_A.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.neSpin_A.Name = "neSpin_A";
            this.neSpin_A.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.neSpin_A.Size = new System.Drawing.Size(125, 35);
            this.neSpin_A.TabIndex = 132;
            this.neSpin_A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.neSpin_A.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.SystemColors.Control;
            this.label47.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label47.Location = new System.Drawing.Point(13, 272);
            this.label47.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(93, 20);
            this.label47.TabIndex = 133;
            this.label47.Text = "位移传感器3";
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.BackColor = System.Drawing.SystemColors.Control;
            this.label50.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label50.Location = new System.Drawing.Point(13, 148);
            this.label50.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(93, 20);
            this.label50.TabIndex = 141;
            this.label50.Text = "位移传感器2";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // neSpin_B
            // 
            this.neSpin_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.neSpin_B.CoercionInterval = 5;
            this.neSpin_B.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neSpin_B.ForeColor = System.Drawing.Color.White;
            this.neSpin_B.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3);
            this.neSpin_B.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.neSpin_B.Location = new System.Drawing.Point(17, 176);
            this.neSpin_B.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.neSpin_B.Name = "neSpin_B";
            this.neSpin_B.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.neSpin_B.Size = new System.Drawing.Size(123, 35);
            this.neSpin_B.TabIndex = 138;
            this.neSpin_B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.neSpin_B.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.BackColor = System.Drawing.SystemColors.Control;
            this.label48.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label48.Location = new System.Drawing.Point(13, 31);
            this.label48.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(93, 20);
            this.label48.TabIndex = 136;
            this.label48.Text = "位移传感器1";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tcDispPlot
            // 
            this.tcDispPlot.Controls.Add(this.tpDispPlot);
            this.tcDispPlot.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcDispPlot.Location = new System.Drawing.Point(13, 106);
            this.tcDispPlot.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tcDispPlot.Name = "tcDispPlot";
            this.tcDispPlot.SelectedIndex = 0;
            this.tcDispPlot.Size = new System.Drawing.Size(165, 444);
            this.tcDispPlot.TabIndex = 153;
            // 
            // tpDispPlot
            // 
            this.tpDispPlot.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpDispPlot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tpDispPlot.Controls.Add(this.groupBox2);
            this.tpDispPlot.Location = new System.Drawing.Point(4, 29);
            this.tpDispPlot.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tpDispPlot.Name = "tpDispPlot";
            this.tpDispPlot.Size = new System.Drawing.Size(157, 411);
            this.tpDispPlot.TabIndex = 1;
            this.tpDispPlot.Text = "传感器实时值";
            this.tpDispPlot.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.neSpin_C);
            this.groupBox2.Controls.Add(this.label50);
            this.groupBox2.Controls.Add(this.label48);
            this.groupBox2.Controls.Add(this.neSpin_B);
            this.groupBox2.Controls.Add(this.neSpin_A);
            this.groupBox2.Controls.Add(this.label47);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(153, 407);
            this.groupBox2.TabIndex = 176;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.cbSensor3);
            this.groupBox1.Controls.Add(this.cbSensor2);
            this.groupBox1.Controls.Add(this.cbSensor1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(5, 365);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Size = new System.Drawing.Size(504, 42);
            this.groupBox1.TabIndex = 106;
            this.groupBox1.TabStop = false;
            // 
            // cbSensor3
            // 
            this.cbSensor3.AutoSize = true;
            this.cbSensor3.BackColor = System.Drawing.Color.Black;
            this.cbSensor3.Checked = true;
            this.cbSensor3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSensor3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbSensor3.ForeColor = System.Drawing.Color.Lime;
            this.cbSensor3.Location = new System.Drawing.Point(379, 18);
            this.cbSensor3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbSensor3.Name = "cbSensor3";
            this.cbSensor3.Size = new System.Drawing.Size(118, 19);
            this.cbSensor3.TabIndex = 130;
            this.cbSensor3.Text = "位移传感器3";
            this.cbSensor3.UseVisualStyleBackColor = false;
            this.cbSensor3.CheckedChanged += new System.EventHandler(this.WavePlot_CheckedChanged);
            // 
            // cbSensor2
            // 
            this.cbSensor2.AutoSize = true;
            this.cbSensor2.BackColor = System.Drawing.Color.Black;
            this.cbSensor2.Checked = true;
            this.cbSensor2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSensor2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbSensor2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cbSensor2.Location = new System.Drawing.Point(197, 19);
            this.cbSensor2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbSensor2.Name = "cbSensor2";
            this.cbSensor2.Size = new System.Drawing.Size(118, 19);
            this.cbSensor2.TabIndex = 3;
            this.cbSensor2.Text = "位移传感器2";
            this.cbSensor2.UseVisualStyleBackColor = false;
            this.cbSensor2.CheckedChanged += new System.EventHandler(this.WavePlot_CheckedChanged);
            // 
            // cbSensor1
            // 
            this.cbSensor1.AutoSize = true;
            this.cbSensor1.BackColor = System.Drawing.Color.Black;
            this.cbSensor1.Checked = true;
            this.cbSensor1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSensor1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbSensor1.ForeColor = System.Drawing.Color.Cyan;
            this.cbSensor1.Location = new System.Drawing.Point(7, 18);
            this.cbSensor1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbSensor1.Name = "cbSensor1";
            this.cbSensor1.Size = new System.Drawing.Size(118, 19);
            this.cbSensor1.TabIndex = 1;
            this.cbSensor1.Text = "位移传感器1";
            this.cbSensor1.UseVisualStyleBackColor = false;
            this.cbSensor1.CheckedChanged += new System.EventHandler(this.WavePlot_CheckedChanged);
            // 
            // wfDataPlot
            // 
            this.wfDataPlot.BindingMethod = NationalInstruments.UI.BindableWaveformGraphMethod.PlotYAppend;
            this.wfDataPlot.Border = NationalInstruments.UI.Border.Raised;
            this.wfDataPlot.CanShowFocus = true;
            this.wfDataPlot.CaptionBackColor = System.Drawing.Color.Transparent;
            this.wfDataPlot.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wfDataPlot.CaptionForeColor = System.Drawing.Color.Black;
            this.wfDataPlot.CaptionVisible = false;
            this.wfDataPlot.Cursor = System.Windows.Forms.Cursors.Default;
            this.wfDataPlot.Dock = System.Windows.Forms.DockStyle.Top;
            this.wfDataPlot.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wfDataPlot.Location = new System.Drawing.Point(0, 0);
            this.wfDataPlot.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.wfDataPlot.Name = "wfDataPlot";
            this.wfDataPlot.PlotAreaBorder = NationalInstruments.UI.Border.ThinFrame3D;
            this.wfDataPlot.PlotAreaImageAlignment = NationalInstruments.UI.ImageAlignment.Center;
            this.wfDataPlot.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.wfSpin_A,
            this.wfSpin_B,
            this.wfSpin_C});
            this.wfDataPlot.SelectionColor = System.Drawing.Color.Transparent;
            this.wfDataPlot.Size = new System.Drawing.Size(505, 359);
            this.wfDataPlot.TabIndex = 104;
            this.wfDataPlot.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis});
            this.wfDataPlot.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yDispAxis});
            // 
            // wfSpin_A
            // 
            this.wfSpin_A.LineColor = System.Drawing.Color.Cyan;
            this.wfSpin_A.XAxis = this.xAxis;
            this.wfSpin_A.YAxis = this.yDispAxis;
            // 
            // xAxis
            // 
            this.xAxis.AutoMinorDivisionFrequency = 5;
            this.xAxis.Mode = NationalInstruments.UI.AxisMode.StripChart;
            this.xAxis.Range = new NationalInstruments.UI.Range(0, 250);
            this.xAxis.Visible = false;
            // 
            // yDispAxis
            // 
            this.yDispAxis.AutoMinorDivisionFrequency = 5;
            this.yDispAxis.BaseLineVisible = true;
            this.yDispAxis.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yDispAxis.EditRangeNumericFormatMode = NationalInstruments.UI.NumericFormatMode.CreateGenericMode("F3");
            this.yDispAxis.LeftCaptionOrientation = NationalInstruments.UI.VerticalCaptionOrientation.TopToBottom;
            this.yDispAxis.MajorDivisions.GridColor = System.Drawing.Color.Gray;
            this.yDispAxis.MajorDivisions.GridVisible = true;
            this.yDispAxis.MajorDivisions.Interval = 1;
            this.yDispAxis.MajorDivisions.LabelFormat = new NationalInstruments.UI.FormatString(NationalInstruments.UI.FormatStringMode.Numeric, "F0");
            this.yDispAxis.MinorDivisions.GridVisible = true;
            this.yDispAxis.MinorDivisions.Interval = 5;
            this.yDispAxis.MinorDivisions.TickVisible = true;
            this.yDispAxis.Mode = NationalInstruments.UI.AxisMode.StripChart;
            this.yDispAxis.OriginLineStyle = NationalInstruments.UI.LineStyle.Dash;
            this.yDispAxis.Range = new NationalInstruments.UI.Range(-2, 10);
            // 
            // wfSpin_B
            // 
            this.wfSpin_B.LineColor = System.Drawing.Color.Red;
            this.wfSpin_B.PointColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.wfSpin_B.XAxis = this.xAxis;
            this.wfSpin_B.YAxis = this.yDispAxis;
            // 
            // wfSpin_C
            // 
            this.wfSpin_C.LineWidth = 1.5F;
            this.wfSpin_C.PointColor = System.Drawing.Color.Fuchsia;
            this.wfSpin_C.XAxis = this.xAxis;
            this.wfSpin_C.YAxis = this.yDispAxis;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Controls.Add(this.txtWorkMode);
            this.groupBox5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(1155, 46);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox5.Size = new System.Drawing.Size(155, 74);
            this.groupBox5.TabIndex = 128;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "工作模式";
            // 
            // txtWorkMode
            // 
            this.txtWorkMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtWorkMode.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtWorkMode.ForeColor = System.Drawing.Color.White;
            this.txtWorkMode.Location = new System.Drawing.Point(11, 28);
            this.txtWorkMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWorkMode.Name = "txtWorkMode";
            this.txtWorkMode.ReadOnly = true;
            this.txtWorkMode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtWorkMode.Size = new System.Drawing.Size(137, 31);
            this.txtWorkMode.TabIndex = 183;
            this.txtWorkMode.TabStop = false;
            this.txtWorkMode.Text = "*";
            this.txtWorkMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.StatusTabPage);
            this.tabControl.Controls.Add(this.Alarm);
            this.tabControl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(740, 585);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(492, 298);
            this.tabControl.TabIndex = 163;
            // 
            // StatusTabPage
            // 
            this.StatusTabPage.Controls.Add(this.lstBoxStatusInfo);
            this.StatusTabPage.Location = new System.Drawing.Point(4, 29);
            this.StatusTabPage.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.StatusTabPage.Name = "StatusTabPage";
            this.StatusTabPage.Size = new System.Drawing.Size(484, 265);
            this.StatusTabPage.TabIndex = 1;
            this.StatusTabPage.Text = "上下位过程信息指示";
            this.StatusTabPage.UseVisualStyleBackColor = true;
            // 
            // lstBoxStatusInfo
            // 
            this.lstBoxStatusInfo.BackColor = System.Drawing.SystemColors.Control;
            this.lstBoxStatusInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBoxStatusInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstBoxStatusInfo.FormattingEnabled = true;
            this.lstBoxStatusInfo.HorizontalScrollbar = true;
            this.lstBoxStatusInfo.ItemHeight = 20;
            this.lstBoxStatusInfo.Location = new System.Drawing.Point(0, 0);
            this.lstBoxStatusInfo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lstBoxStatusInfo.Name = "lstBoxStatusInfo";
            this.lstBoxStatusInfo.Size = new System.Drawing.Size(484, 264);
            this.lstBoxStatusInfo.TabIndex = 2;
            // 
            // Alarm
            // 
            this.Alarm.Controls.Add(this.lstBoxAlarmInfo1);
            this.Alarm.Location = new System.Drawing.Point(4, 29);
            this.Alarm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Alarm.Name = "Alarm";
            this.Alarm.Size = new System.Drawing.Size(484, 265);
            this.Alarm.TabIndex = 2;
            this.Alarm.Text = "下位报警及故障提示";
            this.Alarm.UseVisualStyleBackColor = true;
            // 
            // lstBoxAlarmInfo1
            // 
            this.lstBoxAlarmInfo1.BackColor = System.Drawing.SystemColors.Control;
            this.lstBoxAlarmInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxAlarmInfo1.FormattingEnabled = true;
            this.lstBoxAlarmInfo1.HorizontalScrollbar = true;
            this.lstBoxAlarmInfo1.ItemHeight = 20;
            this.lstBoxAlarmInfo1.Location = new System.Drawing.Point(0, 4);
            this.lstBoxAlarmInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.lstBoxAlarmInfo1.Name = "lstBoxAlarmInfo1";
            this.lstBoxAlarmInfo1.Size = new System.Drawing.Size(481, 264);
            this.lstBoxAlarmInfo1.TabIndex = 3;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem2.Text = "屏幕键盘";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem3.Text = "计算器";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem4.Text = "记事本";
            // 
            // OpcParCfgMenuItem
            // 
            this.OpcParCfgMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpcGroupCfgMenuItem,
            this.OpcItemCfgMenuItem,
            this.AlarmInfoPar,
            this.DebugPar,
            this.SysParMenuItem});
            this.OpcParCfgMenuItem.Name = "OpcParCfgMenuItem";
            this.OpcParCfgMenuItem.Size = new System.Drawing.Size(130, 28);
            this.OpcParCfgMenuItem.Text = "设计参数配置";
            // 
            // OpcGroupCfgMenuItem
            // 
            this.OpcGroupCfgMenuItem.Name = "OpcGroupCfgMenuItem";
            this.OpcGroupCfgMenuItem.Size = new System.Drawing.Size(244, 28);
            this.OpcGroupCfgMenuItem.Text = "OPC参数组配置";
            this.OpcGroupCfgMenuItem.Click += new System.EventHandler(this.OpcParCfgMenuItem_Click);
            // 
            // OpcItemCfgMenuItem
            // 
            this.OpcItemCfgMenuItem.Name = "OpcItemCfgMenuItem";
            this.OpcItemCfgMenuItem.Size = new System.Drawing.Size(244, 28);
            this.OpcItemCfgMenuItem.Text = "OPC参数组标签配置";
            this.OpcItemCfgMenuItem.Click += new System.EventHandler(this.OpcParCfgMenuItem_Click);
            // 
            // AlarmInfoPar
            // 
            this.AlarmInfoPar.Name = "AlarmInfoPar";
            this.AlarmInfoPar.Size = new System.Drawing.Size(244, 28);
            this.AlarmInfoPar.Text = "报警及消息参数配置";
            this.AlarmInfoPar.Click += new System.EventHandler(this.AlarmInfoPar_Click);
            // 
            // DebugPar
            // 
            this.DebugPar.Name = "DebugPar";
            this.DebugPar.Size = new System.Drawing.Size(244, 28);
            this.DebugPar.Text = "调试按钮位信息配置";
            this.DebugPar.Click += new System.EventHandler(this.DebugPar_Click);
            // 
            // SysParMenuItem
            // 
            this.SysParMenuItem.Name = "SysParMenuItem";
            this.SysParMenuItem.Size = new System.Drawing.Size(244, 28);
            this.SysParMenuItem.Text = "系统参数配置";
            this.SysParMenuItem.Click += new System.EventHandler(this.OpcParCfgMenuItem_Click);
            // 
            // InfoViewMenuItem
            // 
            this.InfoViewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TestRecViewMenuItem,
            this.AlarmInfo});
            this.InfoViewMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InfoViewMenuItem.Name = "InfoViewMenuItem";
            this.InfoViewMenuItem.Size = new System.Drawing.Size(130, 28);
            this.InfoViewMenuItem.Text = "信息记录查询";
            // 
            // TestRecViewMenuItem
            // 
            this.TestRecViewMenuItem.Name = "TestRecViewMenuItem";
            this.TestRecViewMenuItem.Size = new System.Drawing.Size(188, 28);
            this.TestRecViewMenuItem.Text = "试验记录浏览";
            this.TestRecViewMenuItem.Click += new System.EventHandler(this.InfoViewMenuItem_Click);
            // 
            // AlarmInfo
            // 
            this.AlarmInfo.Name = "AlarmInfo";
            this.AlarmInfo.Size = new System.Drawing.Size(188, 28);
            this.AlarmInfo.Text = "报警信息查询";
            this.AlarmInfo.Click += new System.EventHandler(this.AlarmInfo_Click);
            // 
            // ExitMmenuItem
            // 
            this.ExitMmenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitWinMenuItem,
            this.ShutDownMenuItem});
            this.ExitMmenuItem.Name = "ExitMmenuItem";
            this.ExitMmenuItem.Size = new System.Drawing.Size(58, 28);
            this.ExitMmenuItem.Text = "退出";
            // 
            // ExitWinMenuItem
            // 
            this.ExitWinMenuItem.Name = "ExitWinMenuItem";
            this.ExitWinMenuItem.Size = new System.Drawing.Size(231, 28);
            this.ExitWinMenuItem.Text = "退到Windows界面";
            this.ExitWinMenuItem.Click += new System.EventHandler(this.ExitWinMenuItem_Click);
            // 
            // ShutDownMenuItem
            // 
            this.ShutDownMenuItem.Name = "ShutDownMenuItem";
            this.ShutDownMenuItem.Size = new System.Drawing.Size(231, 28);
            this.ShutDownMenuItem.Text = "关机";
            this.ShutDownMenuItem.Click += new System.EventHandler(this.ShutDownMenuItem_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.MenuStrip.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpcParCfgMenuItem,
            this.ParSetMmenuItem,
            this.InfoViewMenuItem,
            this.tsmiSysTools,
            this.ExitMmenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MenuStrip.Size = new System.Drawing.Size(1316, 32);
            this.MenuStrip.TabIndex = 131;
            this.MenuStrip.Text = "menuStrip2";
            // 
            // ParSetMmenuItem
            // 
            this.ParSetMmenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProdParMenuItem});
            this.ParSetMmenuItem.Name = "ParSetMmenuItem";
            this.ParSetMmenuItem.Size = new System.Drawing.Size(130, 28);
            this.ParSetMmenuItem.Text = "产品参数配置";
            // 
            // ProdParMenuItem
            // 
            this.ProdParMenuItem.Name = "ProdParMenuItem";
            this.ProdParMenuItem.Size = new System.Drawing.Size(188, 28);
            this.ProdParMenuItem.Text = "产品参数配置";
            this.ProdParMenuItem.Click += new System.EventHandler(this.ProdParCfgMenuItem_Click);
            // 
            // tsmiSysTools
            // 
            this.tsmiSysTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiScreenKeyboard,
            this.tsmiCalculator,
            this.tsmiNotepad});
            this.tsmiSysTools.Name = "tsmiSysTools";
            this.tsmiSysTools.Size = new System.Drawing.Size(94, 28);
            this.tsmiSysTools.Text = "系统工具";
            // 
            // tsmiScreenKeyboard
            // 
            this.tsmiScreenKeyboard.Name = "tsmiScreenKeyboard";
            this.tsmiScreenKeyboard.Size = new System.Drawing.Size(152, 28);
            this.tsmiScreenKeyboard.Text = "屏幕键盘";
            this.tsmiScreenKeyboard.Click += new System.EventHandler(this.tsmiScreenKeyboard_Click);
            // 
            // tsmiCalculator
            // 
            this.tsmiCalculator.Name = "tsmiCalculator";
            this.tsmiCalculator.Size = new System.Drawing.Size(152, 28);
            this.tsmiCalculator.Text = "计算器";
            this.tsmiCalculator.Click += new System.EventHandler(this.tsmiCalculator_Click);
            // 
            // tsmiNotepad
            // 
            this.tsmiNotepad.Name = "tsmiNotepad";
            this.tsmiNotepad.Size = new System.Drawing.Size(152, 28);
            this.tsmiNotepad.Text = "记事本";
            this.tsmiNotepad.Click += new System.EventHandler(this.tsmiNotepad_Click);
            // 
            // tcMainCaliMeas
            // 
            this.tcMainCaliMeas.Controls.Add(tpCaliMeasVal);
            this.tcMainCaliMeas.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tcMainCaliMeas.Location = new System.Drawing.Point(740, 106);
            this.tcMainCaliMeas.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tcMainCaliMeas.Name = "tcMainCaliMeas";
            this.tcMainCaliMeas.SelectedIndex = 0;
            this.tcMainCaliMeas.Size = new System.Drawing.Size(571, 444);
            this.tcMainCaliMeas.TabIndex = 151;
            // 
            // tcSlaveCaliMeas
            // 
            this.tcSlaveCaliMeas.Controls.Add(this.tbMeasRec);
            this.tcSlaveCaliMeas.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcSlaveCaliMeas.Location = new System.Drawing.Point(247, 579);
            this.tcSlaveCaliMeas.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tcSlaveCaliMeas.Name = "tcSlaveCaliMeas";
            this.tcSlaveCaliMeas.SelectedIndex = 0;
            this.tcSlaveCaliMeas.Size = new System.Drawing.Size(485, 302);
            this.tcSlaveCaliMeas.TabIndex = 166;
            // 
            // tbMeasRec
            // 
            this.tbMeasRec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbMeasRec.Controls.Add(this.dgvDataRec);
            this.tbMeasRec.Location = new System.Drawing.Point(4, 29);
            this.tbMeasRec.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbMeasRec.Name = "tbMeasRec";
            this.tbMeasRec.Size = new System.Drawing.Size(477, 269);
            this.tbMeasRec.TabIndex = 3;
            this.tbMeasRec.Text = "最近测量记录";
            this.tbMeasRec.UseVisualStyleBackColor = true;
            // 
            // dgvDataRec
            // 
            this.dgvDataRec.AllowUserToAddRows = false;
            this.dgvDataRec.AllowUserToDeleteRows = false;
            this.dgvDataRec.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDataRec.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvDataRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataRec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataRec.Location = new System.Drawing.Point(0, 0);
            this.dgvDataRec.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvDataRec.Name = "dgvDataRec";
            this.dgvDataRec.ReadOnly = true;
            this.dgvDataRec.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvDataRec.RowTemplate.Height = 23;
            this.dgvDataRec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataRec.Size = new System.Drawing.Size(473, 265);
            this.dgvDataRec.TabIndex = 44;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(1191, 11);
            this.pictureBox13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(119, 36);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 175;
            this.pictureBox13.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(213, 106);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(517, 444);
            this.tabControl1.TabIndex = 176;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.wfDataPlot);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(509, 411);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "传感器实时值曲线";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ModeChoose);
            this.groupBox4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(955, 46);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(164, 74);
            this.groupBox4.TabIndex = 186;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "工作模式选择 ";
            // 
            // ModeChoose
            // 
            this.ModeChoose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModeChoose.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ModeChoose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ModeChoose.FormattingEnabled = true;
            this.ModeChoose.Items.AddRange(new object[] {
            "手动模式",
            "自动模式",
            "空循环模式",
            "旁通模式",
            "标定模式"});
            this.ModeChoose.Location = new System.Drawing.Point(19, 25);
            this.ModeChoose.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ModeChoose.Name = "ModeChoose";
            this.ModeChoose.Size = new System.Drawing.Size(129, 35);
            this.ModeChoose.TabIndex = 183;
            this.ModeChoose.SelectedIndexChanged += new System.EventHandler(this.ModeChoose_SelectedIndexChanged);
            // 
            // 手动调试界面
            // 
            this.手动调试界面.Controls.Add(this.DebugButton);
            this.手动调试界面.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.手动调试界面.Location = new System.Drawing.Point(13, 715);
            this.手动调试界面.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.手动调试界面.Name = "手动调试界面";
            this.手动调试界面.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.手动调试界面.Size = new System.Drawing.Size(165, 81);
            this.手动调试界面.TabIndex = 187;
            this.手动调试界面.TabStop = false;
            this.手动调试界面.Text = "按钮调试";
            // 
            // DebugButton
            // 
            this.DebugButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DebugButton.Location = new System.Drawing.Point(3, 26);
            this.DebugButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DebugButton.Name = "DebugButton";
            this.DebugButton.Size = new System.Drawing.Size(163, 44);
            this.DebugButton.TabIndex = 19;
            this.DebugButton.Text = "请点击进行调试";
            this.DebugButton.UseVisualStyleBackColor = true;
            this.DebugButton.Click += new System.EventHandler(this.DebugButton_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.Stop_Button);
            this.groupBox9.Controls.Add(this.Start_Button);
            this.groupBox9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox9.Location = new System.Drawing.Point(12, 579);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox9.Size = new System.Drawing.Size(221, 100);
            this.groupBox9.TabIndex = 193;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "强制启动/停止";
            // 
            // Stop_Button
            // 
            this.Stop_Button.Location = new System.Drawing.Point(116, 35);
            this.Stop_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Stop_Button.Name = "Stop_Button";
            this.Stop_Button.Size = new System.Drawing.Size(85, 48);
            this.Stop_Button.TabIndex = 1;
            this.Stop_Button.Text = "停止";
            this.Stop_Button.UseVisualStyleBackColor = true;
            this.Stop_Button.Click += new System.EventHandler(this.Stop_Button_Click);
            // 
            // Start_Button
            // 
            this.Start_Button.Location = new System.Drawing.Point(16, 32);
            this.Start_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(84, 48);
            this.Start_Button.TabIndex = 0;
            this.Start_Button.Text = "启动";
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // Release
            // 
            this.Release.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Release.Location = new System.Drawing.Point(12, 811);
            this.Release.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Release.Name = "Release";
            this.Release.Size = new System.Drawing.Size(75, 65);
            this.Release.TabIndex = 194;
            this.Release.Text = "放行";
            this.Release.UseVisualStyleBackColor = true;
            this.Release.Click += new System.EventHandler(this.Release_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox7.Controls.Add(this.ledHeartBeat);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.ledPlcAlarm);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox7.ForeColor = System.Drawing.Color.Black;
            this.groupBox7.Location = new System.Drawing.Point(1263, 614);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox7.Size = new System.Drawing.Size(47, 249);
            this.groupBox7.TabIndex = 195;
            this.groupBox7.TabStop = false;
            // 
            // ledHeartBeat
            // 
            this.ledHeartBeat.BackgroundImageAlignment = NationalInstruments.UI.ImageAlignment.Center;
            this.ledHeartBeat.BlinkInterval = System.TimeSpan.Parse("00:00:10");
            this.ledHeartBeat.BlinkMode = NationalInstruments.UI.LedBlinkMode.BlinkWhenOn;
            this.ledHeartBeat.LedStyle = NationalInstruments.UI.LedStyle.Round3D;
            this.ledHeartBeat.Location = new System.Drawing.Point(4, 196);
            this.ledHeartBeat.Margin = new System.Windows.Forms.Padding(4);
            this.ledHeartBeat.Name = "ledHeartBeat";
            this.ledHeartBeat.OnColor = System.Drawing.Color.Red;
            this.ledHeartBeat.Size = new System.Drawing.Size(41, 40);
            this.ledHeartBeat.TabIndex = 158;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(4, 174);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 18);
            this.label11.TabIndex = 160;
            this.label11.Text = "心跳";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(4, 21);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 18);
            this.label10.TabIndex = 159;
            this.label10.Text = "报警";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ledPlcAlarm
            // 
            this.ledPlcAlarm.BackgroundImageAlignment = NationalInstruments.UI.ImageAlignment.Center;
            this.ledPlcAlarm.BlinkMode = NationalInstruments.UI.LedBlinkMode.BlinkWhenOn;
            this.ledPlcAlarm.LedStyle = NationalInstruments.UI.LedStyle.Round3D;
            this.ledPlcAlarm.Location = new System.Drawing.Point(4, 42);
            this.ledPlcAlarm.Margin = new System.Windows.Forms.Padding(4);
            this.ledPlcAlarm.Name = "ledPlcAlarm";
            this.ledPlcAlarm.OnColor = System.Drawing.Color.Red;
            this.ledPlcAlarm.Size = new System.Drawing.Size(41, 40);
            this.ledPlcAlarm.TabIndex = 158;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(406, 262);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "上下位过程信息指示";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(404, 244);
            this.listBox1.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lstBoxAlarmInfo);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(406, 262);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "下位报警及故障提示";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstBoxAlarmInfo
            // 
            this.lstBoxAlarmInfo.BackColor = System.Drawing.SystemColors.Control;
            this.lstBoxAlarmInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxAlarmInfo.FormattingEnabled = true;
            this.lstBoxAlarmInfo.HorizontalScrollbar = true;
            this.lstBoxAlarmInfo.ItemHeight = 20;
            this.lstBoxAlarmInfo.Location = new System.Drawing.Point(-4, 1);
            this.lstBoxAlarmInfo.Margin = new System.Windows.Forms.Padding(4);
            this.lstBoxAlarmInfo.Name = "lstBoxAlarmInfo";
            this.lstBoxAlarmInfo.Size = new System.Drawing.Size(406, 244);
            this.lstBoxAlarmInfo.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1316, 902);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.Release);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.手动调试界面);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.tcMainCaliMeas);
            this.Controls.Add(this.tcSlaveCaliMeas);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tcDispPlot);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.MenuStrip);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "气门插入翻转机";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            tpCaliMeasVal.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neSpin_C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neSpin_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neSpin_B)).EndInit();
            this.tcDispPlot.ResumeLayout(false);
            this.tpDispPlot.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wfDataPlot)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.StatusTabPage.ResumeLayout(false);
            this.Alarm.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.tcMainCaliMeas.ResumeLayout(false);
            this.tcSlaveCaliMeas.ResumeLayout(false);
            this.tbMeasRec.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataRec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.手动调试界面.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledHeartBeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledPlcAlarm)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunisoft.IrisSkin.SkinEngine mySkinEngine;
        private System.Windows.Forms.Timer RsPlotTimer;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label50;
        private NationalInstruments.UI.WindowsForms.NumericEdit neSpin_B;
        private System.Windows.Forms.Label label48;
        private NationalInstruments.UI.WindowsForms.NumericEdit neSpin_A;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TabControl tcDispPlot;
        private System.Windows.Forms.TabPage tpDispPlot;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbSensor1;
        private NationalInstruments.UI.WindowsForms.WaveformGraph wfDataPlot;
        private NationalInstruments.UI.WaveformPlot wfSpin_C;
        private NationalInstruments.UI.XAxis xAxis;
        private NationalInstruments.UI.YAxis yDispAxis;
        private NationalInstruments.UI.WaveformPlot wfSpin_A;
        private NationalInstruments.UI.WaveformPlot wfSpin_B;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage StatusTabPage;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.GroupBox groupBox5;
        private NationalInstruments.UI.WindowsForms.NumericEdit neSpin_C;
        private System.Windows.Forms.ToolStripMenuItem OpcParCfgMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpcGroupCfgMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpcItemCfgMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InfoViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TestRecViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMmenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitWinMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShutDownMenuItem;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.CheckBox cbSensor2;
        private System.Windows.Forms.TabControl tcMainCaliMeas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tcSlaveCaliMeas;
        private System.Windows.Forms.TabPage tbMeasRec;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ToolStripMenuItem ParSetMmenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProdParMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtScanBar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtRealVal2;
        private System.Windows.Forms.TextBox txtMeasVal2;
        private System.Windows.Forms.TextBox txtCaliVal2;
        private System.Windows.Forms.TextBox txtRealVal1;
        private System.Windows.Forms.TextBox txtMeasVal1;
        private System.Windows.Forms.TextBox txtCaliVal1;
        private System.Windows.Forms.DataGridView dgvDataRec;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.ToolStripMenuItem tsmiSysTools;
        private System.Windows.Forms.ToolStripMenuItem tsmiScreenKeyboard;
        private System.Windows.Forms.ToolStripMenuItem tsmiCalculator;
        private System.Windows.Forms.ToolStripMenuItem tsmiNotepad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtWorkMode;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtCycleTime;
        private System.Windows.Forms.ComboBox cmbProdName;
        private System.Windows.Forms.ComboBox cmbProdNameID;
        private System.Windows.Forms.ToolStripMenuItem SysParMenuItem;
        private System.Windows.Forms.CheckBox cbSensor3;
        private System.Windows.Forms.TextBox txtRealVal3;
        private System.Windows.Forms.TextBox txtCaliVal3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMeasVal3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox ModeChoose;
        private System.Windows.Forms.GroupBox 手动调试界面;
        private System.Windows.Forms.Button DebugButton;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button Stop_Button;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Button Release;
        private System.Windows.Forms.TabPage Alarm;
        private System.Windows.Forms.GroupBox groupBox7;
        private NationalInstruments.UI.WindowsForms.Led ledHeartBeat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private NationalInstruments.UI.WindowsForms.Led ledPlcAlarm;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lstBoxAlarmInfo;
        private System.Windows.Forms.ListBox lstBoxAlarmInfo1;
        private System.Windows.Forms.ToolStripMenuItem AlarmInfoPar;
        private System.Windows.Forms.ToolStripMenuItem DebugPar;
        private System.Windows.Forms.ToolStripMenuItem AlarmInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRealVal4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstBoxStatusInfo;

    }
}