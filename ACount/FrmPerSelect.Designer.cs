namespace AreaCount
{
    partial class FrmPerSelect
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPerSelect));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewPerson = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeViewGroup = new System.Windows.Forms.TreeView();
            this.imageListStatus = new System.Windows.Forms.ImageList(this.components);
            this.radioButtonPerson = new System.Windows.Forms.RadioButton();
            this.radioButtonGroup = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxCardNo = new System.Windows.Forms.TextBox();
            this.textBoxPerName = new System.Windows.Forms.TextBox();
            this.textBoxPerNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxScreenId = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCardType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonAbnormal = new System.Windows.Forms.RadioButton();
            this.radioButtonNormal = new System.Windows.Forms.RadioButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.listViewPerson);
            this.groupBox1.Controls.Add(this.splitter1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(703, 709);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "人员信息";
            // 
            // listViewPerson
            // 
            this.listViewPerson.BackColor = System.Drawing.SystemColors.Window;
            this.listViewPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewPerson.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPerson.FullRowSelect = true;
            this.listViewPerson.GridLines = true;
            this.listViewPerson.HideSelection = false;
            this.listViewPerson.Location = new System.Drawing.Point(313, 27);
            this.listViewPerson.Margin = new System.Windows.Forms.Padding(5);
            this.listViewPerson.MultiSelect = false;
            this.listViewPerson.Name = "listViewPerson";
            this.listViewPerson.Size = new System.Drawing.Size(385, 677);
            this.listViewPerson.TabIndex = 0;
            this.listViewPerson.UseCompatibleStateImageBehavior = false;
            this.listViewPerson.View = System.Windows.Forms.View.Details;
            this.listViewPerson.SelectedIndexChanged += new System.EventHandler(this.listViewPerson_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "编号";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "名称";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "卡号";
            this.columnHeader3.Width = 120;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(310, 27);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 677);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.treeViewGroup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(5, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 677);
            this.panel1.TabIndex = 1;
            // 
            // treeViewGroup
            // 
            this.treeViewGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewGroup.ImageIndex = 0;
            this.treeViewGroup.ImageList = this.imageListStatus;
            this.treeViewGroup.Location = new System.Drawing.Point(0, 0);
            this.treeViewGroup.Margin = new System.Windows.Forms.Padding(5);
            this.treeViewGroup.Name = "treeViewGroup";
            this.treeViewGroup.SelectedImageIndex = 0;
            this.treeViewGroup.Size = new System.Drawing.Size(305, 677);
            this.treeViewGroup.TabIndex = 1;
            this.treeViewGroup.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewGroup_NodeMouseClick);
            this.treeViewGroup.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeViewGroup_MouseUp);
            // 
            // imageListStatus
            // 
            this.imageListStatus.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListStatus.ImageStream")));
            this.imageListStatus.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListStatus.Images.SetKeyName(0, "未选中.png");
            this.imageListStatus.Images.SetKeyName(1, "选中.png");
            this.imageListStatus.Images.SetKeyName(2, "部分选中.png");
            // 
            // radioButtonPerson
            // 
            this.radioButtonPerson.AutoSize = true;
            this.radioButtonPerson.Location = new System.Drawing.Point(194, 43);
            this.radioButtonPerson.Margin = new System.Windows.Forms.Padding(5);
            this.radioButtonPerson.Name = "radioButtonPerson";
            this.radioButtonPerson.Size = new System.Drawing.Size(92, 25);
            this.radioButtonPerson.TabIndex = 1;
            this.radioButtonPerson.Text = "按人查询";
            this.radioButtonPerson.UseVisualStyleBackColor = true;
            this.radioButtonPerson.CheckedChanged += new System.EventHandler(this.radioButtonPerson_CheckedChanged);
            // 
            // radioButtonGroup
            // 
            this.radioButtonGroup.AutoSize = true;
            this.radioButtonGroup.Checked = true;
            this.radioButtonGroup.Location = new System.Drawing.Point(44, 43);
            this.radioButtonGroup.Margin = new System.Windows.Forms.Padding(5);
            this.radioButtonGroup.Name = "radioButtonGroup";
            this.radioButtonGroup.Size = new System.Drawing.Size(92, 25);
            this.radioButtonGroup.TabIndex = 0;
            this.radioButtonGroup.TabStop = true;
            this.radioButtonGroup.Text = "按群查询";
            this.radioButtonGroup.UseVisualStyleBackColor = true;
            this.radioButtonGroup.CheckedChanged += new System.EventHandler(this.radioButtonGroup_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.groupBox4);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(703, 40);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(382, 709);
            this.panel3.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButtonGroup);
            this.groupBox4.Controls.Add(this.radioButtonPerson);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 538);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(382, 100);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "查询方式";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxCardNo);
            this.groupBox2.Controls.Add(this.textBoxPerName);
            this.groupBox2.Controls.Add(this.textBoxPerNo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 283);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(382, 255);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "条件";
            // 
            // textBoxCardNo
            // 
            this.textBoxCardNo.Enabled = false;
            this.textBoxCardNo.Location = new System.Drawing.Point(138, 196);
            this.textBoxCardNo.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxCardNo.Name = "textBoxCardNo";
            this.textBoxCardNo.Size = new System.Drawing.Size(164, 29);
            this.textBoxCardNo.TabIndex = 5;
            // 
            // textBoxPerName
            // 
            this.textBoxPerName.Enabled = false;
            this.textBoxPerName.Location = new System.Drawing.Point(138, 120);
            this.textBoxPerName.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxPerName.Name = "textBoxPerName";
            this.textBoxPerName.Size = new System.Drawing.Size(164, 29);
            this.textBoxPerName.TabIndex = 4;
            // 
            // textBoxPerNo
            // 
            this.textBoxPerNo.Enabled = false;
            this.textBoxPerNo.Location = new System.Drawing.Point(138, 44);
            this.textBoxPerNo.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxPerNo.Name = "textBoxPerNo";
            this.textBoxPerNo.Size = new System.Drawing.Size(164, 29);
            this.textBoxPerNo.TabIndex = 3;
            this.textBoxPerNo.Text = "全部";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(25, 199);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "卡号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(25, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "人员名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(25, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "人员编号";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.comboBoxScreenId);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.comboBoxCardType);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.radioButtonAbnormal);
            this.groupBox3.Controls.Add(this.radioButtonNormal);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(382, 283);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "统计类型";
            // 
            // comboBoxScreenId
            // 
            this.comboBoxScreenId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxScreenId.FormattingEnabled = true;
            this.comboBoxScreenId.Location = new System.Drawing.Point(122, 203);
            this.comboBoxScreenId.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxScreenId.Name = "comboBoxScreenId";
            this.comboBoxScreenId.Size = new System.Drawing.Size(199, 29);
            this.comboBoxScreenId.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 209);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "监控区";
            // 
            // comboBoxCardType
            // 
            this.comboBoxCardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCardType.FormattingEnabled = true;
            this.comboBoxCardType.Location = new System.Drawing.Point(122, 125);
            this.comboBoxCardType.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxCardType.Name = "comboBoxCardType";
            this.comboBoxCardType.Size = new System.Drawing.Size(199, 29);
            this.comboBoxCardType.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "卡类别";
            // 
            // radioButtonAbnormal
            // 
            this.radioButtonAbnormal.AutoSize = true;
            this.radioButtonAbnormal.Location = new System.Drawing.Point(211, 54);
            this.radioButtonAbnormal.Margin = new System.Windows.Forms.Padding(5);
            this.radioButtonAbnormal.Name = "radioButtonAbnormal";
            this.radioButtonAbnormal.Size = new System.Drawing.Size(124, 25);
            this.radioButtonAbnormal.TabIndex = 1;
            this.radioButtonAbnormal.Text = "异常出厂人员";
            this.radioButtonAbnormal.UseVisualStyleBackColor = true;
            // 
            // radioButtonNormal
            // 
            this.radioButtonNormal.AutoSize = true;
            this.radioButtonNormal.Checked = true;
            this.radioButtonNormal.Location = new System.Drawing.Point(60, 54);
            this.radioButtonNormal.Margin = new System.Windows.Forms.Padding(5);
            this.radioButtonNormal.Name = "radioButtonNormal";
            this.radioButtonNormal.Size = new System.Drawing.Size(92, 25);
            this.radioButtonNormal.TabIndex = 0;
            this.radioButtonNormal.TabStop = true;
            this.radioButtonNormal.Text = "在厂人员";
            this.radioButtonNormal.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonQuery,
            this.toolStripSeparator1,
            this.toolStripButtonClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.MinimumSize = new System.Drawing.Size(0, 40);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1085, 40);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonQuery
            // 
            this.toolStripButtonQuery.Image = global::AreaCount.Properties.Resources.查询;
            this.toolStripButtonQuery.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonQuery.Name = "toolStripButtonQuery";
            this.toolStripButtonQuery.Size = new System.Drawing.Size(78, 37);
            this.toolStripButtonQuery.Text = "查询";
            this.toolStripButtonQuery.Click += new System.EventHandler(this.toolStripButtonQuery_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // toolStripButtonClose
            // 
            this.toolStripButtonClose.Image = global::AreaCount.Properties.Resources.返回;
            this.toolStripButtonClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClose.Name = "toolStripButtonClose";
            this.toolStripButtonClose.Size = new System.Drawing.Size(78, 37);
            this.toolStripButtonClose.Text = "返回";
            this.toolStripButtonClose.Click += new System.EventHandler(this.toolStripButtonClose_Click);
            // 
            // FrmPerSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1085, 749);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmPerSelect";
            this.Text = "人员信息统计";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPerSelect_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeViewGroup;
        private System.Windows.Forms.RadioButton radioButtonPerson;
        private System.Windows.Forms.RadioButton radioButtonGroup;
        private System.Windows.Forms.ListView listViewPerson;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxCardType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonAbnormal;
        private System.Windows.Forms.RadioButton radioButtonNormal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxCardNo;
        private System.Windows.Forms.TextBox textBoxPerName;
        private System.Windows.Forms.TextBox textBoxPerNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageListStatus;
        private System.Windows.Forms.ComboBox comboBoxScreenId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonQuery;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}