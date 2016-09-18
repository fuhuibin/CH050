using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using System;
using System.Windows.Forms;
using System.Collections;
using System.Data;
using System.Runtime.InteropServices;
using TSqlAppClass;
using System.Reflection;

namespace MyTestBed
{
    //*****************************************************************************************
    //*****************************************************************************************
    public class TGlobalVar
    {
        public static readonly string sDataSrc  = "(Local)";
        public static readonly string sDataBase = "CH050";

        public static readonly string sSqlConn = "Data Source = " + sDataSrc + "; DataBase = " + sDataBase + ";Integrated security=true";
        public static readonly string sMasterSqlConn = "Data Source = " + sDataSrc + "; DataBase = Master; Integrated security=true";

        public const int SensorTotalNum   = 3;
        public const int SensorPlotNum    = 3; //同时显示的传感器曲线数

        public const int AlarmRecDelDays  = 7;
        public const int HisRecDelDays    = 2 * 365;
       
        public static readonly string AppPath       = Application.StartupPath + "/";         
        public static readonly string SysParIniFile = @"SysPar.Ini"; 
        public static readonly string SysParSecName = @"SysPar";
    }

    class TAlarmInfoPar  //报警信息参数
    {
        private List<string> m_AlarmItemName = new List<string>();
        public List<string> AlarmItemName
        {
            set { m_AlarmItemName = value; }
            get { return m_AlarmItemName; }
        }

        private List<string> m_AlarmType = new List<string>();
        public List<string> AlarmType
        {
            set { m_AlarmType = value; }
            get { return m_AlarmType; }
        }

        private List<string> m_AlarmInfo = new List<string>();
        public List<string> AlarmInfo
        {
            set { m_AlarmInfo = value; }
            get { return m_AlarmInfo; }
        }        
    }

    class TgVCommPar  //公共信息参数
    {       
        private string m_sSqlConn = null;
        public string sSqlConn
        {
            set { m_sSqlConn = value; }
            get { return m_sSqlConn;  }
        } 

        private int m_WorkMode = -1;         //工作模式
        public int WorkMode
        {
            set { m_WorkMode = value; }
            get { return m_WorkMode;  }
        }

        private int m_ProdID = -1;           //产品ID
        public int ProdID
        {
            set { m_ProdID = value; }
            get { return m_ProdID;  }
        }

        private int m_CylinderSleeveID = -1;           //缸盖序号（1-6）
        public int CylinderSleeveID
        {
            set { m_CylinderSleeveID = value; }
            get { return m_CylinderSleeveID; }
        }

        private int m_CylinderSleeveType = -1;           //缸盖型号（1-2:1---A；2---B）
        public int CylinderSleeveType
        {
            set { m_CylinderSleeveType = value; }
            get { return m_CylinderSleeveType; }
        }

        private bool m_WpOnline = false;
        public bool WpOnline
        {
            set { m_WpOnline = value; }
            get { return m_WpOnline;  }
        }

        //private bool m_MesEnable = false;
        //public bool MesEnable
        //{
        //    set { m_MesEnable = value; }
        //    get { return m_MesEnable;  }
        //}

        private string m_ScanBar = "";
        public string ScanBar
        {
            set { m_ScanBar = value; }
            get { return m_ScanBar;  }
        }

        private bool m_CaliTrig = false;     //标定触发
        public bool CaliTrig
        {
            set { m_CaliTrig = value; }
            get { return m_CaliTrig;  }
        }

        private bool m_SensorMeasing = false;  //传感器处于测量中标记
        public bool SensorMeasing
        {
            set { m_SensorMeasing = value; }
            get { return m_SensorMeasing;  }
        }

        private bool m_MeasTrig = false;     //测量触发
        public bool MeasTrig
        {
            set { m_MeasTrig = value; }
            get { return m_MeasTrig; }
        }

        private int m_testNum = 0;  //当前测量第几个
        public int TestNum
        {
            set { m_testNum = value; }
            get { return m_testNum; }
        }

        private float m_CaliSpan = 0;        //标定延时
        public float CaliSpan
        {
            set { m_CaliSpan = value; }
            get { return m_CaliSpan; }
        }

        private float m_MeasSpan = 0;        //测量延时
        public float MeasSpan
        {
            set { m_MeasSpan = value; }
            get { return m_MeasSpan; }
        }

