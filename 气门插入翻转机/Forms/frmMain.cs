using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OpcSrv;
using OpcRcw.Da;
using System.Threading;
using System.IO.Ports;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;
using System.Collections;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Reflection;
using TIniFile;
using TSqlAppClass;
using TRsCom;
using UserManageLib;
using TUserManageUI;

namespace MyTestBed
{
    public partial class frmMain : Form
    {
        public delegate void OnDataAcqHandler();

        #region 异步读写/异步订阅

       static public TPlcSrv pPlcSrv = null;
        //**********************************************************************************************        
        private bool PlcCommInit()
        {
            TOpcSrv pOpcSrv = TOpcSrv.GetInstance();
            pOpcSrv.OnDataChangeEvent += new OnDataChangeEventHandler(OpcAsyncDataChangeEvent);
            pPlcSrv = TPlcSrv.GetInstance();

            return pPlcSrv.OpcSrvInit();
        }

        //**********************************************************************************************        
        private void PlcCommClose()
        {
            TOpcSrv pOpcSrv = TOpcSrv.GetInstance();
            pOpcSrv.OnDataChangeEvent -= new OnDataChangeEventHandler(OpcAsyncDataChangeEvent);           
            pPlcSrv.ReleaseOpc();
        }

        private void OpcAsyncDataChangeEvent(DataChangeEventArgs e)
        {
            object[] parList = { e }; //e.PhClientItems, e.DataChangeVal, e.DataChangeQuality

            this.BeginInvoke(new OnDataChangeEventHandler(OnOpcAsyncDataChangeEvent), parList);
        }

        //****************************************OPC异步回调处理***************************************               
        private void OnOpcAsyncDataChangeEvent(DataChangeEventArgs e)
        {
            string   sGroupName;
            int[]    PhClientItems;
            object[] DataChangeV;
            string[] DataChangeQuality;

            sGroupName = e.sGroupName;  
            PhClientItems = e.PhClientItems;
            DataChangeV = e.DataChangeVal;
            DataChangeQuality = e.DataChangeQuality;

            OpcAsyncDataChangeProc(sGroupName, PhClientItems, DataChangeV, DataChangeQuality);
        }
        #endregion 异步读写/异步订阅

        //**********************************************************************************************
        //********************************************************************************************** 
        private static long heartTimes = 0;
        private static long heartTimesB = 0;

        private TIniFilePtr    IniFilePtr = TIniFilePtr.GetTIniFile(TGlobalVar.SysParIniFile);
        private TDispSensorCom pDispCom   = null;
        private TgVCommPar     gVCommPar  = null;
        
        private WaveformPlot[] wfDispPlotGroup = null; //Plot组
        private CheckBox[]     cbDispPlotGroup = null; //Check组
        private NumericEdit[]  neDispValGroup  = null; //Numedt组        

        private string OpcGroup_FromPlcPar = "FromPlcPar";
        private string OpcGroup_ToPlcPar = "ToPlcPar";
        private string OpcGroup_AlarmMsgPar = "AlarmMsgPar";
        private string OpcGroup_DebugButtPar = "DebugButtPar";

        //*****************************************************************************************************************************
        //*****************************************************************************************************************************         
        //int[] SpinSensorID  = new int[] { (int)SensorIDEnum.SpinDisp_A, (int)SensorIDEnum.SpinDisp_B, (int)SensorIDEnum.SpinDisp_C };
        //int[] HouseSensorID = new int[] { (int)SensorIDEnum.HouseDisp_A, (int)SensorIDEnum.HouseDisp_B, (int)SensorIDEnum.HouseDisp_C };

        int[] AllSensorID = new int[] { (int)SensorIDEnum.SpinDisp_A, (int)SensorIDEnum.SpinDisp_B, (int)SensorIDEnum.SpinDisp_C};
        enum SensorIDEnum
        {           
            SpinDisp_A = 0,
            SpinDisp_B = 1,
            SpinDisp_C = 2,
        }

        #region  反馈标签处理
        private void OpcAsyncDataChangeProc(string sGroupName, int[] PhClientItems, object[] DataChangeV, string[] DataChangeQuality)
        {
            if (sGroupName == OpcGroup_FromPlcPar) //反馈参数
            {
                for (int k = 0; k < PhClientItems.Length; k++) StatusRecvProc(PhClientItems[k], DataChangeV[k]);
            }
            if (sGroupName == OpcGroup_AlarmMsgPar)
            {
                for (int k = 0; k < PhClientItems.Length; k++) AlarmInfoProc(PhClientItems[k], DataChangeV[k]);
                ledPlcAlarm.Value = Convert.ToBoolean(lstBoxAlarmInfo1.Items.Count);
            }     
        }  

        #endregion  反馈标签处理
        #region 报警消息处理

        private string AlarmInfoTblName = "AlarmInfoTbl";
        private string AlarmRecTblName = "AlarmRecTbl";
        private List<string> lstAlarmItemName = null;
        private TAlarmInfoPar pTAlarmInfoPar = null;   //报警信息表对象     
        //**********************************************************************************************
        //***************************************报警消息初始化*************************************
        //**********************************************************************************************
        private void AlarmInfoProcInit()
        {
            DataTable AlarmInfoTbl = TSqlDbClass.RetnTblBySqlCmd(TGlobalVar.sSqlConn, "Select * From " + AlarmInfoTblName);
            if (AlarmInfoTbl != null && AlarmInfoTbl.Rows.Count >= 1)
            {
                pTAlarmInfoPar = new TAlarmInfoPar();
                for (int k = 0; k < AlarmInfoTbl.Rows.Count; k++)
                {
                    pTAlarmInfoPar.AlarmItemName.Add(AlarmInfoTbl.Rows[k]["AlarmItem"].ToString());
                    pTAlarmInfoPar.AlarmType.Add(AlarmInfoTbl.Rows[k]["AlarmType"].ToString());
                    pTAlarmInfoPar.AlarmInfo.Add(AlarmInfoTbl.Rows[k]["AlarmInfo"].ToString());
                }
            }

            //*********************************************************************
            lstAlarmItemName = pPlcSrv.GetOpcGroupItemName(OpcGroup_AlarmMsgPar); //报警标签名列表
            if (lstAlarmItemName != null) pPlcSrv.SetOpcGroupState(OpcGroup_AlarmMsgPar, true);
        }

        private void AlarmInfoProc(int ItemIdx, object ItemVal)
        {
            ListBox myListBox = lstBoxAlarmInfo1;
            bool bAlarmStatus = Convert.ToBoolean(ItemVal);

            if (lstAlarmItemName == null || pTAlarmInfoPar == null) return;

            if (lstAlarmItemName.Count >= ItemIdx + 1)
            {
                int AlarmID = -1;
                for (int i = 0; i < pTAlarmInfoPar.AlarmItemName.Count; i++)
                {
                    if (pTAlarmInfoPar.AlarmItemName[i] == lstAlarmItemName[ItemIdx])
                    {
                        AlarmID = i;
                        break;
                    }
                }
                if (AlarmID >= 0)
                {
                    int lBoxIdx = -1;
                    for (int k = 0; k < myListBox.Items.Count; k++)
                    {
                        if (myListBox.Items[k].ToString().Split('-')[1].IndexOf(pTAlarmInfoPar.AlarmInfo[AlarmID]) != -1)
                        {
                            lBoxIdx = k;

                            if (bAlarmStatus == false) myListBox.Items.RemoveAt(lBoxIdx);
                            break;
                        }
                    }

                    if (bAlarmStatus == true) //报警
                    {
                        SaveAlarmPreProc(AlarmRecTblName, pTAlarmInfoPar.AlarmType[AlarmID], pTAlarmInfoPar.AlarmInfo[AlarmID]);
                        if (lBoxIdx == -1) myListBox.Items.Add(DateTime.Now.ToShortTimeString() + " - " + pTAlarmInfoPar.AlarmInfo[AlarmID]);
                    }
                }
            }
        }

