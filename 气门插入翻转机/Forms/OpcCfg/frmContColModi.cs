using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.InteropServices;
using NationalInstruments.UI;

namespace MyTestBed
{
    public partial class frmContColModi : Form
    {
        private List<string> m_lFieldCap = null;
        private int      m_rowCount  = 0;

        public int    startRow = 0;
        public int    endRow   = 0;
        public string fieldCap = null;
        public string colVal   = null;

        public frmContColModi(List<string> lFieldCap, int rowCount)
        {
            InitializeComponent();

            m_lFieldCap = lFieldCap;
            m_rowCount  = rowCount;
        }        

        private void frmContColModi_Load(object sender, EventArgs e) 
        {
            fieldCapCmbBox.Items.Clear();
            for (int k = 0; k < m_lFieldCap.Count ; k++) fieldCapCmbBox.Items.Add(m_lFieldCap[k]);
            fieldCapCmbBox.SelectedIndex = 0;

            startRowNumedt.Value = 1;
            startRowNumedt.Range = new Range(1, m_rowCount)
                ;
            endRowNumedt.Value = m_rowCount;
            endRowNumedt.Range = new Range(1, m_rowCount);

            colValTxtBox.Text = "";       
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (colValTxtBox.Text.Trim().Length > 0)
            {
                startRow = (int)startRowNumedt.Value;
                endRow   = (int)endRowNumedt.Value;
                fieldCap = fieldCapCmbBox.Text;
                colVal   = colValTxtBox.Text.Trim();
                
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("请填写列值", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
        
    }
}
