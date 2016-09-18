using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TSqlAppClass;
using System.Data.SqlClient;

namespace MyTestBed
{
    public partial class frmAlarmRec : Form
    {
        private bool InitFlag = false;   

        public frmAlarmRec()
        {
            InitializeComponent();
        }

        private void frmAlarmRec_Load(object sender, EventArgs e)
        {
            DelOutDateRec();           
        }

        private void DelOutDateRec()
        {
            DateTime Start = DateTime.Now.AddDays(1 - TGlobalVar.AlarmRecDelDays);
            string StartDt = Start.ToString("yyyy-MM-dd") + " 00:00:00";
            string SqlCmdStr = "Delete From AlarmRecTbl Where Convert(varchar(24),信息时间) < '" + StartDt + "'";
            TSqlDbClass.ExecuteNonQuerySql(TGlobalVar.sSqlConn, SqlCmdStr);
        }

        private void StartDtPicker_CloseUp(object sender, EventArgs e)
        {
            string StartDt = StartDtPicker.Value.AddDays(-1).ToString("yyyy-MM-dd") + " 00:00:00";
            string EndDt = EndDtPicker.Value.AddDays(1).ToString("yyyy-MM-dd") + " 23:59:59";
            SqlQueryProc(StartDt, EndDt);
        }

        private void SqlQueryProc(string StartDt, string EndDt)
        {
            if (Convert.ToDateTime(StartDt) <= Convert.ToDateTime(EndDt))   
            {
                string SqlCmd = string.Format("Select * From AlarmRecTbl Where Convert(varchar(24),信息时间) Between '{0}' And '{1}' Order By Convert(varchar(24),信息时间) Desc", StartDt, EndDt);
                DataTable TmpTbl = TSqlDbClass.RetnTblBySqlCmd(TGlobalVar.sSqlConn, SqlCmd);

                AlarmRec_DgView.DataSource = TmpTbl;
            }
            else
            {
                MessageBox.Show("起始时间不允许大于终止时间，请调整!");
            }            
        }

        private void frmAlarmRec_Activated(object sender, EventArgs e)
        {
            if (InitFlag == false)
            {
                InitFlag = true;

                StartDtPicker.Value = DateTime.Now.AddDays(-30);
                EndDtPicker.Value = DateTime.Now;

                string StartDt = StartDtPicker.Value.AddDays(-1).ToString("yyyy-MM-dd") + " 00:00:00";
                string EndDt = EndDtPicker.Value.AddDays(1).ToString("yyyy-MM-dd") + " 23:59:59";

                SqlQueryProc(StartDt, EndDt);
            }
        }

    }
}