        private void AlarmRecTblInit() //报警记录表初始化
        {
            string sTableName = AlarmRecTblName;

            if (TSqlDbClass.IsDataBaseExist(TGlobalVar.sMasterSqlConn, TGlobalVar.sDataBase) == false) //数据库不存在则创建数据库
            {
                TSqlDbClass.CreateServerDb(TGlobalVar.sMasterSqlConn, Application.StartupPath, TGlobalVar.sDataBase);
            }
            //**********************************************************************************************
            string[] sFieldName = { "信息时间", "信息类型", "信息内容" };
            string[] sDataType = { "Varchar", "Varchar", "Varchar" };
            int[] iMaxLen = { 24, 16, 64 };
            string[] sAllowNull = { "Not Null", "Not Null", "Not Null" };

            if (TSqlDbClass.CreateTable(false, TGlobalVar.sSqlConn, sTableName, sFieldName, sDataType, iMaxLen, sAllowNull) == false) //报警记录数据表
            {
                MessageBox.Show("报警信息表创建失败,请检查！", "警告");
            }
        }

        private void SaveAlarmPreProc(string sTblName, string InfoType, string Info)
        {
            List<string> lstFieldVal = new List<string>();

            lstFieldVal.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ffff"));
            lstFieldVal.Add(InfoType);
            lstFieldVal.Add(Info);

            SaveDataRecProc(lstFieldVal, sTblName);
        }

        #endregion  报警消息处理
        #region 数据保存处理    
    
        private string TestRecTblName = "TestRecTbl";

        private void TestRecTblInit(string sTableName) //试验记录表初始化
        {
            if (TSqlDbClass.IsDataBaseExist(TGlobalVar.sMasterSqlConn, TGlobalVar.sDataBase) == false) //数据库不存在则创建数据库
            {
                TSqlDbClass.CreateServerDb(TGlobalVar.sMasterSqlConn, Application.StartupPath, TGlobalVar.sDataBase);
            }
            //**********************************************************************************************
            string[] sFieldName = { "产品编号", "测量时间", "产品型号", "气门凸出量1", "气门1合格不合格", "气门凸出量2", "气门2合格不合格", "气门凸出量3", "气门3合格不合格", "气门凸出量4", "气门4合格不合格" };
            string[] sDataType = { "Varchar", "Varchar", "Varchar", "Varchar", "Varchar", "Varchar", "Varchar", "Varchar", "Varchar", "Varchar", "Varchar" };
            int[] iMaxLen = { 40, 24, 24, 12, 12, 12, 12, 12, 12, 12, 12 };
            string[] sAllowNull = { "Not Null", "Not Null", "Not Null", "Not Null", "Not Null", "Not Null", "Not Null", "Not Null", "Not Null", "Not Null", "Not Null" };

            if (TSqlDbClass.CreateTableNoPrimary( TGlobalVar.sSqlConn, sTableName, sFieldName, sDataType, iMaxLen, sAllowNull) == false) //数据记录表
            {
                MessageBox.Show("试验记录表创建失败, 请检查!", "警告");
            }
        }        

        private void SaveDataRecProc(List<string> lstFieldVal, string TblName)
        {
            try
            {
                List<string> strParName = new List<string>(lstFieldVal.Count);
                string strSqlCmd = "Insert Into " + TblName + " Values(";

                for (int k = 0; k < lstFieldVal.Count; k++)
                {
                    strParName.Add("@strPar_" + k.ToString());
                    if (k != lstFieldVal.Count - 1) strSqlCmd += strParName[k] + ",";
                    else                            strSqlCmd += strParName[k] + ")";
                }

                SqlConnection sqlConn = new SqlConnection(gVCommPar.sSqlConn);
                TSqlDbClass.sqlConnOpen(sqlConn);
                SqlCommand SqlCmd = new SqlCommand(strSqlCmd, sqlConn);

                for (int k = 0; k < lstFieldVal.Count; k++)
                {
                    SqlCmd.Parameters.Add(new SqlParameter(strParName[k], SqlDbType.Char));
                    SqlCmd.Parameters[strParName[k]].Value = lstFieldVal[k];
                }

                SqlCmd.ExecuteNonQuery();
                SqlCmd.Dispose();
                TSqlDbClass.sqlConnClose(sqlConn);
            }

            catch (Exception e)
            {
                MessageBox.Show(TblName + "表数据保存失败-" + e.Message, "提示");
            }
        }
        #endregion 数据保存处理        

        #region 状态字处理
        enum EnumPlcFbkItem //Recv From Plc
        {
            WorkMode = 0,  //工作模式
            ProdID,        //机型标志    
            ScanBar,       //二维码   
            //PalletID,       
            //PalletStatus,   
            CycleTime,      //循环时间
            HeartBeat,      
            WpOnline,       //托盘到位，初始化数据清除等工作
            //MesEnable,

            MeasCmd1,        //读取第一次测量结果
            MeasCmd2,        //读取第二次测量结果
            MeasCmd3,        //读取第三次测量结果
            MeasCmd4,        //读取第四次测量结果
            CaliCmd,        //读取标定结果

    
            //CylinderSleeveID,    //1-6
            //CylinderSleeveType   //A、B
        }
       
        enum EnumIpcCtrlItem   //Send To Plc
        {
            MeasReply1 = 0,  //第一次测量结果合格不合格
            MeasReply2,      //第二次测量结果合格不合格
            MeasReply3,      //第三次测量结果合格不合格
            MeasReply4,      //第四次测量结果合格不合格
            CaliReply,          //校准结果合格不合格
            //ScanRelpy,      //扫描条码结果合格不合格

            HeartBeatReply,

            //Fstart,       //强制启动
            //Fstop,        //强制停止
            //Release,      //放行
            
 
            //CaliCMD,      //标定请求
            TestMode,     //工作模式
           
      
            MeasResult1,  //第一个测量值
            MeasGood1,
            MeasResult2,  //第二个测量值
            MeasGood2,
            MeasResult3,  //第三个测量值
            MeasGood3,
            MeasResult4,  //第四个测量值
            MeasGood4,
            manulSpeed,
            fastSpeed,
            slowSpeed,
            ProID
        }

