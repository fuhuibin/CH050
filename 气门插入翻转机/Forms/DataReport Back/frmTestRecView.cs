using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TSqlAppClass;
using System.IO;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

namespace MyTestBed
{
    public partial class frmTestRecView : Form
    {
        private bool InitFlag = false;   

        public frmTestRecView()
        {
            InitializeComponent();
        }

        private void frmTestRecView_Load(object sender, EventArgs e)
        {
            DelOutDateRec();
            DgViewInit(TestRecDgView);
            ProdNameCmoBox.Enabled = false;

            DataTable ProdNameTbl = TSqlDbClass.RetnTblBySqlCmd(TGlobalVar.sSqlConn, "Select * From ProdNameTbl");
            if (ProdNameTbl != null && ProdNameTbl.Rows.Count >= 1) //产品表存在
            {
                for (int k = 0; k < ProdNameTbl.Rows.Count; k++)
                {
                    string prodName = ProdNameTbl.Rows[k]["ProdName"].ToString();          
                    ProdNameCmoBox.Items.Add(prodName);                   
                }

                if (ProdNameCmoBox.Items.Count >= 1)
                {
                    ProdNameCmoBox.Enabled = true;
                    ProdNameCmoBox.SelectedIndex = 0;
                }
            }
        }

        private void DgViewInit(DataGridView DgV)
        {
            DgV.RowHeadersWidth     = 4;
            DgV.SelectionMode       = DataGridViewSelectionMode.FullRowSelect;
            DgV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgV.AllowUserToAddRows  = false;
            DgV.AllowUserToResizeRows = false;
        }


        private void frmTestRecView_Activated(object sender, EventArgs e)
        {
            if (InitFlag == false)
            {
                InitFlag = true;

                StartDtPicker.Value = DateTime.Now.AddDays(-7);
                EndDtPicker.Value   = DateTime.Now;                
            }
        }

        private void DelOutDateRec()
        {
            string StartDt = DateTime.Now.AddDays(1 - TGlobalVar.AlarmRecDelDays).ToShortDateString() + " 00:00:00";

            string SqlCmdStr = "Delete From TestRecTbl Where Convert(DateTime,测量时间) < '" +  Convert.ToDateTime(StartDt) + "'";
            TSqlDbClass.ExecuteNonQuerySql(TGlobalVar.sSqlConn, SqlCmdStr);
        }

        private void QueryBtn_Click(object sender, EventArgs e)
        {
            string StartDt = StartDtPicker.Value.ToShortDateString() + " 00:00:00"; ;
            string EndDt = EndDtPicker.Value.ToShortDateString() + " 23:59:59"; ;

            if (Convert.ToDateTime(StartDt) <= Convert.ToDateTime(EndDt))
            {               
                string   SqlCmd  = null;

                SqlCmd = string.Format("Select * From TestRecTbl Where Convert(DateTime,测量时间) Between '{0}' And '{1}' Order By Convert(DateTime,测量时间) Desc", Convert.ToDateTime(StartDt), Convert.ToDateTime(EndDt));
                if (ProdNameChk.Checked == true && ProdNameCmoBox.Text != "")
                {
                    SqlCmd = string.Format("Select * From TestRecTbl Where 产品型号 = '{0}', Convert(DateTime,测量时间) Between '{1}' And '{2}' Order By Convert(DateTime,测量时间) Desc", ProdNameCmoBox.Text, Convert.ToDateTime(StartDt), Convert.ToDateTime(EndDt)); 
                }
                
                DataTable TmpTbl = TSqlDbClass.RetnTblBySqlCmd(TGlobalVar.sSqlConn, SqlCmd);
                TestRecDgView.DataSource = TmpTbl;                
            }
            else
            {
                MessageBox.Show("起始时间不允许大于终止时间, 请调整!");
            }        
        }

        private string RetnFileName(string Filter, string FileName)
        {
            string sFileNamePath = "";

            SaveFileDialog SaveDialog = new SaveFileDialog(); 
            SaveDialog.Filter   = Filter;
            SaveDialog.FileName = FileName;

            if (SaveDialog.ShowDialog() == DialogResult.OK) sFileNamePath = SaveDialog.FileName;            

            return sFileNamePath;
        }

        private void ExcelOutBtn_Click(object sender, EventArgs e)
        {
            if (TestRecDgView.RowCount >= 1) //限制输出数量
            {
                if (TestRecDgView.RowCount <= 400)
                {
                    string Filter = "Excel表单文件(*.xls)|所有文件(*.*)";
                    string strFileName = "试验记录_" + DateTime.Today.Year.ToString() + DateTime.Today.Month.ToString() + DateTime.Today.Day.ToString();

                    string strFilePathName = RetnFileName(Filter, strFileName);
                    if (strFilePathName != "")
                    {
                        if (strFilePathName.IndexOf(".") != -1) //包含.
                        {
                            strFilePathName = strFilePathName.Substring(0, strFilePathName.IndexOf(".") + 1) + ".xls";
                        }
                        else
                        {
                            strFilePathName = strFilePathName + ".xls";
                        }

                        if (File.Exists(strFilePathName) == true)
                        {
                            MessageBox.Show("同名文件已存在，请改名!", "警告");
                        }
                        else
                        {
                            ParTranHintGrpBox.Visible = true;
                            if (OutTestRecFile(strFilePathName) == false)
                            {
                                MessageBox.Show("试验记录文件保存不成功,请检查！", "警告");
                            }
                            ParTranHintGrpBox.Visible = false;
                        }
                    }                    
                }
                else
                {
                    MessageBox.Show("试验记录数太多，请缩短时间范围！", "警告");
                }
            }
            else
            {
                MessageBox.Show("没有试验记录可供输出！", "警告");
            }
        } 

        private bool OutTestRecFile(string strFilePathName)
        {
            bool bRet = true;

            string srcFileName  = Application.StartupPath + "\\试验记录模板.xls";          
            try
            {
                if (!File.Exists(srcFileName)) //模板是否存在
                {
                    MessageBox.Show("试验记录模板不存在，请检查！", "警告");
                    return false;
                }

                string[,] RecInfoCell = new string[TestRecDgView.RowCount, TestRecDgView.ColumnCount];
                for (int i = 0; i < TestRecDgView.RowCount; i++)
                {
                    for (int j = 0; j < TestRecDgView.ColumnCount; j++)
                    {
                        RecInfoCell[i, j] = TestRecDgView.Rows[i].Cells[j].Value.ToString();
                    }
                }

                HSSFWorkbook workbook = null;
                using (FileStream stream = new FileStream(srcFileName, FileMode.Open, FileAccess.Read))
                {
                    workbook = new HSSFWorkbook(stream);
                    stream.Close();
                }

                int InitRow = 4, InitCol = 0;

                HSSFSheet hSheet0 = (HSSFSheet)workbook.GetSheet(workbook.GetSheetName(0));
                for (int i = 0; i < TestRecDgView.RowCount; i++)
                {
                    IRow row = (IRow)hSheet0.GetRow(i + InitRow);
                    if (row != null)
                    {
                        for (int j = 0; j < TestRecDgView.ColumnCount; j++)
                        {
                            row.CreateCell(j + InitCol, CellType.STRING).SetCellValue(RecInfoCell[i, j]);
                        }
                    }
                }
                
                FileStream file = new FileStream(strFilePathName, FileMode.Create);
                workbook.Write(file);
                file.Close();
            }

            catch (Exception e)
            {
                MessageBox.Show("Excel文件保存出错：" + e.Message);
                bRet = false;
            }

            return bRet;
        }

        

    }
}