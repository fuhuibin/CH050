
/**
 * 开 发 者: 陈存平
 * 开发时间: 2011/10/10
 * 模块名称: frmDeleteUser
 * 模块说明: 删除用户窗体
 * 备    注: 
 */

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
    public partial class frmDeleUser : Form
    {
        public frmDeleUser()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            TUserManage.DeleUser(this);
        }

        private void frmDeleteUser_Load(object sender, EventArgs e)
        {
            TUserManage.InitUserManageForm(this);
        }
    }
}
