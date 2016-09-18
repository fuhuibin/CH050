using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sunisoft.IrisSkin;
using System.Data.SqlClient;
using System.Collections;
using NationalInstruments.UI.WindowsForms;
using TSqlAppClass;
using TIniFile;
using OpcSrv;
using OpcRcw.Da;
using System.Reflection;

namespace MyTestBed
{
    public partial class frmButtDebug : Form
    {
        #region instance

        private static frmButtDebug MyInstance = null;

        public static frmButtDebug GetInstance()
        {
            return Myinstance();
        }

        private static frmButtDebug Myinstance()
        {
            if (MyInstance == null || MyInstance.IsDisposed)
            {
                MyInstance = new frmButtDebug();
                MyInstance.StartPosition = FormStartPosition.CenterScreen;
                //MyInstance.WindowState = FormWindowState.Maximized;
            }
            else
            {
                MyInstance.BringToFront();
            }

            return MyInstance;
        }

        #endregion

        //************************************************************************************       
        private int       RowsNumPerPage = 4;  

        private TPlcSrv   pPlcSrv = null;
        private int       PageIdx = 0;

        
        private List<List<Button>> CtrlButtList = null; //按钮指针
        private Button[]  MouseCtrlList = null;         //需要控制的按钮列表
        
        private Button[]  InfoButtList = null;    
        private Panel[]   PanelList    = null;

        private Color[] ButtOnColor = new Color[] { Color.Yellow, Color.Yellow, Color.Green, Color.Green, Color.Green, Color.Green, Color.Red, Color.Red };
        private List<int> DebugButtItemID  = null;
        private DataTable ButtDebugInfoTbl = null;

        private string ButtDebugGroupName = "DebugButtPar";
        //**************************************************************************************************************************************
        public frmButtDebug()
        {
            InitializeComponent();
        }

