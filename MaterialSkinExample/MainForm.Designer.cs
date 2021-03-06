﻿using System.Drawing;
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
            this.textResponse = new System.Windows.Forms.TextBox();
            this.lb_rawMat = new System.Windows.Forms.Label();
            this.bt_clear = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lb_curStatus = new System.Windows.Forms.Label();
            this.lb_previousStatus = new System.Windows.Forms.Label();
            this.lb_previousStation = new System.Windows.Forms.Label();
            this.lb_curStation = new System.Windows.Forms.Label();
            this.lb_timeTag = new System.Windows.Forms.Label();
            this.lb_dateTime = new System.Windows.Forms.Label();
            this.lb_tp_vehicle = new System.Windows.Forms.Label();
            this.bt_readRfid = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBox_material = new System.Windows.Forms.ComboBox();
            this.bt_search = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dateTimePicker_to = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_from = new System.Windows.Forms.DateTimePicker();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView_transport = new System.Windows.Forms.DataGridView();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_searhCar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.bt_deleteCard = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label17 = new System.Windows.Forms.Label();
            this.writeData = new System.Windows.Forms.TextBox();
            this.writeKey = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.writeNum = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.writeStart = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.writeKeyA = new System.Windows.Forms.RadioButton();
            this.writeKeyB = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.writeIdle = new System.Windows.Forms.RadioButton();
            this.writeAll = new System.Windows.Forms.RadioButton();
            this.bt_toSting = new MaterialSkin.Controls.MaterialRaisedButton();
            this.bt_toString = new MaterialSkin.Controls.MaterialRaisedButton();
            this.bt_saveData = new MaterialSkin.Controls.MaterialRaisedButton();
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
            this.comboBox_station = new System.Windows.Forms.ComboBox();
            this.tbstationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rMTTSDataSet = new MaterialSkinExample.RMTTSDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label_setdatabase = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_statusNow = new System.Windows.Forms.Label();
            this.tb_stationsTableAdapter = new MaterialSkinExample.RMTTSDataSetTableAdapters.tb_stationsTableAdapter();
            this.tbmaterialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_materialsTableAdapter = new MaterialSkinExample.RMTTSDataSetTableAdapters.tb_materialsTableAdapter();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_transport)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbstationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMTTSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmaterialsBindingSource)).BeginInit();
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
            this.materialDivider1.Size = new System.Drawing.Size(998, 1);
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
            this.materialTabSelector1.Size = new System.Drawing.Size(998, 48);
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
            this.materialTabControl1.Size = new System.Drawing.Size(957, 391);
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
            this.tabPage1.Size = new System.Drawing.Size(949, 365);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "เริ่มต้น";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(234, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(524, 56);
            this.label2.TabIndex = 20;
            this.label2.Text = "โปรแกรมติดตามการขนส่งวัตถุดิบ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(365, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 56);
            this.label1.TabIndex = 19;
            this.label1.Text = "ยินดีต้อนรับสู่";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.textResponse);
            this.tabPage2.Controls.Add(this.lb_rawMat);
            this.tabPage2.Controls.Add(this.bt_clear);
            this.tabPage2.Controls.Add(this.lb_curStatus);
            this.tabPage2.Controls.Add(this.lb_previousStatus);
            this.tabPage2.Controls.Add(this.lb_previousStation);
            this.tabPage2.Controls.Add(this.lb_curStation);
            this.tabPage2.Controls.Add(this.lb_timeTag);
            this.tabPage2.Controls.Add(this.lb_dateTime);
            this.tabPage2.Controls.Add(this.lb_tp_vehicle);
            this.tabPage2.Controls.Add(this.bt_readRfid);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label_name);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(949, 365);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ข้อมูลการขนส่ง";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // textResponse
            // 
            this.textResponse.Location = new System.Drawing.Point(635, 33);
            this.textResponse.Multiline = true;
            this.textResponse.Name = "textResponse";
            this.textResponse.Size = new System.Drawing.Size(298, 94);
            this.textResponse.TabIndex = 45;
            this.textResponse.Visible = false;
            // 
            // lb_rawMat
            // 
            this.lb_rawMat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_rawMat.AutoSize = true;
            this.lb_rawMat.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rawMat.ForeColor = System.Drawing.Color.Silver;
            this.lb_rawMat.Location = new System.Drawing.Point(421, 65);
            this.lb_rawMat.Name = "lb_rawMat";
            this.lb_rawMat.Size = new System.Drawing.Size(135, 28);
            this.lb_rawMat.TabIndex = 44;
            this.lb_rawMat.Text = "Raw material";
            // 
            // bt_clear
            // 
            this.bt_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_clear.Depth = 0;
            this.bt_clear.Location = new System.Drawing.Point(835, 320);
            this.bt_clear.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Primary = true;
            this.bt_clear.Size = new System.Drawing.Size(108, 38);
            this.bt_clear.TabIndex = 43;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // lb_curStatus
            // 
            this.lb_curStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_curStatus.AutoSize = true;
            this.lb_curStatus.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_curStatus.ForeColor = System.Drawing.Color.Silver;
            this.lb_curStatus.Location = new System.Drawing.Point(421, 203);
            this.lb_curStatus.Name = "lb_curStatus";
            this.lb_curStatus.Size = new System.Drawing.Size(147, 28);
            this.lb_curStatus.TabIndex = 42;
            this.lb_curStatus.Text = "Current status";
            // 
            // lb_previousStatus
            // 
            this.lb_previousStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_previousStatus.AutoSize = true;
            this.lb_previousStatus.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_previousStatus.ForeColor = System.Drawing.Color.Silver;
            this.lb_previousStatus.Location = new System.Drawing.Point(421, 320);
            this.lb_previousStatus.Name = "lb_previousStatus";
            this.lb_previousStatus.Size = new System.Drawing.Size(159, 28);
            this.lb_previousStatus.TabIndex = 41;
            this.lb_previousStatus.Text = "Previous status";
            this.lb_previousStatus.Visible = false;
            this.lb_previousStatus.Click += new System.EventHandler(this.lb_previousStatus_Click);
            // 
            // lb_previousStation
            // 
            this.lb_previousStation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_previousStation.AutoSize = true;
            this.lb_previousStation.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_previousStation.ForeColor = System.Drawing.Color.Silver;
            this.lb_previousStation.Location = new System.Drawing.Point(421, 109);
            this.lb_previousStation.Name = "lb_previousStation";
            this.lb_previousStation.Size = new System.Drawing.Size(164, 28);
            this.lb_previousStation.TabIndex = 40;
            this.lb_previousStation.Text = "Previous station";
            this.lb_previousStation.Click += new System.EventHandler(this.lb_previousStation_Click);
            // 
            // lb_curStation
            // 
            this.lb_curStation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_curStation.AutoSize = true;
            this.lb_curStation.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_curStation.ForeColor = System.Drawing.Color.Silver;
            this.lb_curStation.Location = new System.Drawing.Point(421, 154);
            this.lb_curStation.Name = "lb_curStation";
            this.lb_curStation.Size = new System.Drawing.Size(152, 28);
            this.lb_curStation.TabIndex = 29;
            this.lb_curStation.Text = "Current station";
            // 
            // lb_timeTag
            // 
            this.lb_timeTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_timeTag.AutoSize = true;
            this.lb_timeTag.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timeTag.Location = new System.Drawing.Point(266, 247);
            this.lb_timeTag.Name = "lb_timeTag";
            this.lb_timeTag.Size = new System.Drawing.Size(142, 32);
            this.lb_timeTag.TabIndex = 28;
            this.lb_timeTag.Text = "เวลาทำรายการ";
            // 
            // lb_dateTime
            // 
            this.lb_dateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_dateTime.AutoSize = true;
            this.lb_dateTime.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dateTime.ForeColor = System.Drawing.Color.Silver;
            this.lb_dateTime.Location = new System.Drawing.Point(421, 250);
            this.lb_dateTime.Name = "lb_dateTime";
            this.lb_dateTime.Size = new System.Drawing.Size(103, 28);
            this.lb_dateTime.TabIndex = 27;
            this.lb_dateTime.Text = "Date time";
            // 
            // lb_tp_vehicle
            // 
            this.lb_tp_vehicle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_tp_vehicle.AutoSize = true;
            this.lb_tp_vehicle.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tp_vehicle.ForeColor = System.Drawing.Color.Silver;
            this.lb_tp_vehicle.Location = new System.Drawing.Point(421, 22);
            this.lb_tp_vehicle.Name = "lb_tp_vehicle";
            this.lb_tp_vehicle.Size = new System.Drawing.Size(118, 28);
            this.lb_tp_vehicle.TabIndex = 26;
            this.lb_tp_vehicle.Text = "Car license";
            this.lb_tp_vehicle.Click += new System.EventHandler(this.lb_tp_vehicle_Click);
            // 
            // bt_readRfid
            // 
            this.bt_readRfid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_readRfid.Depth = 0;
            this.bt_readRfid.Location = new System.Drawing.Point(835, 271);
            this.bt_readRfid.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_readRfid.Name = "bt_readRfid";
            this.bt_readRfid.Primary = true;
            this.bt_readRfid.Size = new System.Drawing.Size(108, 38);
            this.bt_readRfid.TabIndex = 13;
            this.bt_readRfid.Text = "read RFID";
            this.bt_readRfid.UseVisualStyleBackColor = true;
            this.bt_readRfid.Click += new System.EventHandler(this.bt_readRfid_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(309, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 32);
            this.label10.TabIndex = 10;
            this.label10.Text = "จากสถานี";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(272, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 32);
            this.label8.TabIndex = 8;
            this.label8.Text = "สถานะปัจจุบัน";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(257, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 32);
            this.label9.TabIndex = 6;
            this.label9.Text = "วัตถุดิบที่บรรทุก";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(220, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 32);
            this.label7.TabIndex = 4;
            this.label7.Text = "สถานะการขนส่งเดิม";
            this.label7.Visible = false;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(301, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "ไปยังสถานี";
            this.label3.Click += new System.EventHandler(this.label3_Click_3);
            // 
            // label_name
            // 
            this.label_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(265, 22);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(143, 32);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "เลขทะเบียนรถ ";
            this.label_name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_name.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.comboBox_material);
            this.tabPage3.Controls.Add(this.bt_search);
            this.tabPage3.Controls.Add(this.dateTimePicker_to);
            this.tabPage3.Controls.Add(this.dateTimePicker_from);
            this.tabPage3.Controls.Add(this.materialLabel4);
            this.tabPage3.Controls.Add(this.dataGridView_transport);
            this.tabPage3.Controls.Add(this.materialLabel3);
            this.tabPage3.Controls.Add(this.materialLabel2);
            this.tabPage3.Controls.Add(this.materialLabel1);
            this.tabPage3.Controls.Add(this.txt_searhCar);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(949, 365);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ประวัติการขนส่ง";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // comboBox_material
            // 
            this.comboBox_material.FormattingEnabled = true;
            this.comboBox_material.Items.AddRange(new object[] {
            "--ALL--",
            "ดินดำ",
            "ดินเหลือง"});
            this.comboBox_material.Location = new System.Drawing.Point(117, 50);
            this.comboBox_material.Name = "comboBox_material";
            this.comboBox_material.Size = new System.Drawing.Size(131, 21);
            this.comboBox_material.TabIndex = 33;
            this.comboBox_material.SelectedIndexChanged += new System.EventHandler(this.comboBox_material_SelectedIndexChanged);
            // 
            // bt_search
            // 
            this.bt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_search.Depth = 0;
            this.bt_search.Location = new System.Drawing.Point(822, 6);
            this.bt_search.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_search.Name = "bt_search";
            this.bt_search.Primary = true;
            this.bt_search.Size = new System.Drawing.Size(121, 43);
            this.bt_search.TabIndex = 32;
            this.bt_search.Text = "SEARCH";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // dateTimePicker_to
            // 
            this.dateTimePicker_to.Location = new System.Drawing.Point(367, 50);
            this.dateTimePicker_to.Name = "dateTimePicker_to";
            this.dateTimePicker_to.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_to.TabIndex = 31;
            // 
            // dateTimePicker_from
            // 
            this.dateTimePicker_from.Location = new System.Drawing.Point(367, 10);
            this.dateTimePicker_from.Name = "dateTimePicker_from";
            this.dateTimePicker_from.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_from.TabIndex = 30;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(320, 50);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(25, 24);
            this.materialLabel4.TabIndex = 28;
            this.materialLabel4.Text = "ถึง";
            // 
            // dataGridView_transport
            // 
            this.dataGridView_transport.AllowUserToAddRows = false;
            this.dataGridView_transport.AllowUserToDeleteRows = false;
            this.dataGridView_transport.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_transport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_transport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_transport.Location = new System.Drawing.Point(0, 96);
            this.dataGridView_transport.Name = "dataGridView_transport";
            this.dataGridView_transport.ReadOnly = true;
            this.dataGridView_transport.Size = new System.Drawing.Size(970, 460);
            this.dataGridView_transport.TabIndex = 20;
            this.dataGridView_transport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(320, 10);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(41, 24);
            this.materialLabel3.TabIndex = 25;
            this.materialLabel3.Text = "ตั้งแต่";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(6, 46);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(53, 24);
            this.materialLabel2.TabIndex = 24;
            this.materialLabel2.Text = "วัตถุดิบ";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(6, 6);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(90, 24);
            this.materialLabel1.TabIndex = 23;
            this.materialLabel1.Text = "เลขทะเบียนรถ";
            // 
            // txt_searhCar
            // 
            this.txt_searhCar.BackColor = System.Drawing.Color.White;
            this.txt_searhCar.Depth = 0;
            this.txt_searhCar.Hint = "Car number";
            this.txt_searhCar.Location = new System.Drawing.Point(117, 6);
            this.txt_searhCar.MaxLength = 32767;
            this.txt_searhCar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_searhCar.Name = "txt_searhCar";
            this.txt_searhCar.PasswordChar = '\0';
            this.txt_searhCar.SelectedText = "";
            this.txt_searhCar.SelectionLength = 0;
            this.txt_searhCar.SelectionStart = 0;
            this.txt_searhCar.Size = new System.Drawing.Size(131, 28);
            this.txt_searhCar.TabIndex = 19;
            this.txt_searhCar.TabStop = false;
            this.txt_searhCar.UseSystemPasswordChar = false;
            this.txt_searhCar.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.bt_deleteCard);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.writeData);
            this.tabPage4.Controls.Add(this.writeKey);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.writeNum);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.writeStart);
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Controls.Add(this.groupBox7);
            this.tabPage4.Controls.Add(this.bt_toSting);
            this.tabPage4.Controls.Add(this.bt_toString);
            this.tabPage4.Controls.Add(this.bt_saveData);
            this.tabPage4.Controls.Add(this.readKey);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.readNum);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.readStart);
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Controls.Add(this.comboBox_station);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.materialSingleLineTextField2);
            this.tabPage4.Controls.Add(this.label_setdatabase);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(949, 365);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "การตั้งค่า";
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // bt_deleteCard
            // 
            this.bt_deleteCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_deleteCard.Depth = 0;
            this.bt_deleteCard.Location = new System.Drawing.Point(841, 317);
            this.bt_deleteCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_deleteCard.Name = "bt_deleteCard";
            this.bt_deleteCard.Primary = true;
            this.bt_deleteCard.Size = new System.Drawing.Size(102, 41);
            this.bt_deleteCard.TabIndex = 51;
            this.bt_deleteCard.Text = "ลบข้อมูลบัตร";
            this.bt_deleteCard.UseVisualStyleBackColor = true;
            this.bt_deleteCard.Click += new System.EventHandler(this.bt_deleteCard_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(262, 289);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 13);
            this.label17.TabIndex = 50;
            this.label17.Text = "Data to Write";
            this.label17.Visible = false;
            // 
            // writeData
            // 
            this.writeData.Location = new System.Drawing.Point(6, 285);
            this.writeData.Name = "writeData";
            this.writeData.Size = new System.Drawing.Size(250, 20);
            this.writeData.TabIndex = 49;
            this.writeData.Text = "FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF";
            this.writeData.Visible = false;
            // 
            // writeKey
            // 
            this.writeKey.FormattingEnabled = true;
            this.writeKey.Items.AddRange(new object[] {
            "A0 A1 A2 A3 A4 A5",
            "B0 B1 B2 B3 B4 B5",
            "FF FF FF FF FF FF"});
            this.writeKey.Location = new System.Drawing.Point(7, 337);
            this.writeKey.Name = "writeKey";
            this.writeKey.Size = new System.Drawing.Size(152, 21);
            this.writeKey.TabIndex = 48;
            this.writeKey.Text = "FF FF FF FF FF FF";
            this.writeKey.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(165, 341);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "The 6 Bytes Block Key";
            this.label14.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(206, 314);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 13);
            this.label15.TabIndex = 46;
            this.label15.Text = "Number of Blocks";
            this.label15.Visible = false;
            // 
            // writeNum
            // 
            this.writeNum.FormattingEnabled = true;
            this.writeNum.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04"});
            this.writeNum.Location = new System.Drawing.Point(160, 311);
            this.writeNum.Name = "writeNum";
            this.writeNum.Size = new System.Drawing.Size(40, 21);
            this.writeNum.TabIndex = 45;
            this.writeNum.Text = "01";
            this.writeNum.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(53, 314);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 13);
            this.label16.TabIndex = 44;
            this.label16.Text = "Starting Block";
            this.label16.Visible = false;
            // 
            // writeStart
            // 
            this.writeStart.FormattingEnabled = true;
            this.writeStart.Items.AddRange(new object[] {
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
            this.writeStart.Location = new System.Drawing.Point(7, 311);
            this.writeStart.Name = "writeStart";
            this.writeStart.Size = new System.Drawing.Size(40, 21);
            this.writeStart.TabIndex = 43;
            this.writeStart.Text = "10";
            this.writeStart.Visible = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.writeKeyA);
            this.groupBox6.Controls.Add(this.writeKeyB);
            this.groupBox6.Location = new System.Drawing.Point(138, 245);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(112, 34);
            this.groupBox6.TabIndex = 42;
            this.groupBox6.TabStop = false;
            this.groupBox6.Visible = false;
            // 
            // writeKeyA
            // 
            this.writeKeyA.AutoSize = true;
            this.writeKeyA.Checked = true;
            this.writeKeyA.Location = new System.Drawing.Point(6, 12);
            this.writeKeyA.Name = "writeKeyA";
            this.writeKeyA.Size = new System.Drawing.Size(50, 17);
            this.writeKeyA.TabIndex = 0;
            this.writeKeyA.TabStop = true;
            this.writeKeyA.Text = "KeyA";
            this.writeKeyA.UseVisualStyleBackColor = true;
            // 
            // writeKeyB
            // 
            this.writeKeyB.AutoSize = true;
            this.writeKeyB.Location = new System.Drawing.Point(59, 12);
            this.writeKeyB.Name = "writeKeyB";
            this.writeKeyB.Size = new System.Drawing.Size(50, 17);
            this.writeKeyB.TabIndex = 1;
            this.writeKeyB.Text = "KeyB";
            this.writeKeyB.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.writeIdle);
            this.groupBox7.Controls.Add(this.writeAll);
            this.groupBox7.Location = new System.Drawing.Point(7, 245);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(106, 34);
            this.groupBox7.TabIndex = 41;
            this.groupBox7.TabStop = false;
            this.groupBox7.Visible = false;
            // 
            // writeIdle
            // 
            this.writeIdle.AutoSize = true;
            this.writeIdle.Checked = true;
            this.writeIdle.Location = new System.Drawing.Point(6, 12);
            this.writeIdle.Name = "writeIdle";
            this.writeIdle.Size = new System.Drawing.Size(42, 17);
            this.writeIdle.TabIndex = 0;
            this.writeIdle.TabStop = true;
            this.writeIdle.Text = "Idle";
            this.writeIdle.UseVisualStyleBackColor = true;
            // 
            // writeAll
            // 
            this.writeAll.AutoSize = true;
            this.writeAll.Location = new System.Drawing.Point(59, 12);
            this.writeAll.Name = "writeAll";
            this.writeAll.Size = new System.Drawing.Size(36, 17);
            this.writeAll.TabIndex = 1;
            this.writeAll.Text = "All";
            this.writeAll.UseVisualStyleBackColor = true;
            // 
            // bt_toSting
            // 
            this.bt_toSting.Depth = 0;
            this.bt_toSting.Location = new System.Drawing.Point(706, 269);
            this.bt_toSting.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_toSting.Name = "bt_toSting";
            this.bt_toSting.Primary = true;
            this.bt_toSting.Size = new System.Drawing.Size(80, 29);
            this.bt_toSting.TabIndex = 36;
            this.bt_toSting.Text = "To String";
            this.bt_toSting.UseVisualStyleBackColor = true;
            this.bt_toSting.Visible = false;
            // 
            // bt_toString
            // 
            this.bt_toString.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_toString.Depth = 0;
            this.bt_toString.Location = new System.Drawing.Point(613, 269);
            this.bt_toString.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_toString.Name = "bt_toString";
            this.bt_toString.Primary = true;
            this.bt_toString.Size = new System.Drawing.Size(81, 28);
            this.bt_toString.TabIndex = 35;
            this.bt_toString.Text = "to Hex";
            this.bt_toString.UseVisualStyleBackColor = true;
            this.bt_toString.Visible = false;
            // 
            // bt_saveData
            // 
            this.bt_saveData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_saveData.Depth = 0;
            this.bt_saveData.Location = new System.Drawing.Point(706, 233);
            this.bt_saveData.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_saveData.Name = "bt_saveData";
            this.bt_saveData.Primary = true;
            this.bt_saveData.Size = new System.Drawing.Size(80, 29);
            this.bt_saveData.TabIndex = 34;
            this.bt_saveData.Text = "SAVE";
            this.bt_saveData.UseVisualStyleBackColor = true;
            this.bt_saveData.Visible = false;
            this.bt_saveData.Click += new System.EventHandler(this.bt_saveData_Click_1);
            // 
            // readKey
            // 
            this.readKey.FormattingEnabled = true;
            this.readKey.Items.AddRange(new object[] {
            "A0 A1 A2 A3 A4 A5",
            "B0 B1 B2 B3 B4 B5",
            "FF FF FF FF FF FF"});
            this.readKey.Location = new System.Drawing.Point(482, 340);
            this.readKey.Name = "readKey";
            this.readKey.Size = new System.Drawing.Size(152, 21);
            this.readKey.TabIndex = 33;
            this.readKey.Text = "FF FF FF FF FF FF";
            this.readKey.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(640, 343);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "The 6 Bytes Block Key";
            this.label13.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(659, 309);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Number of Blocks";
            this.label11.Visible = false;
            // 
            // readNum
            // 
            this.readNum.FormattingEnabled = true;
            this.readNum.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04"});
            this.readNum.Location = new System.Drawing.Point(613, 306);
            this.readNum.Name = "readNum";
            this.readNum.Size = new System.Drawing.Size(40, 21);
            this.readNum.TabIndex = 30;
            this.readNum.Text = "01";
            this.readNum.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(529, 309);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Starting Block";
            this.label12.Visible = false;
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
            this.readStart.Location = new System.Drawing.Point(483, 306);
            this.readStart.Name = "readStart";
            this.readStart.Size = new System.Drawing.Size(40, 21);
            this.readStart.TabIndex = 28;
            this.readStart.Text = "10";
            this.readStart.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.readKeyA);
            this.groupBox5.Controls.Add(this.readKeyB);
            this.groupBox5.Location = new System.Drawing.Point(484, 267);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(112, 34);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Visible = false;
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
            this.groupBox4.Location = new System.Drawing.Point(484, 233);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(106, 34);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Visible = false;
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
            // comboBox_station
            // 
            this.comboBox_station.DataSource = this.tbstationsBindingSource;
            this.comboBox_station.DisplayMember = "station_name";
            this.comboBox_station.FormattingEnabled = true;
            this.comboBox_station.Location = new System.Drawing.Point(176, 111);
            this.comboBox_station.Name = "comboBox_station";
            this.comboBox_station.Size = new System.Drawing.Size(121, 21);
            this.comboBox_station.TabIndex = 6;
            this.comboBox_station.ValueMember = "station_id";
            // 
            // tbstationsBindingSource
            // 
            this.tbstationsBindingSource.DataMember = "tb_stations";
            this.tbstationsBindingSource.DataSource = this.rMTTSDataSet;
            // 
            // rMTTSDataSet
            // 
            this.rMTTSDataSet.DataSetName = "RMTTSDataSet";
            this.rMTTSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(448, 28);
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
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 527);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "สถานะ :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lb_statusNow
            // 
            this.lb_statusNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_statusNow.AutoSize = true;
            this.lb_statusNow.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_statusNow.ForeColor = System.Drawing.Color.Red;
            this.lb_statusNow.Location = new System.Drawing.Point(88, 527);
            this.lb_statusNow.Name = "lb_statusNow";
            this.lb_statusNow.Size = new System.Drawing.Size(158, 28);
            this.lb_statusNow.TabIndex = 3;
            this.lb_statusNow.Text = "ไม่พบการทำรายการ";
            // 
            // tb_stationsTableAdapter
            // 
            this.tb_stationsTableAdapter.ClearBeforeFill = true;
            // 
            // tbmaterialsBindingSource
            // 
            this.tbmaterialsBindingSource.DataMember = "tb_materials";
            this.tbmaterialsBindingSource.DataSource = this.rMTTSDataSet;
            // 
            // tb_materialsTableAdapter
            // 
            this.tb_materialsTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 564);
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
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_transport)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbstationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMTTSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmaterialsBindingSource)).EndInit();
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
        private Label label_setdatabase;
        private TabPage tabPage3;
        private DataGridView dataGridView_transport;
        private MaterialSingleLineTextField txt_searhCar;
        private MaterialSingleLineTextField materialSingleLineTextField2;
        private Label label_name;
        private Label label3;
        private Label label5;
        private Label lb_statusNow;
        private Label label4;
        private Label label9;
        private MaterialLabel materialLabel3;
        private MaterialLabel materialLabel2;
        private MaterialLabel materialLabel1;
        private MaterialLabel materialLabel4;
        private DateTimePicker dateTimePicker_to;
        private DateTimePicker dateTimePicker_from;
        private Label label7;
        private Label label8;
        private Label label10;
        private MaterialRaisedButton bt_readRfid;
        private Label lb_tp_vehicle;
        private Label lb_timeTag;
        private Label lb_dateTime;
        private ComboBox comboBox_station;
        private RMTTSDataSet rMTTSDataSet;
        private BindingSource tbstationsBindingSource;
        private RMTTSDataSetTableAdapters.tb_stationsTableAdapter tb_stationsTableAdapter;
        private Label lb_curStation;
        private Label lb_previousStation;
        private Label lb_previousStatus;
        private Label lb_curStatus;
        private MaterialRaisedButton bt_clear;
        private MaterialRaisedButton bt_toSting;
        private MaterialRaisedButton bt_toString;
        private MaterialRaisedButton bt_saveData;
        private ComboBox readKey;
        private Label label13;
        private Label label11;
        private ComboBox readNum;
        private Label label12;
        private ComboBox readStart;
        private GroupBox groupBox5;
        private RadioButton readKeyA;
        private RadioButton readKeyB;
        private GroupBox groupBox4;
        private RadioButton readIdle;
        private RadioButton readAll;
        private Label label17;
        private TextBox writeData;
        private ComboBox writeKey;
        private Label label14;
        private Label label15;
        private ComboBox writeNum;
        private Label label16;
        private ComboBox writeStart;
        private GroupBox groupBox6;
        private RadioButton writeKeyA;
        private RadioButton writeKeyB;
        private GroupBox groupBox7;
        private RadioButton writeIdle;
        private RadioButton writeAll;
        private MaterialRaisedButton bt_search;
        private Label lb_rawMat;
        private MaterialRaisedButton bt_deleteCard;
        private ComboBox comboBox_material;
        private BindingSource tbmaterialsBindingSource;
        private RMTTSDataSetTableAdapters.tb_materialsTableAdapter tb_materialsTableAdapter;
        private TextBox textResponse;
    }
}