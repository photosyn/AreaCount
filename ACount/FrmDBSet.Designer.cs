namespace AreaCount
{
    partial class FrmDBSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDBSet));
            this.buttonDbTest = new System.Windows.Forms.Button();
            this.buttonDbOk = new System.Windows.Forms.Button();
            this.buttonDbExit = new System.Windows.Forms.Button();
            this.tabPSQL = new System.Windows.Forms.TabPage();
            this.gBoxSQL = new System.Windows.Forms.GroupBox();
            this.labelDbPwd = new System.Windows.Forms.Label();
            this.textBoxDbPwd = new System.Windows.Forms.TextBox();
            this.labelDbUser = new System.Windows.Forms.Label();
            this.textBoxDbUser = new System.Windows.Forms.TextBox();
            this.labelDbName = new System.Windows.Forms.Label();
            this.textBoxDbName = new System.Windows.Forms.TextBox();
            this.labelDbServer = new System.Windows.Forms.Label();
            this.textBoxDbServer = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPSQL.SuspendLayout();
            this.gBoxSQL.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDbTest
            // 
            this.buttonDbTest.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDbTest.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDbTest.Image = global::AreaCount.Properties.Resources.测试;
            this.buttonDbTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDbTest.Location = new System.Drawing.Point(38, 304);
            this.buttonDbTest.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonDbTest.Name = "buttonDbTest";
            this.buttonDbTest.Size = new System.Drawing.Size(90, 40);
            this.buttonDbTest.TabIndex = 1;
            this.buttonDbTest.Text = "测试";
            this.buttonDbTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDbTest.UseVisualStyleBackColor = false;
            this.buttonDbTest.Click += new System.EventHandler(this.buttonDbTest_Click);
            // 
            // buttonDbOk
            // 
            this.buttonDbOk.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDbOk.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDbOk.Image = global::AreaCount.Properties.Resources.确定;
            this.buttonDbOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDbOk.Location = new System.Drawing.Point(189, 304);
            this.buttonDbOk.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonDbOk.Name = "buttonDbOk";
            this.buttonDbOk.Size = new System.Drawing.Size(90, 40);
            this.buttonDbOk.TabIndex = 2;
            this.buttonDbOk.Text = "确定";
            this.buttonDbOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDbOk.UseVisualStyleBackColor = false;
            this.buttonDbOk.Click += new System.EventHandler(this.buttonDbOk_Click);
            // 
            // buttonDbExit
            // 
            this.buttonDbExit.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDbExit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDbExit.Image = global::AreaCount.Properties.Resources.取消;
            this.buttonDbExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDbExit.Location = new System.Drawing.Point(340, 304);
            this.buttonDbExit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonDbExit.Name = "buttonDbExit";
            this.buttonDbExit.Size = new System.Drawing.Size(90, 40);
            this.buttonDbExit.TabIndex = 3;
            this.buttonDbExit.Text = "取消";
            this.buttonDbExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDbExit.UseVisualStyleBackColor = false;
            this.buttonDbExit.Click += new System.EventHandler(this.buttonDbExit_Click);
            // 
            // tabPSQL
            // 
            this.tabPSQL.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPSQL.Controls.Add(this.gBoxSQL);
            this.tabPSQL.Location = new System.Drawing.Point(4, 30);
            this.tabPSQL.Margin = new System.Windows.Forms.Padding(0);
            this.tabPSQL.Name = "tabPSQL";
            this.tabPSQL.Size = new System.Drawing.Size(418, 249);
            this.tabPSQL.TabIndex = 0;
            this.tabPSQL.Text = "SQL";
            // 
            // gBoxSQL
            // 
            this.gBoxSQL.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gBoxSQL.Controls.Add(this.labelDbPwd);
            this.gBoxSQL.Controls.Add(this.textBoxDbPwd);
            this.gBoxSQL.Controls.Add(this.labelDbUser);
            this.gBoxSQL.Controls.Add(this.textBoxDbUser);
            this.gBoxSQL.Controls.Add(this.labelDbName);
            this.gBoxSQL.Controls.Add(this.textBoxDbName);
            this.gBoxSQL.Controls.Add(this.labelDbServer);
            this.gBoxSQL.Controls.Add(this.textBoxDbServer);
            this.gBoxSQL.Location = new System.Drawing.Point(24, 7);
            this.gBoxSQL.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gBoxSQL.Name = "gBoxSQL";
            this.gBoxSQL.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gBoxSQL.Size = new System.Drawing.Size(367, 232);
            this.gBoxSQL.TabIndex = 0;
            this.gBoxSQL.TabStop = false;
            this.gBoxSQL.Text = "SQL SERVER数据库参数";
            // 
            // labelDbPwd
            // 
            this.labelDbPwd.AutoSize = true;
            this.labelDbPwd.Location = new System.Drawing.Point(31, 192);
            this.labelDbPwd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDbPwd.Name = "labelDbPwd";
            this.labelDbPwd.Size = new System.Drawing.Size(106, 21);
            this.labelDbPwd.TabIndex = 9;
            this.labelDbPwd.Text = "数据库密码：";
            // 
            // textBoxDbPwd
            // 
            this.textBoxDbPwd.Location = new System.Drawing.Point(188, 191);
            this.textBoxDbPwd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxDbPwd.Name = "textBoxDbPwd";
            this.textBoxDbPwd.PasswordChar = '*';
            this.textBoxDbPwd.Size = new System.Drawing.Size(123, 29);
            this.textBoxDbPwd.TabIndex = 8;
            // 
            // labelDbUser
            // 
            this.labelDbUser.AutoSize = true;
            this.labelDbUser.Location = new System.Drawing.Point(31, 143);
            this.labelDbUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDbUser.Name = "labelDbUser";
            this.labelDbUser.Size = new System.Drawing.Size(106, 21);
            this.labelDbUser.TabIndex = 7;
            this.labelDbUser.Text = "数据库账号：";
            // 
            // textBoxDbUser
            // 
            this.textBoxDbUser.Location = new System.Drawing.Point(188, 141);
            this.textBoxDbUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxDbUser.Name = "textBoxDbUser";
            this.textBoxDbUser.Size = new System.Drawing.Size(123, 29);
            this.textBoxDbUser.TabIndex = 6;
            // 
            // labelDbName
            // 
            this.labelDbName.AutoSize = true;
            this.labelDbName.Location = new System.Drawing.Point(31, 94);
            this.labelDbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDbName.Name = "labelDbName";
            this.labelDbName.Size = new System.Drawing.Size(90, 21);
            this.labelDbName.TabIndex = 5;
            this.labelDbName.Text = "数据库名：";
            // 
            // textBoxDbName
            // 
            this.textBoxDbName.Location = new System.Drawing.Point(188, 91);
            this.textBoxDbName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxDbName.Name = "textBoxDbName";
            this.textBoxDbName.Size = new System.Drawing.Size(123, 29);
            this.textBoxDbName.TabIndex = 4;
            // 
            // labelDbServer
            // 
            this.labelDbServer.AutoSize = true;
            this.labelDbServer.Location = new System.Drawing.Point(31, 45);
            this.labelDbServer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDbServer.Name = "labelDbServer";
            this.labelDbServer.Size = new System.Drawing.Size(122, 21);
            this.labelDbServer.TabIndex = 3;
            this.labelDbServer.Text = "数据库服务器：";
            // 
            // textBoxDbServer
            // 
            this.textBoxDbServer.Location = new System.Drawing.Point(188, 41);
            this.textBoxDbServer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxDbServer.Name = "textBoxDbServer";
            this.textBoxDbServer.Size = new System.Drawing.Size(123, 29);
            this.textBoxDbServer.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPSQL);
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(25, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(426, 283);
            this.tabControl1.TabIndex = 0;
            // 
            // FrmDBSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(474, 356);
            this.Controls.Add(this.buttonDbExit);
            this.Controls.Add(this.buttonDbOk);
            this.Controls.Add(this.buttonDbTest);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmDBSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据库参数配置";
            this.tabPSQL.ResumeLayout(false);
            this.gBoxSQL.ResumeLayout(false);
            this.gBoxSQL.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDbTest;
        private System.Windows.Forms.Button buttonDbOk;
        private System.Windows.Forms.Button buttonDbExit;
        private System.Windows.Forms.TabPage tabPSQL;
        private System.Windows.Forms.GroupBox gBoxSQL;
        private System.Windows.Forms.Label labelDbPwd;
        private System.Windows.Forms.TextBox textBoxDbPwd;
        private System.Windows.Forms.Label labelDbUser;
        private System.Windows.Forms.TextBox textBoxDbUser;
        private System.Windows.Forms.Label labelDbName;
        private System.Windows.Forms.TextBox textBoxDbName;
        private System.Windows.Forms.Label labelDbServer;
        private System.Windows.Forms.TextBox textBoxDbServer;
        private System.Windows.Forms.TabControl tabControl1;
    }
}