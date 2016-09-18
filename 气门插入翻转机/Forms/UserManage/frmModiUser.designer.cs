namespace TUserManageUI
{
    partial class frmModiUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModiUser));
            this.TryNewUserPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OldUserName = new System.Windows.Forms.ComboBox();
            this.OldUserPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.NewUserPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NewUserName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TryNewUserPass
            // 
            this.TryNewUserPass.Location = new System.Drawing.Point(263, 87);
            this.TryNewUserPass.Name = "TryNewUserPass";
            this.TryNewUserPass.PasswordChar = '*';
            this.TryNewUserPass.Size = new System.Drawing.Size(126, 21);
            this.TryNewUserPass.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 56;
            this.label4.Text = "密码确认";
            // 
            // OldUserName
            // 
            this.OldUserName.FormattingEnabled = true;
            this.OldUserName.Location = new System.Drawing.Point(36, 43);
            this.OldUserName.Name = "OldUserName";
            this.OldUserName.Size = new System.Drawing.Size(126, 20);
            this.OldUserName.TabIndex = 44;
            // 
            // OldUserPass
            // 
            this.OldUserPass.Location = new System.Drawing.Point(36, 90);
            this.OldUserPass.Name = "OldUserPass";
            this.OldUserPass.PasswordChar = '*';
            this.OldUserPass.Size = new System.Drawing.Size(126, 21);
            this.OldUserPass.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 54;
            this.label1.Text = "原密码";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 52;
            this.label6.Text = "原用户名";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(304, 156);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 26);
            this.CancelBtn.TabIndex = 50;
            this.CancelBtn.Text = "取  消";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(206, 156);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 26);
            this.OkBtn.TabIndex = 49;
            this.OkBtn.Text = "确  定";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // NewUserPass
            // 
            this.NewUserPass.Location = new System.Drawing.Point(263, 56);
            this.NewUserPass.Name = "NewUserPass";
            this.NewUserPass.PasswordChar = '*';
            this.NewUserPass.Size = new System.Drawing.Size(126, 21);
            this.NewUserPass.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 48;
            this.label3.Text = "新用户密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 46;
            this.label2.Text = "新用户名";
            // 
            // NewUserName
            // 
            this.NewUserName.Location = new System.Drawing.Point(263, 25);
            this.NewUserName.Name = "NewUserName";
            this.NewUserName.Size = new System.Drawing.Size(126, 21);
            this.NewUserName.TabIndex = 45;
            // 
            // frmModiUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(422, 199);
            this.Controls.Add(this.TryNewUserPass);
            this.Controls.Add(this.OldUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OldUserPass);
            this.Controls.Add(this.NewUserPass);
            this.Controls.Add(this.NewUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.MaximizeBox = false;
            this.Name = "frmModiUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户修改";
            this.Load += new System.EventHandler(this.frmModifyUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TryNewUserPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox OldUserName;
        private System.Windows.Forms.TextBox OldUserPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.TextBox NewUserPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NewUserName;
    }
}