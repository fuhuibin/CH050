using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;
using System.Data.OleDb;
using System.Collections.Generic;
using NationalInstruments.UI.WindowsForms;

namespace TSqlAppClass
{ 
    public class AccessDataClass
    {
        #region 宏定义     
        public enum FstRowAsTblHeader
        {
            Yes, // 将第一行作为表头            
            No   // 不用第一行作为表头
        }
       
        public enum ExcelFileFormat
        {            
            Excel97OR2003, // Excel97/2003格式
            Excel2007      // Excel2007格式
        }
        #endregion

        private static string excelConnStr2003 = "Provider=Microsoft.Jet.OLEDB.4.0;Extended Properties=\"Excel 8.0;HDR={1};IMEX=1\";data source=\"{0}\"";
        private static string excelConnStr2007 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"{0}\";Extended Properties=\"Excel 12.0;HDR={1};IMEX=1\";";
        public static string  DbConnString     = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Application.StartupPath + "\\Database.mdb";

        public static DataTable RetnTblBySql(string strSql)
        {
            DataTable TmpTbl = null;

            OleDbConnection  Conn    = null;
            OleDbDataAdapter Adapter = null;
            OleDbCommand     Command = null;

            try
            {
                Adapter = new OleDbDataAdapter();
                Conn    = new OleDbConnection(DbConnString);
                TmpTbl  = new DataTable();

                Conn.Open();
                Command = new OleDbCommand(strSql, Conn);
                Adapter.SelectCommand = Command;
                Adapter.Fill(TmpTbl);
                Conn.Close();
            }

            catch
            {
                TmpTbl = null;
                Conn.Close();
            }

            return TmpTbl;
        }

        public static DataTable retnExcelTable(string excelFileName)
        {
            string strConn = string.Format(excelConnStr2003, excelFileName, FstRowAsTblHeader.No); //先打开2003,如果失败以2007打开
            OleDbConnection DbConn = new OleDbConnection(strConn);

            try
            {
                DbConn.Open();
            }
            catch
            {
                if (DbConn != null) DbConn.Close();
                
                strConn = string.Format(excelConnStr2007, excelFileName, FstRowAsTblHeader.No);
                DbConn = new OleDbConnection(strConn);
                try
                {                    
                    DbConn.Open();
                }

                catch (Exception e)
                {
                    if (DbConn != null) DbConn.Close();
                    
                    MessageBox.Show(e.Message);
                    return null;
                }
            }

            DataSet ds = new DataSet();
            OleDbDataAdapter oda = new OleDbDataAdapter();
            try
            {
                DataTable TmpTbl = DbConn.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, null);
                string sheetName;

                sheetName = TmpTbl.Rows[0][2].ToString().Trim();
                string strSql = "select * from [" + sheetName + "]";
                
                oda.SelectCommand = new OleDbCommand(strSql, DbConn);
                oda.Fill(ds, sheetName);
                
                DbConn.Close();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                DbConn.Close();
            }

