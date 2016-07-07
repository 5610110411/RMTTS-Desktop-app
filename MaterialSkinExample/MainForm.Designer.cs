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
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialSingleLineTextField8 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label9 = new System.Windows.Forms.Label();
            this.materialSingleLineTextField6 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label7 = new System.Windows.Forms.Label();
            this.materialSingleLineTextField5 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField4 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.comboBox_search = new System.Windows.Forms.ComboBox();
            this.dataGridView_transport = new System.Windows.Forms.DataGridView();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.materialSingleLineTextField3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label4 = new System.Windows.Forms.Label();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label_setdatabase = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_setportrfid = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_transport)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(0, 428);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(0);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(696, 1);
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
            this.materialTabSelector1.Size = new System.Drawing.Size(696, 48);
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
            this.materialTabControl1.Size = new System.Drawing.Size(655, 305);
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
            this.tabPage1.Size = new System.Drawing.Size(647, 279);
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
            this.tabPage2.Controls.Add(this.materialSingleLineTextField8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.materialSingleLineTextField6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.materialSingleLineTextField5);
            this.tabPage2.Controls.Add(this.materialSingleLineTextField4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label_name);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(647, 279);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ข้อมูลผู้ใช้ปัจจุุบัน";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // materialSingleLineTextField8
            // 
            this.materialSingleLineTextField8.Depth = 0;
            this.materialSingleLineTextField8.Hint = "";
            this.materialSingleLineTextField8.Location = new System.Drawing.Point(182, 91);
            this.materialSingleLineTextField8.MaxLength = 32767;
            this.materialSingleLineTextField8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField8.Name = "materialSingleLineTextField8";
            this.materialSingleLineTextField8.PasswordChar = '\0';
            this.materialSingleLineTextField8.SelectedText = "";
            this.materialSingleLineTextField8.SelectionLength = 0;
            this.materialSingleLineTextField8.SelectionStart = 0;
            this.materialSingleLineTextField8.Size = new System.Drawing.Size(262, 23);
            this.materialSingleLineTextField8.TabIndex = 7;
            this.materialSingleLineTextField8.TabStop = false;
            this.materialSingleLineTextField8.UseSystemPasswordChar = false;
            this.materialSingleLineTextField8.Click += new System.EventHandler(this.materialSingleLineTextField8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 88);
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
            this.materialSingleLineTextField6.Location = new System.Drawing.Point(182, 186);
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
            this.label7.Location = new System.Drawing.Point(18, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 32);
            this.label7.TabIndex = 4;
            this.label7.Text = "สถานะการขนส่ง";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // materialSingleLineTextField5
            // 
            this.materialSingleLineTextField5.Depth = 0;
            this.materialSingleLineTextField5.Hint = "";
            this.materialSingleLineTextField5.Location = new System.Drawing.Point(182, 139);
            this.materialSingleLineTextField5.MaxLength = 32767;
            this.materialSingleLineTextField5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField5.Name = "materialSingleLineTextField5";
            this.materialSingleLineTextField5.PasswordChar = '\0';
            this.materialSingleLineTextField5.SelectedText = "";
            this.materialSingleLineTextField5.SelectionLength = 0;
            this.materialSingleLineTextField5.SelectionStart = 0;
            this.materialSingleLineTextField5.Size = new System.Drawing.Size(262, 23);
            this.materialSingleLineTextField5.TabIndex = 3;
            this.materialSingleLineTextField5.TabStop = false;
            this.materialSingleLineTextField5.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField4
            // 
            this.materialSingleLineTextField4.Depth = 0;
            this.materialSingleLineTextField4.Hint = "";
            this.materialSingleLineTextField4.Location = new System.Drawing.Point(181, 43);
            this.materialSingleLineTextField4.MaxLength = 32767;
            this.materialSingleLineTextField4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField4.Name = "materialSingleLineTextField4";
            this.materialSingleLineTextField4.PasswordChar = '\0';
            this.materialSingleLineTextField4.SelectedText = "";
            this.materialSingleLineTextField4.SelectionLength = 0;
            this.materialSingleLineTextField4.SelectionStart = 0;
            this.materialSingleLineTextField4.Size = new System.Drawing.Size(262, 23);
            this.materialSingleLineTextField4.TabIndex = 2;
            this.materialSingleLineTextField4.TabStop = false;
            this.materialSingleLineTextField4.UseSystemPasswordChar = false;
            this.materialSingleLineTextField4.Click += new System.EventHandler(this.materialSingleLineTextField4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "ชื่อสถานี";
            this.label3.Click += new System.EventHandler(this.label3_Click_3);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(18, 36);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(143, 32);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "เลขทะเบียนรถ ";
            this.label_name.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.materialCheckBox1);
            this.tabPage3.Controls.Add(this.comboBox_search);
            this.tabPage3.Controls.Add(this.dataGridView_transport);
            this.tabPage3.Controls.Add(this.materialSingleLineTextField1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(647, 279);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ประวัติการขนส่ง";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox1.Location = new System.Drawing.Point(6, 37);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(123, 30);
            this.materialCheckBox1.TabIndex = 22;
            this.materialCheckBox1.Text = "ค้นหาเฉพาะวันนี้";
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox_search
            // 
            this.comboBox_search.FormattingEnabled = true;
            this.comboBox_search.Location = new System.Drawing.Point(501, 8);
            this.comboBox_search.Name = "comboBox_search";
            this.comboBox_search.Size = new System.Drawing.Size(140, 21);
            this.comboBox_search.TabIndex = 21;
            // 
            // dataGridView_transport
            // 
            this.dataGridView_transport.AllowUserToAddRows = false;
            this.dataGridView_transport.AllowUserToDeleteRows = false;
            this.dataGridView_transport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_transport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_transport.Location = new System.Drawing.Point(3, 70);
            this.dataGridView_transport.Name = "dataGridView_transport";
            this.dataGridView_transport.ReadOnly = true;
            this.dataGridView_transport.Size = new System.Drawing.Size(631, 203);
            this.dataGridView_transport.TabIndex = 20;
            this.dataGridView_transport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialSingleLineTextField1.BackColor = System.Drawing.Color.White;
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "พิมคำที่ต้องการค้นหาที่นี้";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(6, 6);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(457, 23);
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
            this.tabPage4.Size = new System.Drawing.Size(647, 279);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "การตั้งค่า";
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // materialSingleLineTextField3
            // 
            this.materialSingleLineTextField3.Depth = 0;
            this.materialSingleLineTextField3.Hint = "พิมพ์ชื่อสถานีที่นี้";
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
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(282, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "สถานะการบันทึกข้อมูล :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(456, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 28);
            this.label6.TabIndex = 3;
            this.label6.Text = "ไม่พบการทำรายการ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(688, 478);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialDivider1);
            this.Name = "MainForm";
            this.Text = "ระบบติดตามการขนส่งวัตถุดิบ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_transport)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
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
        private ComboBox comboBox_search;
        private DataGridView dataGridView_transport;
        private MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSingleLineTextField materialSingleLineTextField2;
        private Label label_name;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label4;
        private MaterialSingleLineTextField materialSingleLineTextField3;
        private MaterialSingleLineTextField materialSingleLineTextField5;
        private MaterialSingleLineTextField materialSingleLineTextField4;
        private Label label7;
        private MaterialSingleLineTextField materialSingleLineTextField6;
        private MaterialSingleLineTextField materialSingleLineTextField8;
        private Label label9;
        private MaterialCheckBox materialCheckBox1;
    }
}