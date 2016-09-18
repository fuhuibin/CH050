using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using OpcRcw.Da;
using System.Net;
using TSqlAppClass;
using MyTestBed;

namespace OpcSrv
{
    public class TPlcSrv
    {
        //private string sSqlConn = TGlobalVar.getSqlConn(TGlobalVar.sDataSrc, TGlobalVar.sDataBase);
                
        ArrayList ItemNameList          = new ArrayList();
        ArrayList PlcConnList           = new ArrayList();
        ArrayList dBlockList            = new ArrayList();
        ArrayList ItemTypeList          = new ArrayList(); 
        ArrayList ItemAddrList          = new ArrayList();
        ArrayList InitValList           = new ArrayList();       
        ArrayList CommentList           = new ArrayList();
        
        //************************************************************************************************
        TOpcSrv pOpcSrv = TOpcSrv.GetInstance();

        private static readonly TPlcSrv instance = new TPlcSrv();
        public static TPlcSrv GetInstance()
        {
            return instance;
        }

        //************************************************************************************************

        public bool OpcSrvInit()
        {
            bool bRet = true;

            if (!pOpcSrv.CreateServer("KEPware.KEPServerEx.V4", "127.0.0.1"))
            {
                MessageBox.Show("OPC服务创建错误，请检查OPC网络配置、连接是否正常!", "警告：退出程序", MessageBoxButtons.OK);

                bRet = false;
            }

            return bRet;
        }

        #region 创建OPC组对象

        /// <summary>
        /// 创建OPC组对象
        /// </summary>
        /// <param name="sGroupName"></param>
        public bool CreateOpcGroup(string sGroupName, bool Active)
        {
            bool bRet = false;

            DataTable OpcGroupTbl = TSqlDbClass.RetnTblBySqlCmd(TGlobalVar.sSqlConn, "Select * From OpcGroupTbl where OpcGroupName = '" + sGroupName +"'");
            DataRow   dr = OpcGroupTbl.Rows[0];

            if (dr != null)
            {
                string sGroupMode = dr["OpcGroupMode"].ToString();
                int    dwReqUpdateRate = Convert.ToInt32(dr["ReqUpdateRate"].ToString());

                //根据组名获取相应组标签表 "OpcItemTbl_" + sOpcGroupName
                string OpcItemTblName = "OpcItemTbl_" + sGroupName;

                DataTable TmpItemTbl = TSqlDbClass.RetnTblBySqlCmd(TGlobalVar.sSqlConn, "Select * From " + OpcItemTblName);
                if (TmpItemTbl != null)
                {
                    GetGroupItemInfo(TmpItemTbl); //根据组标签表获取标签信息
                    bRet = pOpcSrv.CreateOpcGroup(sGroupName, Active, sGroupMode, dwReqUpdateRate, ItemNameList, PlcConnList, dBlockList, ItemTypeList, ItemAddrList, InitValList, CommentList);
                 }
                //else
                //{
                //    bRet = false;
                //    MessageBox.Show(sGroupName + "组对应的标签表没有记录，请检查!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
            }
            //else
            //{
            //    bRet = false;
            //    MessageBox.Show(sGroupName + "组名不存在，请检查!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

            return bRet;
        }

        //************************************************************************************************************        
        //*********************************************获取OPC组的标签名**********************************************
        //************************************************************************************************************
        public List<string> GetOpcGroupItemName(string GroupName)
        {
            List<string> lstItemName = null;

            DataTable dt = TSqlDbClass.RetnTblBySqlCmd(TGlobalVar.sSqlConn, "Select * From " + "OpcItemTbl_" + GroupName);
            if (dt != null && dt.Rows.Count >= 1)
            {
                lstItemName = new List<string>();
                for (int k = 0; k < dt.Rows.Count; k++) lstItemName.Add(dt.Rows[k]["ItemName"].ToString());
            }

            return lstItemName;
        }