        private void OnForm_Load(object sender, EventArgs e)
        {
            pPlcSrv = TPlcSrv.GetInstance();
            //pPlcSrv.CreateOpcGroup(ButtDebugGroupName, false );
            
            //************************************************************************
            DataTable ButtDebugGroupTbl = TSqlDbClass.RetnTblBySqlCmd(TGlobalVar.sSqlConn, "Select * From OpcItemTbl_" + ButtDebugGroupName);
            if (ButtDebugGroupTbl == null || ButtDebugGroupTbl.Rows.Count <= 0)
            {
                MessageBox.Show("调试按钮标签未配置,请退出检查!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ButtDebugInfoTbl = TSqlDbClass.RetnTblBySqlCmd(TGlobalVar.sSqlConn, "Select * From ButtDebugInfoTbl");
            if (ButtDebugInfoTbl == null || ButtDebugGroupTbl.Rows.Count <= 0)
            {
                MessageBox.Show("调试按钮信息未配置,请退出检查!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //************************************************************************
            CtrlButtList = new List<List<Button>>(RowsNumPerPage);  
            for (int k = 0; k < RowsNumPerPage; k++) 
            { 
                CtrlButtList.Add(null); CtrlButtList[k] = new List<Button>(); 
            }

            for (int k = 0; k < RowsNumPerPage; k++)  //每页的按钮行数
            {                
                for(int i = 0; i < 8; i++)     //每行的按钮数
                {
                    Button tmpButt = (Button)findButtCon(this, "Butt" + k.ToString() + "_Bit" + i.ToString());
                    CtrlButtList[k].Add(tmpButt);

                    CtrlButtList[k][i].BackColor = Color.WhiteSmoke;
                    CtrlButtList[k][i].TabIndex  = k * 8 + i;
                }
            }

            PanelList    = new Panel[]  { ButtPanel_0, ButtPanel_1, ButtPanel_2, ButtPanel_3 };
            InfoButtList = new Button[] { InfoButt_0,  InfoButt_1,  InfoButt_2,  InfoButt_3  };  //中间的提示按钮
            
            //模拟鼠标动作的8个按钮
            MouseCtrlList = new Button[] { Butt0_Bit7, Butt0_Bit6, Butt1_Bit7, Butt1_Bit6, Butt2_Bit7, Butt2_Bit6, Butt3_Bit7, Butt3_Bit6 };
            for (int k = 0; k < MouseCtrlList.Length; k++)
            {
                MouseCtrlList[k].MouseUp   += new MouseEventHandler(this.DebugButt_MouseUp);
                MouseCtrlList[k].MouseDown += new MouseEventHandler(this.DebugButt_MouseDown);
            }       
            
            //读取位配置组行数数,排出在标签配置行记录中的序数
            DebugButtItemID = new List<int>(); DebugButtItemID.Clear(); //相应Debug按钮组在OPC组中的序号           
            for (int k = 0; k < ButtDebugInfoTbl.Rows.Count; k++)
            {
                string strItemName = ButtDebugInfoTbl.Rows[k]["ButtItemName"].ToString();

                int ItemID  = retnItemNameID(ButtDebugGroupTbl, strItemName);
                DebugButtItemID.Add(ItemID);
            }

            //当前页码
            PageIdx = 0;
            RefeshButtInfo(PageIdx, ButtDebugInfoTbl.Rows.Count);

            ButtStatusTimer.Enabled = true;
        }

        private Control findButtCon(Control formCon, string conName)
        {
            Control retnCon;

            foreach (Control c in formCon.Controls)
            {
                if (c.Name == conName)
                {
                    return c;
                }
                else if (c.Controls.Count > 0)
                {
                    retnCon = findButtCon(c, conName);
                    if (retnCon != null) return retnCon;                    
                }
            }

            return null;
        }

        private void buttPageUp_Click(object sender, EventArgs e)
        {
            PageIdx--; RefeshButtInfo(PageIdx, ButtDebugInfoTbl.Rows.Count);
        }

        private void buttPageDn_Click(object sender, EventArgs e)
        {
            PageIdx++; RefeshButtInfo(PageIdx, ButtDebugInfoTbl.Rows.Count);            
        }

        private void RefeshButtInfo(int PageNo, int RecCount) //根据当前页码以及总记录数刷新按钮
        {
            //先隐藏
            buttPageUp.Enabled = false;  buttPageDn.Enabled  = false;
            for(int k = 0; k < PanelList.Length; k++) PanelList[k].Visible = false;          
         
            //计算总页数并确认是否存在上一页与下一页
            int PageCount = (RecCount % RowsNumPerPage == 0) ? (RecCount / RowsNumPerPage) : (RecCount / RowsNumPerPage) + 1; 

            if(PageCount > PageNo + 1) buttPageDn.Enabled = true;
            if(PageNo >= 1)            buttPageUp.Enabled = true;

            //当前页剩余记录数
            int LeftRec = (RecCount - PageNo * RowsNumPerPage >= RowsNumPerPage) ? RowsNumPerPage : RecCount % RowsNumPerPage;      

            //刷新按钮提示
            for (int i = 0; i < LeftRec; i++)
            {
                PanelList[i].Visible = true;
                InfoButtList[i].Text = ButtDebugInfoTbl.Rows[RowsNumPerPage * PageNo + i]["ButtItemName"].ToString();
                
                for (int k = 0; k < 8; k++)
                {
                    CtrlButtList[i][k].Text = ButtDebugInfoTbl.Rows[RowsNumPerPage * PageNo + i]["BitInfo_" + k.ToString()].ToString();
                }                     
            }            
        }

        private void RefeshButtStatus(int PageNo, int RecCount)
        {
            //当前页剩余记录数
            int LeftRec = (RecCount - PageNo * RowsNumPerPage >= RowsNumPerPage) ? RowsNumPerPage : RecCount % RowsNumPerPage;

            //刷新按钮状态
            for (int i = 0; i < LeftRec; i++)
            {
                //第i行按钮组对应的Opc组序数, 根据Opc组序数获取标签值
                int ItemIdx     = DebugButtItemID[RowsNumPerPage * PageNo + i];
                Byte ButtStatus = Convert.ToByte(pPlcSrv.SyncReadItem(ButtDebugGroupName, ItemIdx, OPCDATASOURCE.OPC_DS_CACHE));
                
                for (int k = 0; k < 8; k++)
                {
                    bool bStatus = Convert.ToBoolean((ButtStatus >> k) & 0x01);

                    if (bStatus == true)
                    {
                        CtrlButtList[i][k].BackColor = ButtOnColor[k];
                    }
                    else
                    {
                        CtrlButtList[i][k].BackColor = Color.WhiteSmoke;
                    }
                }
            }
        }

        private int retnItemNameID(DataTable GroupTbl, string strItemName)
        {
            int ItemID = 0;

            for (int k = 0; k < GroupTbl.Rows.Count; k++)
            {
                if (GroupTbl.Rows[k]["ItemName"].ToString() == strItemName)
                {
                    ItemID = k; break;
                }
            }

            return ItemID;
        }

        private void DebugButt_MouseUp(object sender, MouseEventArgs e)
        {
            Button myButt  = (Button)sender;
            int    ButtIdx = myButt.TabIndex, OpcItemID = 0;
            Byte   myByte  = 0x00;
            int[]  lstButtIdx = { 6, 7, 14, 15, 22, 23, 30, 31 };

            for (int k = 0; k < lstButtIdx.Length; k++)
            {
                if (ButtIdx == lstButtIdx[k])
                {
                    OpcItemID = RowsNumPerPage * PageIdx + ButtIdx / 8;
                    if (lstButtIdx[k] % 8 == 6) myByte = 0xbf;
                    if (lstButtIdx[k] % 8 == 7) myByte = 0x7f;
                    break;
                }
            }
                        
            object TmpObj = Convert.ToByte(pPlcSrv.SyncReadItem(ButtDebugGroupName, DebugButtItemID[OpcItemID], OPCDATASOURCE.OPC_DS_CACHE));
            if(TmpObj != null)
            {
                Byte TmpByte = ((Byte)TmpObj);
                pPlcSrv.SyncWriteItem(ButtDebugGroupName, DebugButtItemID[OpcItemID], TmpByte & myByte);
            } 
        }

        private void DebugButt_MouseDown(object sender, MouseEventArgs e)
        {
            Button myButt = (Button)sender;
            int ButtIdx = myButt.TabIndex, OpcItemID = 0;
            Byte myByte = 0x00;

            int[] lstButtIdx = { 6, 7, 14, 15, 22, 23, 30, 31 };

            for (int k = 0; k < lstButtIdx.Length; k++)
            {
                if (ButtIdx == lstButtIdx[k])
                {
                    OpcItemID = RowsNumPerPage * PageIdx + ButtIdx / 8 ;

                    if (lstButtIdx[k] % 8 == 6) myByte = 0x40;
                    if (lstButtIdx[k] % 8 == 7) myByte = 0x80;                                                    
                    break;
                }
            }

            object TmpObj = Convert.ToByte(pPlcSrv.SyncReadItem(ButtDebugGroupName, DebugButtItemID[OpcItemID], OPCDATASOURCE.OPC_DS_CACHE));
            if (TmpObj != null)
            {
                Byte TmpByte = Convert.ToByte(TmpObj);
                pPlcSrv.SyncWriteItem(ButtDebugGroupName, DebugButtItemID[OpcItemID], TmpByte | myByte);
            }             
        }

        private void ButtStatusTimer_Tick(object sender, EventArgs e)
        {
            RefeshButtStatus(PageIdx, ButtDebugInfoTbl.Rows.Count); //刷新当前页
        }

        private void frmButtDebug_FormClosing(object sender, FormClosingEventArgs e)
        {
            ButtStatusTimer.Enabled = false;
            //pPlcSrv.ReleaseGroup(ButtDebugGroupName);           
            
            MyInstance = null;            
        }

    }
}


