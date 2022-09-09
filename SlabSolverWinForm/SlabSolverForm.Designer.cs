using System.Windows.Forms;

namespace SlabSolverWinForm
{
    partial class SlabSolverForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ntbxSpan = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbxSLS_QPER = new System.Windows.Forms.TextBox();
            this.tbxSLS_FREQ = new System.Windows.Forms.TextBox();
            this.tbxSLS_CHAR = new System.Windows.Forms.TextBox();
            this.tbxULS_GEO = new System.Windows.Forms.TextBox();
            this.tbxULS_STRB = new System.Windows.Forms.TextBox();
            this.tbxULS_STRA = new System.Windows.Forms.TextBox();
            this.tbxULS_STR = new System.Windows.Forms.TextBox();
            this.tbxULS_EQU = new System.Windows.Forms.TextBox();
            this.label109a = new System.Windows.Forms.Label();
            this.label110a = new System.Windows.Forms.Label();
            this.label111a = new System.Windows.Forms.Label();
            this.label104 = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.label109 = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.label106 = new System.Windows.Forms.Label();
            this.label110 = new System.Windows.Forms.Label();
            this.label104a = new System.Windows.Forms.Label();
            this.label108a = new System.Windows.Forms.Label();
            this.label105a = new System.Windows.Forms.Label();
            this.label107a = new System.Windows.Forms.Label();
            this.label106a = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbLoadType = new System.Windows.Forms.ComboBox();
            this.tbxLoadValue = new System.Windows.Forms.TextBox();
            this.label103 = new System.Windows.Forms.Label();
            this.btnAddLoad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudSpan = new System.Windows.Forms.NumericUpDown();
            this.label101 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.dgvLoads = new System.Windows.Forms.DataGridView();
            this.LoadGUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoadTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoadValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ntbxEffect = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbxMeqper = new System.Windows.Forms.TextBox();
            this.label205a = new System.Windows.Forms.Label();
            this.tbxMefreq = new System.Windows.Forms.TextBox();
            this.label204a = new System.Windows.Forms.Label();
            this.tbxMed = new System.Windows.Forms.TextBox();
            this.label203a = new System.Windows.Forms.Label();
            this.tbxMrd = new System.Windows.Forms.TextBox();
            this.label202a = new System.Windows.Forms.Label();
            this.tbxVrd = new System.Windows.Forms.TextBox();
            this.label201a = new System.Windows.Forms.Label();
            this.label205 = new System.Windows.Forms.Label();
            this.label204 = new System.Windows.Forms.Label();
            this.label203 = new System.Windows.Forms.Label();
            this.label202 = new System.Windows.Forms.Label();
            this.label201 = new System.Windows.Forms.Label();
            this.cmbSlabsTypes = new System.Windows.Forms.ComboBox();
            this.dgvSlabs = new System.Windows.Forms.DataGridView();
            this.SlabGUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Signature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbFireResistant = new System.Windows.Forms.ComboBox();
            this.cmbExposure = new System.Windows.Forms.ComboBox();
            this.GUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoadType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnPrint = new System.Windows.Forms.Button();
            this.reportDocument = new System.Drawing.Printing.PrintDocument();
            this.tabControl1.SuspendLayout();
            this.ntbxSpan.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoads)).BeginInit();
            this.ntbxEffect.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlabs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ntbxSpan);
            this.tabControl1.Controls.Add(this.ntbxEffect);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(677, 348);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // ntbxSpan
            // 
            this.ntbxSpan.Controls.Add(this.groupBox3);
            this.ntbxSpan.Controls.Add(this.groupBox2);
            this.ntbxSpan.Controls.Add(this.groupBox1);
            this.ntbxSpan.Controls.Add(this.dgvLoads);
            this.ntbxSpan.Location = new System.Drawing.Point(4, 24);
            this.ntbxSpan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ntbxSpan.Name = "ntbxSpan";
            this.ntbxSpan.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ntbxSpan.Size = new System.Drawing.Size(669, 320);
            this.ntbxSpan.TabIndex = 0;
            this.ntbxSpan.Text = "Obciążenie równomierne przęsło";
            this.ntbxSpan.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbxSLS_QPER);
            this.groupBox3.Controls.Add(this.tbxSLS_FREQ);
            this.groupBox3.Controls.Add(this.tbxSLS_CHAR);
            this.groupBox3.Controls.Add(this.tbxULS_GEO);
            this.groupBox3.Controls.Add(this.tbxULS_STRB);
            this.groupBox3.Controls.Add(this.tbxULS_STRA);
            this.groupBox3.Controls.Add(this.tbxULS_STR);
            this.groupBox3.Controls.Add(this.tbxULS_EQU);
            this.groupBox3.Controls.Add(this.label109a);
            this.groupBox3.Controls.Add(this.label110a);
            this.groupBox3.Controls.Add(this.label111a);
            this.groupBox3.Controls.Add(this.label104);
            this.groupBox3.Controls.Add(this.label108);
            this.groupBox3.Controls.Add(this.label109);
            this.groupBox3.Controls.Add(this.label111);
            this.groupBox3.Controls.Add(this.label105);
            this.groupBox3.Controls.Add(this.label107);
            this.groupBox3.Controls.Add(this.label106);
            this.groupBox3.Controls.Add(this.label110);
            this.groupBox3.Controls.Add(this.label104a);
            this.groupBox3.Controls.Add(this.label108a);
            this.groupBox3.Controls.Add(this.label105a);
            this.groupBox3.Controls.Add(this.label107a);
            this.groupBox3.Controls.Add(this.label106a);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(4, 156);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(661, 161);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            // 
            // tbxSLS_QPER
            // 
            this.tbxSLS_QPER.Enabled = false;
            this.tbxSLS_QPER.Location = new System.Drawing.Point(303, 70);
            this.tbxSLS_QPER.Name = "tbxSLS_QPER";
            this.tbxSLS_QPER.Size = new System.Drawing.Size(84, 23);
            this.tbxSLS_QPER.TabIndex = 36;
            this.tbxSLS_QPER.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxSLS_FREQ
            // 
            this.tbxSLS_FREQ.Enabled = false;
            this.tbxSLS_FREQ.Location = new System.Drawing.Point(303, 41);
            this.tbxSLS_FREQ.Name = "tbxSLS_FREQ";
            this.tbxSLS_FREQ.Size = new System.Drawing.Size(84, 23);
            this.tbxSLS_FREQ.TabIndex = 35;
            this.tbxSLS_FREQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxSLS_CHAR
            // 
            this.tbxSLS_CHAR.Enabled = false;
            this.tbxSLS_CHAR.Location = new System.Drawing.Point(303, 12);
            this.tbxSLS_CHAR.Name = "tbxSLS_CHAR";
            this.tbxSLS_CHAR.Size = new System.Drawing.Size(84, 23);
            this.tbxSLS_CHAR.TabIndex = 34;
            this.tbxSLS_CHAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxULS_GEO
            // 
            this.tbxULS_GEO.Enabled = false;
            this.tbxULS_GEO.Location = new System.Drawing.Point(85, 128);
            this.tbxULS_GEO.Name = "tbxULS_GEO";
            this.tbxULS_GEO.Size = new System.Drawing.Size(84, 23);
            this.tbxULS_GEO.TabIndex = 33;
            this.tbxULS_GEO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxULS_STRB
            // 
            this.tbxULS_STRB.Enabled = false;
            this.tbxULS_STRB.Location = new System.Drawing.Point(85, 99);
            this.tbxULS_STRB.Name = "tbxULS_STRB";
            this.tbxULS_STRB.Size = new System.Drawing.Size(84, 23);
            this.tbxULS_STRB.TabIndex = 32;
            this.tbxULS_STRB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxULS_STRA
            // 
            this.tbxULS_STRA.Enabled = false;
            this.tbxULS_STRA.Location = new System.Drawing.Point(85, 70);
            this.tbxULS_STRA.Name = "tbxULS_STRA";
            this.tbxULS_STRA.Size = new System.Drawing.Size(84, 23);
            this.tbxULS_STRA.TabIndex = 31;
            this.tbxULS_STRA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxULS_STR
            // 
            this.tbxULS_STR.Enabled = false;
            this.tbxULS_STR.Location = new System.Drawing.Point(85, 41);
            this.tbxULS_STR.Name = "tbxULS_STR";
            this.tbxULS_STR.Size = new System.Drawing.Size(84, 23);
            this.tbxULS_STR.TabIndex = 30;
            this.tbxULS_STR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxULS_EQU
            // 
            this.tbxULS_EQU.Enabled = false;
            this.tbxULS_EQU.Location = new System.Drawing.Point(85, 12);
            this.tbxULS_EQU.Name = "tbxULS_EQU";
            this.tbxULS_EQU.Size = new System.Drawing.Size(84, 23);
            this.tbxULS_EQU.TabIndex = 29;
            this.tbxULS_EQU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label109a
            // 
            this.label109a.Location = new System.Drawing.Point(382, 16);
            this.label109a.Name = "label109a";
            this.label109a.Size = new System.Drawing.Size(30, 15);
            this.label109a.TabIndex = 26;
            this.label109a.Text = "kPa";
            this.label109a.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label110a
            // 
            this.label110a.Location = new System.Drawing.Point(382, 45);
            this.label110a.Name = "label110a";
            this.label110a.Size = new System.Drawing.Size(30, 15);
            this.label110a.TabIndex = 27;
            this.label110a.Text = "kPa";
            this.label110a.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label111a
            // 
            this.label111a.Location = new System.Drawing.Point(382, 74);
            this.label111a.Name = "label111a";
            this.label111a.Size = new System.Drawing.Size(30, 15);
            this.label111a.TabIndex = 28;
            this.label111a.Text = "kPa";
            this.label111a.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Location = new System.Drawing.Point(12, 16);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(61, 15);
            this.label104.TabIndex = 18;
            this.label104.Text = "ULS EQU=";
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Location = new System.Drawing.Point(12, 132);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(61, 15);
            this.label108.TabIndex = 22;
            this.label108.Text = "ULS GEO=";
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Location = new System.Drawing.Point(229, 15);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(68, 15);
            this.label109.TabIndex = 23;
            this.label109.Text = "SLS CHAR=";
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(229, 74);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(65, 15);
            this.label111.TabIndex = 25;
            this.label111.Text = "SLS QPER=";
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Location = new System.Drawing.Point(12, 45);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(58, 15);
            this.label105.TabIndex = 19;
            this.label105.Text = "ULS STR=";
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Location = new System.Drawing.Point(12, 103);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(73, 15);
            this.label107.TabIndex = 20;
            this.label107.Text = "ULS STR(b)=";
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Location = new System.Drawing.Point(12, 74);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(72, 15);
            this.label106.TabIndex = 21;
            this.label106.Text = "ULS STR(a)=";
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Location = new System.Drawing.Point(229, 44);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(64, 15);
            this.label110.TabIndex = 24;
            this.label110.Text = "SLS FREQ=";
            // 
            // label104a
            // 
            this.label104a.Location = new System.Drawing.Point(164, 16);
            this.label104a.Name = "label104a";
            this.label104a.Size = new System.Drawing.Size(30, 15);
            this.label104a.TabIndex = 10;
            this.label104a.Text = "kPa";
            this.label104a.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label108a
            // 
            this.label108a.Location = new System.Drawing.Point(164, 132);
            this.label108a.Name = "label108a";
            this.label108a.Size = new System.Drawing.Size(30, 15);
            this.label108a.TabIndex = 14;
            this.label108a.Text = "kPa";
            this.label108a.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label105a
            // 
            this.label105a.Location = new System.Drawing.Point(164, 45);
            this.label105a.Name = "label105a";
            this.label105a.Size = new System.Drawing.Size(30, 15);
            this.label105a.TabIndex = 11;
            this.label105a.Text = "kPa";
            this.label105a.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label107a
            // 
            this.label107a.Location = new System.Drawing.Point(164, 103);
            this.label107a.Name = "label107a";
            this.label107a.Size = new System.Drawing.Size(30, 15);
            this.label107a.TabIndex = 12;
            this.label107a.Text = "kPa";
            this.label107a.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label106a
            // 
            this.label106a.Location = new System.Drawing.Point(164, 74);
            this.label106a.Name = "label106a";
            this.label106a.Size = new System.Drawing.Size(30, 15);
            this.label106a.TabIndex = 13;
            this.label106a.Text = "kPa";
            this.label106a.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.cmbLoadType);
            this.groupBox2.Controls.Add(this.tbxLoadValue);
            this.groupBox2.Controls.Add(this.label103);
            this.groupBox2.Controls.Add(this.btnAddLoad);
            this.groupBox2.Location = new System.Drawing.Point(7, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 84);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // cmbLoadType
            // 
            this.cmbLoadType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoadType.FormattingEnabled = true;
            this.cmbLoadType.Location = new System.Drawing.Point(9, 22);
            this.cmbLoadType.Name = "cmbLoadType";
            this.cmbLoadType.Size = new System.Drawing.Size(239, 23);
            this.cmbLoadType.TabIndex = 5;
            // 
            // tbxLoadValue
            // 
            this.tbxLoadValue.Location = new System.Drawing.Point(9, 51);
            this.tbxLoadValue.Name = "tbxLoadValue";
            this.tbxLoadValue.Size = new System.Drawing.Size(83, 23);
            this.tbxLoadValue.TabIndex = 6;
            this.tbxLoadValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxLoadValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLoadValue_KeyPress);
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Location = new System.Drawing.Point(100, 54);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(26, 15);
            this.label103.TabIndex = 7;
            this.label103.Text = "kPa";
            // 
            // btnAddLoad
            // 
            this.btnAddLoad.Location = new System.Drawing.Point(132, 51);
            this.btnAddLoad.Name = "btnAddLoad";
            this.btnAddLoad.Size = new System.Drawing.Size(116, 23);
            this.btnAddLoad.TabIndex = 9;
            this.btnAddLoad.Text = "Dodaj";
            this.btnAddLoad.UseVisualStyleBackColor = true;
            this.btnAddLoad.Click += new System.EventHandler(this.btnAddLoad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudSpan);
            this.groupBox1.Controls.Add(this.label101);
            this.groupBox1.Controls.Add(this.label102);
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 57);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // nudSpan
            // 
            this.nudSpan.Location = new System.Drawing.Point(123, 22);
            this.nudSpan.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudSpan.Name = "nudSpan";
            this.nudSpan.Size = new System.Drawing.Size(77, 23);
            this.nudSpan.TabIndex = 4;
            this.nudSpan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Location = new System.Drawing.Point(14, 24);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(103, 15);
            this.label101.TabIndex = 1;
            this.label101.Text = "Rozpiętość przęsła";
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Location = new System.Drawing.Point(206, 28);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(24, 15);
            this.label102.TabIndex = 3;
            this.label102.Text = "cm";
            // 
            // dgvLoads
            // 
            this.dgvLoads.AllowUserToAddRows = false;
            this.dgvLoads.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLoads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoads.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoadGUID,
            this.LoadTypeColumn,
            this.LoadValueColumn});
            this.dgvLoads.Location = new System.Drawing.Point(264, 0);
            this.dgvLoads.MultiSelect = false;
            this.dgvLoads.Name = "dgvLoads";
            this.dgvLoads.ReadOnly = true;
            this.dgvLoads.RowHeadersVisible = false;
            this.dgvLoads.RowTemplate.Height = 25;
            this.dgvLoads.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvLoads.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoads.Size = new System.Drawing.Size(413, 150);
            this.dgvLoads.TabIndex = 8;
            // 
            // LoadGUID
            // 
            this.LoadGUID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.LoadGUID.HeaderText = "GUID";
            this.LoadGUID.Name = "LoadGUID";
            this.LoadGUID.ReadOnly = true;
            this.LoadGUID.Visible = false;
            // 
            // LoadTypeColumn
            // 
            this.LoadTypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LoadTypeColumn.HeaderText = "Rodzaj obciążenia";
            this.LoadTypeColumn.Name = "LoadTypeColumn";
            this.LoadTypeColumn.ReadOnly = true;
            // 
            // LoadValueColumn
            // 
            this.LoadValueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.LoadValueColumn.HeaderText = "Wartość [kPa]";
            this.LoadValueColumn.Name = "LoadValueColumn";
            this.LoadValueColumn.ReadOnly = true;
            this.LoadValueColumn.Width = 110;
            // 
            // ntbxEffect
            // 
            this.ntbxEffect.Controls.Add(this.groupBox4);
            this.ntbxEffect.Location = new System.Drawing.Point(4, 24);
            this.ntbxEffect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ntbxEffect.Name = "ntbxEffect";
            this.ntbxEffect.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ntbxEffect.Size = new System.Drawing.Size(669, 320);
            this.ntbxEffect.TabIndex = 1;
            this.ntbxEffect.Text = "Efekty oddziaływań";
            this.ntbxEffect.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbxMeqper);
            this.groupBox4.Controls.Add(this.label205a);
            this.groupBox4.Controls.Add(this.tbxMefreq);
            this.groupBox4.Controls.Add(this.label204a);
            this.groupBox4.Controls.Add(this.tbxMed);
            this.groupBox4.Controls.Add(this.label203a);
            this.groupBox4.Controls.Add(this.tbxMrd);
            this.groupBox4.Controls.Add(this.label202a);
            this.groupBox4.Controls.Add(this.tbxVrd);
            this.groupBox4.Controls.Add(this.label201a);
            this.groupBox4.Controls.Add(this.label205);
            this.groupBox4.Controls.Add(this.label204);
            this.groupBox4.Controls.Add(this.label203);
            this.groupBox4.Controls.Add(this.label202);
            this.groupBox4.Controls.Add(this.label201);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(661, 314);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Efekty oddziaływań przypadające na jedną płytę";
            // 
            // tbxMeqper
            // 
            this.tbxMeqper.Location = new System.Drawing.Point(375, 138);
            this.tbxMeqper.Name = "tbxMeqper";
            this.tbxMeqper.Size = new System.Drawing.Size(83, 23);
            this.tbxMeqper.TabIndex = 16;
            this.tbxMeqper.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxMeqper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLoadValue_KeyPress);
            // 
            // label205a
            // 
            this.label205a.AutoSize = true;
            this.label205a.Location = new System.Drawing.Point(466, 141);
            this.label205a.Name = "label205a";
            this.label205a.Size = new System.Drawing.Size(33, 15);
            this.label205a.TabIndex = 17;
            this.label205a.Text = "kNm";
            // 
            // tbxMefreq
            // 
            this.tbxMefreq.Location = new System.Drawing.Point(375, 109);
            this.tbxMefreq.Name = "tbxMefreq";
            this.tbxMefreq.Size = new System.Drawing.Size(83, 23);
            this.tbxMefreq.TabIndex = 14;
            this.tbxMefreq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxMefreq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLoadValue_KeyPress);
            // 
            // label204a
            // 
            this.label204a.AutoSize = true;
            this.label204a.Location = new System.Drawing.Point(466, 112);
            this.label204a.Name = "label204a";
            this.label204a.Size = new System.Drawing.Size(33, 15);
            this.label204a.TabIndex = 15;
            this.label204a.Text = "kNm";
            // 
            // tbxMed
            // 
            this.tbxMed.Location = new System.Drawing.Point(375, 80);
            this.tbxMed.Name = "tbxMed";
            this.tbxMed.Size = new System.Drawing.Size(83, 23);
            this.tbxMed.TabIndex = 12;
            this.tbxMed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxMed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLoadValue_KeyPress);
            // 
            // label203a
            // 
            this.label203a.AutoSize = true;
            this.label203a.Location = new System.Drawing.Point(466, 83);
            this.label203a.Name = "label203a";
            this.label203a.Size = new System.Drawing.Size(33, 15);
            this.label203a.TabIndex = 13;
            this.label203a.Text = "kNm";
            // 
            // tbxMrd
            // 
            this.tbxMrd.Location = new System.Drawing.Point(375, 51);
            this.tbxMrd.Name = "tbxMrd";
            this.tbxMrd.Size = new System.Drawing.Size(83, 23);
            this.tbxMrd.TabIndex = 10;
            this.tbxMrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxMrd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLoadValue_KeyPress);
            // 
            // label202a
            // 
            this.label202a.AutoSize = true;
            this.label202a.Location = new System.Drawing.Point(466, 54);
            this.label202a.Name = "label202a";
            this.label202a.Size = new System.Drawing.Size(33, 15);
            this.label202a.TabIndex = 11;
            this.label202a.Text = "kNm";
            // 
            // tbxVrd
            // 
            this.tbxVrd.Location = new System.Drawing.Point(375, 22);
            this.tbxVrd.Name = "tbxVrd";
            this.tbxVrd.Size = new System.Drawing.Size(83, 23);
            this.tbxVrd.TabIndex = 8;
            this.tbxVrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxVrd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLoadValue_KeyPress);
            // 
            // label201a
            // 
            this.label201a.AutoSize = true;
            this.label201a.Location = new System.Drawing.Point(466, 25);
            this.label201a.Name = "label201a";
            this.label201a.Size = new System.Drawing.Size(22, 15);
            this.label201a.TabIndex = 9;
            this.label201a.Text = "kN";
            // 
            // label205
            // 
            this.label205.AutoSize = true;
            this.label205.Location = new System.Drawing.Point(6, 141);
            this.label205.Name = "label205";
            this.label205.Size = new System.Drawing.Size(346, 15);
            this.label205.TabIndex = 4;
            this.label205.Text = "Charakterystyczny moment zginający dla kombinacji quasi stałej";
            // 
            // label204
            // 
            this.label204.AutoSize = true;
            this.label204.Location = new System.Drawing.Point(6, 112);
            this.label204.Name = "label204";
            this.label204.Size = new System.Drawing.Size(323, 15);
            this.label204.TabIndex = 3;
            this.label204.Text = "Charakterystyczny moment zginający dla kombinacji częstej";
            // 
            // label203
            // 
            this.label203.AutoSize = true;
            this.label203.Location = new System.Drawing.Point(6, 83);
            this.label203.Name = "label203";
            this.label203.Size = new System.Drawing.Size(204, 15);
            this.label203.TabIndex = 2;
            this.label203.Text = "Charakterystyczny moment zginający";
            // 
            // label202
            // 
            this.label202.AutoSize = true;
            this.label202.Location = new System.Drawing.Point(6, 54);
            this.label202.Name = "label202";
            this.label202.Size = new System.Drawing.Size(179, 15);
            this.label202.TabIndex = 1;
            this.label202.Text = "Obliczeniowy moment zginający";
            // 
            // label201
            // 
            this.label201.AutoSize = true;
            this.label201.Location = new System.Drawing.Point(6, 25);
            this.label201.Name = "label201";
            this.label201.Size = new System.Drawing.Size(161, 15);
            this.label201.TabIndex = 0;
            this.label201.Text = "Obliczeniowa siła poprzeczna";
            // 
            // cmbSlabsTypes
            // 
            this.cmbSlabsTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSlabsTypes.FormattingEnabled = true;
            this.cmbSlabsTypes.Location = new System.Drawing.Point(12, 12);
            this.cmbSlabsTypes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbSlabsTypes.Name = "cmbSlabsTypes";
            this.cmbSlabsTypes.Size = new System.Drawing.Size(339, 23);
            this.cmbSlabsTypes.TabIndex = 1;
            // 
            // dgvSlabs
            // 
            this.dgvSlabs.AllowUserToAddRows = false;
            this.dgvSlabs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSlabs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SlabGUID,
            this.Signature,
            this.Capacity});
            this.dgvSlabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSlabs.Location = new System.Drawing.Point(0, 0);
            this.dgvSlabs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvSlabs.Name = "dgvSlabs";
            this.dgvSlabs.ReadOnly = true;
            this.dgvSlabs.RowHeadersVisible = false;
            this.dgvSlabs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSlabs.Size = new System.Drawing.Size(677, 208);
            this.dgvSlabs.TabIndex = 1;
            // 
            // SlabGUID
            // 
            this.SlabGUID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SlabGUID.HeaderText = "GUID";
            this.SlabGUID.Name = "SlabGUID";
            this.SlabGUID.ReadOnly = true;
            this.SlabGUID.Visible = false;
            // 
            // Signature
            // 
            this.Signature.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Signature.HeaderText = "Sygnatura płyty stropowej";
            this.Signature.Name = "Signature";
            this.Signature.ReadOnly = true;
            // 
            // Capacity
            // 
            this.Capacity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Capacity.HeaderText = "Wytężenie [%]";
            this.Capacity.Name = "Capacity";
            this.Capacity.ReadOnly = true;
            this.Capacity.Width = 110;
            // 
            // cmbFireResistant
            // 
            this.cmbFireResistant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFireResistant.FormattingEnabled = true;
            this.cmbFireResistant.Location = new System.Drawing.Point(12, 41);
            this.cmbFireResistant.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbFireResistant.Name = "cmbFireResistant";
            this.cmbFireResistant.Size = new System.Drawing.Size(95, 23);
            this.cmbFireResistant.TabIndex = 3;
            // 
            // cmbExposure
            // 
            this.cmbExposure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExposure.FormattingEnabled = true;
            this.cmbExposure.Location = new System.Drawing.Point(116, 41);
            this.cmbExposure.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbExposure.Name = "cmbExposure";
            this.cmbExposure.Size = new System.Drawing.Size(113, 23);
            this.cmbExposure.TabIndex = 5;
            // 
            // GUID
            // 
            this.GUID.HeaderText = "GUID";
            this.GUID.Name = "GUID";
            this.GUID.Visible = false;
            // 
            // LoadType
            // 
            this.LoadType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LoadType.HeaderText = "Rodzaj obciążenia";
            this.LoadType.Name = "LoadType";
            this.LoadType.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "GUID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(0, 70);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel1MinSize = 350;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvSlabs);
            this.splitContainer1.Size = new System.Drawing.Size(679, 570);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 7;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Image = global::SlabSolverWinForm.Properties.Resources.printer;
            this.btnPrint.Location = new System.Drawing.Point(582, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(92, 52);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // reportDocument
            // 
            this.reportDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.reportDocument_PrintPage);
            // 
            // SlabSolverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 637);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.cmbExposure);
            this.Controls.Add(this.cmbFireResistant);
            this.Controls.Add(this.cmbSlabsTypes);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(684, 587);
            this.Name = "SlabSolverForm";
            this.Text = "Slab Solver";
            this.Load += new System.EventHandler(this.Solver_Load);
            this.Resize += new System.EventHandler(this.SlabSolverForm_Resize);
            this.tabControl1.ResumeLayout(false);
            this.ntbxSpan.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoads)).EndInit();
            this.ntbxEffect.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlabs)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ntbxSpan;
        private System.Windows.Forms.TabPage ntbxEffect;
        private System.Windows.Forms.DataGridView dgvSlabs;
        private System.Windows.Forms.ComboBox cmbSlabsTypes;
        private ComboBox cmbFireResistant;
        private NumericUpDown nudSpan;
        private Label label102;
        private Label label101;
        private ComboBox cmbExposure;
        private Label label103;
        private TextBox tbxLoadValue;
        private ComboBox cmbLoadType;
        private DataGridView dgvLoads;
        private Button btnAddLoad;
        private DataGridViewTextBoxColumn GUID;
        private DataGridViewTextBoxColumn LoadType;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn LoadGUID;
        private DataGridViewTextBoxColumn LoadTypeColumn;
        private DataGridViewTextBoxColumn LoadValueColumn;
        private DataGridViewTextBoxColumn SlabGUID;
        private DataGridViewTextBoxColumn Signature;
        private DataGridViewTextBoxColumn Capacity;
        private Label label108a;
        private Label label106a;
        private Label label107a;
        private Label label105a;
        private Label label104a;
        private SplitContainer splitContainer1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private Label label203;
        private Label label202;
        private Label label201;
        private TextBox tbxMeqper;
        private Label label205a;
        private TextBox tbxMefreq;
        private Label label204a;
        private TextBox tbxMed;
        private Label label203a;
        private TextBox tbxMrd;
        private Label label202a;
        private TextBox tbxVrd;
        private Label label201a;
        private Label label205;
        private Label label204;
        private Label label104;
        private Label label108;
        private Label label109;
        private Label label111;
        private Label label105;
        private Label label107;
        private Label label106;
        private Label label110;
        private TextBox tbxULS_EQU;
        private Label label109a;
        private Label label110a;
        private Label label111a;
        private TextBox tbxULS_GEO;
        private TextBox tbxULS_STRB;
        private TextBox tbxULS_STRA;
        private TextBox tbxULS_STR;
        private TextBox tbxSLS_QPER;
        private TextBox tbxSLS_FREQ;
        private TextBox tbxSLS_CHAR;
        private Button btnPrint;
        private System.Drawing.Printing.PrintDocument reportDocument;
    }
}

