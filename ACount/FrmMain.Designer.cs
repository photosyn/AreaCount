namespace AreaCount
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.buttonRecordHandle = new System.Windows.Forms.Button();
            this.buttonRealTime = new System.Windows.Forms.Button();
            this.btnPerson = new System.Windows.Forms.Button();
            this.btnDuty = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 659);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(811, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.Controls.Add(this.buttonRecordHandle);
            this.splitContainer1.Panel1.Controls.Add(this.buttonRealTime);
            this.splitContainer1.Panel1.Controls.Add(this.btnPerson);
            this.splitContainer1.Panel1.Controls.Add(this.btnDuty);
            this.splitContainer1.Panel1.Controls.Add(this.btnArea);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel2.Controls.Add(this.pnlMain);
            this.splitContainer1.Size = new System.Drawing.Size(811, 659);
            this.splitContainer1.SplitterDistance = 236;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 2;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(572, 659);
            this.pnlMain.TabIndex = 0;
            // 
            // buttonRecordHandle
            // 
            this.buttonRecordHandle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRecordHandle.FlatAppearance.BorderSize = 0;
            this.buttonRecordHandle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRecordHandle.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonRecordHandle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(150)))), ((int)(((byte)(219)))));
            this.buttonRecordHandle.Image = global::AreaCount.Properties.Resources.异常补录;
            this.buttonRecordHandle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRecordHandle.Location = new System.Drawing.Point(0, 523);
            this.buttonRecordHandle.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRecordHandle.Name = "buttonRecordHandle";
            this.buttonRecordHandle.Padding = new System.Windows.Forms.Padding(12);
            this.buttonRecordHandle.Size = new System.Drawing.Size(238, 130);
            this.buttonRecordHandle.TabIndex = 4;
            this.buttonRecordHandle.Text = "异常人员处理";
            this.buttonRecordHandle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRecordHandle.UseVisualStyleBackColor = true;
            this.buttonRecordHandle.Click += new System.EventHandler(this.buttonRecordHandle_Click);
            // 
            // buttonRealTime
            // 
            this.buttonRealTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRealTime.BackColor = System.Drawing.Color.Transparent;
            this.buttonRealTime.FlatAppearance.BorderSize = 0;
            this.buttonRealTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRealTime.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonRealTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(150)))), ((int)(((byte)(219)))));
            this.buttonRealTime.Image = global::AreaCount.Properties.Resources.实时监控;
            this.buttonRealTime.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRealTime.Location = new System.Drawing.Point(0, 393);
            this.buttonRealTime.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRealTime.Name = "buttonRealTime";
            this.buttonRealTime.Padding = new System.Windows.Forms.Padding(12);
            this.buttonRealTime.Size = new System.Drawing.Size(238, 130);
            this.buttonRealTime.TabIndex = 3;
            this.buttonRealTime.Text = "在厂实时监控";
            this.buttonRealTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRealTime.UseVisualStyleBackColor = false;
            this.buttonRealTime.Click += new System.EventHandler(this.buttonRealTime_Click);
            // 
            // btnPerson
            // 
            this.btnPerson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPerson.FlatAppearance.BorderSize = 0;
            this.btnPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerson.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(150)))), ((int)(((byte)(219)))));
            this.btnPerson.Image = global::AreaCount.Properties.Resources.报表;
            this.btnPerson.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPerson.Location = new System.Drawing.Point(0, 263);
            this.btnPerson.Margin = new System.Windows.Forms.Padding(0);
            this.btnPerson.Name = "btnPerson";
            this.btnPerson.Padding = new System.Windows.Forms.Padding(12);
            this.btnPerson.Size = new System.Drawing.Size(238, 130);
            this.btnPerson.TabIndex = 2;
            this.btnPerson.Text = "在厂人员报表";
            this.btnPerson.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPerson.UseVisualStyleBackColor = true;
            this.btnPerson.Click += new System.EventHandler(this.btnPerson_Click);
            // 
            // btnDuty
            // 
            this.btnDuty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDuty.FlatAppearance.BorderSize = 0;
            this.btnDuty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuty.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDuty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(150)))), ((int)(((byte)(219)))));
            this.btnDuty.Image = global::AreaCount.Properties.Resources.值班管理;
            this.btnDuty.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDuty.Location = new System.Drawing.Point(0, 130);
            this.btnDuty.Margin = new System.Windows.Forms.Padding(0);
            this.btnDuty.Name = "btnDuty";
            this.btnDuty.Padding = new System.Windows.Forms.Padding(12);
            this.btnDuty.Size = new System.Drawing.Size(238, 130);
            this.btnDuty.TabIndex = 1;
            this.btnDuty.Text = "值班管理";
            this.btnDuty.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDuty.UseVisualStyleBackColor = false;
            this.btnDuty.Click += new System.EventHandler(this.btnDuty_Click);
            // 
            // btnArea
            // 
            this.btnArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnArea.FlatAppearance.BorderSize = 0;
            this.btnArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArea.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(150)))), ((int)(((byte)(219)))));
            this.btnArea.Image = global::AreaCount.Properties.Resources.区域统计;
            this.btnArea.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnArea.Location = new System.Drawing.Point(0, 0);
            this.btnArea.Margin = new System.Windows.Forms.Padding(0);
            this.btnArea.Name = "btnArea";
            this.btnArea.Padding = new System.Windows.Forms.Padding(12);
            this.btnArea.Size = new System.Drawing.Size(238, 130);
            this.btnArea.TabIndex = 0;
            this.btnArea.Text = "区域统计";
            this.btnArea.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnArea.UseVisualStyleBackColor = false;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(811, 681);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "区域监控管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnPerson;
        private System.Windows.Forms.Button btnDuty;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button buttonRealTime;
        private System.Windows.Forms.Button buttonRecordHandle;
    }
}