        private DateTime m_InitTime = DateTime.Now;  //标定测量初始计时
        public DateTime InitTime
        {
            set { m_InitTime = value; }
            get { return m_InitTime;  }
        }

        private List<float> m_lstStdVal = new List<float>();  //轴/壳体标准高
        public List<float> lstStdVal
        {
            set { m_lstStdVal = value; }
            get { return m_lstStdVal;  }
        }

        private List<float> m_lstCaliVal = new List<float>();  //轴/壳体标定值
        public List<float> lstCaliVal
        {
            set { m_lstCaliVal = value; }
            get { return m_lstCaliVal; }
        }

        private float m_MotorMeasSpd = 0;                      //电机测量转速
        public float MotorMeasSpd
        {
            set { m_MotorMeasSpd = value; }
            get { return m_MotorMeasSpd;  }
        }

        private float m_PreMeasSpan = 0;                      //预测量时间
        public float PreMeasSpan
        {
            set { m_PreMeasSpan = value; }
            get { return m_PreMeasSpan; }
        }           
        //*****************************************************************************
        private string m_MatchMode = "过盈";
        public string MatchMode
        {
            set { m_MatchMode = value; }
            get { return m_MatchMode;  }
        }        
        
        private float m_MeasCpes = 0;                        //测量补偿
        public float MeasCpes
        {
            set { m_MeasCpes = value; }
            get { return m_MeasCpes;  }
        }

        private float m_UpLimit = 0;                      //凸出量上限
        public float UpLimit
        {
            set { m_UpLimit = value; }
            get { return m_UpLimit; }
        }

        private float m_DnLimit = 0;                      //凸出量下限
        public float DnLimit
        {
            set { m_DnLimit = value; }
            get { return m_DnLimit; }
        }

        private float m_CaliUpLimit = 0;                      //凸出量上限
        public float CaliUpLimit
        {
            set { m_CaliUpLimit = value; }
            get { return m_CaliUpLimit; }
        }

        private float m_CaliDnLimit = 0;                      //凸出量下限
        public float CaliDnLimit
        {
            set { m_CaliDnLimit = value; }
            get { return m_CaliDnLimit; }
        }

        private float m_DiffUpLimit = 0;                      //相邻凸出量差值上限
        public float DiffUpLimit
        {
            set { m_DiffUpLimit = value; }
            get { return m_DiffUpLimit; }
        }

        private float m_MeasResult = new float();        //凸出量结果
        public float MeasResult
        {
            set { m_MeasResult = value; }
            get { return m_MeasResult; }
        }

        private float[] m_Difference = new float[5];        //相邻凸出量差值结果
        public float[] Difference
        {
            set { m_Difference = value; }
            get { return m_Difference; }
        }

        private bool m_ResultGood = new bool();           //结果合格标志
        public bool ResultGood
        {
            set { m_ResultGood = value; }
            get { return m_ResultGood; }
        }
        private bool []m_CaliGood = new bool[4];           //结果合格标志
        public bool []CaliGood
        {
            set { m_CaliGood = value; }
            get { return m_CaliGood; }
        }
        private string[] m_Result = new string[4];           //结果合格标志
        public string[] Result
        {
            set { m_Result = value; }
            get { return m_Result; }
        }
        
        private float m_UpErrLimit = 0;                      //垫片配合误差上限
        public float UpErrLimit
        {
            set { m_UpErrLimit = value; }
            get { return m_UpErrLimit; }
        }

        private float m_DnErrLimit = 0;                      //垫片配合误差下限
        public float DnErrLimit
        {
            set { m_DnErrLimit = value; }
            get { return m_DnErrLimit; }
        }

        //*****************************************************************************        
        private List<int> m_lstGasketID = new List<int>();         //垫片LedID
        public List<int> lstGasketID
        {
            set { m_lstGasketID = value; }
            get { return m_lstGasketID;  }
        }

        private List<float> m_lstGasketThick = new List<float>();  //垫片厚度
        public List<float> lstGasketThick
        {
            set { m_lstGasketThick = value; }
            get { return m_lstGasketThick;  }
        }
        //**********************************************

        public static float GetBufMean(float[] DataBuf)
        {
            float TmpVal = 0;

            for (int k = 0; k < DataBuf.Length; k++)
            {
                TmpVal += DataBuf[k];
            }

            return (TmpVal / DataBuf.Length);
        }