        private void StatusRecvProc(int ItemIdx, object ItemVal)
        {              
            try
            {
                switch (ItemIdx)
                {
                    case (int)EnumPlcFbkItem.WorkMode:
                        int iWorkMode = Convert.ToInt32(ItemVal);
                        WorkModeProc(iWorkMode); //根据模式变化切换相应IPC选择工位还是产品类型
                        gVCommPar.WorkMode = iWorkMode;                        
                        break;

                    case (int)EnumPlcFbkItem.ProdID:
                        gVCommPar.ProdID = Convert.ToInt32(ItemVal);
                        cmbProdName.SelectedIndex = ProdParUpdate(gVCommPar.ProdID);
                        break;

                    case (int)EnumPlcFbkItem.ScanBar:
                        gVCommPar.ScanBar = Convert.ToString(ItemVal);
                        txtScanBar.Text = gVCommPar.ScanBar;
                        TBoxAllInitUpdate();
                        break;

                    //case (int)EnumPlcFbkItem.PalletID:
                    //    int PalletID     = Convert.ToInt32(ItemVal);
                    //    //txtPalletID.Text = PalletID.ToString();
                    //    break;

                    //case (int)EnumPlcFbkItem.PalletStatus:
                    //    int PalletStatus =Convert.ToInt32(ItemVal);
                    //    PalletStatusProc(PalletStatus);  //1：合格 2：不合格 3：返修 4：空盘
                    //    break;                    

                    case (int)EnumPlcFbkItem.CycleTime:
                        int CycleTime     = Convert.ToInt32(ItemVal);
                        txtCycleTime.Text = CycleTime.ToString();
                        break;
                    
                    case (int)EnumPlcFbkItem.HeartBeat:
                        heartTimes = heartTimes + 1;
                        heartTimesB = heartTimes;
                        ledHeartBeat.Value = Convert.ToBoolean(ItemVal);
                        pPlcSrv.SyncWriteItem(OpcGroup_ToPlcPar, (int)EnumIpcCtrlItem.HeartBeatReply, ledHeartBeat.Value); //给PLC应答心跳信号
                        break;

                    case (int)EnumPlcFbkItem.WpOnline:  //工件上线先进行界面初始化
                        bool WpOnline = Convert.ToBoolean(ItemVal);

                        if (gVCommPar.WpOnline == false && WpOnline == true)
                        {
                            Release.Visible = false;
                            InfoToStatusListBox("  工件到位...");
                            gVCommPar.ResultGood = true;  //默认测量结果合格
                        }
                        else if (gVCommPar.WpOnline == true && WpOnline == false)
                        {
                            InfoToStatusListBox("  工件离开...");
                        }
                        gVCommPar.WpOnline = WpOnline;
                        break;

                    //case  (int)EnumPlcFbkItem.MesEnable: //MES使能信号--->决定站点及产品型号由IPC确定还是PLC确定
                    //    bool MesEnable = Convert.ToBoolean(ItemVal);

                    //    cmbProdName.Enabled  = !gVCommPar.MesEnable;
                    //    if (gVCommPar.MesEnable == true && MesEnable == false)
                    //    {
                    //        InfoToStatusListBox("  RFID无效，请选择产品类型...");
                    //    }                        
                    //    gVCommPar.MesEnable  = MesEnable;
                    //    break;

                    case (int)EnumPlcFbkItem.MeasCmd1:
                        if (Convert.ToInt32(ItemVal) == 1)
                        {
                            gVCommPar.TestNum = 1;
                            gVCommPar.MeasTrig = true; 
                            gVCommPar.SensorMeasing = false;

                            TBoxMeasRealValInitUpdate();
                            pDispCom.ChanBufTrig(AllSensorID, false);

                            gVCommPar.InitTime = DateTime.Now;
                            InfoToStatusListBox("  气门1测量中，请稍候..."); 
                        }
                        break;

                    case (int)EnumPlcFbkItem.MeasCmd2:
                        if (Convert.ToInt32(ItemVal) == 1)
                        {
                            gVCommPar.TestNum = 2;
                            gVCommPar.MeasTrig = true;
                            gVCommPar.SensorMeasing = false;

                            TBoxMeasRealValInitUpdate();
                            pDispCom.ChanBufTrig(AllSensorID, false);

                            gVCommPar.InitTime = DateTime.Now;
                            InfoToStatusListBox("  气门2测量中，请稍候...");
                        }
                        break;

                    case (int)EnumPlcFbkItem.MeasCmd3:
                        if (Convert.ToInt32(ItemVal) == 1)
                        {
                            gVCommPar.TestNum = 3;
                            gVCommPar.MeasTrig = true;
                            gVCommPar.SensorMeasing = false;

                            TBoxMeasRealValInitUpdate();
                            pDispCom.ChanBufTrig(AllSensorID, false);

                            gVCommPar.InitTime = DateTime.Now;
                            InfoToStatusListBox("  气门3测量中，请稍候...");
                        }
                        break;

                    case (int)EnumPlcFbkItem.MeasCmd4:
                        if (Convert.ToInt32(ItemVal) == 1)
                        {
                            gVCommPar.TestNum = 4;
                            gVCommPar.MeasTrig = true;
                            gVCommPar.SensorMeasing = false;

                            TBoxMeasRealValInitUpdate();
                            pDispCom.ChanBufTrig(AllSensorID, false);

                            gVCommPar.InitTime = DateTime.Now;
                            InfoToStatusListBox("  气门4测量中，请稍候...");
                        }
                        break;

                    case (int)EnumPlcFbkItem.CaliCmd:
                        if(Convert.ToInt32(ItemVal) == 1)
                        {
                            for (int i = 0; i < 3; i++) gVCommPar.CaliGood[i] = true;  //默认标定值全为合格
                           gVCommPar.CaliTrig = true;

                           TBoxCaliValInitUpdate();
                           pDispCom.ChanBufTrig(AllSensorID, true);  //启动缓冲存储

                           gVCommPar.InitTime = DateTime.Now;
                           InfoToStatusListBox("  标定中，请稍候..."); 
                        }
                        break;

                    //case (int)EnumPlcFbkItem.CylinderSleeveID:       //缸盖序号（1-6）
                    //    gVCommPar.CylinderSleeveID = Convert.ToInt32(ItemVal);
                    //    break;

                    //case (int)EnumPlcFbkItem.CylinderSleeveType:       //缸盖序号（1-2:1---A；2---B）
                    //    gVCommPar.CylinderSleeveType = Convert.ToInt32(ItemVal);
                    //    if (gVCommPar.CylinderSleeveType == 1) txtCylinderSleeveType.Text = "A";
                    //    else if (gVCommPar.CylinderSleeveType == 2) txtCylinderSleeveType.Text = "B";
                    //    break;
                }
            }

            catch (Exception e)
            {
                InfoToStatusListBox("反馈触发有误-" + e.Message);
            }
        }

        enum EnumWorkMode
        {
            NoSelect = 0,
            Auto,    //测量
            Manual,  //调试
            EmptyCycle,
            pangtong,
            Cali
        }