        public bool SetOpcGroupState(string sGroupName, bool bActive)
        {
            bool bRet = true;

            if (pOpcSrv.CheckOpcGroupExist(sGroupName) == true)
            {
                bRet = pOpcSrv.SetOpcGroupState(sGroupName, bActive);
            }
            else
            {
                //MessageBox.Show(sGroupName + "组没有创建，请检查!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bRet = false;
            }

            return bRet;
        }

        public bool CheckOpcGroupExist(string sGroupName)
        {
            return pOpcSrv.CheckOpcGroupExist(sGroupName);
        }

        /// <summary>
        /// 获得组内标签信息。
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="ItemsIndex"></param>
        private void GetGroupItemInfo(DataTable dt)
        {
            ItemNameList.Clear();
            PlcConnList.Clear();
            dBlockList.Clear();
            ItemTypeList.Clear();
            ItemAddrList.Clear();
            InitValList.Clear();
            CommentList.Clear();

            DataTable extdt = RetnExtItemsTbl(dt);
            for (int k = 0; k < extdt.Rows.Count; k++)
            {
                DataRow dr = extdt.Rows[k];

                ItemNameList.Add(dr["ItemName"]);
                PlcConnList.Add(dr["PlcConn"]);
                dBlockList.Add(dr["dBlock"]);
                ItemTypeList.Add(dr["ItemType"]);
                ItemAddrList.Add(dr["ItemAddr"]);
                InitValList.Add(dr["InitVal"]);
                CommentList.Add(dr["Comment"]);
            }
        }

        #region 展开自定义标签类型表
        
        private bool CustomItemTypeChk(string Type)
        {
            bool bRet = true;
            string[] sItemType = { "BOOL", "BYTE", "WORD", "DWORD", "INT", "DINT", "REAL", "CHAR", "STRING" };

            for (int k = 0; k < sItemType.Length; k++)
            {
                if (Type == sItemType[k]) 
                { 
                    bRet = false; 
                    break; 
                }
            }

            return bRet;
        }

        private DataTable RetnExtItemsTbl(DataTable dt)
        {
            try
            {
                int n = -1;
                int offset = 0; //偏移量。 
                int ItemNum;
                string InitItemAddr, ItemAddr;

                DataTable tmpdt = new DataTable(); //需要先定义表结构
                DataRow tmpdr = null;

                string[] ColName = { "ItemName", "PlcConn", "dBlock", "ItemType", "ItemAddr", "InitVal", "Comment" };
                for (int k = 0; k < ColName.Length; k++) tmpdt.Columns.Add(new DataColumn(ColName[k], typeof(System.String)));

                for (int i = 0; i < dt.Rows.Count; i++)  //OPC标签组记录行数
                {
                    ItemNum = Convert.ToInt32(dt.Rows[i]["ItemNum"]);                //当前类型标签数量
                    InitItemAddr = dt.Rows[i]["ItemAddr"].ToString();                     //初始标签地址                 

                    if (CustomItemTypeChk(dt.Rows[i]["ItemType"].ToString()) == true)     //定制类型判别
                    {
                        string CustItemTypeTblName = "CustomItemTbl_" + dt.Rows[i]["ItemType"].ToString();
                        DataTable Customdt = TSqlDbClass.RetnTblBySqlCmd(TGlobalVar.sSqlConn, "Select * From " + CustItemTypeTblName); //自定义标签类型表

                        if (Customdt != null && Customdt.Rows.Count > 0)
                        {
                            offset = RetnCustomOffset(Customdt);                          //定制标签偏置值
                            for (int j = 0; j < ItemNum; j++)                             //当前类型标签数量
                            {
                                for (int k = 0; k < Customdt.Rows.Count; k++)             //自定义标签类型表的行数
                                {
                                    n = -1;
                                    tmpdr = tmpdt.NewRow();

                                    n++; tmpdr[n] = Customdt.Rows[k]["ItemName"];

                                    n++; tmpdr[n] = dt.Rows[i]["PlcConn"];
                                    n++; tmpdr[n] = dt.Rows[i]["dBlock"];

                                    n++; tmpdr[n] = Customdt.Rows[k]["ItemType"];
                                    Decimal TmpItemAddr = Convert.ToDecimal(InitItemAddr) + Convert.ToDecimal(Customdt.Rows[k]["ItemAddr"].ToString()) + offset * j;
                                    n++; tmpdr[n] = TmpItemAddr.ToString();               //标签地址

                                    n++; tmpdr[n] = dt.Rows[i]["InitVal"];
                                    n++; tmpdr[n] = dt.Rows[i]["Comment"];

                                    tmpdt.Rows.Add(tmpdr);
                                }
                            }
                        }
                    }
                    else  //标准标签类型行 "ItemName", "PlcConn", "dBlock", "ItemType", "ItemAddr", "ItemNum", "InitVal", "Comment" 
                    {
                        ItemAddr = InitItemAddr;
                        for (int k = 0; k < ItemNum; k++)  //标签类型数量
                        {
                            n = -1;
                            tmpdr = tmpdt.NewRow();

                            n++; tmpdr[n] = dt.Rows[i]["ItemName"];
                            n++; tmpdr[n] = dt.Rows[i]["PlcConn"];
                            n++; tmpdr[n] = dt.Rows[i]["dBlock"];
                            n++; tmpdr[n] = dt.Rows[i]["ItemType"];
                            n++; tmpdr[n] = ItemAddr;
                            n++; tmpdr[n] = dt.Rows[i]["InitVal"];
                            n++; tmpdr[n] = dt.Rows[i]["Comment"];

                            tmpdt.Rows.Add(tmpdr);
                            ItemAddr = ResetOctalToString(Convert.ToDecimal(ItemAddr), dt.Rows[i]["ItemType"].ToString());
                        }
                    }
                }

                return tmpdt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :"+ ex.ToString());
                return null;
            }
        }

