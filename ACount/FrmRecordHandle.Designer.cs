namespace AreaCount
{
    partial class FrmRecordHandle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonFix = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewPerson = new System.Windows.Forms.DataGridView();
            this.LOGID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Per_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.所在群 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.卡号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.卡类别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.进闸口 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.电话 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonFix,
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.MinimumSize = new System.Drawing.Size(0, 49);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(983, 49);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonFix
            // 
            this.toolStripButtonFix.Image = global::AreaCount.Properties.Resources.确定;
            this.toolStripButtonFix.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonFix.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFix.Name = "toolStripButtonFix";
            this.toolStripButtonFix.Size = new System.Drawing.Size(142, 46);
            this.toolStripButtonFix.Text = "异常记录修复";
            this.toolStripButtonFix.ToolTipText = "异常记录确认";
            this.toolStripButtonFix.Click += new System.EventHandler(this.toolStripButtonFix_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 49);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::AreaCount.Properties.Resources.返回;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(78, 46);
            this.toolStripButton1.Text = "返回";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewPerson);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(983, 408);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "异常人员";
            // 
            // dataGridViewPerson
            // 
            this.dataGridViewPerson.AllowUserToAddRows = false;
            this.dataGridViewPerson.AllowUserToDeleteRows = false;
            this.dataGridViewPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LOGID,
            this.Per_ID,
            this.编号,
            this.姓名,
            this.所在群,
            this.卡号,
            this.卡类别,
            this.进闸口,
            this.时间,
            this.电话});
            this.dataGridViewPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPerson.Location = new System.Drawing.Point(4, 26);
            this.dataGridViewPerson.MultiSelect = false;
            this.dataGridViewPerson.Name = "dataGridViewPerson";
            this.dataGridViewPerson.RowTemplate.Height = 23;
            this.dataGridViewPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPerson.Size = new System.Drawing.Size(975, 378);
            this.dataGridViewPerson.TabIndex = 1;
            this.dataGridViewPerson.SelectionChanged += new System.EventHandler(this.dataGridViewPerson_SelectionChanged);
            // 
            // LOGID
            // 
            this.LOGID.DataPropertyName = "Log_ID";
            this.LOGID.HeaderText = "LOGID";
            this.LOGID.Name = "LOGID";
            this.LOGID.ReadOnly = true;
            this.LOGID.Visible = false;
            // 
            // Per_ID
            // 
            this.Per_ID.DataPropertyName = "Base_PerID";
            this.Per_ID.HeaderText = "人员ID";
            this.Per_ID.Name = "Per_ID";
            this.Per_ID.ReadOnly = true;
            this.Per_ID.Visible = false;
            // 
            // 编号
            // 
            this.编号.DataPropertyName = "Base_PerNo";
            this.编号.HeaderText = "编号";
            this.编号.Name = "编号";
            this.编号.ReadOnly = true;
            // 
            // 姓名
            // 
            this.姓名.DataPropertyName = "Base_PerName";
            this.姓名.HeaderText = "姓名";
            this.姓名.Name = "姓名";
            this.姓名.ReadOnly = true;
            this.姓名.Width = 80;
            // 
            // 所在群
            // 
            this.所在群.DataPropertyName = "Base_GroupName";
            this.所在群.HeaderText = "所在群";
            this.所在群.Name = "所在群";
            this.所在群.ReadOnly = true;
            this.所在群.Width = 130;
            // 
            // 卡号
            // 
            this.卡号.DataPropertyName = "Base_CardNo";
            this.卡号.HeaderText = "卡号";
            this.卡号.Name = "卡号";
            this.卡号.ReadOnly = true;
            this.卡号.Visible = false;
            // 
            // 卡类别
            // 
            this.卡类别.DataPropertyName = "Base_RoleName";
            this.卡类别.HeaderText = "卡类别";
            this.卡类别.Name = "卡类别";
            this.卡类别.ReadOnly = true;
            // 
            // 进闸口
            // 
            this.进闸口.DataPropertyName = "Device_Name";
            this.进闸口.HeaderText = "进闸口";
            this.进闸口.Name = "进闸口";
            this.进闸口.ReadOnly = true;
            this.进闸口.Width = 120;
            // 
            // 时间
            // 
            this.时间.DataPropertyName = "Access_DateTime";
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
            this.时间.DefaultCellStyle = dataGridViewCellStyle1;
            this.时间.HeaderText = "进闸时间";
            this.时间.Name = "时间";
            this.时间.ReadOnly = true;
            this.时间.Width = 180;
            // 
            // 电话
            // 
            this.电话.DataPropertyName = "Base_Tel";
            this.电话.HeaderText = "电话";
            this.电话.Name = "电话";
            this.电话.ReadOnly = true;
            this.电话.Width = 130;
            // 
            // FrmRecordHandle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(983, 457);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmRecordHandle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "刷卡记录";
            this.Shown += new System.EventHandler(this.FrmRecordHandle_Shown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewPerson;
        private System.Windows.Forms.ToolStripButton toolStripButtonFix;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOGID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Per_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 所在群;
        private System.Windows.Forms.DataGridViewTextBoxColumn 卡号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 卡类别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 进闸口;
        private System.Windows.Forms.DataGridViewTextBoxColumn 时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 电话;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}