        private void WorkModeProc(int iMode)
        {
            string[] strWorkMode = new string[] { "未选择", "自 动", "手 动", "空循环", "旁通", "标 定" };

            txtWorkMode.Text = (iMode >= 0 && iMode <= 5) ? strWorkMode[iMode] : "未知";

            //if (gVCommPar.MesEnable == true) //刷新工作位几产品类型相关的参数
            {
                if (gVCommPar.WorkMode != (int)EnumWorkMode.Auto && iMode == (int)EnumWorkMode.Auto) // &&gVCommPar.MesEnable == true )  
                {
                    //        AllTBoxInitUpdate();

                    //gVCommPar.ProdID = Convert.ToInt32(pPlcSrv.SyncReadItem(OpcGroup_ToPlcPar, (int)EnumPlcFbkItem.ProdID, OPCDATASOURCE.OPC_DS_CACHE));
                    //cmbProdName.SelectedIndex = ProdParUpdate(gVCommPar.ProdID);

                    cmbProdName.Enabled = false;
                }
                else
                {
                    cmbProdName.Enabled = true;
                }
            }
        }

        //private void PalletStatusProc(int iStatus)
        //{
        //    string[] strStatus = new string[] { "合格", "不合格", "返修", "空盘" };

        //    //txtPalletStatus.Text = (iStatus >= 1 && iStatus <= 4) ? strStatus[iStatus - 1] : "未知";
        //}

        #endregion 状态字处理

        private void RsPlotTimer_Tick(object sender, EventArgs e)
        {
            if (heartTimesB == long.MaxValue)
            {
                heartTimes = 0;
                heartTimesB = 0;
            }
            heartTimesB += 1;

            // LogWrite("heartTimesA: " + heartTimes.ToString() + "  heartTimeB: " + heartTimesB.ToString());
            if (heartTimesB > heartTimes + 30)
            {
                ledHeartBeat.Value = false;
            }

            //位移传感器超时接收报警
            if (pDispCom.bRecvOk == true)
            {
                RsPlotTimer.Tag = DateTime.Now;
                pDispCom.bRecvOk = false;
            }
            else
            {
                TimeSpan TmpTimeSpan = DateTime.Now - Convert.ToDateTime(RsPlotTimer.Tag);
                if (TmpTimeSpan.TotalSeconds >= 5)
                {
                    pDispCom.PortOpen();
                    pDispCom.RequestSend();

                    RsPlotTimer.Tag = DateTime.Now;
                }
            }
            //************************************************************************************************************

            //************************************************************************************************************           
            for (int k = 0; k < AllSensorID.Length; k++)
            {
                int iID = AllSensorID[k];

                neDispValGroup[k].Value = pDispCom.ChanCurrVal[iID];
                wfDispPlotGroup[k].PlotYAppend(pDispCom.ChanCurrVal[iID]);
            }

            //************************************************************************************************************
            if (gVCommPar.CaliTrig == true || gVCommPar.MeasTrig == true) //标定或测量
            {
                TimeSpan TmpSpan = DateTime.Now - gVCommPar.InitTime;

                //**************************************************************************************************************          
                if (gVCommPar.CaliTrig == true && Convert.ToSingle(TmpSpan.TotalSeconds) >= gVCommPar.CaliSpan)
                {
                    pDispCom.ChanBufTrig(AllSensorID, false);
                    gVCommPar.CaliTrig = false;
                    //**********************************************************************************************************
                    string[] TmpCaliIniStr = new string[] { "CaliVal1", "CaliVal2", "CaliVal3"};                         
                    for (int i = 0; i < TmpCaliIniStr.Length; i++)
                    {
                        float TmpCaliVal = pDispCom.GetChanMean(AllSensorID[i], 0.5f);
                        //TmpCaliVal /= 3.0f; 
                        IniFilePtr.IniWriteString(TGlobalVar.SysParSecName, TmpCaliIniStr[i], TmpCaliVal.ToString("f3"));
                    }

                    CaliParInit();           
                    InfoToStatusListBox("  标定结束...");
                    //int k = 0;
                    //for (int i = 0; i < 3; i++)
                    //{
                    //    if (gVCommPar.CaliGood[i] == false)
                    //    {
                    //        pPlcSrv.SyncWriteItem(OpcGroup_ToPlcPar, (int)EnumIpcCtrlItem.CaliRe, 2);//不合格
                    //        break;
                    //    }
                    //    k++;
                    //}
                    //if (k == 3)
                    //{
                    //    pPlcSrv.SyncWriteItem(OpcGroup_ToPlcPar, (int)EnumIpcCtrlItem.CaliRe, 1); //合格
                    //}
                    pPlcSrv.SyncWriteItem(OpcGroup_ToPlcPar, (int)EnumIpcCtrlItem.CaliReply, 1);   //标定结束
                
                }

                //************************************************************************************************************                                
                if (gVCommPar.MeasTrig == true)
                {
                    //if (gVCommPar.lstStdVal.Count >0)
                    //{
                    if (Convert.ToSingle(TmpSpan.TotalSeconds) >= gVCommPar.PreMeasSpan && gVCommPar.SensorMeasing == false) //预测量延时
                    {
                        pDispCom.ChanBufTrig(AllSensorID, true);  //启动缓冲存储
                        gVCommPar.SensorMeasing = true;
                    }

                    if (Convert.ToSingle(TmpSpan.TotalSeconds) >= gVCommPar.PreMeasSpan + gVCommPar.MeasSpan)
                    {
                        pDispCom.ChanBufTrig(AllSensorID, false);
                       
                        gVCommPar.MeasTrig  = false;

                        //***************************************测量值********************************************************
                        TextBox[] TBoxMeasRealVal = new TextBox[] { txtMeasVal1, txtMeasVal2, txtMeasVal3, txtRealVal1, txtRealVal2, txtRealVal3, txtRealVal4 };

                        float[] TmpMeasVal=new float[3];
                        float[] TmpRealVal = new float[3];
                        for (int k = 0; k < 3; k++)
                        {
                            TmpMeasVal[k] = pDispCom.GetChanMean(AllSensorID[k], 0.5f);
                            TmpRealVal[k] = TmpMeasVal[k] - gVCommPar.lstCaliVal[k];
                            TBoxMeasRealVal[k].Text = TmpMeasVal[k].ToString("f3");
                        }

                        //计算凸出量平均值  判合格（红绿底色）、提示信息（测量结束、不合格）、写给PLC
                        gVCommPar.MeasResult = (float)System.Math.Round((TmpRealVal[0] + TmpRealVal[1] + TmpRealVal[2]) / 3 , 3);
                        if (gVCommPar.TestNum == 1)
                        {
                            txtRealVal1.Text = gVCommPar.MeasResult.ToString("f3");
                            if (gVCommPar.MeasResult < gVCommPar.DnLimit || gVCommPar.MeasResult > gVCommPar.UpLimit)
                            {
                                txtRealVal1.BackColor = Color.Red;
                                gVCommPar.ResultGood = false;
                                gVCommPar.Result[0] = "不合格";
                            }
                            else
                            {
                                txtRealVal1.BackColor = Color.Green;
                                gVCommPar.ResultGood = true;
                                gVCommPar.Result[0] = "合格";
                            }

                            pPlcSrv.SyncWriteItem(OpcGroup_ToPlcPar, (int)EnumIpcCtrlItem.MeasResult1, gVCommPar.MeasResult);

                            if (gVCommPar.ResultGood) pPlcSrv.SyncWriteItem(OpcGroup_ToPlcPar, (int)EnumIpcCtrlItem.MeasGood1, 1); //结果合格
                            else pPlcSrv.SyncWriteItem(OpcGroup_ToPlcPar, (int)EnumIpcCtrlItem.MeasGood1, 2);  //结果不合格
                            pPlcSrv.SyncWriteItem(OpcGroup_ToPlcPar, (int)EnumIpcCtrlItem.MeasReply1, 1);   //测量完成
                            InfoToStatusListBox("  气门1测量结束...");
                            gVCommPar.TestNum = 0;
                        }
                        else if (gVCommPar.TestNum == 2)
                        {
                            txtRealVal2.Text = gVCommPar.MeasResult.ToString("f3");
                            if (gVCommPar.MeasResult < gVCommPar.DnLimit || gVCommPar.MeasResult > gVCommPar.UpLimit)
                            {
                                txtRealVal2.BackColor = Color.Red;
                                gVCommPar.ResultGood = false;
                                gVCommPar.Result[1] = "不合格";
                            }
                            else
                            {
                                txtRealVal2.BackColor = Color.Green;
                                gVCommPar.ResultGood = true;
                                gVCommPar.Result[1] = "合格";
                            }

                            pPlcSrv.SyncWriteItem(OpcGroup_ToPlcPar, (int)EnumIpcCtrlItem.MeasResult2, gVCommPar.MeasResult);

                            if (gVCommPar.ResultGood) pPlcSrv.SyncWriteItem(OpcGroup_ToPlcPar, (int)EnumIpcCtrlItem.MeasGood2, 1); //结果合格
                            else pPlcSrv.SyncWriteItem(OpcGroup_ToPlcPar, (int)EnumIpcCtrlItem.MeasGood2, 2);  //结果不合格
                            pPlcSrv.SyncWriteItem(OpcGroup_ToPlcPar, (int)EnumIpcCtrlItem.MeasReply2, 1);   //测量完成
                            InfoToStatusListBox("  气门2测量结束...");
                            gVCommPar.TestNum = 0;
                        }
                        else if (gVCommPar.TestNum == 3)
                        {
                            txtRealVal3.Text = gVCommPar.MeasResult.ToString("f3");
                            if (gVCommPar.MeasResult < gVCommPar.DnLimit || gVCommPar.MeasResult > gVCommPar.UpLimit)
                            {
                                txtRealVal3.BackColor = Color.Red;
                                gVCommPar.ResultGood = false;
                                gVCommPar.Result[2] = "不合格";
                            }
                            else
                            {
                                txtRealVal3.BackColor = Color.Green;
                                gVCommPar.ResultGood = true;
                                gVCommPar.Result[2] = "合格";
                            }

                            pPlcSrv.SyncWriteItem(OpcGroup_ToPlcPar, (int)EnumIpcCtrlItem.MeasResult3, gVCommPar.MeasResult);

                            if (gVCommPar.ResultGood) pPlcSrv.SyncWriteItem(OpcGroup_ToPlcPar, (int)EnumIpcCtrlItem.MeasGood3, 1); //结果合格
                            else pPlcSrv.SyncWriteItem(OpcGroup_ToPlcPar, (int)EnumIpcCtrlItem.MeasGood3, 2);  //结果不合格
                            pPlcSrv.SyncWriteItem(OpcGroup_ToPlcPar, (int)EnumIpcCtrlItem.MeasReply3, 1);   //测量完成
                            InfoToStatusListBox("  气门3测量结束...");
                            gVCommPar.TestNum = 0;
                        }
                        else if (gVCommPar.TestNum == 4)
                        { 
                            txtRealVal4.Text = gVCommPar.MeasResult.ToString("f3");
                            if (gVCommPar.MeasResult < gVCommPar.DnLimit || gVCommPar.MeasResult > gVCommPar.UpLimit)
                            {
                                txtRealVal4.BackColor = Color.Red;
                                gVCommPar.ResultGood = false;
                                gVCommPar.Result[3] = "不合格";
                            }
                            else
                            {
                                txtRealVal4.BackColor = Color.Green;
                                gVCommPar.ResultGood = true;
                                gVCommPar.Result[3] = "合格";
                            }

                            pPlcSrv.SyncWriteItem(OpcGroup_ToPlcPar, (int)EnumIpcCtrlItem.MeasResult4, gVCommPar.MeasResult);

                            if (gVCommPar.ResultGood) pPlcSrv.SyncWriteItem(OpcGroup_ToPlcPar, (int)EnumIpcCtrlItem.MeasGood4, 1); //结果合格
                            else pPlcSrv.SyncWriteItem(OpcGroup_ToPlcPar, (int)EnumIpcCtrlItem.MeasGood4, 2);  //结果不合格

                            SaveMeasRecProc(txtRealVal1.Text,txtRealVal2.Text,txtRealVal3.Text,txtRealVal4.Text, gVCommPar.Result);
                            pPlcSrv.SyncWriteItem(OpcGroup_ToPlcPar, (int)EnumIpcCtrlItem.MeasReply4, 1);   //测量完成
                            InfoToStatusListBox("  气门4测量结束...");
                            gVCommPar.TestNum = 0;
                        }
                    
                    }
                    //}

                }
            }
        }