        public static float GetBufMean(List<float> lstDataBuf)
        {
            float[] DataBuf = new float[lstDataBuf.Count];

            lstDataBuf.CopyTo(DataBuf); 

            return GetBufMean(DataBuf);
        }

        public static float GetBufMean(float[] DataBuf, float KeepRate)
        {
            if(KeepRate <= 0) KeepRate = 0.5f;
            if(KeepRate >= 1) KeepRate = 1.0f;

            int InitID    = (int)(DataBuf.Length * (1 - KeepRate) * 0.5);
            int KeepCount = (int)(DataBuf.Length * KeepRate);
            
            float TmpVal = 0;

            Array.Sort(DataBuf);
            for (int k = InitID; k < InitID + KeepCount; k++) TmpVal += DataBuf[k];
            TmpVal /= KeepCount;

            return TmpVal;
        }        
    }    

    public class TShutDown
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1)]

        internal struct TokPriv1Luid
        {
            public int Count;
            public long Luid;
            public int Attr;
        }

        [DllImport("kernel32.dll", ExactSpelling = true)]
        internal static extern IntPtr GetCurrentProcess();

        [DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
        internal static extern bool OpenProcessToken(IntPtr h, int acc, ref IntPtr phtok);

        [DllImport("advapi32.dll", SetLastError = true)]
        internal static extern bool LookupPrivilegeValue(string host, string name, ref long pluid);

        [DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
        internal static extern bool AdjustTokenPrivileges(IntPtr htok, bool disall, ref TokPriv1Luid newst, int len, IntPtr prev, IntPtr relen);

        [DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
        internal static extern bool ExitWindowsEx(int flg, int rea);

        internal const int SE_PRIVILEGE_ENABLED = 0x00000002;
        internal const int TOKEN_QUERY = 0x00000008;
        internal const int TOKEN_ADJUST_PRIVILEGES = 0x00000020;
        internal const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";
        internal const int EWX_LOGOFF = 0x00000000;
        internal const int EWX_SHUTDOWN = 0x00000001;
        internal const int EWX_REBOOT = 0x00000002;
        internal const int EWX_FORCE = 0x00000004;
        internal const int EWX_POWEROFF = 0x00000008;
        internal const int EWX_FORCEIFHUNG = 0x00000010;

        public static void DoExitWin(int flg)
        {
            bool ok;
            TokPriv1Luid tp;
            IntPtr hproc = GetCurrentProcess();
            IntPtr htok = IntPtr.Zero;
            ok = OpenProcessToken(hproc, TOKEN_ADJUST_PRIVILEGES | TOKEN_QUERY, ref htok);
            tp.Count = 1;
            tp.Luid = 0;
            tp.Attr = SE_PRIVILEGE_ENABLED;
            ok = LookupPrivilegeValue(null, SE_SHUTDOWN_NAME, ref tp.Luid);
            ok = AdjustTokenPrivileges(htok, false, ref tp, 0, IntPtr.Zero, IntPtr.Zero);
            ok = ExitWindowsEx(flg, 0);
        }


        //修改 EWX_SHUTDOWN 或者 EWX_LOGOFF, EWX_REBOOT等实现不同功能       
        //DoExitWin(EWX_SHUTDOWN);        
    }

}

public class TGlobalLog
{
    //write log into txt file.

    public static void WriteLog(string strLog)
    {
        StreamWriter streamWriter = null;
        try
        {
            lock (typeof(TGlobalLog))
            {
                string directoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
                directoryName = directoryName.Substring(6, directoryName.Length - 6);
                string str = string.Concat(directoryName, "\\log\\");
                if (!Directory.Exists(str))
                {
                    Directory.CreateDirectory(str);
                }
                string str1 = "Log.txt";
                string str2 = string.Concat(str, str1);
                streamWriter = (File.Exists(str2) ? File.AppendText(str2) : File.CreateText(str2));
                string str3 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ffff");
                if (strLog == "")
                {
                    streamWriter.WriteLine("");
                }
                else
                {
                    streamWriter.WriteLine(string.Concat(str3, " ", strLog));
                }
                streamWriter.Flush();
                streamWriter.Close();
                streamWriter.Dispose();
            }
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message, "提示");
        }
    }
}