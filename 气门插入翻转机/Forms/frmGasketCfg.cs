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
using NationalInstruments.UI;

namespace MyTestBed
{
    public partial class frmGasketCfg : Form
    {
        //*************************************************************************************
        #region instance

        private static frmGasketCfg MyInstance = null;
        public static frmGasketCfg GetInstance()
        {
            return Myinstance();
        }

        private static frmGasketCfg Myinstance()
        {
            if (MyInstance == null || MyInstance.IsDisposed)
            {
                MyInstance = new frmGasketCfg();
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
        private TIniFilePtr  IniFilePtr = TIniFilePtr.GetTIniFile(TGlobalVar.SysParIniFile);
        private DgVBindClass ParCfg_DgViewPtr = null;
        private string[]     sFieldCap  = { "指示灯编号", "垫片厚度" };
               
        public frmGasketCfg()
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
            ParCfg_DgViewPtr = new DgVBindClass(TGlobalVar.sDataBase, TGlobalVar.sSqlConn, TGlobalVar.sMasterSqlConn, this);
            ParCfg_TblInit();

            if (ParCfg_DgViewPtr.TableBindToDgV("GasketTbl") == false)
            {
                MessageBox.Show("垫片数据表创建失败,请检查!");
                Close();
            }
        }        

        private void ParCfg_TblInit()
        {
            string[] sFieldName = { "ID",    "Thick" };
            string[] sDataType  = { "Int",   "Float" };
            int[]    iMaxLen    = {  0,      0,      };
            string[] sAllowNull = { "Not Null", "Not Null" };

            ParCfg_DgViewPtr.TableParProc(sFieldName, sDataType, iMaxLen, sAllowNull); //表结构参数初始化           
            
            //*******************************************************************************************************************************************************
            Control[] cItemCon = { ItemCon_0, ItemCon_1 };
            string[] sConType = { "NumericEdit", "NumericEdit" };

            ParCfg_DgViewPtr.DgViewParProc(ParCfg_DgView, sFieldCap, cItemCon, sConType, btnRecAdd, btnRecModi, btnRecUp, btnRecDel, btnRecDn);
            //**************************************************************************************************************************************************
            //Label[] ItemLblPtr = { ItemLbl_0, ItemLbl_1 };
            //for (int k = 0; k < sFieldCap.Length; k++) ItemLblPtr[k].Text = sFieldCap[k];
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

        private void RecUpdateProc()
        {
            ParCfg_DgViewPtr.RecUpdateProc();                
        }
        
        private void RecAddProc()
        {            
            bool bIsAdd = true;

            if (ParCfg_DgViewPtr.redundancyCheck(sFieldCap[0], -1) == true || ParCfg_DgViewPtr.redundancyCheck(sFieldCap[1], -1) == true) //某一列重复
            {
                MessageBox.Show("指示灯编号或垫片值已存在,请检查!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bIsAdd = false;
            }

            if (bIsAdd == true) ParCfg_DgViewPtr.RecAddProc(AddCheck.Checked);           
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

            if (ParCfg_DgViewPtr.redundancyCheck(sFieldCap[0], ParCfg_DgView.CurrentCell.RowIndex) == true || ParCfg_DgViewPtr.redundancyCheck(sFieldCap[1], ParCfg_DgView.CurrentCell.RowIndex) == true) //重复性检查
            {
                MessageBox.Show("指示灯编号或垫片值已存在,请检查!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bIsModi = false;
            }

            if (bIsModi == true) ParCfg_DgViewPtr.RecModiProc();
        } 

        private void OnDgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ParCfg_DgViewPtr.CellClickProc(e.RowIndex);
        }

        private void OnForm_Closing(object sender, FormClosingEventArgs e)
        {
            RecUpdateProc();
        } 
         
        //**************************************************************************************************
        //**************************************************************************************************        
    }
}