        private void SaveMeasRecProc(string re1,string re2,string re3,string re4,string []Result)
        {
            List<string> lstFieldVal = new List<string>();
            string[] re = new string[] { re1, re2, re3, re4 };
            lstFieldVal.Add(txtScanBar.Text);
            lstFieldVal.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));  //记录时间
            lstFieldVal.Add(cmbProdName.Text);
            
            for (int i = 0; i < 4; i++)
            {
                lstFieldVal.Add(re[i]);
                lstFieldVal.Add(Result[i]);
            }
            TSqlDbClass.ExecuteNonQuerySql(gVCommPar.sSqlConn, "Delete From " + TestRecTblName + " Where 产品编号 = '" + txtScanBar.Text + "'");
            SaveDataRecProc(lstFieldVal, TestRecTblName);

            dgvDataRec.DataSource = TSqlDbClass.RetnTblBySqlCmd(TGlobalVar.sSqlConn, "Select Top 20 * From " + TestRecTblName + " Order By Convert(DateTime,测量时间) Desc");
        }       


        //**********************************************************************************************
        //**********************************************************************************************
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            PlcCommClose();
        }

        private void InfoToStatusListBox(string info)
        {
            lstBoxStatusInfo.Items.Add(info);
            if (lstBoxStatusInfo.Items.Count >= 12) lstBoxStatusInfo.Items.RemoveAt(0);
        }
        
        //**********************************************************************************************
        //**********************************************************************************************
        public frmMain()
        {
            TUserManage.InitUserXmlDbase();
            TUserManage.SetActiveUser("Operator");
            gVCommParInit();

            InitializeComponent();
        }

        //**********************************************************************************************
        private void gVCommParInit()
        {
            string SectionName = TGlobalVar.SysParSecName;
            
            gVCommPar = new TgVCommPar();
            gVCommPar.sSqlConn = TGlobalVar.sSqlConn;

            gVCommPar.CaliSpan  = IniFilePtr.IniReadFloat(SectionName, "CaliSpan", 5);
            gVCommPar.MeasSpan  = IniFilePtr.IniReadFloat(SectionName, "MeasSpan", 5);
            //gVCommPar.MatchMode = IniFilePtr.IniReadString(SectionName, "MatchMode", "过盈");            
        }
    
        //**********************************************************************************************
        private void frmMain_Load(object sender, EventArgs e)
        {            
            //mySkinEngine.SkinFile = "sColor-9.ssk";
            //UserAuthorityManage();
            Release.Visible = false;
            AllTBoxInitUpdate();
            CaliLimitInit();
            CaliParInit();
            if (PlcCommInit() == false)
            {
                MessageBox.Show("OpcSrv初始化失败，请检查！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
              //  Close();
            }
            else
            {
                if (OpcGroupCreateInit() == false)
                {
                    MessageBox.Show("Opc组创建失败，请检查！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 //   Close();
                }
                else
                {
                    //GasketParInit(); //灯箱垫片初始化

                    ConGroupInit();
                    ProdNameInitProc();
                   
                    TestRecTblInit(TestRecTblName);
                    RsCommInit();
                    RsPlotTimer.Enabled = true;

                    AlarmInfoProcInit();
                    AlarmRecTblInit();
                    SpeedInit();
                }
            }
        } 
        
        //**********************************************************************************************
        //**********************************************************************************************       
        private bool OpcGroupCreateInit()
        {
              bool bRet = true;

            if (pPlcSrv.CreateOpcGroup(OpcGroup_ToPlcPar, false) == false ||
                pPlcSrv.CreateOpcGroup(OpcGroup_AlarmMsgPar, false) == false ||
                pPlcSrv.CreateOpcGroup(OpcGroup_DebugButtPar, false) == false
             )
            {
                bRet = false;
            }
            else
            {
                if (pPlcSrv.SyncWrtInitVal(OpcGroup_ToPlcPar) == false)
                {
                    bRet = false;
                }
                else
                {
                    if (pPlcSrv.CreateOpcGroup(OpcGroup_FromPlcPar, true) == false)
                    {
                        bRet = false;
                    }

                }
            }

            return bRet;
        }

        //********************************************************************************************************************
        private void ConGroupInit() // 位移曲线/位移值控件组初始化
        {
            wfDispPlotGroup = new WaveformPlot[TGlobalVar.SensorPlotNum] { wfSpin_A, wfSpin_B, wfSpin_C };
            neDispValGroup = new NumericEdit[TGlobalVar.SensorPlotNum] { neSpin_A, neSpin_B, neSpin_C };

            cbDispPlotGroup = new CheckBox[3] { cbSensor1, cbSensor2, cbSensor3 };  //CheckedBox
            for (int k = 0; k < cbDispPlotGroup.Length; k++) cbDispPlotGroup[k].TabIndex = k;            
        }

        private void AllTBoxInitUpdate()        //界面相关Text控件*初始化
        {
            cmbProdName.SelectedIndex = -1; 
            //txtPalletID.Text = "***"; 
            txtScanBar.Text  = "***";

            //TBoxStdValInitUpdate();  
            TBoxCaliValInitUpdate();   
            
            TBoxAllInitUpdate();
        }

        private void TBoxAllInitUpdate()     //结果 * 初始化
        {
            TextBox[] TBoxStdVal = new TextBox[] { txtRealVal1,txtRealVal2,txtRealVal3,txtRealVal4,txtMeasVal1,txtMeasVal2,txtMeasVal3 };

            for (int k = 0; k < TBoxStdVal.Length; k++)
            {
                TBoxStdVal[k].Text = "***";
                TBoxStdVal[k].BackColor = Color.White;
            }
        }

        private void TBoxCaliValInitUpdate()    //标定值 * 初始化
        {
            TextBox[] TBoxCaliVal = new TextBox[] { txtCaliVal1, txtCaliVal2, txtCaliVal3};

            for (int k = 0; k < TBoxCaliVal.Length; k++)
            {
                TBoxCaliVal[k].Text = "*";
                TBoxCaliVal[k].BackColor = Color.White;
            }
        }

        private void TBoxMeasRealValInitUpdate()    //测量值/实际值/测量结果值 * 初始化
        {
            TextBox[] TBoxMeasRealVal = new TextBox[] { txtMeasVal1, txtMeasVal2, txtMeasVal3};
            
            for (int k = 0; k < TBoxMeasRealVal.Length; k++) TBoxMeasRealVal[k].Text = "*";
            if (gVCommPar.TestNum == 1)
            {
                txtRealVal1.Text = "***";
                txtRealVal1.BackColor = Color.White;
            }
            else if (gVCommPar.TestNum == 2)
            { 
                txtRealVal2.Text = "***";
                txtRealVal2.BackColor = Color.White;
            }
            else if (gVCommPar.TestNum == 3)
            {  
                txtRealVal3.Text = "***";
                txtRealVal3.BackColor = Color.White;
            }
            else if (gVCommPar.TestNum == 4)
            {  
                txtRealVal4.Text = "***";
                txtRealVal4.BackColor = Color.White;
            }
        }

        //********************************************************************************************************************
        private void CaliParInit()
        {
            gVCommPar.lstCaliVal.Clear(); //清空标定值列表
            //****************************************************************************************************************
            string[] strCaliValIni = new string[] { "CaliVal1", "CaliVal2", "CaliVal3" };
            TextBox[] TBoxCaliVal = new TextBox[] { txtCaliVal1, txtCaliVal2, txtCaliVal3 };

            for (int k = 0; k < TBoxCaliVal.Length; k++)
            {
                float TmpCaliVal = IniFilePtr.IniReadFloat(TGlobalVar.SysParSecName, strCaliValIni[k], 0);

                TBoxCaliVal[k].Text = TmpCaliVal.ToString("f3");
                if (TmpCaliVal < gVCommPar.CaliDnLimit | TmpCaliVal > gVCommPar.CaliUpLimit)
                {
                    TBoxCaliVal[k].BackColor = Color.Red;
                    gVCommPar.CaliGood[k] = false;
                }
                else
                {
                    TBoxCaliVal[k].BackColor = Color.White;
                    gVCommPar.CaliGood[k] = true;
                }
                gVCommPar.lstCaliVal.Add(TmpCaliVal);
            }            
        }   

        //********************************************************************************************************************


        private void CaliLimitInit()
        {
            DataTable ProdNameTbl = TSqlDbClass.RetnTblBySqlCmd(TGlobalVar.sSqlConn, "Select * From ProdNameTbl");
            if (ProdNameTbl != null && ProdNameTbl.Rows.Count >= 1)
            {
                gVCommPar.CaliUpLimit = Convert.ToSingle(ProdNameTbl.Rows[0]["CaliUpLimit"].ToString());  //标定凸出量上限
                gVCommPar.CaliDnLimit = Convert.ToSingle(ProdNameTbl.Rows[0]["CaliDnLimit"].ToString());  //标定凸出量下限
            }
        }
       
        private void ProdNameInitProc()
        {
            cmbProdName.Items.Clear(); 
            cmbProdNameID.Items.Clear();
             
            DataTable ProdNameTbl = TSqlDbClass.RetnTblBySqlCmd(TGlobalVar.sSqlConn, "Select * From ProdNameTbl");
            if (ProdNameTbl != null && ProdNameTbl.Rows.Count >= 1)
            {
                for (int i = 0; i < ProdNameTbl.Rows.Count; i++)
                {
                    string strProdName = ProdNameTbl.Rows[i]["ProdName"].ToString();  
                    string strProdNameID = ProdNameTbl.Rows[i]["ProdID"].ToString();
                    
                    cmbProdName.Items.Add(strProdName);
                    cmbProdNameID.Items.Add(strProdNameID);
                }
            }

            cmbProdName.SelectedIndex = -1;
        }

        enum ProIDChoose
        {
            A = 1,  //1.5
            B,      //1.5T
            C,      //1.8
            D       //4H
        }
        private void cmbProdName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (gVCommPar.MesEnable == false)
            //{
            int SeleID = cmbProdName.SelectedIndex;

            //gVCommPar.ProdID = Convert.ToInt32(cmbProdNameID.Items[SeleID].ToString());
            gVCommPar.ProdID = SeleID + 1;
            ProdParUpdate(gVCommPar.ProdID);

            switch (gVCommPar.ProdID)
            {
                case 1:
                    pPlcSrv.SyncWriteItem(OpcGroup_ToPlcPar, (int)EnumIpcCtrlItem.ProID, (int)ProIDChoose.A);
                    break;
                case 2:
                    pPlcSrv.SyncWriteItem(OpcGroup_ToPlcPar, (int)EnumIpcCtrlItem.ProID, (int)ProIDChoose.B);
                    break;
                case 3:
                    pPlcSrv.SyncWriteItem(OpcGroup_ToPlcPar, (int)EnumIpcCtrlItem.ProID, (int)ProIDChoose.C);
                    break;
                case 4:
                    pPlcSrv.SyncWriteItem(OpcGroup_ToPlcPar, (int)EnumIpcCtrlItem.ProID, (int)ProIDChoose.D);
                    break;
            }
        }

        private int ProdParUpdate(int ProdID) //产品变化刷新产品参数
        {
            int ProdNameIdx = -1;
            ProdID = ProdID == 0 ? 1 : ProdID;
           
            //gVCommPar.lstStdVal.Clear(); //清空标准值列表
            //***********************************************************************************************************            
            //string[]  strStdValIni = new string[] { "SpinStdVal", "HouseStdVal" };
            //TextBox[] TBoxStdVal   = new TextBox[] { txtSStdVal1, txtStdVal2 };

            if (ProdID >= 0)
            {
                DataTable ProdNameTbl = TSqlDbClass.RetnTblBySqlCmd(TGlobalVar.sSqlConn, "Select * From ProdNameTbl");
                if (ProdNameTbl != null && ProdNameTbl.Rows.Count >= 1)
                {
                    for (int i = 0; i < ProdNameTbl.Rows.Count; i++)
                    {
                        int TmpProdID = Convert.ToInt32(ProdNameTbl.Rows[i]["ProdID"].ToString());
                        if (TmpProdID == ProdID)
                        {
                            ProdNameIdx = i;                           
                            
                            //for (int k = 0; k < TBoxStdVal.Length; k++) //轴高及壳体深标准值
                            //{
                            //    float TmpStdVal = Convert.ToSingle(ProdNameTbl.Rows[i][strStdValIni[k]].ToString());

                            //    TBoxStdVal[k].Text = TmpStdVal.ToString("f3"); 
                            //    gVCommPar.lstStdVal.Add(TmpStdVal);     //标准值列表缓冲
                            //}
                            
                            gVCommPar.UpLimit = Convert.ToSingle(ProdNameTbl.Rows[i]["UpLimit"].ToString());  //凸出量上限
                            gVCommPar.DnLimit = Convert.ToSingle(ProdNameTbl.Rows[i]["DnLimit"].ToString());  //凸出量下限

                            gVCommPar.CaliUpLimit = Convert.ToSingle(ProdNameTbl.Rows[i]["CaliUpLimit"].ToString());  //标定凸出量上限
                            gVCommPar.CaliDnLimit = Convert.ToSingle(ProdNameTbl.Rows[i]["CaliDnLimit"].ToString());  //标定凸出量下限

                            //gVCommPar.DiffUpLimit = Convert.ToSingle(ProdNameTbl.Rows[i]["DiffUpLimit"].ToString());  //凸出量上限
                            //gVCommPar.MeasCpes = Convert.ToSingle(ProdNameTbl.Rows[i]["MeasCpes"].ToString());   //测量补偿                            
                            gVCommPar.PreMeasSpan  = Convert.ToSingle(ProdNameTbl.Rows[i]["PreMeasSpan"].ToString());   //测量前延时

                            //gVCommPar.UpErrLimit = Convert.ToSingle(ProdNameTbl.Rows[i]["UpErrLimit"].ToString());  //配合上下限
                            //gVCommPar.DnErrLimit = Convert.ToSingle(ProdNameTbl.Rows[i]["DnErrLimit"].ToString()); 
                            //gVCommPar.MotorMeasSpd = Convert.ToSingle(ProdNameTbl.Rows[i]["MotorMeasSpd"].ToString());  //电机磨合转速  预测量(磨合）时间
                            
                            //pPlcSrv.SyncWriteItem(OpcGroup_ToPlcPar, (int)EnumIpcCtrlItem.MotorMeasSpd, gVCommPar.MotorMeasSpd);    
                            break;
                        }
                    }
                }
            }

            if (ProdNameIdx == -1) 
            {
                InfoToStatusListBox("警告:产品编号对应的参数未配置，请检查...");
                //添加上位机异常向PLC置位
            }

            return ProdNameIdx;
        }        

        //**********************************************************************************************
        //**********************************************************************************************
        private void WavePlot_CheckedChanged(object sender, EventArgs e)
        {            
            CheckBox cb = (CheckBox)sender;     
            wfDispPlotGroup[cb.TabIndex].Visible = cb.Checked;
        }

        private void RsCommInit()
        {
            try
            {   
                string sDispChan = IniFilePtr.IniReadString(TGlobalVar.SysParSecName, "DispChan", "COM3");

                pDispCom = new TDispSensorCom(sDispChan, 9600, Parity.None, 8, StopBits.One, true, true);
                pDispCom.RecvInit(TGlobalVar.SensorTotalNum);
                
                RsPlotTimer.Enabled = true;
            }
            
            catch
            {
                MessageBox.Show("COM端口通讯失败,请检查COM设置！", "警告");
                Close();
            }

            if (!pDispCom.CheckPortIsOpen())
            {
                MessageBox.Show("串口没打开,请检查COM设置！", "警告");
            }
        }        
        
        //**************************************************************************************************
        //**************************************************************************************************
        #region 菜单处理
        
        private void InfoViewMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem TmpMenuItem = (ToolStripMenuItem)sender;

            switch (TmpMenuItem.Name)
            {
                case "TestRecViewMenuItem":
                    frmTestRecView RecView = new frmTestRecView();
                    RecView.Show(this);
                    break;      
            }            
        }

        //**************************************************************************************************
        //**************************************************************************************************
        private void ProdParCfgMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem TmpMenuItem = (ToolStripMenuItem)sender;

            switch (TmpMenuItem.Name)
            {
                case "ProdParMenuItem":
                    frmProdNameCfg ProdNameCfg = new frmProdNameCfg();
                    ProdNameCfg.ShowDialog();
                    break;

                case "GasketParCfgMenuItem":
                    frmGasketCfg GasketCfg = new frmGasketCfg();
                    GasketCfg.ShowDialog();
                    break;
            }
        }

        private void OpcParCfgMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem TmpMenuItem = (ToolStripMenuItem)sender;

            switch (TmpMenuItem.Name)
            {
                case "OpcGroupCfgMenuItem":
                    frmOpcGroupCfg OpcGroupCfg = new frmOpcGroupCfg();
                    OpcGroupCfg.ShowDialog();
                    break;

                case "OpcItemCfgMenuItem":
                    frmOpcItemCfg ItemCfg = new frmOpcItemCfg();
                    ItemCfg.ShowDialog();
                    break;

                case "SysParMenuItem":
                    frmSysParCfg SysParCfg = new frmSysParCfg();
                    SysParCfg.ShowDialog();
                    break;                
            }
        }

        private void ExitWinMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShutDownMenuItem_Click(object sender, EventArgs e)
        {
            TShutDown.DoExitWin(0x00000001);
        }


        private void tsmiScreenKeyboard_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");
        }

        private void tsmiCalculator_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void tsmiNotepad_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }


        #endregion 菜单处理

        //**************************************************************************************************
        //**************************************************************************************************

        #region 用户管理
        private void UserAuthorityManage()
        {
            string Authority = TUserManage.GetActiveUserLevel();

            OpcParCfgMenuItem.Enabled = false;            
            ParSetMmenuItem.Enabled = false;
            InfoViewMenuItem.Enabled = false;

            switch (Authority)
            {
                case "超级管理员":                    
                    ParSetMmenuItem.Enabled = true;
                    InfoViewMenuItem.Enabled = true;
                    break;

                case "管理员":
                    InfoViewMenuItem.Enabled = true;
                    break;

                case "操作员":
                    break;

                case "系统管理员":
                    OpcParCfgMenuItem.Enabled = true;
                    ParSetMmenuItem.Enabled   = true;
                    InfoViewMenuItem.Enabled  = true;
                    break;
            }
        }

        private void UserLoginMenuItem_Click(object sender, EventArgs e)
        {
            TUserManage.LogoutUser();

            frmLogin MyfrmLogin = new frmLogin("ReLogin");
            MyfrmLogin.ShowDialog();

            if (MyfrmLogin.DialogResult == DialogResult.OK)
            {
                UserAuthorityManage();
            }
        }

        private void UserAddMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUser MyfrmAddUser = new frmAddUser();
            MyfrmAddUser.ShowDialog();
        }

        private void UserDeleMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleUser MyfrmDeleUser = new frmDeleUser();
            MyfrmDeleUser.ShowDialog();
        }

        private void UserModiMenuItem_Click(object sender, EventArgs e)
        {
            frmModiUser MyfrmModiUser = new frmModiUser();
            MyfrmModiUser.ShowDialog();
        }

        private void LogOutMenuItem_Click(object sender, EventArgs e)
        {
            TUserManage.LogoutUser();
            TUserManage.SetActiveUser("Operator");
            UserAuthorityManage();
        }

        #endregion 用户管理         

      

        private void Release_Click(object sender, EventArgs e)
        {
            //pPlcSrv.SyncWriteItem(OpcGroup_ToPlcPar, (int)EnumIpcCtrlItem.Release, 1);
        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
            //pPlcSrv.SyncWriteItem(OpcGroup_ToPlcPar, (int)EnumIpcCtrlItem.Fstart, 1);
        }

        private void Stop_Button_Click(object sender, EventArgs e)
        {
            //pPlcSrv.SyncWriteItem(OpcGroup_ToPlcPar, (int)EnumIpcCtrlItem.Fstop, 1);
        }

        private void DebugButton_Click(object sender, EventArgs e)
        {
            frmButtDebug frmButton = new frmButtDebug();
            frmButton.Show();
        }
        enum WorkMode
        {
            autoTest = 1,
            manulTest,
            emptyTest,
            pangtong,
            Cali,

        }
        private void ModeChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ModeChoose.Text)
            {
                case "手动模式":
                    pPlcSrv.SyncWriteItem(OpcGroup_ToPlcPar, (int)EnumIpcCtrlItem.TestMode, (int)WorkMode.manulTest);//0: 未 选择 模式 1: 自 动 模式 2: 手 动 模 式 3: 空循 环 模式 4: 旁通模式 5:标 定 模式
                    break;
                case "自动模式":
                    pPlcSrv.SyncWriteItem(OpcGroup_ToPlcPar, (int)EnumIpcCtrlItem.TestMode, (int)WorkMode.autoTest);
                    break;
                case "空循环模式":
                    pPlcSrv.SyncWriteItem(OpcGroup_ToPlcPar, (int)EnumIpcCtrlItem.TestMode, (int)WorkMode.emptyTest);
                    break;
                case "旁通模式":
                    pPlcSrv.SyncWriteItem(OpcGroup_ToPlcPar, (int)EnumIpcCtrlItem.TestMode, (int)WorkMode.pangtong);
                    break;
                case "标定模式":
                    pPlcSrv.SyncWriteItem(OpcGroup_ToPlcPar, (int)EnumIpcCtrlItem.TestMode, (int)WorkMode.Cali);
                    break;
            }
        }


        private void DebugPar_Click(object sender, EventArgs e)
        {
            frmButtDebugBitCfg frmButt = new frmButtDebugBitCfg();
            frmButt.Show();
        }

        private void AlarmInfo_Click(object sender, EventArgs e)
        {
            frmAlarmRec frmAlarm = new frmAlarmRec();
            frmAlarm.Show();
        }

        private void AlarmInfoPar_Click(object sender, EventArgs e)
        {
            frmAlarmMsgCfg frmAlarmCfg = new frmAlarmMsgCfg();
            frmAlarmCfg.Show();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            Process[] po = Process.GetProcesses();
            for (int i = 0; i < po.Length; i++)
            {
                try
                {
                    if (po[i].MainModule.ModuleName.ToString() == "气门插入翻转机.vshost.exe" || po[i].MainModule.ModuleName.ToString() == "气门插入翻转机.exe")
                    {
                        po[i].Kill();
                    }
                }
                catch
                {
                }
             }
        
        }


        private void SpeedInit()
        {
           float manulSpeed = IniFilePtr.IniReadFloat(TGlobalVar.SysParSecName, "ManulSpeed", 12);
           float fastSpeed = IniFilePtr.IniReadFloat(TGlobalVar.SysParSecName, "FastSpeed", 12);
           float slowSpeed = IniFilePtr.IniReadFloat(TGlobalVar.SysParSecName, "SlowSpeed", 12);
           pPlcSrv.SyncWriteItem(OpcGroup_ToPlcPar, (int)EnumIpcCtrlItem.manulSpeed, manulSpeed);
           pPlcSrv.SyncWriteItem(OpcGroup_ToPlcPar, (int)EnumIpcCtrlItem.fastSpeed, fastSpeed);
           pPlcSrv.SyncWriteItem(OpcGroup_ToPlcPar, (int)EnumIpcCtrlItem.slowSpeed, slowSpeed);

        }

        //**************************************************************************************************
        //**************************************************************************************************
    }
}
