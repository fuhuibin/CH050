namespace TUserManageUI
{
    partial class frmDeleUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeleUser));
            this.UserName = new System.Windows.Forms.ComboBox();
            this.SuperUserName = new System.Windows.Forms.ComboBox();
            this.SuperUserPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.FormattingEnabled = true;
            this.UserName.Location = new System.Drawing.Point(173, 64);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(126, 20);
            this.UserName.TabIndex = 58;
            // 
            // SuperUserName
            // 
            this.SuperUserName.FormattingEnabled = true;
            this.SuperUserName.Location = new System.Drawing.Point(173, 10);
            this.SuperUserName.Name = "SuperUserName";
            this.SuperUserName.Size = new System.Drawing.Size(126, 20);
            this.SuperUserName.TabIndex = 44;
            // 
            // SuperUserPass
            // 
            this.SuperUserPass.Location = new System.Drawing.Point(173, 36);
            this.SuperUserPass.Name = "SuperUserPass";
            this.SuperUserPass.PasswordChar = '*';
            this.SuperUserPass.Size = new System.Drawing.Size(126, 21);
            this.SuperUserPass.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 54;
            this.label1.Text = "管理员密码";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 52;
            this.label6.Text = "管理员";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(224, 99);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 26);
            this.Cancel.TabIndex = 50;
            this.Cancel.Text = "取  消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(108, 99);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 26);
            this.OkBtn.TabIndex = 49;
            this.OkBtn.Text = "确  定";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 46;
            this.label2.Text = "用户名";
            // 
            // frmDeleUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(316, 141);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.SuperUserName);
            this.Controls.Add(this.SuperUserPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "frmDeleUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户删除";
            this.Load += new System.EventHandler(this.frmDeleteUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox UserName;
        private System.Windows.Forms.ComboBox SuperUserName;
        private System.Windows.Forms.TextBox SuperUserPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Label label2;
    }
}