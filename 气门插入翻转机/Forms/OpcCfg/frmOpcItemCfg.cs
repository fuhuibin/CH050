using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using NationalInstruments.UI.WindowsForms;
using TSqlAppClass;
using MyTestBed;


namespace MyTestBed
{
    public partial class frmOpcItemCfg : Form
    {
        private DgVBindClass ParCfg_DgViewPtr = null;
        private string[] sFieldCap = { "Opc标签名", "Plc连接点", "数据区域", "数据类型", "数据地址", "标签数量", "初始值", "注释" };

        public frmOpcItemCfg()
        {
            InitializeComponent();

            btnRecAdd.Click += new EventHandler(OnDgViewBtn_Click);
            btnRecModi.Click += new EventHandler(OnDgViewBtn_Click);
            btnRecUp.Click += new EventHandler(OnDgViewBtn_Click);
            btnRecDn.Click += new EventHandler(OnDgViewBtn_Click);
            btnRecDel.Click += new EventHandler(OnDgViewBtn_Click);
            
            this.ParCfg_DgView.CellClick += new DataGridViewCellEventHandler(this.OnDgView_CellClick);
            this.Load += new System.EventHandler(this.OnForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnForm_Closing);
        }

        private void OnForm_Load(object sender, EventArgs e)
        {
            //*********************************************************************************
            ParCfg_DgViewPtr = new DgVBindClass(TGlobalVar.sDataBase, TGlobalVar.sSqlConn, TGlobalVar.sMasterSqlConn, this);
            ParCfg_TblStructInit();

            //******************************************Opc组名*********************************
            OpcGroupNameCboBox.SelectedIndex = -1;
            DataTable OpcGroupNameTbl = TSqlDbClass.RetnTblBySqlCmd(ParCfg_DgViewPtr.sSqlConn, "Select * From OpcGroupTbl");
            if (OpcGroupNameTbl.Rows.Count >= 1)
            {
                for (int k = 0; k < OpcGroupNameTbl.Rows.Count; k++)
                {
                    OpcGroupNameCboBox.Items.Add(OpcGroupNameTbl.Rows[k]["OpcGroupName"].ToString());                   
                }

                OpcGroupNameCboBox.SelectedIndex = 0; //触发
            }
            //*********************************************************************************            
        }

        private void OpcGroupNameCboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ParCfg_DgViewPtr.RecUpdateProc();
            ParCfg_TblBindInit(OpcGroupNameCboBox.SelectedIndex);
        }

        private void ParCfg_TblBindInit(int ProdIdx)
        {
            string OpcGroupName = OpcGroupNameCboBox.Items[ProdIdx].ToString();

            if (ParCfg_DgViewPtr.TableBindToDgV("OpcItemTbl_" + OpcGroupName) == false)
            {
                MessageBox.Show("Opc标签数据表创建失败,请检查!");
                Close();
            }
        }

        private void ParCfg_TblStructInit()
        {
            string[] sFieldName = { "ItemName", "PlcConn", "dBlock", "ItemType", "ItemAddr", "ItemNum", "InitVal", "Comment" };
            string[] sDataType  = { "Varchar", "Varchar", "Varchar", "Varchar", "Varchar", "int", "Varchar", "Varchar" };
            int[]    iMaxLen    = { 24, 24, 16, 24, 16, 0, 16, 32 };
            string[] sAllowNull = { "Not Null", "Not Null", "Not Null", "Not Null", "Not Null", "Not Null", "Not Null", "Not Null" };
    
            ParCfg_DgViewPtr.TableParProc( sFieldName, sDataType, iMaxLen, sAllowNull); //表结构参数初始化
            
            //*******************************************************************************************************************************************************
            Control[] cItemCon = { ItemNameTxtBox, PlcConnTxtBox, dBlockTxtBox, ItemTypeCboBox, ItemAddrTxtBox, ItemNumNumedt, InitValTxtBox, CommentTxtBox };
            string[]  sConType = { "TextBox", "TextBox", "TextBox", "ComboBox", "TextBox", "NumericEdit", "TextBox", "TextBox" };
                                  
            ParCfg_DgViewPtr.DgViewParProc(ParCfg_DgView, sFieldCap, cItemCon, sConType, btnRecAdd, btnRecModi, btnRecUp, btnRecDel, btnRecDn);
            
            //**************************************************************************************************************************************************
            Label[] ItemLblPtr = { ItemLbl_0, ItemLbl_1, ItemLbl_2, ItemLbl_3, ItemLbl_4, ItemLbl_5, ItemLbl_6, ItemLbl_7 };
            for(int k = 0; k < sFieldCap.Length; k++) ItemLblPtr[k].Text = sFieldCap[k];

            //**************************************************************************************************************************************************
            ItemTypeInit();
        }

