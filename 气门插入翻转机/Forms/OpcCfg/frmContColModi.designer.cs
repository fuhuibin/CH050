namespace MyTestBed
{
    partial class frmContColModi
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
            this.OkBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemLbl_0 = new System.Windows.Forms.Label();
            this.fieldCapCmbBox = new System.Windows.Forms.ComboBox();
            this.startRowNumedt = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.endRowNumedt = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.ItemLbl_2 = new System.Windows.Forms.Label();
            this.ItemLbl_1 = new System.Windows.Forms.Label();
            this.colValTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.startRowNumedt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endRowNumedt)).BeginInit();
            this.SuspendLayout();
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(59, 224);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(65, 29);
            this.OkBtn.TabIndex = 5;
            this.OkBtn.Text = "确认";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(150, 224);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(65, 29);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "取消";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "连续行_列内容修改";
            // 
            // ItemLbl_0
            // 
            this.ItemLbl_0.AutoSize = true;
            this.ItemLbl_0.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemLbl_0.Location = new System.Drawing.Point(41, 59);
            this.ItemLbl_0.Name = "ItemLbl_0";
            this.ItemLbl_0.Size = new System.Drawing.Size(45, 20);
            this.ItemLbl_0.TabIndex = 142;
            this.ItemLbl_0.Text = "列  名";
            // 
            // fieldCapCmbBox
            // 
            this.fieldCapCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fieldCapCmbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldCapCmbBox.FormattingEnabled = true;
            this.fieldCapCmbBox.Items.AddRange(new object[] {
            "R",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.fieldCapCmbBox.Location = new System.Drawing.Point(98, 51);
            this.fieldCapCmbBox.Name = "fieldCapCmbBox";
            this.fieldCapCmbBox.Size = new System.Drawing.Size(104, 28);
            this.fieldCapCmbBox.TabIndex = 141;
            // 
            // startRowNumedt
            // 
            this.startRowNumedt.CoercionInterval = 0.5;
            this.startRowNumedt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startRowNumedt.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.startRowNumedt.Location = new System.Drawing.Point(98, 89);
            this.startRowNumedt.Name = "startRowNumedt";
            this.startRowNumedt.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.startRowNumedt.Range = new NationalInstruments.UI.Range(0, double.PositiveInfinity);
            this.startRowNumedt.Size = new System.Drawing.Size(104, 29);
            this.startRowNumedt.TabIndex = 156;
            this.startRowNumedt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startRowNumedt.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // endRowNumedt
            // 
            this.endRowNumedt.CoercionInterval = 0.5;
            this.endRowNumedt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.endRowNumedt.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.endRowNumedt.Location = new System.Drawing.Point(98, 129);
            this.endRowNumedt.Name = "endRowNumedt";
            this.endRowNumedt.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.endRowNumedt.Range = new NationalInstruments.UI.Range(0, double.PositiveInfinity);
            this.endRowNumedt.Size = new System.Drawing.Size(104, 29);
            this.endRowNumedt.TabIndex = 155;
            this.endRowNumedt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.endRowNumedt.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // ItemLbl_2
            // 
            this.ItemLbl_2.AutoSize = true;
            this.ItemLbl_2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemLbl_2.Location = new System.Drawing.Point(42, 136);
            this.ItemLbl_2.Name = "ItemLbl_2";
            this.ItemLbl_2.Size = new System.Drawing.Size(51, 20);
            this.ItemLbl_2.TabIndex = 154;
            this.ItemLbl_2.Text = "结束行";
            // 
            // ItemLbl_1
            // 
            this.ItemLbl_1.AutoSize = true;
            this.ItemLbl_1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ItemLbl_1.Location = new System.Drawing.Point(41, 97);
            this.ItemLbl_1.Name = "ItemLbl_1";
            this.ItemLbl_1.Size = new System.Drawing.Size(51, 20);
            this.ItemLbl_1.TabIndex = 153;
            this.ItemLbl_1.Text = "起始行";
            // 
            // colValTxtBox
            // 
            this.colValTxtBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colValTxtBox.Location = new System.Drawing.Point(98, 170);
            this.colValTxtBox.Name = "colValTxtBox";
            this.colValTxtBox.Size = new System.Drawing.Size(104, 29);
            this.colValTxtBox.TabIndex = 158;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(44, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 157;
            this.label7.Text = "列  值";
            // 
            // frmContColModi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 261);
            this.ControlBox = false;
            this.Controls.Add(this.colValTxtBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.startRowNumedt);
            this.Controls.Add(this.endRowNumedt);
            this.Controls.Add(this.ItemLbl_2);
            this.Controls.Add(this.ItemLbl_1);
            this.Controls.Add(this.ItemLbl_0);
            this.Controls.Add(this.fieldCapCmbBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmContColModi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "连续行_列修改";
            this.Load += new System.EventHandler(this.frmContColModi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.startRowNumedt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endRowNumedt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ItemLbl_0;
        private System.Windows.Forms.ComboBox fieldCapCmbBox;
        private NationalInstruments.UI.WindowsForms.NumericEdit startRowNumedt;
        private NationalInstruments.UI.WindowsForms.NumericEdit endRowNumedt;
        private System.Windows.Forms.Label ItemLbl_2;
        private System.Windows.Forms.Label ItemLbl_1;
        public System.Windows.Forms.TextBox colValTxtBox;
        private System.Windows.Forms.Label label7;
    }
}