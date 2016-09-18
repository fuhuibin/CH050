using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UserManageLib;

namespace TUserManageUI
{
    public partial class frmModiUser : Form
    {
        public frmModiUser()
        {
            InitializeComponent();

            TUserManage.InitUserXmlDbase();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmModifyUser_Load(object sender, EventArgs e)
        {
            TUserManage.InitUserManageForm(this);
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            TUserManage.UpdateUser(this);
        }

    }
}
