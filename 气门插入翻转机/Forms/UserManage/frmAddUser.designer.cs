namespace TUserManageUI
{
    partial class frmAddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUser));
            this.SuperUserName = new System.Windows.Forms.ComboBox();
            this.SuperUserPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.NewUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NewUserLevel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NewUserPass = new System.Windows.Forms.TextBox();
            this.TryNewUserPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SuperUserName
            // 
            this.SuperUserName.FormattingEnabled = true;
            this.SuperUserName.Location = new System.Drawing.Point(12, 24);
            this.SuperUserName.Name = "SuperUserName";
            this.SuperUserName.Size = new System.Drawing.Size(126, 20);
            this.SuperUserName.TabIndex = 28;
            this.SuperUserName.SelectedIndexChanged += new System.EventHandler(this.SuperUserName_SelectedIndexChanged);
            // 
            // SuperUserPass
            // 
            this.SuperUserPass.Location = new System.Drawing.Point(12, 74);
            this.SuperUserPass.Name = "SuperUserPass";
            this.SuperUserPass.PasswordChar = '*';
            this.SuperUserPass.Size = new System.Drawing.Size(126, 21);
            this.SuperUserPass.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 38;
            this.label1.Text = "管理员密码";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 36;
            this.label6.Text = "管理员";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(63, 155);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 26);
            this.CancelBtn.TabIndex = 34;
            this.CancelBtn.Text = "取  消";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(63, 113);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 26);
            this.OkBtn.TabIndex = 33;
            this.OkBtn.Text = "确  定";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // NewUserName
            // 
            this.NewUserName.Location = new System.Drawing.Point(179, 24);
            this.NewUserName.Name = "NewUserName";
            this.NewUserName.Size = new System.Drawing.Size(126, 21);
            this.NewUserName.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 45;
            this.label2.Text = "新用户名";
            // 
            // NewUserLevel
            // 
            this.NewUserLevel.FormattingEnabled = true;
            this.NewUserLevel.Location = new System.Drawing.Point(179, 68);
            this.NewUserLevel.Name = "NewUserLevel";
            this.NewUserLevel.Size = new System.Drawing.Size(126, 20);
            this.NewUserLevel.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 47;
            this.label3.Text = "新用户密码";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 50;
            this.label5.Text = "用户组";
            // 
            // NewUserPass
            // 
            this.NewUserPass.Location = new System.Drawing.Point(179, 112);
            this.NewUserPass.Name = "NewUserPass";
            this.NewUserPass.PasswordChar = '*';
            this.NewUserPass.Size = new System.Drawing.Size(126, 21);
            this.NewUserPass.TabIndex = 46;
            // 
            // TryNewUserPass
            // 
            this.TryNewUserPass.Location = new System.Drawing.Point(179, 156);
            this.TryNewUserPass.Name = "TryNewUserPass";
            this.TryNewUserPass.PasswordChar = '*';
            this.TryNewUserPass.Size = new System.Drawing.Size(126, 21);
            this.TryNewUserPass.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 49;
            this.label4.Text = "密码确认";
            // 
            // frmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(324, 197);
            this.Controls.Add(this.NewUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewUserLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NewUserPass);
            this.Controls.Add(this.TryNewUserPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SuperUserPass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SuperUserName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.MaximizeBox = false;
            this.Name = "frmAddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户添加";
            this.Load += new System.EventHandler(this.frmAddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SuperUserName;
        private System.Windows.Forms.TextBox SuperUserPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.TextBox NewUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox NewUserLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NewUserPass;
        private System.Windows.Forms.TextBox TryNewUserPass;
        private System.Windows.Forms.Label label4;
    }
}