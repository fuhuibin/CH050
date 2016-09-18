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
            string StartDt = DateTime.Now.AddDays(1 - TGlobalVar.AlarmRecDelDays).ToShortDateString() + " 00:00:00";

            string SqlCmdStr = "Delete From AlarmRecTbl Where Convert(DateTime,信息时间) < '" + Convert.ToDateTime(StartDt) + "'";
            TSqlDbClass.ExecuteNonQuerySql(TGlobalVar.sSqlConn, SqlCmdStr);
        }

        private void StartDtPicker_CloseUp(object sender, EventArgs e)
        {
            DateTime StartDt = StartDtPicker.Value.AddDays(-1);
            DateTime EndDt = EndDtPicker.Value.AddDays(1);

            SqlQueryProc(StartDt, EndDt);
        }

        private void SqlQueryProc(DateTime StartDt, DateTime EndDt)
        {
            if (StartDt <= EndDt)   
            {
                string SqlCmd = string.Format("Select * From AlarmRecTbl Where Convert(DateTime,信息时间) Between '{0}' And '{1}' Order By Convert(DateTime,信息时间) Desc", Convert.ToDateTime(StartDt.ToShortDateString() + " 00:00:00"), Convert.ToDateTime(EndDt.ToShortDateString() + " 23:59:59"));
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

                DateTime StartDt = StartDtPicker.Value.AddDays(-1);
                DateTime EndDt = EndDtPicker.Value.AddDays(1);

                SqlQueryProc(StartDt, EndDt);
            }
        }

    }
}