            return ds.Tables[0];
        }
    
    }

    public class TSqlDbClass
    {
        
        public static void sqlConnOpen(SqlConnection sqlConn)
        {
            if (sqlConn.State == ConnectionState.Closed) sqlConn.Open();
        }

        public static void sqlConnClose(SqlConnection SqlConn)
        {
            if (SqlConn.State == ConnectionState.Open) SqlConn.Close();
        }

        public static bool CreateServerDb(string strSqlConn, string dbPath, string dbName)
        {
            bool bRet = true;

            if (dbPath == "" || dbName == "") return false;
            
            string dbdataName = dbName + "_Data";
            string dbDataFullName = dbPath + "\\" + dbName + ".mdf";
            string dbLogName = dbName + "_Log";
            string dbLogFullName = dbPath + "\\" + dbName + ".ldf";
                        
            string strSqlCmd = "CREATE DATABASE " + dbName + " ON PRIMARY "
                + "(NAME = " + dbdataName + ", "
                + "FILENAME = '" + dbDataFullName + "', "
                + "SIZE = 5MB, FILEGROWTH = 10%) "
                + "LOG ON (NAME = " + dbLogName + ", "
                + "FILENAME = '" + dbLogFullName + "', "
                + "SIZE = 1MB, "
                + "FILEGROWTH = 10%)";
            
            SqlConnection sqlConn = new SqlConnection(strSqlConn);
            try
            {                 
                SqlCommand sqlCmd = new SqlCommand(strSqlCmd, sqlConn);
                sqlConnOpen(sqlConn);

                sqlCmd.ExecuteNonQuery();               
            }
            catch
            { 
                bRet = false;
            }

            finally
            {
                sqlConnClose(sqlConn);                
            }

            return bRet;
        }

        public static SqlDataReader ExecuteReaderSql(string strSqlConn, string strSqlCmd) 
        {
            SqlDataReader SqlReader;            
            try
            {
                SqlConnection sqlConn = new SqlConnection(strSqlConn);
                SqlCommand sqlCmd = new SqlCommand(strSqlCmd, sqlConn);

                sqlConn.Open();
                SqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection);

                //使用 CommandBehavior.CloseConnection 关闭DataReader对象时同时关闭Connection对象
                //DataReader以独占方式连接，关闭前无法使用数据库,在调用程序中需调用SqlReader.Close();
                
                //while(SqlReader.Read())               //获取当前记录
                //{
                    //String Id=SqlReader.GetString(1); //获取记录的某一列，GetChar(int Id)   GetInt32(int Id)
                    //SqlReader.GetValue(int Id)   GetValues(Object[] Values) 
                //}

                //SqlCmd.Dispose();
                //SqlReader.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString());
                SqlReader = null;
            }

            return SqlReader;
        }

        public static bool CreateTable(bool bAutoInc, string sSqlConn, string sTableName, string[] sFieldName, string[] sDataType, int[] iMaxLen, string[] sAllowNull)
        {
            bool bRet = true;

            try
            {
                string strSql = "Select * From sysobjects Where Type = 'U' and Name = '" + sTableName + "'";
                if (IsTblExist(sSqlConn, strSql) == false)
                {
                    string sqlCreateTbl = "Create Table " + sTableName + "(";

                    if (bAutoInc == true) sqlCreateTbl += "ID INT PRIMARY KEY IDENTITY(1,1),";
                    for (int k = 0; k < sFieldName.Length; k++)
                    {
                        sqlCreateTbl += sFieldName[k] + " ";  //字段名

                        sqlCreateTbl += sDataType[k];         //数据类型
                        if (iMaxLen[k] > 0) sqlCreateTbl += "(" + iMaxLen[k].ToString() + ")";
                        sqlCreateTbl += " ";

                        if (k == 0 && bAutoInc == false) sqlCreateTbl += "Primary Key"; //规定第一个为主键
                        else                             sqlCreateTbl += sAllowNull[k]; //是否允许为空

                        if (k == sFieldName.Length - 1)
                        {
                            sqlCreateTbl += ")";
                        }
                        else
                        {
                            sqlCreateTbl += ", ";
                        }
                    }

                    TSqlDbClass.ExecuteNonQuerySql(sSqlConn, sqlCreateTbl);
                }
            }
            catch
            {
                bRet = false;
            }

            return bRet;
        }

        public static bool CreateTableNoPrimary(string sSqlConn, string sTableName, string[] sFieldName, string[] sDataType, int[] iMaxLen, string[] sAllowNull)
        {
            bool bRet = true;

            try
            {
                string strSql = "Select * From sysobjects Where Type = 'U' and Name = '" + sTableName + "'";
                if (IsTblExist(sSqlConn, strSql) == false)
                {
                    string sqlCreateTbl = "Create Table " + sTableName + "(";
                    
                    for (int k = 0; k < sFieldName.Length; k++)
                    {
                        sqlCreateTbl += sFieldName[k] + " ";  //字段名

                        sqlCreateTbl += sDataType[k];         //数据类型
                        if (iMaxLen[k] > 0) sqlCreateTbl += "(" + iMaxLen[k].ToString() + ")";
                        sqlCreateTbl += " ";

                        sqlCreateTbl += sAllowNull[k]; //是否允许为空
                        if (k == sFieldName.Length - 1)
                        {
                            sqlCreateTbl += ")";
                        }
                        else
                        {
                            sqlCreateTbl += ", ";
                        }
                    }

                    TSqlDbClass.ExecuteNonQuerySql(sSqlConn, sqlCreateTbl);
                }
            }
            catch
            {
                bRet = false;
            }

            return bRet;
        }

        public static bool CreateTableByDateTime(string sSqlConn, string sTableName, string[] sFieldName, string[] sDataType, int[] iMaxLen, string[] sAllowNull)
        {
            bool bRet = true;

            try
            {
                string strSql = "Select * From sysobjects Where Type = 'U' and Name = '" + sTableName + "'";
                if (IsTblExist(sSqlConn, strSql) == false)
                {
                    string sqlCreateTbl = "Create Table " + sTableName + "(ID_DateTime Varchar(32) Primary Key,";

                    for (int k = 0; k < sFieldName.Length; k++)
                    {
                        sqlCreateTbl += sFieldName[k] + " ";  //字段名

                        sqlCreateTbl += sDataType[k];         //数据类型
                        if (iMaxLen[k] > 0) sqlCreateTbl += "(" + iMaxLen[k].ToString() + ")";
                        sqlCreateTbl += " ";


                        sqlCreateTbl += sAllowNull[k];        //是否允许为空
                        if (k == sFieldName.Length - 1)
                        {
                            sqlCreateTbl += ")";
                        }
                        else
                        {
                            sqlCreateTbl += ", ";
                        }
                    }

                    TSqlDbClass.ExecuteNonQuerySql(sSqlConn, sqlCreateTbl);
                }
                //else   //Drop Table TblName
            }
            catch
            {
                bRet = false;
            }

            return bRet;
        }

        public static SqlDataAdapter RetnAdapterBySqlCmd(string strSqlConn, string strSqlCmd)
        {
            SqlConnection sqlConn = new SqlConnection(strSqlConn);
            
            SqlDataAdapter Adapter = new SqlDataAdapter();
            Adapter.SelectCommand = new SqlCommand(strSqlCmd, sqlConn);

            return Adapter;
        }

        public static bool DeleteTblBySqlCmd(string strSqlConn, string strSqlCmd)
        {
            SqlConnection sqlConn = new SqlConnection(strSqlConn);
            sqlConnOpen(sqlConn);
            SqlCommand sqlCmd = new SqlCommand(strSqlCmd, sqlConn);
            int Rows = sqlCmd.ExecuteNonQuery();
            sqlConnClose(sqlConn);
            return false;
        }

        public static DataTable RetnTblBySqlCmd(string strSqlConn, string strSqlCmd)
        {
            DataTable MyTable = new DataTable();
                        
            SqlDataAdapter Adapter = new SqlDataAdapter();
            Adapter.SelectCommand = new SqlCommand(strSqlCmd, new SqlConnection(strSqlConn));
            try
            {
                Adapter.Fill(MyTable);
                return MyTable;
            }
            catch { return null; }
        }

        public static bool InsertTblToDB(string strSqlConn, DataTable SrcTbl, string sDestTblName)
        {
            bool bRet = false;

            SqlTransaction trn = null;
            SqlBulkCopy sbc = null;

            SqlConnection sqlConn = new SqlConnection(strSqlConn);
            try
            {
                sqlConnOpen(sqlConn);
                trn = sqlConn.BeginTransaction();
                sbc = new SqlBulkCopy(sqlConn, SqlBulkCopyOptions.Default, trn);
                sbc.DestinationTableName = sDestTblName;
                sbc.WriteToServer(SrcTbl);
                trn.Commit();
                sqlConnClose(sqlConn);
                bRet = true;
            }
            catch
            {
                if (trn != null) trn.Rollback();
                sqlConnClose(sqlConn);
            }

            return bRet;

            //SqlDataAdapter da = new SqlDataAdapter("select * from " + sDestTblName, m_SqlConn);
            //SqlCommandBuilder cb = new SqlCommandBuilder(da);

            //DataSet ds = new DataSet();
            //da.Fill(ds, "myTest");
            //ds.Tables["myTest"].Merge(SrcTbl);
            //da.Update(ds, "myTest");
            //ds.AcceptChanges();
        }


        public static DataTable RetnTblBySqlCmd(string strSqlConn, ArrayList strSqlCmdList)
        {
            DataTable MyTable = new DataTable();

            for (int k = 0; k < strSqlCmdList.Count; k++)
            {
                SqlDataAdapter Adapter = new SqlDataAdapter();
                Adapter.SelectCommand = new SqlCommand(strSqlCmdList[k].ToString(), new SqlConnection(strSqlConn));
                Adapter.Fill(MyTable);
            }

            return MyTable;
        }

        //public DataSet UpdateDataSet(string strSelectCmdStr, string strTableName, DataSet dsDataSet)
        //{
        //    SqlDataAdapter Adapter = new SqlDataAdapter(); //DataAdapter自动打开连接，读完数据自动关闭连接
        //    Adapter.SelectCommand = new SqlCommand(strSelectCmdStr, m_SqlConn);

        //    //CmdBuilder is for update the dataset to database
        //    SqlCommandBuilder CmdBuilder = new SqlCommandBuilder(Adapter);
        //    Adapter.Update(dsDataSet, strTableName);
        //    dsDataSet.AcceptChanges();

        //    return dsDataSet;//返回更新了的数据库表   changedDs.RejectChanges() 取消更新

        //}

        //public DataTable FillSeleDataToTable(string strCmdStr)
        //{
        //    SqlCommand SqlCmd = new SqlCommand(strCmdStr, m_SqlConn);
        //    SqlDataAdapter Adapter = new SqlDataAdapter();

        //    //adAdapter.SelectCommand  adAdapter.InsertCommand  adAdapter.DeleteCommand  adAdapter.UpdateCommand
        //    Adapter.SelectCommand = new SqlCommand(strCmdStr, m_SqlConn);

        //    DataTable dsDataTable = new DataTable();
        //    Adapter.Fill(dsDataTable);   //DataAdapter自动打开连接，读完数据自动关闭连接

        //    return dsDataTable;
        //}

        public static int ExecuteNonQuerySql(string strSqlConn, string strCmdStr)
        {
            SqlConnection sqlConn = new SqlConnection(strSqlConn);
            SqlCommand SqlCmd = new SqlCommand(strCmdStr, sqlConn);

            sqlConnOpen(sqlConn);
            int nAffected = SqlCmd.ExecuteNonQuery();
            SqlCmd.Dispose();
            sqlConnClose(sqlConn);

            return nAffected;
        }

        public static float ExecuteScalarSql(string strSqlConn, string strCmdStr)
        {
            SqlConnection sqlConn = new SqlConnection(strSqlConn);
            SqlCommand SqlCmd = new SqlCommand(strCmdStr, sqlConn);

            sqlConnOpen(sqlConn);
            Object Ret = SqlCmd.ExecuteScalar();
            SqlCmd.Dispose();
            sqlConnClose(sqlConn);

            float  nAffected;

            if(Ret.Equals(DBNull.Value)) nAffected = 0;
            else                         nAffected = Convert.ToSingle(Ret);
            
            return nAffected;
        }

        /// <summary>
        /// 每次只执行一个SQL语句。
        /// </summary>
        /// <param name="tmpSQL"></param>
        /// <returns></returns>
        public static bool SingleSqlTranProc(string strSqlConn, string sqlStrCmd)
        {
            SqlConnection sqlConn = null;
            SqlTransaction SqlTran = null;
            SqlCommand sqlCmd = null;

            bool bRet = false;
            int Rows = -1;

            try
            {
                sqlConn = new SqlConnection(strSqlConn);
                sqlConnOpen(sqlConn);
                SqlTran = sqlConn.BeginTransaction();
                sqlCmd = new SqlCommand(sqlStrCmd, sqlConn, SqlTran);
                Rows = sqlCmd.ExecuteNonQuery();
                SqlTran.Commit();
                sqlConnClose(sqlConn);

                bRet = true;
            }

            catch //(Exception ee)
            {
                if (SqlTran != null) SqlTran.Rollback();
                if (sqlConn != null) sqlConnClose(sqlConn);
            }

            return bRet;
        }

        /// <summary>
        /// 每次执行多个SQL语句
        /// </summary>
        /// <param name="tmpSQL"></param>
        /// <returns></returns>
        public static bool MultiSqlTranProc(string strSqlConn, ArrayList sqlCmdList)
        {
            bool bRet = false;

            SqlConnection sqlConn = null;
            SqlTransaction sqlTran = null;
            SqlCommand sqlCmd = null;
            string sqlStrCmd = "";

            try
            {
                sqlConn = new SqlConnection(strSqlConn);
                sqlConnOpen(sqlConn);
                sqlTran = sqlConn.BeginTransaction();

                sqlStrCmd = "begin ";
                for (int k = 0; k < sqlCmdList.Count; k++)
                {
                    sqlStrCmd = sqlStrCmd + sqlCmdList[k].ToString() + ";";
                }
                sqlStrCmd = sqlStrCmd + " end";

                sqlCmd = new SqlCommand(sqlStrCmd, sqlConn, sqlTran);
                int Rows = sqlCmd.ExecuteNonQuery();
                sqlTran.Commit();
                sqlConnClose(sqlConn);

                bRet = true;
            }

            catch
            {
                if (sqlTran != null) sqlTran.Rollback();
                if (sqlConn != null) sqlConnClose(sqlConn);
            }

            return bRet;
        }

        //select * From master.dbo.sysdatabases where name='数据库名'  判断数据库是否存在
        public static bool IsDataBaseExist(string strSqlConn, string DbName)
        {
            bool bRet = false;

            using (SqlConnection sqlConn = new SqlConnection(strSqlConn))
            {
                sqlConnOpen(sqlConn);
                SqlCommand myCmd = new SqlCommand("Select 1 From Master..sysDataBases where name='" + DbName + "'", sqlConn);

                object n = myCmd.ExecuteScalar();
                if (n != null) bRet = true;
                sqlConnClose(sqlConn);                
            }

            return bRet;
            
            //int n = myCmd.ExecuteNonQuery();
            //ExecuteNonQuery 只对update，insert delete 有效            
        }

        public static bool IsTblExist(string strSqlConn, string strSql) 
        {
            bool bRet = true;

            SqlConnection sqlConn = new SqlConnection(strSqlConn);            
            SqlDataAdapter SqlDa = new SqlDataAdapter(strSql, sqlConn);

            DataTable myTbl = new DataTable();
            SqlDa.Fill(myTbl);
            if(myTbl.Rows.Count == 0) bRet = false;

            return bRet;
        }

        public static void PrepareCommand(string strSqlConn, SqlCommand cmd, SqlTransaction trans, CommandType cmdType, string cmdText, SqlParameter[] cmdParms)
        {
            SqlConnection sqlConn = new SqlConnection(strSqlConn);

            sqlConnOpen(sqlConn);
            cmd.Connection = sqlConn;
            cmd.CommandText = cmdText;

            if (trans != null) cmd.Transaction = trans;

            cmd.CommandType = cmdType;
            if (cmdParms != null)
            {
                foreach (SqlParameter parm in cmdParms) cmd.Parameters.Add(parm);
            }
        }


        public static List<string> GetColFieldName(string strSqlConn, string TableName)
        {
            List<string> ColNamelist = new List<string>();

            SqlConnection sqlConn = new SqlConnection(strSqlConn);
            try
            {
                sqlConnOpen(sqlConn);

                SqlCommand sqlCmd = new SqlCommand("Select Name From SysColumns Where id = Object_Id('" + TableName + "')", sqlConn);
                SqlDataReader objReader = sqlCmd.ExecuteReader();

                while (objReader.Read())
                {
                    ColNamelist.Add(objReader[0].ToString());
                }
            }

            catch
            {

            }
            sqlConnClose(sqlConn);

            return ColNamelist;
        }

    }
}