        private string ResetOctalToString(decimal a, string sType) //两个十进制数相加,小数部分相加转化为八进制后再转化为十进制数
        {
            decimal b = RetnItemLength(a.ToString(), sType);   //标准标签长度,BOOL-->0.1  String----> . 后的数值

            decimal a0 = Math.Floor(a),  b0 = Math.Floor(b);   //前一地址及后一类型整数部分
            decimal c0 = a - a0, c1 = b - b0;                  //前一地址及后一类型小数部分

            int     d0 = Convert.ToInt32 ((c0 + c1) * 10);     //小数--->整数            
            decimal e0 = Convert.ToDecimal(Convert.ToString(d0, 8)) / 10;  //整数--->八进制--->十进制
         
           
            return Convert.ToString(a0 + b0 + e0);
        }

        private int RetnCustomOffset(DataTable dt)
        {
            //用结构中最后一个标签的地址 - 第一个标签的地址 + 最后一个标签的长度。
            decimal offset;

            offset  = Math.Floor(Convert.ToDecimal(dt.Rows[dt.Rows.Count - 1]["ItemAddr"].ToString())) - Math.Floor(Convert.ToDecimal(dt.Rows[0]["ItemAddr"].ToString()));
            offset += Math.Ceiling(RetnItemLength(dt.Rows[dt.Rows.Count - 1]["ItemAddr"].ToString(), dt.Rows[dt.Rows.Count - 1]["ItemType"].ToString()));            
            
            return Convert.ToInt32(offset);
        }

        private decimal RetnItemLength(string ItemAddr, string sType)
        {
            decimal itemlen = 0;

            switch (sType.ToLower())
            {
                case "BOOL":
                    itemlen = 0.1m;  
                    break;

                case "BYTE":
                    itemlen = 1m;
                    break;

                case "WORD":
                    itemlen = 2m;
                    break;

                case "DWORD":
                    itemlen = 4m;
                    break;

                case "INT":
                    itemlen = 2m;
                    break;

                case "DINT":
                    itemlen = 4m;
                    break;

                case "REAL":
                    itemlen = 4m;
                    break;

                case "CHAR":
                    itemlen = 1m;
                    break;

                case "STRING":
                    itemlen = Convert.ToDecimal(ItemAddr.Substring(ItemAddr.IndexOf(".") + 1, ItemAddr.Length - ItemAddr.IndexOf(".") - 1));
                    break;
            }

            return itemlen;
        }
        #endregion