        private void ItemTypeInit()
        {
            string[] TmpItemType = { "BOOL", "BYTE", "WORD", "DWORD", "INT", "DINT", "REAL", "CHAR", "STRING" };

            ItemTypeCboBox.Items.Clear();
            for (int k = 0; k < TmpItemType.Length; k++) ItemTypeCboBox.Items.Add(TmpItemType[k]);
            
            //************************************添加自定义类型**********************************
            string strSql = "Select * From sysobjects Where Type='U' and Name='" + "CustomItemTbl" + "'";
            if (TSqlDbClass.IsTblExist(ParCfg_DgViewPtr.sSqlConn, strSql) == true)
            {

                DataTable CustomItemTbl = TSqlDbClass.RetnTblBySqlCmd(ParCfg_DgViewPtr.sSqlConn, "Select * From CustomItemTbl");
                for (int k = 0; k < CustomItemTbl.Rows.Count; k++)
                {
                    ItemTypeCboBox.Items.Add(CustomItemTbl.Rows[k]["CustomItemName"].ToString());
                }
            }
            //************************************************************************************

            ItemTypeCboBox.SelectedIndex = 4;
        }        
 
        //**************************************************************************************************
        //**************************************************************************************************       
        private void OnDgViewBtn_Click(object sender, EventArgs e)
        {
            Button TmpBtn = (Button)sender;

            switch (TmpBtn.Name)
            {
                case "btnRecAdd":
                    RecAddProc();                   
                    break;

                case "btnRecModi":
                    RecModiProc();
                    break;

                case "btnRecUp":
                    ParCfg_DgViewPtr.RecUpProc();
                    break;

                case "btnRecDel":
                    ParCfg_DgViewPtr.RecDelProc();                   
                    break;

                case "btnRecDn":
                    ParCfg_DgViewPtr.RecDnProc();
                    break;
            }
        }
        
