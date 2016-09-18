using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Collections;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using System.IO;
using TSqlAppClass;
using ExcelSrv;
using Excel;
using System.Data.SqlClient;

namespace MyTestBed
{
    public partial class frmReadItems : Form
    {
        private string strXlsFileName = "";
       
        private void frmReadItems_Load(object sender, EventArgs e)
        {
            cmbOpcGroupName.Items.Clear();

            System.Data.DataTable OpcGroupTbl = TSqlDbClass.RetnTblBySqlCmd(TGlobalVar.sSqlConn, "Select * From OpcGroupTbl");
            if (OpcGroupTbl != null && OpcGroupTbl.Rows.Count >= 1) 
            {
                for (int k = 0; k < OpcGroupTbl.Rows.Count; k++)
                {
                    string OpcGroupName = OpcGroupTbl.Rows[k]["OpcGroupName"].ToString(); //产品名
                    cmbOpcGroupName.Items.Add(OpcGroupName);                    
                }
            }
            else
            {
                MessageBox.Show("提示:Opc组参数未配置。。。");
            }
        }
        
        private string RetnFileNameAndPath(string Filter)
        {
            string sFileNamePath = "";

            FileSeleDialog.Filter = Filter;
            if (FileSeleDialog.ShowDialog() == DialogResult.OK)
            {
                sFileNamePath = FileSeleDialog.FileName;
            }

            return sFileNamePath;
        }
        
        public frmReadItems()
        {
            InitializeComponent();
        }
  
        private void buttCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InsertRecProc(string TblName, List<string> strFieldList, List<List<string>> strRecList)
        {
           if(strRecList.Count <= 0) return;

           ArrayList SqlCmdList = new ArrayList();
           for (int i = 0; i < strRecList.Count; i++)
           {
               string strSqlCmd = "Insert Into " + TblName + "(";

               for (int k = 0; k < strFieldList.Count - 1; k++) strSqlCmd += strFieldList[k] + ",";
               strSqlCmd += strFieldList[strFieldList.Count - 1] + ") Values (";

               for (int k = 0; k < strFieldList.Count - 1; k++) strSqlCmd += "'" + strRecList[i][k].ToString() + "'" + ", ";
               strSqlCmd += "'" + strRecList[i][strFieldList.Count - 1].ToString() + "')";

               SqlCmdList.Add(strSqlCmd);
           }

           TSqlDbClass.MultiSqlTranProc(TGlobalVar.sSqlConn, SqlCmdList);
        }

        private void FileSeleBtn_Click(object sender, EventArgs e)
        {
            strXlsFileName = RetnFileNameAndPath("表单文件(*.xls/*.xlsx)|*.xls;*.xlsx");
            if (strXlsFileName != "")
            {
                string[] sfilePath  = strXlsFileName.Split('\\'); 
                txtXlsFileName.Text = sfilePath[sfilePath.Length - 1]; //截取文件名
            }
            else
            {
                MessageBox.Show("Xls文件未选择, 请检查！", "警告");
                return;
            }
        } 

        private void buttOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtXlsFileName.Text !="" && txtXlsForm.Text.Trim() != "" && cmbOpcGroupName.Text != "")
                {
                    int iStartRow = (int)neStartRow.Value, iEndRow = (int)neEndRow.Value;
                    int iStartCol = (int)neStartCol.Value, iEndCol = (int)neEndCol.Value;

                    ExcelAppClass MyExcelApp = new ExcelAppClass();
                    MyExcelApp.OpenExistFile(strXlsFileName);
                    MyExcelApp.App.Visible = false;

                    //int usedRows = MyExcelApp.GetSheet(txtXlsForm.Text).UsedRange.Rows.Count;
                    //int usedCols = MyExcelApp.GetSheet(txtXlsForm.Text).UsedRange.Columns.Count;                    

                    //******************************************检查数据表是否存在，不存在创建**************************************                   
                    string sTableName = "OpcItemTbl_" + cmbOpcGroupName.Text;

                    string[] sFieldName = { "ItemName", "PlcConn", "dBlock", "ItemType", "ItemAddr", "ItemNum", "InitVal", "Comment" };
                    string[] sDataType  = { "Varchar", "Varchar", "Varchar", "Varchar", "Varchar", "Varchar", "Varchar", "Varchar" };
                    int[]    iMaxLen    = { 24, 24, 16, 24, 48, 12, 16, 32 };
                    string[] sAllowNull = { "Not Null", "Not Null", "Not Null", "Not Null", "Not Null", "Not Null", "Not Null", "Not Null" };

                    if (TSqlDbClass.CreateTableByDateTime(TGlobalVar.sSqlConn, sTableName, sFieldName, sDataType, iMaxLen, sAllowNull) == false)
                    {
                        MessageBox.Show("数据表创建失败,请检查！", "警告");
                        return;
                    }

                    //**************************************************************************************************************
                    DateTime dtColTime = DateTime.Now;
                    List<List<string>> strRecBufPtr = new List<List<string>>();

                    if (buttKeepAdd.Checked == true)
                    {
                        System.Data.DataTable DataRecTbl = TSqlDbClass.RetnTblBySqlCmd(TGlobalVar.sSqlConn, "Select * From " + sTableName);
                        if (DataRecTbl != null && DataRecTbl.Rows.Count >= 1)
                        {
                            for (int k = 0; k < DataRecTbl.Rows.Count; k++)
                            {
                                List<string> strRecBuf = new List<string>();

                                strRecBuf.Add(dtColTime.ToString("yyyy-mm-dd hh:mm:ss:fff"));
                                for (int j = 0; j < sFieldName.Length; j++)
                                {
                                    string strFieldVal = DataRecTbl.Rows[k][sFieldName[j]].ToString();
                                    strRecBuf.Add(strFieldVal);
                                }
                                strRecBufPtr.Add(strRecBuf);

                                dtColTime = dtColTime.AddMilliseconds(1);
                            }
                        }
                    }
                    
                    //*****************************************************************************************************
                    TSqlDbClass.ExecuteNonQuerySql(TGlobalVar.sSqlConn, "Delete From " + sTableName);
                    for (int i = 0; i <= iEndRow - iStartRow; i++)
                    {
                        List<string> strRecBuf = new List<string>();
                        strRecBuf.Add(dtColTime.ToString("yyyy-mm-dd hh:mm:ss:fff"));

                        for (int j = 0; j <= iEndCol - iStartCol; j++)
                        {
                            Range TmpRng = (Range)MyExcelApp.GetSheet(txtXlsForm.Text).Cells[i + iStartRow, j + iStartCol];
                            strRecBuf.Add(Convert.ToString(TmpRng.Value2));
                        }
                        strRecBufPtr.Add(strRecBuf);

                        dtColTime = dtColTime.AddMilliseconds(1);
                    }

                    List<string> strFieldList = new List<string>();
                    strFieldList.Add("ID_DateTime");  
                    for (int k = 0; k < sFieldName.Length; k++) strFieldList.Add(sFieldName[k]);

                    InsertRecProc(sTableName, strFieldList, strRecBufPtr);

                    MyExcelApp.Close();
                }
                else
                {
                    MessageBox.Show("Opc组名或Excel表单名没填写, 请检查！", "提示");
                }
            }

            catch (Exception ex)
            {               
                throw ex;
            }
        }            
    }
}