        #endregion
        //************************************************************************************************

        #region 标签同步    
        /// <summary>
        /// 整个组标签同步读
        /// </summary>
        /// <param name="sGroupName"></param>
        /// <param name="itemsV"></param>
        public object[] SyncReadItemsGroup(string sGroupName, OPCDATASOURCE OpcDataSrc) //缓存,设备
        {
            object[] TmpItemsVal = null;

            if (pOpcSrv.CheckOpcGroupExist(sGroupName) == true)
            {
                //根据组名获取相应组标签表
                string OpcItemTblName = "OpcItemTbl_" + sGroupName;
                DataTable dt = TSqlDbClass.RetnTblBySqlCmd(TGlobalVar.sSqlConn, "Select * From " + OpcItemTblName);
                if (dt != null)
                {
                    int[] ItemsIndex = new int[dt.Rows.Count];
                    for (int k = 0; k < dt.Rows.Count; k++) ItemsIndex[k] = k;

                    // OPCDATASOURCE.OPC_DS_CACHE, OPCDATASOURCE.OPC_DS_DEVICE
                    TmpItemsVal = pOpcSrv.SyncReadItems(sGroupName, ItemsIndex, OpcDataSrc);               
                }                
            }
            else
            {
                MessageBox.Show(sGroupName + "组没有创建！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TmpItemsVal = null;
            }

            return TmpItemsVal;
        }

        /// <summary>
        /// 多标签同步读
        /// </summary>
        /// <param name="sGroupName"></param>
        /// <param name="itemsV"></param>
        public object[] SyncReadItems(string sGroupName, int[] ItemsIdx, OPCDATASOURCE OpcDataSrc)
        {
            object[] TmpItemsVal = null;

            if (pOpcSrv.CheckOpcGroupExist(sGroupName) == true)
            {
                // OPCDATASOURCE.OPC_DS_CACHE, OPCDATASOURCE.OPC_DS_DEVICE
                TmpItemsVal = pOpcSrv.SyncReadItems(sGroupName, ItemsIdx, OpcDataSrc);               
            }
            else
            {
                MessageBox.Show(sGroupName + "组没有创建！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TmpItemsVal = null;
            }

            return TmpItemsVal;
        }

        /// <summary>
        /// 单标签同步读
        /// </summary>
        /// <param name="sGroupName"></param>
        /// <param name="itemsV"></param>
        public object SyncReadItem(string sGroupName, int ItemIdx, OPCDATASOURCE OpcDataSrc)
        {
            object TmpItemsVal = null;

            if (pOpcSrv.CheckOpcGroupExist(sGroupName) == true)
            {
                int[] ItemsIdx = new int[1];
                object[] ItemsVal = null;

                ItemsIdx[0] = ItemIdx;                
                // OPCDATASOURCE.OPC_DS_CACHE, OPCDATASOURCE.OPC_DS_DEVICE
                ItemsVal = pOpcSrv.SyncReadItems(sGroupName, ItemsIdx, OpcDataSrc);

                if (ItemsVal != null) TmpItemsVal = ItemsVal[0];

            }
            else
            {
                MessageBox.Show(sGroupName + "组没有创建！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TmpItemsVal = null;
            }

            return TmpItemsVal; 
        }

         #endregion        
        
        #region 标签同步写

