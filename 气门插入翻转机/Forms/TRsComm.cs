using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System.Threading;

namespace TRsCom
{
    public class TDispSensorCom
    {
        private int m_ChanNum = 0;

        private bool m_bRecvOk = true;
        public bool bRecvOk
        {
            set { m_bRecvOk = value; }
            get { return m_bRecvOk;  }
        }

        private List<bool> m_bChanTrig = null;　
        public List<bool> bChanTrig
        {
            set { m_bChanTrig = value; }
            get { return m_bChanTrig;  }
        }       

        //单值数据
        private List<float> m_ChanCurrVal = null;
        public List<float> ChanCurrVal
        {
            get { return m_ChanCurrVal; }
        }

        //数据缓冲
        private List<List<float>> m_ChanBufList = null;
        public List<List<float>> ChanBufList
        {
            get { return m_ChanBufList; }
        }

        public void ChanBufClr()
        {
            for (int k = 0; k < m_ChanNum; k++)
            {
                m_bChanTrig[k] = false;
                m_ChanBufList[k].Clear();
            }
        }

        public void ChanBufTrig(int Chan, bool bTrig)
        {
            m_bChanTrig[Chan] = bTrig;
            if(bTrig == true) m_ChanBufList[Chan].Clear();           
        }

        public void ChanBufTrig(int[] arrChan, bool bTrig)
        {
            for (int k = 0; k < arrChan.Length; k++)
            {                
                m_bChanTrig[arrChan[k]] = bTrig;
                if (bTrig == true) m_ChanBufList[arrChan[k]].Clear();
            } 
        }

        public float GetChanMean(int Chan, float KeepRate)
        {
            float TmpVal = 0;
            int   KeepLen = 0, InitLen = 0;

            if(KeepRate > 1.0f) KeepRate = 1.0f;
            if(KeepRate < 0)    KeepRate = 0.2f;
            
            InitLen = (int)(ChanBufList[Chan].Count * 0.5f * (1-KeepRate));
            KeepLen = (int)(ChanBufList[Chan].Count * KeepRate);

            for (int k = InitLen; k < KeepLen +InitLen; k++)
            {
                TmpVal += ChanBufList[Chan][k];
            }

            return (TmpVal / KeepLen);
        }

        public float GetChanMean(int Chan)
        {
            float TmpVal = 0;

            for (int k = 0; k < ChanBufList[Chan].Count; k++)
            {
                TmpVal += ChanBufList[Chan][k];
            }

            return (TmpVal / ChanBufList[Chan].Count);
        }
       

        private SerialPort RsPort = null;
        public TDispSensorCom(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits, bool DtrEnable, bool RtsEnable)
        {
            RsPort = new SerialPort(portName, baudRate, parity, dataBits, stopBits);

            RsPort.NewLine = "\r";
            RsPort.ReceivedBytesThreshold = 1;
            RsPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(RsPort_DataReceived);
            RsPort.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(RsPort_ErrReceived);
            RsPort.DtrEnable = DtrEnable;
            RsPort.RtsEnable = RtsEnable;

            RsPort.ReadBufferSize = 1024;
            RsPort.WriteBufferSize = 1024;
        }

        private void RsPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                string RecvStr = RsPort.ReadLine();

                if (RecvStr != null)
                {
                    TGlobalLog.WriteLog("  " + RecvStr);
                    for (int k = 0; k < m_ChanNum; k++)
                    {
                        m_ChanCurrVal[k] = 0.0F;

                        string TmpStr = RecvStr.Substring(k * 10 + 3, 8);//提取有效的8个字节数据
                        if (TmpStr != @"+EEE.EEE")
                        {
                            m_ChanCurrVal[k] = float.Parse(TmpStr);
                            if (m_bChanTrig[k] == true) ChanBufList[k].Add(m_ChanCurrVal[k]);
                        }
                    }

                    m_bRecvOk = true;
                    RequestSend();
                }
            }

            catch
            {
                PortOpen();
                RequestSend();
            }
        }

        private void RsPort_ErrReceived(object sender, System.IO.Ports.SerialErrorReceivedEventArgs e)
        {
            PortOpen();
            RequestSend();
        }

        public void RequestSend()
        {
            byte[] TmpBytes = new byte[4];

            TmpBytes[0] = Convert.ToByte('M');
            TmpBytes[1] = Convert.ToByte('0');
            TmpBytes[2] = 0x0D;
            TmpBytes[3] = 0x0A;

            if (RsPort.IsOpen)
            {
                RsPort.DiscardInBuffer();
                RsPort.DiscardOutBuffer();

                RsPort.Write(TmpBytes, 0, 4);
            }
        }

        public void RecvInit(int chanNum)
        {
            m_ChanNum = chanNum;

            m_bChanTrig = new List<bool>(m_ChanNum);
            for (int k = 0; k < m_ChanNum; k++) m_bChanTrig.Add(false);

            m_ChanCurrVal = new List<float>(m_ChanNum);
            for (int k = 0; k < m_ChanNum; k++) m_ChanCurrVal.Add(0);

            m_ChanBufList = new List<List<float>>(chanNum);
            for (int k = 0; k < chanNum; k++)
            {
                m_ChanBufList.Add(null); m_ChanBufList[k] = new List<float>();
            }

            PortOpen();            
            RequestSend();
        }        

        public void PortOpen()
        {
            try
            {
                if (RsPort.IsOpen) RsPort.Close();
                RsPort.Open();
            }
            catch
            {
            }
        }

        public void PortClose()
        {
            if (RsPort.IsOpen) RsPort.Close();
        }

        public bool CheckPortIsOpen()
        {
            if (RsPort.IsOpen) return true;
            return false;
        }
    }

}