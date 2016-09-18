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


namespace MyTestBed
{
    public partial class frmButtDebugBitCfg : Form 
    {
        //*************************************************************************************
        #region instance

        private static frmButtDebugBitCfg MyInstance = null;
        public static frmButtDebugBitCfg GetInstance()
        {
            return Myinstance();
        }

        private static frmButtDebugBitCfg Myinstance()
        {
            if (MyInstance == null || MyInstance.IsDisposed)
            {
                MyInstance = new frmButtDebugBitCfg();
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
        //*************************************************************************************

        private DgVBindClass ParCfg_DgViewPtr = null;
        string[] sFieldCap = { "按钮标签", "位0提示", "位1提示", "位2提示", "位3提示", "位4提示", "位5提示", "位6提示", "位7提示" };

        public frmButtDebugBitCfg()
        {
            InitializeComponent();

            btnRecAdd.Click  += new EventHandler(OnDgViewBtn_Click);
            btnRecModi.Click += new EventHandler(OnDgViewBtn_Click);
            btnRecUp.Click   += new EventHandler(OnDgViewBtn_Click);
            btnRecDn.Click   += new EventHandler(OnDgViewBtn_Click);
            btnRecDel.Click  += new EventHandler(OnDgViewBtn_Click);

            this.ParCfg_DgView.CellClick += new DataGridViewCellEventHandler(this.OnDgView_CellClick);
            this.Load += new System.EventHandler(this.OnForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnForm_Closing);
        }

        private void OnForm_Load(object sender, EventArgs e) 
        {             
            //*********************************************************************************
            ParCfg_DgViewPtr = new DgVBindClass(TGlobalVar.sDataBase, TGlobalVar.sSqlConn, TGlobalVar.sMasterSqlConn, this);
            TableStructParInit();

            //******************************************************************
            if (ParCfg_DgViewPtr.TableBindToDgV("ButtDebugInfoTbl") == false)
            {
                MessageBox.Show("按钮信息数据表创建失败,请检查!");
                Close();
            }         
        }

        private void TableStructParInit()
        {
            string[] sFieldName = { "ButtItemName", "BitInfo_0", "BitInfo_1", "BitInfo_2", "BitInfo_3", "BitInfo_4", "BitInfo_5", "BitInfo_6", "BitInfo_7" };
            string[] sDataType  = { "Varchar", "Varchar", "Varchar", "Varchar", "Varchar", "Varchar", "Varchar", "Varchar", "Varchar" };
            int[]    iMaxLen    = {  32, 16, 16, 16, 24, 16, 16, 16, 16 };
            string[] sAllowNull = { "Not Null", "Not Null", "Not Null", "Not Null", "Not Null", "Not Null", "Not Null", "Not Null", "Not Null" };
    
            ParCfg_DgViewPtr.TableParProc( sFieldName, sDataType, iMaxLen, sAllowNull); //表结构参数初始化
            
            //**************************************************************************************************************************************************
            Control[] cItemCon = {  ItemCon_0, ItemCon_1, ItemCon_2, ItemCon_3, ItemCon_4, ItemCon_5, ItemCon_6, ItemCon_7, ItemCon_8 };
            string[] sConType = { "ComboBox", "TextBox", "TextBox", "TextBox", "TextBox", "TextBox", "TextBox", "TextBox", "TextBox" };

            ParCfg_DgViewPtr.DgViewParProc(ParCfg_DgView, sFieldCap, cItemCon, sConType, btnRecAdd, btnRecModi, btnRecUp, btnRecDel, btnRecDn);
            
            //**************************************************************************************************************************************************
            Label[] ItemLblPtr = { ItemLbl_0, ItemLbl_1, ItemLbl_2, ItemLbl_3, ItemLbl_4, ItemLbl_5, ItemLbl_6, ItemLbl_7, ItemLbl_8 };
            for (int k = 0; k < sFieldCap.Length; k++) ItemLblPtr[k].Text = sFieldCap[k];

            //**********************************************************************************************************************************
            DataTable ButtDebugTbl = TSqlDbClass.RetnTblBySqlCmd(ParCfg_DgViewPtr.sSqlConn, "Select * From OpcItemTbl_" + "DebugButtPar");
            if (ButtDebugTbl != null && ButtDebugTbl.Rows.Count > 0) 
            {
                for (int k = 0; k < ButtDebugTbl.Rows.Count; k++)
                {
                    ItemCon_0.Items.Add(ButtDebugTbl.Rows[k]["ItemName"].ToString());                    
                }

                ItemCon_0.SelectedIndex = 0;                
            }           
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
            if (ItemCon_0.Text != "")
            {
                bool bIsAdd = true;
                List<string> lFieldCap = new List<string>();
                
                if (ParCfg_DgViewPtr.redundancyCheck(sFieldCap[0], -1) == true) //列重复检查，-1--检查所有行
                {
                    MessageBox.Show("按钮标签配置重复,请检查!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bIsAdd = false;
                }

                if (bIsAdd == true) ParCfg_DgViewPtr.RecAddProc(AddCheck.Checked);
            }            
            else
            {
                MessageBox.Show("按钮标签不能为空,请检查!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RecModiProc()
        {             
            int iCount = ParCfg_DgView.SelectedRows.Count;
            if (iCount <= 0 || iCount >= 2)
            {
                MessageBox.Show("请选择一条需要修改的记录！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ItemCon_0.Text != "")
            {
                bool bIsModi = true;
                
                if (ParCfg_DgViewPtr.redundancyCheck(sFieldCap[0], ParCfg_DgView.CurrentCell.RowIndex) == true) //列重复检查，不检查焦点行
                {
                    MessageBox.Show("按钮标签配置重复", "警告"); bIsModi = false;
                }

                if (bIsModi == true) ParCfg_DgViewPtr.RecModiProc();
            }
            else
            {
                MessageBox.Show("信息内容不能为空,请检查!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
         
        //**************************************************************************************************
        //**************************************************************************************************        
    }
}