        private void RecAddProc()
        {
            if (dataFormatCheck() == true)
            {
                bool bIsAdd = true;

                List<string> lFieldCap = new List<string>(); lFieldCap.Clear();
                lFieldCap.Add(sFieldCap[1]); lFieldCap.Add(sFieldCap[2]); lFieldCap.Add(sFieldCap[4]);
                //"Plc连接点", "数据区域",  "数据地址"                        //"数据类型"暂不考虑

                if (ParCfg_DgViewPtr.redundancyCheck(lFieldCap, -1) == true)  //多列重复
                {                  
                    bIsAdd = false;
                    MessageBox.Show("标签配置有冲突,请检查!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (bIsAdd == true) ParCfg_DgViewPtr.RecAddProc(AddCheck.Checked);
            }
            else
            {
                MessageBox.Show("标签参数配置有误，请检查!", "警告", MessageBoxButtons.OK);
            }
        }

        private void RecModiProc()
        {            
            bool bIsModi = true;

            int iCount = ParCfg_DgView.SelectedRows.Count;
            if (iCount <= 0 || iCount >= 2)
            {
                MessageBox.Show("请选择一条需要修改的记录！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataFormatCheck() == true)
            {
                List<string> lFieldCap = new List<string>(); lFieldCap.Clear();
                lFieldCap.Add(sFieldCap[1]); lFieldCap.Add(sFieldCap[2]); lFieldCap.Add(sFieldCap[4]);
                //"Plc连接点", "数据区域",  "数据地址"                        //"数据类型"暂不考虑

                if (ParCfg_DgViewPtr.redundancyCheck(lFieldCap, ParCfg_DgView.CurrentCell.RowIndex) == true) //重复性检查
                {
                    bIsModi = false;
                    MessageBox.Show("标签配置有冲突,请检查!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (bIsModi == true) ParCfg_DgViewPtr.RecModiProc();
            }
            else
            {
                MessageBox.Show("标签参数配置有误，请检查!", "警告", MessageBoxButtons.OK);
            }
        } 

        private void OnDgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ParCfg_DgViewPtr.CellClickProc(e.RowIndex);
        }

        private void OnForm_Closing(object sender, FormClosingEventArgs e)
        {
            ParCfg_DgViewPtr.RecUpdateProc();
        } 

        private void ColModiMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "ContColModiMenuItem")
            {
                if(ParCfg_DgView.RowCount > 2) 
                {                    
                    List<string> lFieldCap = new List<string>(); lFieldCap.Clear(); 
                    lFieldCap.Add(sFieldCap[1]); lFieldCap.Add(sFieldCap[2]); lFieldCap.Add(sFieldCap[3]);
                    lFieldCap.Add(sFieldCap[5]);
                    
                    frmContColModi myForm = new frmContColModi(lFieldCap, ParCfg_DgView.RowCount);                    
                    myForm.ShowDialog();
                    
                    if (myForm.DialogResult == DialogResult.OK)
                    {
                        int ColId = 0;
                        for (int k = 0; k < sFieldCap.Length; k++)
                        {
                            if (myForm.fieldCap == sFieldCap[k])
                            {
                                ColId = k+1;
                                break;
                            }
                        }

                        if(ColId>=1)
                        {
                            for (int k = myForm.startRow; k <= myForm.endRow; k++)
                            {
                                ParCfg_DgView.Rows[k-1].Cells[ColId].Value = myForm.colVal.ToString();
                            }
                        }                        
                    }
                }                   
            }
        }

        private void ItemAddrTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool b = true;

            if ((e.KeyChar >= '0' & e.KeyChar <= '9') || e.KeyChar == (Char)Keys.Back || e.KeyChar.ToString() == Keys.Delete.ToString() || e.KeyChar == (Char)Keys.Left || e.KeyChar == (Char)Keys.Right)
            {
                b = false;
            }
            else
            {
                if ((ItemTypeCboBox.Text == "BOOL" || ItemTypeCboBox.Text == "STRING") && e.KeyChar == '.')
                {
                    if (ItemAddrTxtBox.Text.IndexOf(".") == -1)
                    {
                        b = false;
                    }
                }
            }

            e.Handled = b;
        }

        private void InitValTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Back || e.KeyChar == (Char)Keys.Delete || e.KeyChar == (Char)Keys.Left || e.KeyChar == (Char)Keys.Right)
            {
                e.Handled = false;
            }
            else
            {
                if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z'))
                {
                    bool b = false;

                    if (ItemTypeCboBox.Text == "CHAR" && ItemTypeCboBox.Text.Length >= 1)
                    {
                        b = true;
                    }

                    if (ItemTypeCboBox.Text == "BOOL" && (e.KeyChar != '0' || e.KeyChar != '1') && InitValTxtBox.Text.Length >= 1)
                    {
                        b = true;
                    }

                    e.Handled = b;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void dBlockTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Back || e.KeyChar.ToString() == Keys.Delete.ToString() || e.KeyChar == (Char)Keys.Left || e.KeyChar == (Char)Keys.Right)
            {
                e.Handled = false;
            }
            else
            {
                if ((e.KeyChar >= '0' & e.KeyChar <= '9') || (e.KeyChar == 'I' || e.KeyChar == 'Q' || e.KeyChar == 'M' || e.KeyChar == 'D' || e.KeyChar == 'B'))
                {
                    bool b = true;

                    if (dBlockTxtBox.Text == "" && (e.KeyChar == 'I' || e.KeyChar == 'Q' || e.KeyChar == 'M' || e.KeyChar == 'D')) b = false;
                    if (dBlockTxtBox.Text == "D" && e.KeyChar == 'B') b = false;
                    if (dBlockTxtBox.Text.Length >= 2 && dBlockTxtBox.Text.Substring(0, 2) == "DB" && (e.KeyChar >= '0' && e.KeyChar <= '9')) b = false;

                    e.Handled = b;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private bool dataFormatCheck()  //数据格式检查
        {
            bool bRet = false;

            if (dBlockTxtBox.Text.Length >= 1 && (ItemNameTxtBox.Text.Trim() != "" && ItemAddrTxtBox.Text.Trim() != "" && PlcConnTxtBox.Text.Trim() != ""))
            {
                string str = dBlockTxtBox.Text.Substring(0, 1); //第一个字符

                if (str == "I" || str == "Q" || str == "M" || dBlockTxtBox.Text.Substring(0, 1) == "D")
                {
                    if (str != "D") //第一个字符为 I、Q、M
                    {
                        if (dBlockTxtBox.Text.Length == 1) bRet = true;
                        dBlockTxtBox.Text = str;
                    }
                    else            //第一个字符为 D
                    {
                        if (dBlockTxtBox.Text.Length > 2 && dBlockTxtBox.Text.Substring(0, 2) == "DB")
                        {
                            str = dBlockTxtBox.Text.Substring(2, dBlockTxtBox.Text.Length - 2);
                            if (str.IndexOf('I') == -1 && str.IndexOf('Q') == -1 && str.IndexOf('M') == -1 && str.IndexOf('D') == -1 && str.IndexOf('B') == -1) bRet = true;
                        }
                    }
                }

                if (bRet == true && (ItemTypeCboBox.Text == "BOOL" || ItemTypeCboBox.Text == "STRING"))
                {
                    bRet = ItemAddrFormatCheck(ItemTypeCboBox.Text, ItemAddrTxtBox.Text);
                }
            }

            return bRet;
        }

        private bool ItemAddrFormatCheck(string type, string str)
        {
            bool bRet = false;

            int idx = str.IndexOf("."); //12.34
            string prefix = "", suffix = "";

            if (idx != -1)
            {
                prefix = str.Substring(0, idx); //12
                if (str.Length > idx + 1) suffix = str.Substring(idx + 1); //34

                switch (type)
                {
                    case "BOOL":
                        if (prefix.Length >= 1 && (suffix.Length == 1 && Convert.ToDecimal(suffix) >= 0 && Convert.ToDecimal(suffix) <= 7)) bRet = true;
                        break;

                    case "STRING":
                        if (prefix.Length >= 1 && (suffix.Length >= 1 && Convert.ToDecimal(suffix) >= 1)) bRet = true;
                        break;
                }
            }

            return bRet;
        }

        private void ItemTypeCboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemNumNumedt.Enabled = true;

            if (ItemTypeCboBox.Text == "BOOL" || ItemTypeCboBox.Text == "STRING")
            {
                ItemNumNumedt.Enabled = false;
                ItemNumNumedt.Value = 1;
            }
        }  

 
        //**************************************************************************************************
        //**************************************************************************************************        
    }
}


