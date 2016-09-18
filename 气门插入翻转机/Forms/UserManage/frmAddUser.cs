
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using UserManageLib;

namespace TUserManageUI
{
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            TUserManage.AddUser(this);            
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            TUserManage.InitUserManageForm(this);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SuperUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SuperUserPass.Text == "")
            {
                SuperUserPass.Focus();
            }
        }
    }
}
