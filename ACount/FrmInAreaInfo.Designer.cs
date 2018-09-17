namespace AreaCount
{
    partial class FrmInAreaInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInAreaInfo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treeViewGroup = new System.Windows.Forms.TreeView();
            this.imageListStatus = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxCardType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEditArea6 = new DevExpress.XtraEditors.ButtonEdit();
            this.buttonEditArea5 = new DevExpress.XtraEditors.ButtonEdit();
            this.buttonEditArea4 = new DevExpress.XtraEditors.ButtonEdit();
            this.buttonEditArea3 = new DevExpress.XtraEditors.ButtonEdit();
            this.buttonEditArea2 = new DevExpress.XtraEditors.ButtonEdit();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonEditArea1 = new DevExpress.XtraEditors.ButtonEdit();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBoxArea6 = new System.Windows.Forms.TextBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.textBoxArea5 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.textBoxArea1 = new System.Windows.Forms.TextBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.textBoxArea2 = new System.Windows.Forms.TextBox();
            this.textBoxArea3 = new System.Windows.Forms.TextBox();
            this.textBoxArea4 = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditArea6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditArea5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditArea4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditArea3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditArea2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditArea1.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.treeViewGroup);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.MaximumSize = new System.Drawing.Size(350, 0);
            this.groupBox1.MinimumSize = new System.Drawing.Size(233, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(310, 480);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "人员所在群信息";
            // 
            // treeViewGroup
            // 
            this.treeViewGroup.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewGroup.ImageIndex = 0;
            this.treeViewGroup.ImageList = this.imageListStatus;
            this.treeViewGroup.Location = new System.Drawing.Point(3, 26);
            this.treeViewGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.treeViewGroup.Name = "treeViewGroup";
            this.treeViewGroup.SelectedImageIndex = 0;
            this.treeViewGroup.Size = new System.Drawing.Size(304, 450);
            this.treeViewGroup.TabIndex = 0;
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.comboBoxCardType);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(310, 40);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(545, 93);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "卡类别";
            // 
            // comboBoxCardType
            // 
            this.comboBoxCardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCardType.FormattingEnabled = true;
            this.comboBoxCardType.Location = new System.Drawing.Point(124, 44);
            this.comboBoxCardType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxCardType.Name = "comboBoxCardType";
            this.comboBoxCardType.Size = new System.Drawing.Size(186, 29);
            this.comboBoxCardType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "卡类别：";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(310, 133);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(545, 387);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "区域设备设置";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.buttonEditArea6, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonEditArea5, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonEditArea4, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonEditArea3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonEditArea2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonEditArea1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxArea6, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.checkBox6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxArea5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.checkBox3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBox5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxArea1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBox4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxArea2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxArea3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxArea4, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 26);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(539, 357);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // buttonEditArea6
            // 
            this.buttonEditArea6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditArea6.EditValue = "";
            this.buttonEditArea6.Location = new System.Drawing.Point(257, 312);
            this.buttonEditArea6.Margin = new System.Windows.Forms.Padding(23, 4, 23, 4);
            this.buttonEditArea6.Name = "buttonEditArea6";
            this.buttonEditArea6.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditArea6.Properties.Appearance.Options.UseFont = true;
            this.buttonEditArea6.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEditArea6.Size = new System.Drawing.Size(259, 28);
            this.buttonEditArea6.TabIndex = 23;
            this.buttonEditArea6.Click += new System.EventHandler(this.buttonEditArea6_Click);
            // 
            // buttonEditArea5
            // 
            this.buttonEditArea5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditArea5.EditValue = "";
            this.buttonEditArea5.Location = new System.Drawing.Point(257, 251);
            this.buttonEditArea5.Margin = new System.Windows.Forms.Padding(23, 4, 23, 4);
            this.buttonEditArea5.Name = "buttonEditArea5";
            this.buttonEditArea5.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditArea5.Properties.Appearance.Options.UseFont = true;
            this.buttonEditArea5.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEditArea5.Size = new System.Drawing.Size(259, 28);
            this.buttonEditArea5.TabIndex = 22;
            this.buttonEditArea5.Click += new System.EventHandler(this.buttonEditArea5_Click);
            // 
            // buttonEditArea4
            // 
            this.buttonEditArea4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditArea4.EditValue = "";
            this.buttonEditArea4.Location = new System.Drawing.Point(257, 192);
            this.buttonEditArea4.Margin = new System.Windows.Forms.Padding(23, 4, 23, 4);
            this.buttonEditArea4.Name = "buttonEditArea4";
            this.buttonEditArea4.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditArea4.Properties.Appearance.Options.UseFont = true;
            this.buttonEditArea4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEditArea4.Size = new System.Drawing.Size(259, 28);
            this.buttonEditArea4.TabIndex = 21;
            this.buttonEditArea4.Click += new System.EventHandler(this.buttonEditArea4_Click);
            // 
            // buttonEditArea3
            // 
            this.buttonEditArea3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditArea3.EditValue = "";
            this.buttonEditArea3.Location = new System.Drawing.Point(257, 133);
            this.buttonEditArea3.Margin = new System.Windows.Forms.Padding(23, 4, 23, 4);
            this.buttonEditArea3.Name = "buttonEditArea3";
            this.buttonEditArea3.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditArea3.Properties.Appearance.Options.UseFont = true;
            this.buttonEditArea3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEditArea3.Size = new System.Drawing.Size(259, 28);
            this.buttonEditArea3.TabIndex = 20;
            this.buttonEditArea3.Click += new System.EventHandler(this.buttonEditArea3_Click);
            // 
            // buttonEditArea2
            // 
            this.buttonEditArea2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditArea2.EditValue = "";
            this.buttonEditArea2.Location = new System.Drawing.Point(257, 74);
            this.buttonEditArea2.Margin = new System.Windows.Forms.Padding(23, 4, 23, 4);
            this.buttonEditArea2.Name = "buttonEditArea2";
            this.buttonEditArea2.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditArea2.Properties.Appearance.Options.UseFont = true;
            this.buttonEditArea2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEditArea2.Size = new System.Drawing.Size(259, 28);
            this.buttonEditArea2.TabIndex = 19;
            this.buttonEditArea2.Click += new System.EventHandler(this.buttonEditArea2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox1.Location = new System.Drawing.Point(35, 4);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(35, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(79, 51);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "区域一";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // buttonEditArea1
            // 
            this.buttonEditArea1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditArea1.EditValue = "";
            this.buttonEditArea1.Location = new System.Drawing.Point(257, 15);
            this.buttonEditArea1.Margin = new System.Windows.Forms.Padding(23, 4, 23, 4);
            this.buttonEditArea1.Name = "buttonEditArea1";
            this.buttonEditArea1.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditArea1.Properties.Appearance.Options.UseFont = true;
            this.buttonEditArea1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEditArea1.Size = new System.Drawing.Size(259, 28);
            this.buttonEditArea1.TabIndex = 18;
            this.buttonEditArea1.Click += new System.EventHandler(this.buttonEditArea1_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox2.Location = new System.Drawing.Point(35, 63);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(35, 4, 3, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(79, 51);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "区域二";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBoxArea6
            // 
            this.textBoxArea6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxArea6.Location = new System.Drawing.Point(120, 311);
            this.textBoxArea6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxArea6.Name = "textBoxArea6";
            this.textBoxArea6.Size = new System.Drawing.Size(111, 29);
            this.textBoxArea6.TabIndex = 11;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox6.Location = new System.Drawing.Point(35, 299);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(35, 4, 3, 4);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(79, 54);
            this.checkBox6.TabIndex = 17;
            this.checkBox6.Text = "区域六";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // textBoxArea5
            // 
            this.textBoxArea5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxArea5.Location = new System.Drawing.Point(120, 251);
            this.textBoxArea5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxArea5.Name = "textBoxArea5";
            this.textBoxArea5.Size = new System.Drawing.Size(111, 29);
            this.textBoxArea5.TabIndex = 10;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox3.Location = new System.Drawing.Point(35, 122);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(35, 4, 3, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(79, 51);
            this.checkBox3.TabIndex = 14;
            this.checkBox3.Text = "区域三";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox5.Location = new System.Drawing.Point(35, 240);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(35, 4, 3, 4);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(79, 51);
            this.checkBox5.TabIndex = 16;
            this.checkBox5.Text = "区域五";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // textBoxArea1
            // 
            this.textBoxArea1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxArea1.Location = new System.Drawing.Point(120, 15);
            this.textBoxArea1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxArea1.Name = "textBoxArea1";
            this.textBoxArea1.Size = new System.Drawing.Size(111, 29);
            this.textBoxArea1.TabIndex = 6;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox4.Location = new System.Drawing.Point(35, 181);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(35, 4, 3, 4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(79, 51);
            this.checkBox4.TabIndex = 15;
            this.checkBox4.Text = "区域四";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // textBoxArea2
            // 
            this.textBoxArea2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxArea2.Location = new System.Drawing.Point(120, 74);
            this.textBoxArea2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxArea2.Name = "textBoxArea2";
            this.textBoxArea2.Size = new System.Drawing.Size(111, 29);
            this.textBoxArea2.TabIndex = 7;
            // 
            // textBoxArea3
            // 
            this.textBoxArea3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxArea3.Location = new System.Drawing.Point(120, 133);
            this.textBoxArea3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxArea3.Name = "textBoxArea3";
            this.textBoxArea3.Size = new System.Drawing.Size(111, 29);
            this.textBoxArea3.TabIndex = 8;
            // 
            // textBoxArea4
            // 
            this.textBoxArea4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxArea4.Location = new System.Drawing.Point(120, 192);
            this.textBoxArea4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxArea4.Name = "textBoxArea4";
            this.textBoxArea4.Size = new System.Drawing.Size(111, 29);
            this.textBoxArea4.TabIndex = 9;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSave,
            this.toolStripSeparator1,
            this.toolStripButtonQuery,
            this.toolStripSeparator2,
            this.toolStripButtonClose});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.MinimumSize = new System.Drawing.Size(0, 40);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(855, 40);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.Image = global::AreaCount.Properties.Resources.保存;
            this.toolStripButtonSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(142, 37);
            this.toolStripButtonSave.Text = "保存区域设置";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
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
            // FrmInAreaInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(855, 520);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmInAreaInfo";
            this.Text = "区域统计报表";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditArea6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditArea5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditArea4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditArea3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditArea2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditArea1.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView treeViewGroup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxCardType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBoxArea6;
        private System.Windows.Forms.TextBox textBoxArea5;
        private System.Windows.Forms.TextBox textBoxArea4;
        private System.Windows.Forms.TextBox textBoxArea3;
        private System.Windows.Forms.TextBox textBoxArea2;
        private System.Windows.Forms.TextBox textBoxArea1;
        private DevExpress.XtraEditors.ButtonEdit buttonEditArea1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.ButtonEdit buttonEditArea6;
        private DevExpress.XtraEditors.ButtonEdit buttonEditArea5;
        private DevExpress.XtraEditors.ButtonEdit buttonEditArea4;
        private DevExpress.XtraEditors.ButtonEdit buttonEditArea3;
        private DevExpress.XtraEditors.ButtonEdit buttonEditArea2;
        private System.Windows.Forms.ImageList imageListStatus;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonQuery;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}