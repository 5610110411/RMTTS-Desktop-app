using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace MaterialSkinExample
{
    partial class MainForm
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
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lb_timeTag = new System.Windows.Forms.Label();
            this.lb_dateTime = new System.Windows.Forms.Label();
            this.lb_tp_vehicle = new System.Windows.Forms.Label();
            this.bt_toSting = new MaterialSkin.Controls.MaterialRaisedButton();
            this.bt_toString = new MaterialSkin.Controls.MaterialRaisedButton();
            this.bt_saveData = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textResponse = new System.Windows.Forms.TextBox();
            this.readKey = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.readNum = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.readStart = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.readKeyA = new System.Windows.Forms.RadioButton();
            this.readKeyB = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.readIdle = new System.Windows.Forms.RadioButton();
            this.readAll = new System.Windows.Forms.RadioButton();
            this.bt_readRfid = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialSingleLineTextField11 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label10 = new System.Windows.Forms.Label();
            this.materialSingleLineTextField9 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_tp_material = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label9 = new System.Windows.Forms.Label();
            this.materialSingleLineTextField6 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_tp_station = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.materialSingleLineTextField7 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView_transport = new System.Windows.Forms.DataGridView();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.materialSingleLineTextField3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label4 = new System.Windows.Forms.Label();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label_setdatabase = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_setportrfid = new System.Windows.Forms.Label();
            this.tbtransportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rMTTSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rMTTSDataSet = new MaterialSkinExample.RMTTSDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_statusNow = new System.Windows.Forms.Label();
            this.tb_transportsTableAdapter = new MaterialSkinExample.RMTTSDataSetTableAdapters.tb_transportsTableAdapter();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_transport)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbtransportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMTTSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMTTSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(0, 514);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(0);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(841, 1);
            this.materialDivider1.TabIndex = 16;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(841, 48);
            this.materialTabSelector1.TabIndex = 17;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(14, 111);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(800, 391);
            this.materialTabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 365);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "เริ่มต้น";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(70, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(516, 56);
            this.label2.TabIndex = 20;
            this.label2.Text = "โปรแกรมจัดการการขนส่งวัตถุดิบ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(206, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 56);
            this.label1.TabIndex = 19;
            this.label1.Text = "ยินดีต้อนรับสู่";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.lb_timeTag);
            this.tabPage2.Controls.Add(this.lb_dateTime);
            this.tabPage2.Controls.Add(this.lb_tp_vehicle);
            this.tabPage2.Controls.Add(this.bt_toSting);
            this.tabPage2.Controls.Add(this.bt_toString);
            this.tabPage2.Controls.Add(this.bt_saveData);
            this.tabPage2.Controls.Add(this.textResponse);
            this.tabPage2.Controls.Add(this.readKey);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.readNum);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.readStart);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.bt_readRfid);
            this.tabPage2.Controls.Add(this.materialSingleLineTextField11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.materialSingleLineTextField9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txt_tp_material);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.materialSingleLineTextField6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txt_tp_station);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label_name);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 365);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ข้อมูลการขนส่ง";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // lb_timeTag
            // 
            this.lb_timeTag.AutoSize = true;
            this.lb_timeTag.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timeTag.Location = new System.Drawing.Point(6, 219);
            this.lb_timeTag.Name = "lb_timeTag";
            this.lb_timeTag.Size = new System.Drawing.Size(142, 32);
            this.lb_timeTag.TabIndex = 28;
            this.lb_timeTag.Text = "เวลาทำรายการ";
            // 
            // lb_dateTime
            // 
            this.lb_dateTime.AutoSize = true;
            this.lb_dateTime.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dateTime.ForeColor = System.Drawing.Color.Silver;
            this.lb_dateTime.Location = new System.Drawing.Point(194, 223);
            this.lb_dateTime.Name = "lb_dateTime";
            this.lb_dateTime.Size = new System.Drawing.Size(103, 28);
            this.lb_dateTime.TabIndex = 27;
            this.lb_dateTime.Text = "Date time";
            // 
            // lb_tp_vehicle
            // 
            this.lb_tp_vehicle.AutoSize = true;
            this.lb_tp_vehicle.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tp_vehicle.ForeColor = System.Drawing.Color.Silver;
            this.lb_tp_vehicle.Location = new System.Drawing.Point(194, 7);
            this.lb_tp_vehicle.Name = "lb_tp_vehicle";
            this.lb_tp_vehicle.Size = new System.Drawing.Size(118, 28);
            this.lb_tp_vehicle.TabIndex = 26;
            this.lb_tp_vehicle.Text = "Car license";
            this.lb_tp_vehicle.Click += new System.EventHandler(this.lb_tp_vehicle_Click);
            // 
            // bt_toSting
            // 
            this.bt_toSting.Depth = 0;
            this.bt_toSting.Location = new System.Drawing.Point(587, 285);
            this.bt_toSting.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_toSting.Name = "bt_toSting";
            this.bt_toSting.Primary = true;
            this.bt_toSting.Size = new System.Drawing.Size(136, 47);
            this.bt_toSting.TabIndex = 25;
            this.bt_toSting.Text = "To String";
            this.bt_toSting.UseVisualStyleBackColor = true;
            this.bt_toSting.Click += new System.EventHandler(this.bt_toSting_Click);
            // 
            // bt_toString
            // 
            this.bt_toString.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_toString.Depth = 0;
            this.bt_toString.Location = new System.Drawing.Point(434, 285);
            this.bt_toString.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_toString.Name = "bt_toString";
            this.bt_toString.Primary = true;
            this.bt_toString.Size = new System.Drawing.Size(135, 47);
            this.bt_toString.TabIndex = 24;
            this.bt_toString.Text = "to Hex";
            this.bt_toString.UseVisualStyleBackColor = true;
            this.bt_toString.Click += new System.EventHandler(this.bt_toHex_Click);
            // 
            // bt_saveData
            // 
            this.bt_saveData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_saveData.Depth = 0;
            this.bt_saveData.Location = new System.Drawing.Point(667, 40);
            this.bt_saveData.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_saveData.Name = "bt_saveData";
            this.bt_saveData.Primary = true;
            this.bt_saveData.Size = new System.Drawing.Size(108, 34);
            this.bt_saveData.TabIndex = 23;
            this.bt_saveData.Text = "SAVE";
            this.bt_saveData.UseVisualStyleBackColor = true;
            this.bt_saveData.Click += new System.EventHandler(this.bt_saveData_Click);
            // 
            // textResponse
            // 
            this.textResponse.Location = new System.Drawing.Point(484, 134);
            this.textResponse.Multiline = true;
            this.textResponse.Name = "textResponse";
            this.textResponse.Size = new System.Drawing.Size(302, 75);
            this.textResponse.TabIndex = 22;
            // 
            // readKey
            // 
            this.readKey.FormattingEnabled = true;
            this.readKey.Items.AddRange(new object[] {
            "A0 A1 A2 A3 A4 A5",
            "B0 B1 B2 B3 B4 B5",
            "FF FF FF FF FF FF"});
            this.readKey.Location = new System.Drawing.Point(484, 108);
            this.readKey.Name = "readKey";
            this.readKey.Size = new System.Drawing.Size(152, 21);
            this.readKey.TabIndex = 21;
            this.readKey.Text = "FF FF FF FF FF FF";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(642, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "The 6 Bytes Block Key";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(684, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Number of Blocks";
            // 
            // readNum
            // 
            this.readNum.FormattingEnabled = true;
            this.readNum.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04"});
            this.readNum.Location = new System.Drawing.Point(638, 74);
            this.readNum.Name = "readNum";
            this.readNum.Size = new System.Drawing.Size(40, 21);
            this.readNum.TabIndex = 18;
            this.readNum.Text = "01";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(531, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Starting Block";
            // 
            // readStart
            // 
            this.readStart.FormattingEnabled = true;
            this.readStart.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "0A",
            "0B",
            "0C",
            "0D",
            "0E",
            "0F",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "1A",
            "1B",
            "1C",
            "1D",
            "1E",
            "1F",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "2A",
            "2B",
            "2C",
            "2D",
            "2E",
            "2F",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "3A",
            "3B",
            "3C",
            "3D",
            "3E",
            "3F"});
            this.readStart.Location = new System.Drawing.Point(485, 74);
            this.readStart.Name = "readStart";
            this.readStart.Size = new System.Drawing.Size(40, 21);
            this.readStart.TabIndex = 16;
            this.readStart.Text = "10";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.readKeyA);
            this.groupBox5.Controls.Add(this.readKeyB);
            this.groupBox5.Location = new System.Drawing.Point(486, 35);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(112, 34);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            // 
            // readKeyA
            // 
            this.readKeyA.AutoSize = true;
            this.readKeyA.Checked = true;
            this.readKeyA.Location = new System.Drawing.Point(6, 12);
            this.readKeyA.Name = "readKeyA";
            this.readKeyA.Size = new System.Drawing.Size(50, 17);
            this.readKeyA.TabIndex = 0;
            this.readKeyA.TabStop = true;
            this.readKeyA.Text = "KeyA";
            this.readKeyA.UseVisualStyleBackColor = true;
            // 
            // readKeyB
            // 
            this.readKeyB.AutoSize = true;
            this.readKeyB.Location = new System.Drawing.Point(59, 12);
            this.readKeyB.Name = "readKeyB";
            this.readKeyB.Size = new System.Drawing.Size(50, 17);
            this.readKeyB.TabIndex = 1;
            this.readKeyB.Text = "KeyB";
            this.readKeyB.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.readIdle);
            this.groupBox4.Controls.Add(this.readAll);
            this.groupBox4.Location = new System.Drawing.Point(486, 1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(106, 34);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            // 
            // readIdle
            // 
            this.readIdle.AutoSize = true;
            this.readIdle.Checked = true;
            this.readIdle.Location = new System.Drawing.Point(6, 12);
            this.readIdle.Name = "readIdle";
            this.readIdle.Size = new System.Drawing.Size(42, 17);
            this.readIdle.TabIndex = 0;
            this.readIdle.TabStop = true;
            this.readIdle.Text = "Idle";
            this.readIdle.UseVisualStyleBackColor = true;
            // 
            // readAll
            // 
            this.readAll.AutoSize = true;
            this.readAll.Location = new System.Drawing.Point(59, 12);
            this.readAll.Name = "readAll";
            this.readAll.Size = new System.Drawing.Size(36, 17);
            this.readAll.TabIndex = 1;
            this.readAll.Text = "All";
            this.readAll.UseVisualStyleBackColor = true;
            this.readAll.Visible = false;
            // 
            // bt_readRfid
            // 
            this.bt_readRfid.Depth = 0;
            this.bt_readRfid.Location = new System.Drawing.Point(667, 3);
            this.bt_readRfid.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_readRfid.Name = "bt_readRfid";
            this.bt_readRfid.Primary = true;
            this.bt_readRfid.Size = new System.Drawing.Size(108, 32);
            this.bt_readRfid.TabIndex = 13;
            this.bt_readRfid.Text = "read RFID";
            this.bt_readRfid.UseVisualStyleBackColor = true;
            this.bt_readRfid.Click += new System.EventHandler(this.bt_readRfid_Click);
            // 
            // materialSingleLineTextField11
            // 
            this.materialSingleLineTextField11.Depth = 0;
            this.materialSingleLineTextField11.Hint = "";
            this.materialSingleLineTextField11.Location = new System.Drawing.Point(199, 113);
            this.materialSingleLineTextField11.MaxLength = 32767;
            this.materialSingleLineTextField11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField11.Name = "materialSingleLineTextField11";
            this.materialSingleLineTextField11.PasswordChar = '\0';
            this.materialSingleLineTextField11.SelectedText = "";
            this.materialSingleLineTextField11.SelectionLength = 0;
            this.materialSingleLineTextField11.SelectionStart = 0;
            this.materialSingleLineTextField11.Size = new System.Drawing.Size(262, 23);
            this.materialSingleLineTextField11.TabIndex = 12;
            this.materialSingleLineTextField11.TabStop = false;
            this.materialSingleLineTextField11.UseSystemPasswordChar = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 32);
            this.label10.TabIndex = 10;
            this.label10.Text = "สถานีก่อนหน้า";
            // 
            // materialSingleLineTextField9
            // 
            this.materialSingleLineTextField9.Depth = 0;
            this.materialSingleLineTextField9.Hint = "";
            this.materialSingleLineTextField9.Location = new System.Drawing.Point(199, 186);
            this.materialSingleLineTextField9.MaxLength = 32767;
            this.materialSingleLineTextField9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField9.Name = "materialSingleLineTextField9";
            this.materialSingleLineTextField9.PasswordChar = '\0';
            this.materialSingleLineTextField9.SelectedText = "";
            this.materialSingleLineTextField9.SelectionLength = 0;
            this.materialSingleLineTextField9.SelectionStart = 0;
            this.materialSingleLineTextField9.Size = new System.Drawing.Size(262, 23);
            this.materialSingleLineTextField9.TabIndex = 9;
            this.materialSingleLineTextField9.TabStop = false;
            this.materialSingleLineTextField9.UseSystemPasswordChar = false;
            this.materialSingleLineTextField9.Click += new System.EventHandler(this.materialSingleLineTextField9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 32);
            this.label8.TabIndex = 8;
            this.label8.Text = "สถานะการขนส่งใหม่";
            // 
            // txt_tp_material
            // 
            this.txt_tp_material.Depth = 0;
            this.txt_tp_material.Hint = "";
            this.txt_tp_material.Location = new System.Drawing.Point(198, 44);
            this.txt_tp_material.MaxLength = 32767;
            this.txt_tp_material.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_tp_material.Name = "txt_tp_material";
            this.txt_tp_material.PasswordChar = '\0';
            this.txt_tp_material.SelectedText = "";
            this.txt_tp_material.SelectionLength = 0;
            this.txt_tp_material.SelectionStart = 0;
            this.txt_tp_material.Size = new System.Drawing.Size(262, 23);
            this.txt_tp_material.TabIndex = 7;
            this.txt_tp_material.TabStop = false;
            this.txt_tp_material.UseSystemPasswordChar = false;
            this.txt_tp_material.Click += new System.EventHandler(this.materialSingleLineTextField8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 32);
            this.label9.TabIndex = 6;
            this.label9.Text = "วัตถุดิบที่บรรทุก";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // materialSingleLineTextField6
            // 
            this.materialSingleLineTextField6.Depth = 0;
            this.materialSingleLineTextField6.Hint = "";
            this.materialSingleLineTextField6.Location = new System.Drawing.Point(199, 147);
            this.materialSingleLineTextField6.MaxLength = 32767;
            this.materialSingleLineTextField6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField6.Name = "materialSingleLineTextField6";
            this.materialSingleLineTextField6.PasswordChar = '\0';
            this.materialSingleLineTextField6.SelectedText = "";
            this.materialSingleLineTextField6.SelectionLength = 0;
            this.materialSingleLineTextField6.SelectionStart = 0;
            this.materialSingleLineTextField6.Size = new System.Drawing.Size(262, 23);
            this.materialSingleLineTextField6.TabIndex = 5;
            this.materialSingleLineTextField6.TabStop = false;
            this.materialSingleLineTextField6.UseSystemPasswordChar = false;
            this.materialSingleLineTextField6.Click += new System.EventHandler(this.materialSingleLineTextField6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 32);
            this.label7.TabIndex = 4;
            this.label7.Text = "สถานะการขนส่งเดิม";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_tp_station
            // 
            this.txt_tp_station.Depth = 0;
            this.txt_tp_station.Hint = "";
            this.txt_tp_station.Location = new System.Drawing.Point(199, 79);
            this.txt_tp_station.MaxLength = 32767;
            this.txt_tp_station.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_tp_station.Name = "txt_tp_station";
            this.txt_tp_station.PasswordChar = '\0';
            this.txt_tp_station.SelectedText = "";
            this.txt_tp_station.SelectionLength = 0;
            this.txt_tp_station.SelectionStart = 0;
            this.txt_tp_station.Size = new System.Drawing.Size(262, 23);
            this.txt_tp_station.TabIndex = 3;
            this.txt_tp_station.TabStop = false;
            this.txt_tp_station.UseSystemPasswordChar = false;
            this.txt_tp_station.Click += new System.EventHandler(this.materialSingleLineTextField5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "สถานีปัจจุบัน";
            this.label3.Click += new System.EventHandler(this.label3_Click_3);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(6, 3);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(143, 32);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "เลขทะเบียนรถ ";
            this.label_name.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.materialRaisedButton2);
            this.tabPage3.Controls.Add(this.dateTimePicker2);
            this.tabPage3.Controls.Add(this.dateTimePicker1);
            this.tabPage3.Controls.Add(this.materialSingleLineTextField7);
            this.tabPage3.Controls.Add(this.materialLabel4);
            this.tabPage3.Controls.Add(this.materialRaisedButton1);
            this.tabPage3.Controls.Add(this.materialLabel3);
            this.tabPage3.Controls.Add(this.materialLabel2);
            this.tabPage3.Controls.Add(this.materialLabel1);
            this.tabPage3.Controls.Add(this.dataGridView_transport);
            this.tabPage3.Controls.Add(this.materialSingleLineTextField1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 365);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ประวัติการขนส่ง";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(672, 54);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(107, 38);
            this.materialRaisedButton2.TabIndex = 32;
            this.materialRaisedButton2.Text = "Print Report";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(269, 50);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 31;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(269, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // materialSingleLineTextField7
            // 
            this.materialSingleLineTextField7.BackColor = System.Drawing.Color.White;
            this.materialSingleLineTextField7.Depth = 0;
            this.materialSingleLineTextField7.Hint = "Raw material";
            this.materialSingleLineTextField7.Location = new System.Drawing.Point(80, 46);
            this.materialSingleLineTextField7.MaxLength = 32767;
            this.materialSingleLineTextField7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField7.Name = "materialSingleLineTextField7";
            this.materialSingleLineTextField7.PasswordChar = '\0';
            this.materialSingleLineTextField7.SelectedText = "";
            this.materialSingleLineTextField7.SelectionLength = 0;
            this.materialSingleLineTextField7.SelectionStart = 0;
            this.materialSingleLineTextField7.Size = new System.Drawing.Size(100, 23);
            this.materialSingleLineTextField7.TabIndex = 29;
            this.materialSingleLineTextField7.TabStop = false;
            this.materialSingleLineTextField7.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(233, 50);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(19, 19);
            this.materialLabel4.TabIndex = 28;
            this.materialLabel4.Text = "ถึง";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(672, 10);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(107, 38);
            this.materialRaisedButton1.TabIndex = 26;
            this.materialRaisedButton1.Text = "Search";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(233, 10);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(30, 19);
            this.materialLabel3.TabIndex = 25;
            this.materialLabel3.Text = "ตั้งแต่";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(6, 46);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(38, 19);
            this.materialLabel2.TabIndex = 24;
            this.materialLabel2.Text = "วัตถุดิบ";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(6, 6);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(68, 19);
            this.materialLabel1.TabIndex = 23;
            this.materialLabel1.Text = "เลขทะเบียนรถ";
            // 
            // dataGridView_transport
            // 
            this.dataGridView_transport.AllowUserToAddRows = false;
            this.dataGridView_transport.AllowUserToDeleteRows = false;
            this.dataGridView_transport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_transport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_transport.Location = new System.Drawing.Point(3, 98);
            this.dataGridView_transport.Name = "dataGridView_transport";
            this.dataGridView_transport.ReadOnly = true;
            this.dataGridView_transport.Size = new System.Drawing.Size(786, 261);
            this.dataGridView_transport.TabIndex = 20;
            this.dataGridView_transport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.BackColor = System.Drawing.Color.White;
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "Car number";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(80, 6);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(100, 23);
            this.materialSingleLineTextField1.TabIndex = 19;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            this.materialSingleLineTextField1.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.materialSingleLineTextField3);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.materialSingleLineTextField2);
            this.tabPage4.Controls.Add(this.label_setdatabase);
            this.tabPage4.Controls.Add(this.comboBox1);
            this.tabPage4.Controls.Add(this.label_setportrfid);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 365);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "การตั้งค่า";
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // materialSingleLineTextField3
            // 
            this.materialSingleLineTextField3.Depth = 0;
            this.materialSingleLineTextField3.Hint = "Station name";
            this.materialSingleLineTextField3.Location = new System.Drawing.Point(176, 109);
            this.materialSingleLineTextField3.MaxLength = 32767;
            this.materialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField3.Name = "materialSingleLineTextField3";
            this.materialSingleLineTextField3.PasswordChar = '\0';
            this.materialSingleLineTextField3.SelectedText = "";
            this.materialSingleLineTextField3.SelectionLength = 0;
            this.materialSingleLineTextField3.SelectionStart = 0;
            this.materialSingleLineTextField3.Size = new System.Drawing.Size(215, 23);
            this.materialSingleLineTextField3.TabIndex = 5;
            this.materialSingleLineTextField3.TabStop = false;
            this.materialSingleLineTextField3.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(33, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "ชื่อสถานี";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "Connection string";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(176, 64);
            this.materialSingleLineTextField2.MaxLength = 32767;
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(448, 23);
            this.materialSingleLineTextField2.TabIndex = 3;
            this.materialSingleLineTextField2.TabStop = false;
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // label_setdatabase
            // 
            this.label_setdatabase.AutoSize = true;
            this.label_setdatabase.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_setdatabase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_setdatabase.Location = new System.Drawing.Point(33, 64);
            this.label_setdatabase.Name = "label_setdatabase";
            this.label_setdatabase.Size = new System.Drawing.Size(134, 24);
            this.label_setdatabase.TabIndex = 2;
            this.label_setdatabase.Text = "การเชื่อมต่อฐานข้อมูล";
            this.label_setdatabase.Click += new System.EventHandler(this.label_setdatabase_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(176, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label_setportrfid
            // 
            this.label_setportrfid.AutoSize = true;
            this.label_setportrfid.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_setportrfid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_setportrfid.Location = new System.Drawing.Point(33, 24);
            this.label_setportrfid.Name = "label_setportrfid";
            this.label_setportrfid.Size = new System.Drawing.Size(95, 24);
            this.label_setportrfid.TabIndex = 0;
            this.label_setportrfid.Text = "พอร์ต RFID";
            this.label_setportrfid.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbtransportsBindingSource
            // 
            this.tbtransportsBindingSource.DataMember = "tb_transports";
            this.tbtransportsBindingSource.DataSource = this.rMTTSDataSetBindingSource;
            // 
            // rMTTSDataSetBindingSource
            // 
            this.rMTTSDataSetBindingSource.DataSource = this.rMTTSDataSet;
            this.rMTTSDataSetBindingSource.Position = 0;
            // 
            // rMTTSDataSet
            // 
            this.rMTTSDataSet.DataSetName = "RMTTSDataSet";
            this.rMTTSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(266, 523);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "สถานะ :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lb_statusNow
            // 
            this.lb_statusNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_statusNow.AutoSize = true;
            this.lb_statusNow.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_statusNow.ForeColor = System.Drawing.Color.Red;
            this.lb_statusNow.Location = new System.Drawing.Point(341, 523);
            this.lb_statusNow.Name = "lb_statusNow";
            this.lb_statusNow.Size = new System.Drawing.Size(158, 28);
            this.lb_statusNow.TabIndex = 3;
            this.lb_statusNow.Text = "ไม่พบการทำรายการ";
            // 
            // tb_transportsTableAdapter
            // 
            this.tb_transportsTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(833, 564);
            this.Controls.Add(this.lb_statusNow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialDivider1);
            this.Name = "MainForm";
            this.Text = "Raw Material Tracking System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_transport)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbtransportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMTTSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMTTSDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialDivider materialDivider1;
        private MaterialTabSelector materialTabSelector1;
        private MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage4;
        private TabPage tabPage2;
        private Label label1;
        private Label label2;
        private Label label_setportrfid;
        private ComboBox comboBox1;
        private Label label_setdatabase;
        private TabPage tabPage3;
        private DataGridView dataGridView_transport;
        private MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSingleLineTextField materialSingleLineTextField2;
        private Label label_name;
        private Label label3;
        private Label label5;
        private Label lb_statusNow;
        private Label label4;
        private MaterialSingleLineTextField materialSingleLineTextField3;
        private MaterialSingleLineTextField txt_tp_station;
        private MaterialSingleLineTextField materialSingleLineTextField6;
        private Label label9;
        private MaterialRaisedButton materialRaisedButton1;
        private MaterialLabel materialLabel3;
        private MaterialLabel materialLabel2;
        private MaterialLabel materialLabel1;
        private MaterialLabel materialLabel4;
        private MaterialSingleLineTextField materialSingleLineTextField7;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private MaterialSingleLineTextField materialSingleLineTextField9;
        private Label label8;
        private Label label10;
        private MaterialSingleLineTextField materialSingleLineTextField11;
        private MaterialRaisedButton materialRaisedButton2;
        private MaterialRaisedButton bt_readRfid;
        private GroupBox groupBox5;
        private RadioButton readKeyA;
        private RadioButton readKeyB;
        private GroupBox groupBox4;
        private RadioButton readIdle;
        private RadioButton readAll;
        private Label label11;
        private ComboBox readNum;
        private Label label12;
        private ComboBox readStart;
        private ComboBox readKey;
        private Label label13;
        private TextBox textResponse;
        private MaterialRaisedButton bt_saveData;
        private BindingSource rMTTSDataSetBindingSource;
        private RMTTSDataSet rMTTSDataSet;
        private BindingSource tbtransportsBindingSource;
        private RMTTSDataSetTableAdapters.tb_transportsTableAdapter tb_transportsTableAdapter;
        private MaterialRaisedButton bt_toString;
        private MaterialRaisedButton bt_toSting;
        private Label lb_tp_vehicle;
        private MaterialSingleLineTextField txt_tp_material;
        private Label lb_timeTag;
        private Label lb_dateTime;
    }
}