        /// <summary>
        /// 同步写组标签初始值
        /// </summary>
        /// <param name="sGroupName"></param>
        /// <param name="itemsIdx"></param>
        /// <param name="itemsVal"></param>
        public bool SyncWrtInitVal(string sGroupName)
        {
            bool bRet = false;
           
            if (pOpcSrv.CheckOpcGroupExist(sGroupName) == true)
            {
                int[]    itemsIdx = null;
                object[] itemsVal = null;

                //先读取标签组 
                string OpcItemTblName = "OpcItemTbl_" + sGroupName;
                DataTable GroupItemsTbl = TSqlDbClass.RetnTblBySqlCmd(TGlobalVar.sSqlConn, "Select * From " + OpcItemTblName);               
                if (GroupItemsTbl != null)
                {
                    if (GroupItemsTbl.Rows.Count >= 1) 
                    {
                        itemsIdx = new int[GroupItemsTbl.Rows.Count];
                        itemsVal = new object[GroupItemsTbl.Rows.Count];

                        for (int k = 0; k < GroupItemsTbl.Rows.Count; k++)
                        {
                            DataRow dr = GroupItemsTbl.Rows[k];

                            itemsIdx[k] = k;
                            itemsVal[k] = Convert.ToDecimal(dr["InitVal"]);
                        }

                        bRet = pOpcSrv.SyncWriteItems(sGroupName, itemsIdx, itemsVal);
                        
                    }
                    else
                    {
                        MessageBox.Show(sGroupName + "组记录为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }               
                
            }
            else
            {
                MessageBox.Show(sGroupName + "组未创建！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return bRet;
        }

        /// <summary>
        /// 多标签同步写
        /// </summary>
        /// <param name="sGroupName"></param>
        /// <param name="itemsV"></param>
        public bool SyncWriteItems(string sGroupName, int[] itemsIdx, object[] itemsVal)
        {
            bool bRet = false;

            if (pOpcSrv.CheckOpcGroupExist(sGroupName) == true)
            {
                bRet = pOpcSrv.SyncWriteItems(sGroupName, itemsIdx, itemsVal);
            }
            else
            {
                MessageBox.Show(sGroupName + "组没有创建！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return bRet;
        }

        /// <summary>
        /// 单标签同步写PLC
        /// </summary>
        /// <param name="sGroupName"></param>
        /// <param name="itemsV"></param>
        public bool SyncWriteItem(string sGroupName, int ItemIdx, object itemVal)
        {
            bool bRet = false;

            if (pOpcSrv.CheckOpcGroupExist(sGroupName) == true)
            {
                int[] itemsIndex  = new int[1];
                object[] itemsVal = new object[1];               

                itemsIndex[0] = ItemIdx;
                itemsVal[0]   = itemVal;

                bRet = pOpcSrv.SyncWriteItems(sGroupName, itemsIndex, itemsVal);
            }  
            else                
            {
                MessageBox.Show(sGroupName + "组没有创建！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }

            return bRet;
        }

        public bool SyncSetItemBit(string sGroupName, int ItemIdx, int BitNo) //Word对应的位
        {
            bool bRet = false;

            object ItemVal = SyncReadItem(sGroupName, ItemIdx, OPCDATASOURCE.OPC_DS_CACHE);
            if (ItemVal != null)
            {
                ushort ItemWord = Convert.ToUInt16(ItemVal.ToString());
                ushort BitWord = (ushort)(1 << BitNo); //置位

                ItemWord |= BitWord;
                SyncWriteItem(sGroupName, ItemIdx, ItemWord);
            }

            return bRet; //TmpCtrlWord = (ushort)(~(1 << ctrlbit));
                         //ctrlword &= TmpCtrlWord;    //复位
        }

        public bool SyncClrItemBit(string sGroupName, int ItemIdx, int BitNo) //Word对应的位
        {
            bool bRet = false;

            object ItemVal = SyncReadItem(sGroupName, ItemIdx, OPCDATASOURCE.OPC_DS_CACHE);
            if (ItemVal != null)
            {
                ushort ItemWord = Convert.ToUInt16(ItemVal.ToString());
                ushort BitWord = (ushort)(~(1 << BitNo)); //复位

                ItemWord &= BitWord;
                SyncWriteItem(sGroupName, ItemIdx, ItemWord);
            }

            return bRet;          
        }     
 
        #endregion


        #region 释放Opc资源
        /// <summary>
        /// 释放单个组资源。
        /// </summary>
        /// <param name="sGroupName"></param>
        public void ReleaseGroup(string sGroupName)
        {
            pOpcSrv.ReleaseGroupConn(sGroupName);
        }

        /// <summary>
        /// 释放OPC资源。仅在系统退出时调用。
        /// </summary>
        public void ReleaseOpc()
        {
            pOpcSrv.DisConnOpc();
        }
        #endregion
    }
}
