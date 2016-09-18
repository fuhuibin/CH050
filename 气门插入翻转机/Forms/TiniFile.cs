using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections.Specialized;
using System.Runtime.InteropServices;

namespace TIniFile
{
    class TIniFilePtr
    {
        public string m_IniFile;
               
        [DllImport("kernel32")]
        private static extern bool WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, byte[] retVal, int size, string filePath);

        //string ConfigPath = Application.StartupPath;       
        //ConfigPath = ConfigPath.Substring(0, ConfigPath.LastIndexOf("\\"));
        //ConfigPath = ConfigPath.Substring(0, ConfigPath.LastIndexOf("\\"));

        public static TIniFilePtr GetTIniFile(string IniFileName)
        {
            string IniFilePath = Application.StartupPath;
            //IniFilePath = IniFilePath.Substring(0, IniFilePath.LastIndexOf("\\")) + "\\"+IniFileName;
            IniFilePath = IniFilePath+ "\\" + IniFileName;

            return new TIniFilePtr(IniFilePath);
        }
        
        public TIniFilePtr(string IniFile)
        {
            m_IniFile = IniFile;
        }

        //********************************************************************************************************************
        //********************************************************************************************************************
        public bool IniWriteString(string Section, string Key, string Val)
        {
            bool bret = WritePrivateProfileString(Section, Key, Val, m_IniFile); //Success--->nonzero.
            
            return bret;
        }

        public string IniReadString(string Section, string Key, string Default)
        {
            Byte[] TmpBuf = new Byte[1024];
            int Len = GetPrivateProfileString(Section, Key, Default, TmpBuf, TmpBuf.GetUpperBound(0), m_IniFile);
            
            //必须设定0（系统默认的代码页）的编码方式，否则无法支持中文
            string TmpStr = Encoding.GetEncoding(0).GetString(TmpBuf);
            TmpStr = TmpStr.Substring(0, Len);            

            return TmpStr.TrimEnd('\0');
        }

        //********************************************************************************************************************
        //********************************************************************************************************************        
        public bool IniWriteFloat(string Section, string Key, float Val)
        {
            bool bret = IniWriteString(Section, Key, Val.ToString());

            return bret;
        }

        public float IniReadFloat(string Section, string Key, float Default)
        {
            string TmpStr = IniReadString(Section, Key, Default.ToString());

            try
            {
                return Convert.ToSingle(TmpStr);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return Default;
            }
        }//txtCkMeasVal

        //********************************************************************************************************************
        //********************************************************************************************************************        
        public bool IniWriteDouble(string Section, string Key, double Val)
        {
            bool bret = WritePrivateProfileString(Section, Key, Val.ToString(), m_IniFile);

            return bret;
        }
        
        public double IniReadDouble(string Section, string Key, double Default)
        {
            string TmpStr = IniReadString(Section, Key, Default.ToString());

            try
            {
                return Convert.ToDouble(TmpStr);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return Default;
            }    
        }

        //********************************************************************************************************************
        //********************************************************************************************************************
        public bool IniWriteInt(string Section, string Key, int Val)
        {
            bool bret = IniWriteString(Section, Key, Val.ToString());

            return bret;
        }

        //********************************************************************************************************************
        //********************************************************************************************************************
        public bool IniWriteInt(string Section, string Key, uint Val)
        {
            bool bret = IniWriteString(Section, Key, Val.ToString());

            return bret;
        }


        public int IniReadInt(string Section, string Key, int Default)
        {
            string TmpStr = IniReadString(Section, Key, Default.ToString());
            
            try
            {
                return Convert.ToInt32(TmpStr);  
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return Default;
            }   
        }
        //********************************************************************************************************************
        //********************************************************************************************************************
        public bool IniWriteBool(string Section, string Key, bool Val)
        {
            bool bret = IniWriteString(Section, Key, Val.ToString());

            return bret;
        }

        public bool IniReadBool(string Section, string Key, bool Default)
        {
            string TmpStr = IniReadString(Section, Key, Default.ToString());

            try
            {
                return Convert.ToBoolean(TmpStr);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return Default;
            }
        }

        //********************************************************************************************************************
        //********************************************************************************************************************

        //删除指定Section 
        public bool IniEraseSection(string Section)
        {
            bool bret = WritePrivateProfileString(Section, null, null, m_IniFile);

            return bret;
        }

        //删除指定Section下的键 
        public bool IniDeleteKey(string Section, string Key)
        {
            bool bret = WritePrivateProfileString(Section, Key, null, m_IniFile);

            return bret;
        }
        //********************************************************************************************************************
        //********************************************************************************************************************

        //检查Section下的键值是否存在
        public bool IniKeyExist(string Section, string Key)
        {
            StringCollection KeyList = new StringCollection();
            ReadKeyList(Section, KeyList);

            return KeyList.IndexOf(Key) > -1;
        }

        //读取Section下的所有Key
        private void ReadKeyList(string Section, StringCollection KeyList)
        {
            Byte[] TmpBuf = new Byte[4096];

            int Len = GetPrivateProfileString(Section, null, null, TmpBuf, TmpBuf.GetUpperBound(0), m_IniFile);
            SplitBufToStrList(TmpBuf, Len, KeyList);
        }

        private void SplitBufToStrList(Byte[] Buffer, int bufLen, StringCollection StrList)
        {
            StrList.Clear();

            if (bufLen != 0)
            {
                int start = 0;
                for (int i = 0; i < bufLen; i++)
                {
                    if ((Buffer[i] == 0) && ((i - start) > 0))
                    {
                        String TmpStr = Encoding.GetEncoding(0).GetString(Buffer, start, i - start);
                        StrList.Add(TmpStr);
                        start = i + 1;
                    }
                }
            }
        }

        //读取指定Section 的所有Key及Value列表 
        public void IniReadKeyValList(string Section, NameValueCollection KeyValList)
        {
            StringCollection KeyList = new StringCollection();

            ReadKeyList(Section, KeyList); 
            KeyValList.Clear();

            foreach (string key in KeyList)
            {
                KeyValList.Add(key, IniReadString(Section, key, ""));
            }
        }

        //读取所有Sections名称
        public void IniReadSectionList(StringCollection SectionList)
        {
            //必须得用Bytes来实现，StringBuilder只能取到第一个Section
            byte[] TmpStr = new byte[4096];
            int    bufLen = 0;

            bufLen = GetPrivateProfileString(null, null, null, TmpStr, TmpStr.GetUpperBound(0), m_IniFile);
            SplitBufToStrList(TmpStr, bufLen, SectionList);
        }
        
    }

}
