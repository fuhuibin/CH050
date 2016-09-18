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
    public partial class frmAlarmMsgCfg : Form 
    {
         //*************************************************************************************
        #region instance

        private static frmAlarmMsgCfg MyInstance = null;
        public static frmAlarmMsgCfg GetInstance()
        {
            return Myinstance();
        }

        private static frmAlarmMsgCfg Myinstance()
        {
            if (MyInstance == null || MyInstance.IsDisposed)
            {
                MyInstance = new frmAlarmMsgCfg();
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
        string[] sFieldCap = { "标签名", "信息类型", "信息内容" };

        public frmAlarmMsgCfg()
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
            TableStructParInit();

            //******************************************************************
            if (ParCfg_DgViewPtr.TableBindToDgV("AlarmInfoTbl") == false)
            {
                MessageBox.Show("数据表创建失败,请检查!");
                Close();
            }   
        }

        private void TableStructParInit()
        {                        
            string[] sFieldName = { "AlarmItem", "AlarmType", "AlarmInfo" };
            string[] sDataType  = { "Varchar", "Varchar", "Varchar" };
            int[]    iMaxLen    = { 16, 8, 64 };
            string[] sAllowNull = { "Not Null", "Not Null", "Not Null" };
    
            ParCfg_DgViewPtr.TableParProc( sFieldName, sDataType, iMaxLen, sAllowNull); //表结构参数初始化
            
            //**************************************************************************************************************************************************
            Control[] cItemCon = { ItemCon_0, ItemCon_1, ItemCon_2  };
            string[] sConType = { "ComboBox", "ComboBox", "TextBox" };

            ParCfg_DgViewPtr.DgViewParProc(ParCfg_DgView, sFieldCap, cItemCon, sConType, btnRecAdd, btnRecModi, btnRecUp, btnRecDel, btnRecDn);
            
            //**************************************************************************************************************************************************
            Label[] ItemLblPtr = { ItemLbl_0, ItemLbl_1, ItemLbl_2 };
            for (int k = 0; k < sFieldCap.Length; k++) ItemLblPtr[k].Text = sFieldCap[k];

            CommentCboBox.Items.Clear();            
            DataTable AlarmItemTbl = TSqlDbClass.RetnTblBySqlCmd(ParCfg_DgViewPtr.sSqlConn, "Select * From OpcItemTbl_" + "AlarmMsgPar");
            if (AlarmItemTbl != null && AlarmItemTbl.Rows.Count > 0) 
            {
                for (int k = 0; k < AlarmItemTbl.Rows.Count; k++)
                {
                    ItemCon_0.Items.Add(AlarmItemTbl.Rows[k]["ItemName"].ToString());
                    CommentCboBox.Items.Add(AlarmItemTbl.Rows[k]["Comment"].ToString());
                }

                ItemCon_0.SelectedIndex = 0;                
            }

            ItemCon_1.SelectedIndex = 0;
        }

        private void ItemCon_0_SelectedIndexChanged(object sender, EventArgs e)
        {
            CommentTxt.Text = CommentCboBox.Items[ItemCon_0.SelectedIndex].ToString();
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
            if (ItemCon_0.Text != "" && ItemCon_2.Text.Trim().Length > 0)
            {
                bool bIsAdd = true;                
                
                if (ParCfg_DgViewPtr.redundancyCheck(sFieldCap[0], -1) == true) //列重复检查，-1--检查所有行
                {
                    MessageBox.Show("配置重复,请检查!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bIsAdd = false;
                }

                if (bIsAdd == true) ParCfg_DgViewPtr.RecAddProc(AddCheck.Checked);
            }            
            else
            {
                MessageBox.Show("信息内容不能为空,请检查!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (ItemCon_0.Text != "" && ItemCon_2.Text.Trim().Length > 0)
            {
                bool bIsModi = true;
                
                if (ParCfg_DgViewPtr.redundancyCheck(sFieldCap[0], ParCfg_DgView.CurrentCell.RowIndex) == true) //列重复检查，不检查焦点行
                {
                    MessageBox.Show("配置重复", "警告"); bIsModi = false;
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

        private void ColModiMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "ContColModiMenuItem")
            {
                if(ParCfg_DgView.RowCount > 2) 
                {
                    List<string> lFieldCap = new List<string>();
                    lFieldCap.Clear(); lFieldCap.Add(sFieldCap[1]); lFieldCap.Add(sFieldCap[2]); 

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

        private void OnForm_Closing(object sender, FormClosingEventArgs e) 
        {
            ParCfg_DgViewPtr.RecUpdateProc();           
        }        
         
        //**************************************************************************************************
        //**************************************************************************************************        
    }
}


