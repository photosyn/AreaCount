namespace AreaCount
{
    partial class FrmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogIn));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxPsw = new System.Windows.Forms.TextBox();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.lLblDB = new System.Windows.Forms.LinkLabel();
            this.BtnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(43, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(77, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户名：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(43, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码：";
            // 
            // tBoxPsw
            // 
            this.tBoxPsw.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tBoxPsw.Location = new System.Drawing.Point(147, 72);
            this.tBoxPsw.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tBoxPsw.Name = "tBoxPsw";
            this.tBoxPsw.Size = new System.Drawing.Size(161, 26);
            this.tBoxPsw.TabIndex = 3;
            this.tBoxPsw.UseSystemPasswordChar = true;
            this.tBoxPsw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxPsw_KeyPress);
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(147, 20);
            this.comboBoxUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(161, 27);
            this.comboBoxUser.TabIndex = 7;
            // 
            // lLblDB
            // 
            this.lLblDB.BackColor = System.Drawing.Color.Transparent;
            this.lLblDB.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.lLblDB.Image = global::AreaCount.Properties.Resources.数据库;
            this.lLblDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lLblDB.LinkColor = System.Drawing.SystemColors.Highlight;
            this.lLblDB.Location = new System.Drawing.Point(110, 109);
            this.lLblDB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lLblDB.Name = "lLblDB";
            this.lLblDB.Size = new System.Drawing.Size(125, 33);
            this.lLblDB.TabIndex = 6;
            this.lLblDB.TabStop = true;
            this.lLblDB.Text = "数据库配置";
            this.lLblDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lLblDB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // BtnOK
            // 
            this.BtnOK.BackColor = System.Drawing.SystemColors.Control;
            this.BtnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOK.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnOK.ForeColor = System.Drawing.Color.Black;
            this.BtnOK.Image = global::AreaCount.Properties.Resources.登录;
            this.BtnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOK.Location = new System.Drawing.Point(47, 152);
            this.BtnOK.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(90, 40);
            this.BtnOK.TabIndex = 5;
            this.BtnOK.Text = "登录";
            this.BtnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnOK.UseVisualStyleBackColor = false;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            this.BtnOK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BtnOK_KeyPress);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Image = global::AreaCount.Properties.Resources.退出;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(193, 152);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 40);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "退出";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(341, 205);
            this.Controls.Add(this.comboBoxUser);
            this.Controls.Add(this.lLblDB);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tBoxPsw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登陆";
            this.Load += new System.EventHandler(this.FrmLogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxPsw;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.LinkLabel lLblDB;
        private System.Windows.Forms.ComboBox comboBoxUser;
    }
}