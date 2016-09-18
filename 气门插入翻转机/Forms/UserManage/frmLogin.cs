
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
    public partial class frmLogin : Form
    {
        private bool ReLogin = false;       
        
        public frmLogin(string LoginType)
        {
            InitializeComponent();

            switch (LoginType)
            {
                case "InitLogin":
                    TUserManage.InitUserXmlDbase(); //用户表及信息初始化
                    ReLogin = false;
                    break;

                case "ReLogin":
                    ReLogin = true;
                    break;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            TUserManage.InitUserManageForm(this); //初始化用户选择
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (TUserManage.CheckLogin(this)) 
            {
                TUserManage.SetActiveUser(UserName.Text);

                this.DialogResult = DialogResult.OK;
                if (ReLogin==true) this.Close();
            }
        } 

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要取消登录吗?", "提示！", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void UserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserName.Text != "")
            {
                UserPass.Focus();
            }
            else
            {
                UserName.Focus();
            }
        }
     } 
}