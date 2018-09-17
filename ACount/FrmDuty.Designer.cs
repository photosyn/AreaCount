namespace AreaCount
{
    partial class FrmDuty
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
            this.spDuty = new System.Windows.Forms.SplitContainer();
            this.tBoxExcel = new System.Windows.Forms.TextBox();
            this.cmBoxMonth = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gBoxInfo = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tBoxInerPhone = new System.Windows.Forms.TextBox();
            this.tBoxPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxDeputy = new System.Windows.Forms.TextBox();
            this.tBoxDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxTel = new System.Windows.Forms.TextBox();
            this.gBoxDuty = new System.Windows.Forms.GroupBox();
            this.DbGridDuty = new System.Windows.Forms.DataGridView();
            this.ColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPosit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColInTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.smItemDel = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ofDlgExcel = new System.Windows.Forms.OpenFileDialog();
            this.dsDuty = new System.Data.DataSet();
            this.BtnExcel = new System.Windows.Forms.Button();
            this.BtnImport = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.tlBtnModify = new System.Windows.Forms.ToolStripButton();
            this.tlBtnDel = new System.Windows.Forms.ToolStripButton();
            this.tlBtnClose = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.spDuty)).BeginInit();
            this.spDuty.Panel1.SuspendLayout();
            this.spDuty.Panel2.SuspendLayout();
            this.spDuty.SuspendLayout();
            this.gBoxInfo.SuspendLayout();
            this.gBoxDuty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DbGridDuty)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDuty)).BeginInit();
            this.SuspendLayout();
            // 
            // spDuty
            // 
            this.spDuty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spDuty.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spDuty.Location = new System.Drawing.Point(0, 34);
            this.spDuty.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.spDuty.Name = "spDuty";
            // 
            // spDuty.Panel1
            // 
            this.spDuty.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.spDuty.Panel1.Controls.Add(this.BtnExcel);
            this.spDuty.Panel1.Controls.Add(this.BtnImport);
            this.spDuty.Panel1.Controls.Add(this.tBoxExcel);
            this.spDuty.Panel1.Controls.Add(this.cmBoxMonth);
            this.spDuty.Panel1.Controls.Add(this.label8);
            this.spDuty.Panel1.Controls.Add(this.label7);
            this.spDuty.Panel1.Controls.Add(this.gBoxInfo);
            this.spDuty.Panel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // spDuty.Panel2
            // 
            this.spDuty.Panel2.Controls.Add(this.gBoxDuty);
            this.spDuty.Panel2.Controls.Add(this.dataGridView1);
            this.spDuty.Size = new System.Drawing.Size(700, 575);
            this.spDuty.SplitterDistance = 352;
            this.spDuty.SplitterWidth = 3;
            this.spDuty.TabIndex = 0;
            // 
            // tBoxExcel
            // 
            this.tBoxExcel.Location = new System.Drawing.Point(109, 391);
            this.tBoxExcel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tBoxExcel.Name = "tBoxExcel";
            this.tBoxExcel.ReadOnly = true;
            this.tBoxExcel.Size = new System.Drawing.Size(123, 29);
            this.tBoxExcel.TabIndex = 18;
            // 
            // cmBoxMonth
            // 
            this.cmBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxMonth.FormattingEnabled = true;
            this.cmBoxMonth.Items.AddRange(new object[] {
            "当前月",
            "下月"});
            this.cmBoxMonth.Location = new System.Drawing.Point(109, 459);
            this.cmBoxMonth.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmBoxMonth.Name = "cmBoxMonth";
            this.cmBoxMonth.Size = new System.Drawing.Size(123, 29);
            this.cmBoxMonth.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 463);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "月份：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 395);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Excel文件：";
            // 
            // gBoxInfo
            // 
            this.gBoxInfo.BackColor = System.Drawing.Color.Transparent;
            this.gBoxInfo.Controls.Add(this.label10);
            this.gBoxInfo.Controls.Add(this.label9);
            this.gBoxInfo.Controls.Add(this.BtnSave);
            this.gBoxInfo.Controls.Add(this.label6);
            this.gBoxInfo.Controls.Add(this.tBoxInerPhone);
            this.gBoxInfo.Controls.Add(this.tBoxPhone);
            this.gBoxInfo.Controls.Add(this.label5);
            this.gBoxInfo.Controls.Add(this.tBoxName);
            this.gBoxInfo.Controls.Add(this.label1);
            this.gBoxInfo.Controls.Add(this.label4);
            this.gBoxInfo.Controls.Add(this.tBoxDeputy);
            this.gBoxInfo.Controls.Add(this.tBoxDate);
            this.gBoxInfo.Controls.Add(this.label2);
            this.gBoxInfo.Controls.Add(this.label3);
            this.gBoxInfo.Controls.Add(this.tBoxTel);
            this.gBoxInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.gBoxInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gBoxInfo.Location = new System.Drawing.Point(0, 0);
            this.gBoxInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gBoxInfo.Name = "gBoxInfo";
            this.gBoxInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gBoxInfo.Size = new System.Drawing.Size(352, 575);
            this.gBoxInfo.TabIndex = 14;
            this.gBoxInfo.TabStop = false;
            this.gBoxInfo.Text = "值班信息";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(279, 274);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 21);
            this.label10.TabIndex = 16;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(279, 48);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 274);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "日期：";
            // 
            // tBoxInerPhone
            // 
            this.tBoxInerPhone.Location = new System.Drawing.Point(151, 225);
            this.tBoxInerPhone.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tBoxInerPhone.Name = "tBoxInerPhone";
            this.tBoxInerPhone.Size = new System.Drawing.Size(123, 29);
            this.tBoxInerPhone.TabIndex = 12;
            // 
            // tBoxPhone
            // 
            this.tBoxPhone.Location = new System.Drawing.Point(151, 180);
            this.tBoxPhone.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tBoxPhone.Name = "tBoxPhone";
            this.tBoxPhone.Size = new System.Drawing.Size(123, 29);
            this.tBoxPhone.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "内部电话：";
            // 
            // tBoxName
            // 
            this.tBoxName.Location = new System.Drawing.Point(151, 44);
            this.tBoxName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(123, 29);
            this.tBoxName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "姓名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "固定电话：";
            // 
            // tBoxDeputy
            // 
            this.tBoxDeputy.Location = new System.Drawing.Point(151, 89);
            this.tBoxDeputy.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tBoxDeputy.Name = "tBoxDeputy";
            this.tBoxDeputy.Size = new System.Drawing.Size(123, 29);
            this.tBoxDeputy.TabIndex = 4;
            // 
            // tBoxDate
            // 
            this.tBoxDate.Location = new System.Drawing.Point(151, 270);
            this.tBoxDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tBoxDate.Name = "tBoxDate";
            this.tBoxDate.Size = new System.Drawing.Size(123, 29);
            this.tBoxDate.TabIndex = 8;
            this.tBoxDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxDate_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "职务：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "移动电话：";
            // 
            // tBoxTel
            // 
            this.tBoxTel.Location = new System.Drawing.Point(151, 134);
            this.tBoxTel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tBoxTel.Name = "tBoxTel";
            this.tBoxTel.Size = new System.Drawing.Size(123, 29);
            this.tBoxTel.TabIndex = 6;
            // 
            // gBoxDuty
            // 
            this.gBoxDuty.AutoSize = true;
            this.gBoxDuty.BackColor = System.Drawing.Color.Transparent;
            this.gBoxDuty.Controls.Add(this.DbGridDuty);
            this.gBoxDuty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBoxDuty.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gBoxDuty.Location = new System.Drawing.Point(0, 0);
            this.gBoxDuty.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gBoxDuty.Name = "gBoxDuty";
            this.gBoxDuty.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gBoxDuty.Size = new System.Drawing.Size(345, 575);
            this.gBoxDuty.TabIndex = 2;
            this.gBoxDuty.TabStop = false;
            this.gBoxDuty.Text = "值班信息";
            // 
            // DbGridDuty
            // 
            this.DbGridDuty.AllowUserToAddRows = false;
            this.DbGridDuty.AllowUserToDeleteRows = false;
            this.DbGridDuty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DbGridDuty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDate,
            this.ColID,
            this.ColName,
            this.ColPosit,
            this.ColTel,
            this.ColFTel,
            this.ColInTel,
            this.ColMonth});
            this.DbGridDuty.ContextMenuStrip = this.contextMenuStrip1;
            this.DbGridDuty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DbGridDuty.Location = new System.Drawing.Point(2, 25);
            this.DbGridDuty.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DbGridDuty.Name = "DbGridDuty";
            this.DbGridDuty.RowTemplate.Height = 27;
            this.DbGridDuty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DbGridDuty.Size = new System.Drawing.Size(341, 547);
            this.DbGridDuty.TabIndex = 1;
            this.DbGridDuty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DbGridDuty_CellClick);
            this.DbGridDuty.SelectionChanged += new System.EventHandler(this.DbGridDuty_SelectionChanged);
            // 
            // ColDate
            // 
            this.ColDate.DataPropertyName = "M_Date";
            this.ColDate.HeaderText = "日期";
            this.ColDate.Name = "ColDate";
            this.ColDate.ReadOnly = true;
            // 
            // ColID
            // 
            this.ColID.DataPropertyName = "M_DutyID";
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            this.ColID.Visible = false;
            // 
            // ColName
            // 
            this.ColName.DataPropertyName = "M_Name";
            this.ColName.HeaderText = "姓名";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            // 
            // ColPosit
            // 
            this.ColPosit.DataPropertyName = "M_Deputy";
            this.ColPosit.HeaderText = "职务";
            this.ColPosit.Name = "ColPosit";
            this.ColPosit.ReadOnly = true;
            // 
            // ColTel
            // 
            this.ColTel.DataPropertyName = "M_TelNo";
            this.ColTel.HeaderText = "移动电话";
            this.ColTel.Name = "ColTel";
            this.ColTel.ReadOnly = true;
            // 
            // ColFTel
            // 
            this.ColFTel.DataPropertyName = "M_Phone";
            this.ColFTel.HeaderText = "固定电话";
            this.ColFTel.Name = "ColFTel";
            this.ColFTel.ReadOnly = true;
            // 
            // ColInTel
            // 
            this.ColInTel.DataPropertyName = "M_InerPhone";
            this.ColInTel.HeaderText = "内部电话";
            this.ColInTel.Name = "ColInTel";
            this.ColInTel.ReadOnly = true;
            // 
            // ColMonth
            // 
            this.ColMonth.DataPropertyName = "M_Month";
            this.ColMonth.HeaderText = "月份";
            this.ColMonth.Name = "ColMonth";
            this.ColMonth.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smItemDel});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            // 
            // smItemDel
            // 
            this.smItemDel.Name = "smItemDel";
            this.smItemDel.Size = new System.Drawing.Size(124, 22);
            this.smItemDel.Text = "删除值班";
            this.smItemDel.Click += new System.EventHandler(this.tlBtnDel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(345, 575);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlBtnModify,
            this.toolStripSeparator1,
            this.tlBtnDel,
            this.toolStripSeparator2,
            this.tlBtnClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.MinimumSize = new System.Drawing.Size(0, 40);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(700, 40);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // ofDlgExcel
            // 
            this.ofDlgExcel.FileName = "openFileDialog1";
            this.ofDlgExcel.Filter = "Excel文件 (*.xls; *.xlsx)|*.xls; *.xlsx";
            this.ofDlgExcel.Title = "请选择Excel文档";
            // 
            // dsDuty
            // 
            this.dsDuty.DataSetName = "NewDataSet";
            // 
            // BtnExcel
            // 
            this.BtnExcel.BackColor = System.Drawing.SystemColors.Control;
            this.BtnExcel.Image = global::AreaCount.Properties.Resources.导入;
            this.BtnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExcel.Location = new System.Drawing.Point(246, 384);
            this.BtnExcel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.Size = new System.Drawing.Size(92, 40);
            this.BtnExcel.TabIndex = 20;
            this.BtnExcel.Text = "导入";
            this.BtnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExcel.UseVisualStyleBackColor = false;
            this.BtnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // BtnImport
            // 
            this.BtnImport.BackColor = System.Drawing.SystemColors.Control;
            this.BtnImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnImport.CausesValidation = false;
            this.BtnImport.Image = global::AreaCount.Properties.Resources.保存;
            this.BtnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnImport.Location = new System.Drawing.Point(246, 453);
            this.BtnImport.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(92, 40);
            this.BtnImport.TabIndex = 19;
            this.BtnImport.Text = "保存";
            this.BtnImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnImport.UseVisualStyleBackColor = false;
            this.BtnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSave.Image = global::AreaCount.Properties.Resources.保存;
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.Location = new System.Drawing.Point(109, 313);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(94, 40);
            this.BtnSave.TabIndex = 14;
            this.BtnSave.Text = "保存";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Visible = false;
            this.BtnSave.Click += new System.EventHandler(this.tlBtnModify_Click);
            // 
            // tlBtnModify
            // 
            this.tlBtnModify.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tlBtnModify.Image = global::AreaCount.Properties.Resources.修改;
            this.tlBtnModify.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlBtnModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlBtnModify.Name = "tlBtnModify";
            this.tlBtnModify.Size = new System.Drawing.Size(112, 37);
            this.tlBtnModify.Text = "修改值班";
            this.tlBtnModify.Click += new System.EventHandler(this.tlBtnModify_Click);
            // 
            // tlBtnDel
            // 
            this.tlBtnDel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tlBtnDel.Image = global::AreaCount.Properties.Resources.删除;
            this.tlBtnDel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlBtnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlBtnDel.Name = "tlBtnDel";
            this.tlBtnDel.Size = new System.Drawing.Size(110, 37);
            this.tlBtnDel.Text = "删除值班";
            this.tlBtnDel.Click += new System.EventHandler(this.tlBtnDel_Click);
            // 
            // tlBtnClose
            // 
            this.tlBtnClose.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tlBtnClose.Image = global::AreaCount.Properties.Resources.返回;
            this.tlBtnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlBtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlBtnClose.Name = "tlBtnClose";
            this.tlBtnClose.Size = new System.Drawing.Size(78, 37);
            this.tlBtnClose.Text = "返回";
            this.tlBtnClose.Click += new System.EventHandler(this.tlBtnClose_Click);
            // 
            // FrmDuty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(700, 609);
            this.Controls.Add(this.spDuty);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmDuty";
            this.Text = "值班管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.FrmDuty_Shown);
            this.spDuty.Panel1.ResumeLayout(false);
            this.spDuty.Panel1.PerformLayout();
            this.spDuty.Panel2.ResumeLayout(false);
            this.spDuty.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spDuty)).EndInit();
            this.spDuty.ResumeLayout(false);
            this.gBoxInfo.ResumeLayout(false);
            this.gBoxInfo.PerformLayout();
            this.gBoxDuty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DbGridDuty)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDuty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer spDuty;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gBoxDuty;
        private System.Windows.Forms.DataGridView DbGridDuty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBoxInerPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBoxPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxTel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxDeputy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tlBtnModify;
        private System.Windows.Forms.ToolStripButton tlBtnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tlBtnClose;
        private System.Windows.Forms.TextBox tBoxExcel;
        private System.Windows.Forms.ComboBox cmBoxMonth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gBoxInfo;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.OpenFileDialog ofDlgExcel;
        private System.Windows.Forms.Button BtnImport;
        private System.Data.DataSet dsDuty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPosit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColInTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMonth;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem smItemDel;
        private System.Windows.Forms.Button BtnExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}