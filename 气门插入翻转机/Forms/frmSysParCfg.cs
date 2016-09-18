using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using TIniFile;

namespace MyTestBed
{
    public partial class frmSysParCfg : Form
    {
        private TIniFilePtr IniFilePtr = TIniFilePtr.GetTIniFile(TGlobalVar.SysParIniFile);
        private string OpcGroup_ToPlcPar = "ToPlcPar";
        enum EnumIpcCtrlItem   //Send To Plc
        {
            
            manulSpeed=15,
            fastSpeed, 
            slowSpeed,
        }
        public frmSysParCfg()
        {
            InitializeComponent();
        }

        private void frmSysParCfg_Load(object sender, EventArgs e)
        {
            InitParInfo();
        }

        private void InitParInfo()
        {
            string SectionName = TGlobalVar.SysParSecName;

            neCaliSpan.Value = IniFilePtr.IniReadFloat(SectionName, "CaliSpan", 5);
            neMeasSpan.Value = IniFilePtr.IniReadFloat(SectionName, "MeasSpan", 5);

            manulSpeed.Value = IniFilePtr.IniReadFloat(SectionName,"ManulSpeed",12);
            fastSpeed.Value = IniFilePtr.IniReadFloat(SectionName,"FastSpeed",12);
            slowSpeed.Value = IniFilePtr.IniReadFloat(SectionName,"SlowSpeed",12);

            cmbDispChan.Text = IniFilePtr.IniReadString(SectionName, "DispChan", "COM1");           
        }

        private void SaveParInfo()
        {
            string SectionName = TGlobalVar.SysParSecName;

            IniFilePtr.IniWriteFloat(SectionName, "CaliSpan", Convert.ToSingle(neCaliSpan.Value));
            IniFilePtr.IniWriteFloat(SectionName, "MeasSpan", Convert.ToSingle(neMeasSpan.Value));

            IniFilePtr.IniWriteFloat(SectionName, "ManulSpeed", Convert.ToSingle(manulSpeed.Value));
            IniFilePtr.IniWriteFloat(SectionName, "FastSpeed", Convert.ToSingle(fastSpeed.Value));
            IniFilePtr.IniWriteFloat(SectionName, "SlowSpeed", Convert.ToSingle(slowSpeed.Value));

            frmMain.pPlcSrv.SyncWriteItem(OpcGroup_ToPlcPar, (int)EnumIpcCtrlItem.manulSpeed, Convert.ToSingle(manulSpeed.Value));
            frmMain.pPlcSrv.SyncWriteItem(OpcGroup_ToPlcPar, (int)EnumIpcCtrlItem.fastSpeed, Convert.ToSingle(fastSpeed.Value));
            frmMain.pPlcSrv.SyncWriteItem(OpcGroup_ToPlcPar, (int)EnumIpcCtrlItem.slowSpeed, Convert.ToSingle(slowSpeed.Value));

            IniFilePtr.IniWriteString(SectionName, "DispChan", cmbDispChan.Text);           
        }

        private void frmSysParCfg_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveParInfo();
        } 
    }

}