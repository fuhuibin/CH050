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

namespace MyTestBed
{
    public partial class frmProdNameCfg : Form 
    {
        //*************************************************************************************
        #region instance
        private static frmProdNameCfg MyInstance = null;
        public static frmProdNameCfg GetInstance()
        {
            return Myinstance();
        }

        private static frmProdNameCfg Myinstance()
        {
            if (MyInstance == null || MyInstance.IsDisposed)
            {
                MyInstance = new frmProdNameCfg();
                //MyInstance.StartPosition = FormStartPosition.CenterScreen;
                MyInstance.WindowState = FormWindowState.Maximized;
            }
            else
            {
                MyInstance.BringToFront();
            }

            return MyInstance;
        }
        #endregion        

        public frmProdNameCfg()
        {
            InitializeComponent();
            //******************************************************************************************
            btnRecAdd.Click  += new EventHandler(this.OnDgViewBtn_Click);
            btnRecModi.Click += new EventHandler(this.OnDgViewBtn_Click);
            btnRecUp.Click   += new EventHandler(this.OnDgViewBtn_Click);
            btnRecDn.Click   += new EventHandler(this.OnDgViewBtn_Click);
            btnRecDel.Click  += new EventHandler(this.OnDgViewBtn_Click);            
            
            this.DgViewRec.CellClick += new DataGridViewCellEventHandler(this.OnDgView_CellClick);
            this.Load += new System.EventHandler(this.OnForm_Load);
            this.FormClosing += new FormClosingEventHandler(this.OnForm_Closing);
        }

        private void OnForm_Load(object sender, EventArgs e) 
        {
            DgViewRecPtr = new DgVBindClass(TGlobalVar.sDataBase, TGlobalVar.sSqlConn, TGlobalVar.sMasterSqlConn, this);   
            DgView_TblStructParInit();

            if (DgViewRecPtr.TableBindToDgV("ProdNameTbl") == false) //产品组表
            {
                MessageBox.Show("产品名表创建失败,请检查!");
                Close();
            }
        }

        //*************************************************************************************        
        private DgVBindClass DgViewRecPtr = null;
        string[] sFieldCap = { "产品型号", "产品编号", "凸出量上限", "凸出量下限", "标定值上限", "标定值下限", "相邻差值上限", "测量延时", "测量补偿", "备用1", "备用2" };        

        private void DgView_TblStructParInit()
        {
            string[] sFieldName = { "ProdName", "ProdID", "UpLimit", "DnLimit", "CaliUpLimit", "CaliDnLimit", "DiffUpLimit", "PreMeasSpan", "MeasCpes", "Spare1", "Spare2" };
            string[] sDataType = { "Varchar", "Int", "Float", "Float", "Float", "Float", "Float", "Float", "Float", "Float", "Float" };
            int[] iMaxLen = { 32, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            string[] sAllowNull = { "Not Null", "Not Null", "Not Null", "Not Null", "Not Null", "Not Null", "Not Null", "Not Null", "Not Null", "Not Null", "Not Null" };

            DgViewRecPtr.TableParProc(sFieldName, sDataType, iMaxLen, sAllowNull); //表结构参数初始化
            
            //*******************************************************************************************************************************************************
            Control[] cItemCon = { ItemCon_0, ItemCon_1, ItemCon_2, ItemCon_3, ItemCon_9, ItemCon_10, ItemCon_4, ItemCon_5, ItemCon_6, ItemCon_7, ItemCon_8 };
            string[] sConType = { "TextBox", "NumericEdit", "NumericEdit", "NumericEdit", "NumericEdit", "NumericEdit", "NumericEdit", "NumericEdit", "NumericEdit", "NumericEdit", "NumericEdit" };

            DgViewRecPtr.DgViewParProc(DgViewRec, sFieldCap, cItemCon, sConType, btnRecAdd, btnRecModi, btnRecUp, btnRecDel, btnRecDn);
            
            //**************************************************************************************************************************************************
            //Label[] ItemLblPtr = { ItemLbl_0, ItemLbl_1, ItemLbl_2, ItemLbl_3, ItemLbl_4, ItemLbl_5, ItemLbl_6, ItemLbl_7, ItemLbl_8, ItemLbl_9, ItemLbl_10, ItemLbl_11 };
            //for (int k = 0; k < sFieldCap.Length; k++) ItemLblPtr[k].Text = sFieldCap[k];           
        }
 
        //**************************************************************************************************
        //**************************************************************************************************       
        private void DgView_RecAddProc()
        {
            if (ItemCon_0.Text.Trim().Length > 0)
            {
                bool bIsAdd = true;

                if (DgViewRecPtr.redundancyCheck(sFieldCap[0], -1) == true || DgViewRecPtr.redundancyCheck(sFieldCap[1], -1) == true) //某列重复
                {
                    MessageBox.Show("产品型号或产品编号已存在,请检查!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bIsAdd = false;
                }

                if (bIsAdd == true) DgViewRecPtr.RecAddProc(chkRecAdd.Checked);
            }
            else
            {
                MessageBox.Show("产品型号或产品编号已存在, 请检查!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DgView_RecModiProc()
        {
            int iCount = DgViewRec.SelectedRows.Count;
            if (iCount <= 0 || iCount >= 2)
            {
                MessageBox.Show("请选择一条需要修改的记录！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ItemCon_0.Text.Trim().Length > 0)
            {
                DgViewRecPtr.RecModiProc();                
            }
            else
            {
                MessageBox.Show("产品型号名不能为空, 请检查!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void OnDgViewBtn_Click(object sender, EventArgs e)
        {
            Button TmpBtn = (Button)sender;

            switch(TmpBtn.Name)
            {
                case "btnRecAdd":
                    DgView_RecAddProc();                    
                    break;

                case "btnRecModi":
                    DgView_RecModiProc();
                    break;

                case "btnRecUp":
                    DgViewRecPtr.RecUpProc();
                    break;

                case "btnRecDel":
                    DgViewRecPtr.RecDelProc();                    
                    break;

                case "btnRecDn":
                    DgViewRecPtr.RecDnProc();
                    break;
            }
        } 

        //**************************************************************************************************
        //************************************************************************************************** 
        private void OnDgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView TmpDgView = (DataGridView)sender;

            switch(TmpDgView.Name)
            {
                case "DgViewRec":                    
                     DgViewRecPtr.CellClickProc(e.RowIndex);                   
                     break;
            }
        }
        
        private void OnForm_Closing(object sender, FormClosingEventArgs e)
        {
            //更新数据表
            DgViewRecPtr.RecUpdateProc();            
        } 

     }
}


