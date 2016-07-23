using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data;            // for access ms sql
using System.Data.SqlClient;  // for access ms sql
using System.Text.RegularExpressions;
using System.Threading.Tasks;   //For delay function
using System.Text;
using System.Globalization;
using System.Net;
using System.Linq;

namespace MaterialSkinExample
{
    public partial class MainForm : MaterialForm
    {
        private String Hex_transectionID = "";
        private int needToNew = 0;
        private string String_transactionID = null;
        private string String_transactionStatus = null;
        private readonly MaterialSkinManager materialSkinManager;
        public MainForm()
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        //DataSet ds = new DataSet(); // create ds
        //string cn = "Data Source =.; Initial Catalog = RMTTS; User ID = Nineza; Password = 1234";
        //SqlConnection conn = new SqlConnection("Server=.\\SQLEXPRESS; Database=RMTTS; Trusted_Connection=True;");
        //good//SqlConnection conn = new SqlConnection("Server=.\\SQLEXPRESS;Initial Catalog = RMTTS; Persist Security Info=True;User ID = newnine; Password=ninenine;");
        //Data Source = NEXT - GCDLTNPKUF\SQLEXPRESS;Initial Catalog = RMTTS; Persist Security Info=True;User ID = newnine; Password=ninenine
        //SqlConnection con = new SqlConnection("Server=.\\SQLEXPRESS;Initial Catalog = RMTTS; Persist Security Info=True;User ID = newnine; Password=ninenine;");

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rMTTSDataSet.tb_stations' table. You can move, or remove it, as needed.
            this.tb_stationsTableAdapter.Fill(this.rMTTSDataSet.tb_stations);

            /*
            try
            {
                conn.Open();
                Showdata();
            }
            catch
            {
                MessageBox.Show("Error");
            }
            */
        }

        private void Showdata()
        {
            string sql = "SELECT * FROM tb_staff";
            SqlCommand com = new SqlCommand(sql, conn);
            SqlDataReader dr = com.ExecuteReader();

            DataTable dt = new DataTable();

            if (dr.HasRows)
            {
                dt.Load(dr);
                dataGridView_transport.DataSource = dt;
            }
            else
            {
                dataGridView_transport.DataSource = null;
            }
            dr.Close();
        }


        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            string sql = "SELECT * FROM tb_staff";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(ds, "RMTTS");

            dataGridView_transport.DataSource = ds.Tables["RMTTS"];
            */
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }

        private void label3_Click_3(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label_setdatabase_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField8_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField7_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField7_Click_1(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField5_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField9_Click(object sender, EventArgs e)
        {

        }

        private void showStatue(int Code)
        {
            string msg = "";
            switch (Code)
            {
                case 0x00:
                    msg = "Command succeed.....";
                    break;
                case 0x01:
                    msg = "Command failed.....";
                    break;
                case 0x02:
                    msg = "Checksum error.....";
                    break;
                case 0x03:
                    msg = "Not selected COM port.....";
                    break;
                case 0x04:
                    msg = "Reply time out.....";
                    break;
                case 0x05:
                    msg = "Check sequence error.....";
                    break;
                case 0x07:
                    msg = "Check sum error.....";
                    break;
                case 0x0A:
                    msg = "The parameter value out of range.....";
                    break;
                case 0x80:
                    msg = "Command OK.....";
                    break;
                case 0x81:
                    msg = "Command FAILURE.....";
                    break;
                case 0x82:
                    msg = "Reader reply time out error.....";
                    break;
                case 0x83:
                    msg = "The card does not exist.....";
                    break;
                case 0x84:
                    msg = "The data is error.....";
                    break;
                case 0x85:
                    msg = "Reader received unknown command.....";
                    break;
                case 0x87:
                    msg = "Error.....";
                    break;
                case 0x89:
                    msg = "The parameter of the command or the format of the command error.....";
                    break;
                case 0x8A:
                    msg = "Some error appear in the card InitVal process.....";
                    break;
                case 0x8B:
                    msg = "Get the wrong snr during anticollison loop.....";
                    break;
                case 0x8C:
                    msg = "The authentication failure.....";
                    break;
                case 0x8F:
                    msg = "Reader received unknown command.....";
                    break;
                case 0x90:
                    msg = "The card do not support this command.....";
                    break;
                case 0x91:
                    msg = "The foarmat of the command error.....";
                    break;
                case 0x92:
                    msg = "Do not support option mode.....";
                    break;
                case 0x93:
                    msg = "The block do not exist.....";
                    break;
                case 0x94:
                    msg = "The object have been locked.....";
                    break;
                case 0x95:
                    msg = "The lock operation do not success.....";
                    break;
                case 0x96:
                    msg = "The operation do not success.....";
                    break;
            }
            textResponse.Text += msg + "\r\n";
        }

        //แปลงข้อมูล
        private byte[] convertSNR(string str, int keyN)
        {
            string regex = "[^a-fA-F0-9]";
            string tmpJudge = Regex.Replace(str, regex, "");

            if (tmpJudge.Length != 12) return null;

            string[] tmpResult = Regex.Split(str, regex);
            byte[] result = new byte[keyN];
            int i = 0;
            foreach (string tmp in tmpResult)
            {
                result[i] = Convert.ToByte(tmp, 16);
                i++;
            }
            return result;
        }

        //แสดงข้อมูล
        private void showData(string text, byte[] data, int s, int e)
        {

            //Clear value in label
            textResponse.Text = "";
            /*for (int i = 0; i < e; i++)
            {
                if (data[s + i] < 0)
                    data[s + i] = Convert.ToByte(Convert.ToInt32(data[s + i]) + 256);
            }
            textResponse.Text += text;*/

            //for (int i = s; i < e; i++)
            //{
            //    textResponse.Text += data[i].ToString("X2")+" ";
            //}
            //textResponse.Text += "\r\n";

            for (int i = 0; i < e; i++)
            {
                textResponse.Text += data[s + i].ToString("X2") + " ";
            }
            //ใช้แสดงคำในกรอบ
            //textResponse.Text += "\r\n\r\n";
            //textResponse.Text = "e0 b8 95 e0 b8 a5 e0 b8 81 35 35 35";
            //Display car license
            lb_tp_vehicle.Text = HexStringToString(textResponse.Text, Encoding.UTF8);
        }

        private DateTime getDateTime()
        {
            SqlCommand cmd = new SqlCommand("select getdate()", conn);
            //Open The database
            conn.Open();
            DataSet ds = new DataSet();
            DateTime strDatetime;
            strDatetime = (DateTime)cmd.ExecuteScalar();
            //close The databse
            conn.Close();
            return strDatetime;
        }

        /*setBUZZER*/
        private void btn_ControlBuzzer_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[1];
            //string strErrorCode = "";

            int nRet = Reader.ControlBuzzer(18, 1, buffer);

            //if (nRet != 0)
            //{
            //    strErrorCode = FormatErrorCode(buffer);

            //    WriteLog("Succeed Hints Error", nRet, strErrorCode);
            //}
            //else
            //{
            //    WriteLog("Succeed Hints", nRet, strErrorCode);
            //}
            showStatue(nRet);
            showStatue(buffer[0]);
        }

        //ปุ่มกดอ่าน RFID
        private async void bt_readRfid_Click(object sender, EventArgs e)
        {
            byte mode1 = (readKeyB.Checked) ? (byte)0x01 : (byte)0x00;
            byte mode2 = (readAll.Checked) ? (byte)0x01 : (byte)0x00;
            byte mode = (byte)((mode1 << 1) | mode2);
            byte blk_add = Convert.ToByte(readStart.Text, 16);
            byte num_blk = Convert.ToByte(readNum.Text, 16);


            byte[] snr = new byte[6];
            snr = convertSNR(readKey.Text, 6);
            if (snr == null)
            {
                MessageBox.Show("Invalid Serial Number! from read Rfid button", "ERROR");
                return;
            }

            byte[] buffer = new byte[16 * num_blk];

            int nRet = Reader.MF_Read(mode, blk_add, num_blk, snr, buffer);
            //string strErrorCode;

            //ใช้แสดงสถานะว่าอ่านสำเร็จหรือไม่
            //showStatue(nRet);
            if (nRet != 0)
            {
                //strErrorCode = FormatErrorCode(buffer);
                //WriteLog("Failed: ", nRet, strErrorCode);
                showStatue(buffer[0]);
            }
            else
            {
                //ส่งเสียง
                /*byte[] buffer_bff = new byte[1];
                int nRetf = Reader.ControlBuzzer(14, 1, buffer_bff);
                showStatue(nRet);
                showStatue(buffer_bff[0]);
                */
                //แสดงผล
                //showData("CardNumber: ", snr, 0, 4);
                showData("Data: ", buffer, 0, 12 * num_blk);

                //Display current time
                currTime();
                //Display current station
                currStation();
                //เช็คว่าต้อง Update or Insert
                setNewLoop();
                if (needToNew == 1)
                {
                    //Insert data (ยังไม่มีข้อมูลในระบบ หรือ อาจจะเริ่มต้น Transaction ใหม่)
                    createTransection();
                    needToNew = 0;
                    lb_statusNow.ForeColor = System.Drawing.Color.Green;
                    lb_previousStation.Text = "----";
                    lb_statusNow.Text = "เริ่มต้นการทำรายการใหม่";
                    await Task.Delay(10000);         //set for doing something
                    lb_statusNow.ForeColor = System.Drawing.Color.Red;
                    resetRabel();
                }
                else if (needToNew == 0)
                {
                    //Update data (มี Transaction ที่ยังไม่เสร็จในระบบ) 

                    readPrimaryKeyFromRFID();
                    getValueFromDatabase(String_transactionID);
                    updateTransection();
                    lb_statusNow.ForeColor = System.Drawing.Color.Green;
                    lb_statusNow.Text = "อัพเดตข้อมูลใหม่";
                    await Task.Delay(10000);         //set for doing something
                    lb_statusNow.ForeColor = System.Drawing.Color.Red;
                    resetRabel();
                }
                else
                {
                    MessageBox.Show("ข้อมูลในบัตรผิดพลาด กรุณาติดต่อเจ้าหน้าที่");
                }

            }
        }


        private void createTransection()
        {
            //Write Hex into the RFID card
            string str_autokey = autoGenKey();
            string Hex_autokey = StringToHexString(str_autokey, Encoding.UTF8);
            //MessageBox.Show(Hex_autokey + " FF FF");
            writeRFID("8", "1", Hex_autokey + " FF FF");
            //format 32 35 35 39 31 37 33 33 32 34 33 35 32 36 FF FF
            
            //Insert String into the database
            //card for test: e0 b8 95 e0 b8 a5 e0 b8 81 35 35 35 FF FF FF FF
            string sql = "INSERT INTO tb_transports (tp_id, tp_vehicle, tp_time_get, tp_status, tp_from, tp_material) VALUES('" + str_autokey + "' ,'" + lb_tp_vehicle.Text + "', '" + lb_dateTime.Text + "', '1', '" + comboBox_station.SelectedValue + "', '" + comboBox_station.SelectedValue + "')";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            //MessageBox.Show("Silent Insert completely");
           
        }


        private void updateTransection()
        {
            int int_transactionStatus = Int32.Parse(String_transactionStatus);
            int_transactionStatus += 1;
            string sql = "UPDATE tb_transports SET tp_time_get_finish = '" + lb_dateTime.Text + "', tp_status = '" + int_transactionStatus.ToString() + "' WHERE tp_id = '" + String_transactionID +"' ;";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            String_transactionID = null;
            String_transactionStatus = null;
            conn.Close();
        }

        //get values from database for display in textboxs
        private void getValueFromDatabase(string primarykey)
        {
            string sql = "Select * From tb_transports WHERE tp_id = '" + primarykey + "' ";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            //using (SqlDataReader sdr = cmd.ExecuteReader())
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                lb_previousStatus.Text = translateStatus(sdr["tp_status"].ToString());
                String_transactionStatus = sdr["tp_status"].ToString();
            }

            conn.Close();
        }

        private string translateStatus(string OriginString)
        {
            string translatedStatus;
            if (OriginString == "1")
                translatedStatus = "รับวัตถุดิบจากแหล่ง";
            else if (OriginString == "2")
                translatedStatus = "รับวัตถุดิบเสร็จสิ้น";
            else if (OriginString == "3")
                translatedStatus = "รับวัตถุดิบเสร็จสิ้น";
            else if (OriginString == "4")
                translatedStatus = "รับวัตถุดิบเสร็จสิ้น";
            else
                translatedStatus = "เกิดข้อผิดพลาด";
            return translatedStatus;
        }

        private void writeRFID(string sector, string block, string Hax_text){
            byte mode1 = (writeKeyB.Checked) ? (byte)0x01 : (byte)0x00;
            byte mode2 = (writeAll.Checked) ? (byte)0x01 : (byte)0x00;
            byte mode = (byte)((mode1 << 1) | mode2);
            byte blk_add = Convert.ToByte(sector, 16);
            byte num_blk = Convert.ToByte(block, 16);

            byte[] snr = new byte[6];
            snr = convertSNR(writeKey.Text, 16);
            if (snr == null)
            {
                MessageBox.Show("Invalid Serial Number! in writeRFID snr", "ERROR");
                return;
            }

            byte[] buffer = new byte[16 * num_blk];
            string bufferStr = formatStr(Hax_text, num_blk);
            if (bufferStr == null)
            {
                MessageBox.Show("Invalid Serial Number! in buffer", "ERROR");
                return;
            }
            convertStr(buffer, bufferStr, 16 * num_blk);

            int nRet = Reader.MF_Write(mode, blk_add, num_blk, snr, buffer);
            //string strErrorCode;

            showStatue(nRet);
            if (nRet != 0)
            {
                //strErrorCode = FormatErrorCode(buffer);
                //WriteLog("Failed:", nRet, strErrorCode);
                showStatue(buffer[0]);
            }
            else
            {
                //showData("CardNumber:", snr, 0, 4);
            }

        }

        //Display current station
        private void currStation()
        {
            lb_curStation.Text = comboBox_station.Text;
        }

        //Display current time
        private void currTime()
        {
            SqlCommand cmdDate = new SqlCommand("select getdate()", conn);
            conn.Open();
            DataSet ds = new DataSet();
            DateTime strDatetime = (DateTime)cmdDate.ExecuteScalar();

            //get year month day
            int thaiYear = new ThaiBuddhistCalendar().GetYear(strDatetime);
            int thaiMonth = new ThaiBuddhistCalendar().GetMonth(strDatetime);
            int thaiDay = new ThaiBuddhistCalendar().GetDayOfMonth(strDatetime);
            int thaiHour = new ThaiBuddhistCalendar().GetHour(strDatetime);
            int thaiMinute = new ThaiBuddhistCalendar().GetMinute(strDatetime);
            int thaiSecond = new ThaiBuddhistCalendar().GetSecond(strDatetime);

            //convert year
            thaiYear -= 543 * 2;
            /*
            MessageBox.Show(thaiYear.ToString());
            MessageBox.Show(thaiMonth.ToString());
            MessageBox.Show(thaiDay.ToString());
            */
            DateTime thaiDateTime = new DateTime(thaiYear, thaiMonth, thaiDay, thaiHour, thaiMinute, thaiSecond);
            //MessageBox.Show(thaiDateTime.ToString("yyyy-MM-dd HH:mm:ss"));
            lb_dateTime.Text = thaiDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            conn.Close();
        }

        //
        private String autoGenKey()
        {
            SqlCommand cmdDate = new SqlCommand("select getdate()", conn);
            conn.Open();
            DataSet ds = new DataSet();
            DateTime strDatetime = (DateTime)cmdDate.ExecuteScalar();

            //get year month day
            int thaiYear = new ThaiBuddhistCalendar().GetYear(strDatetime);
            int thaiMonth = new ThaiBuddhistCalendar().GetMonth(strDatetime);
            int thaiDay = new ThaiBuddhistCalendar().GetDayOfMonth(strDatetime);
            int thaiHour = new ThaiBuddhistCalendar().GetHour(strDatetime);
            int thaiMinute = new ThaiBuddhistCalendar().GetMinute(strDatetime);
            int thaiSecond = new ThaiBuddhistCalendar().GetSecond(strDatetime);

            //Fix digit
            thaiMonth += 10;
            thaiDay += 10;
            thaiHour += 10;
            thaiMinute += 10;
            thaiSecond += 10;

            //append string
            String autoKey = ""+ thaiYear.ToString() + thaiMonth.ToString() + thaiDay.ToString() + thaiHour.ToString() + thaiMinute.ToString() + thaiSecond.ToString();

            //MessageBox.Show(autoKey);
            conn.Close();
            return autoKey;
        }

        /*MF_Write_Func*/
        private void bt_writeRFiD_Click(object sender, EventArgs e)
        {
            byte mode1 = (writeKeyB.Checked) ? (byte)0x01 : (byte)0x00;
            byte mode2 = (writeAll.Checked) ? (byte)0x01 : (byte)0x00;
            byte mode = (byte)((mode1 << 1) | mode2);
            byte blk_add = Convert.ToByte(writeStart.Text, 16);
            byte num_blk = Convert.ToByte(writeNum.Text, 16);

            byte[] snr = new byte[6];
            snr = convertSNR(writeKey.Text, 16);
            if (snr == null)
            {
                MessageBox.Show("Invalid Serial Number!", "ERROR");
                return;
            }

            byte[] buffer = new byte[16 * num_blk];
            string bufferStr = formatStr(writeData.Text, num_blk);
            if (bufferStr == null)
            {
                MessageBox.Show("Invalid Serial Number!", "ERROR");
                return;
            }
            convertStr(buffer, bufferStr, 16 * num_blk);

            int nRet = Reader.MF_Write(mode, blk_add, num_blk, snr, buffer);
            //string strErrorCode;

            showStatue(nRet);
            if (nRet != 0)
            {
                //strErrorCode = FormatErrorCode(buffer);
                //WriteLog("Failed:", nRet, strErrorCode);
                showStatue(buffer[0]);
            }
            else
            {
                showData("CardNumber:", snr, 0, 4);
            }
        }

        private string formatStr(string str, int num_blk)
        {

            string tmp = Regex.Replace(str, "[^a-fA-F0-9]", "");
            //长度不对直接报错
            //num_blk==-1指示不用检查位数
            if (num_blk == -1) return tmp;
            //num_blk==其它负数，为-1/num_blk
            if (num_blk < -1)
            {
                if (tmp.Length != -16 / num_blk * 2) return null;
                else return tmp;
            }
            if (tmp.Length != 16 * num_blk * 2) return null;
            else return tmp;
        }

        private void convertStr(byte[] after, string before, int length)
        {
            for (int i = 0; i < length; i++)
            {
                after[i] = Convert.ToByte(before.Substring(2 * i, 2), 16);
            }
        }

        /*get time from web
        public static DateTime GetNistTime()
        {
            var myHttpWebRequest = (HttpWebRequest)WebRequest.Create("https://www.google.co.th");
            var response = myHttpWebRequest.GetResponse();
            string todaysDates = response.Headers["date"];
            DateTime dateTime = DateTime.ParseExact(todaysDates, "ddd, dd MMM yyyy HH:mm:ss 'GMT'", CultureInfo.InvariantCulture.DateTimeFormat, DateTimeStyles.AssumeUniversal);
            return dateTime;
        }
        */




        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        SqlConnection conn = new SqlConnection("Server=.\\SQLEXPRESS;Initial Catalog = RMTTS; Persist Security Info=True;User ID = newnine; Password=ninenine;");
        private async void bt_saveData_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection("Server=.\\SQLEXPRESS; Database=RMTTS; Trusted_Connection=True;");
            try
            {
                //conn.Open();
                insertData();
                lb_statusNow.ForeColor = System.Drawing.Color.Green;
                lb_statusNow.Text = "บันทึกสำเร็จ";
                MessageBox.Show("การบันทึกข้อมูลเสร็จสิ้น");
                await Task.Delay(10000);         //set for doing something
                lb_statusNow.ForeColor = System.Drawing.Color.Red;
                resetRabel();


            }
            catch
            {
                MessageBox.Show("การบันทึกข้อมูลผิดพลาด กรุณาลองใหม่อีกครั้ง");
            }

        }
        private void resetRabel()
        {
            lb_statusNow.Text = "ไม่พบการทำรายการ";
            lb_tp_vehicle.Text = "Car license";
            lb_dateTime.Text = "Date time";
            lb_previousStatus.Text = "Previous status";
            lb_curStation.Text = "Current Station";
        }

        private void insertData()
        {
            string sql = "INSERT INTO tb_transports (tp_vehicle, tp_material, tp_time_get) VALUES('" + lb_tp_vehicle.Text + "', '" + txt_tp_material.Text + "', '" + lb_dateTime.Text + "')";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();


        }

        private void rMTTSDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
       

        private void bt_toHex_Click(object sender, EventArgs e)
        {
            string textString = "ตลก555";
            string textHex = StringToHexString(textString, Encoding.UTF8);
            lb_statusNow.Text = textHex;
        }

        private string toHex(string inp)
        {
            string outp = string.Empty;
            char[] value = inp.ToCharArray();
            foreach (char L in value)
            {
                int V = Convert.ToInt32(L);
                outp += string.Format("{0:x}", V);
            }
            return outp;

        }

        private void bt_toSting_Click(object sender, EventArgs e)
        {
            string HexString = "e0 b8 95 e0 b8 a5 e0 b8 81 35 35 35 ";
            string textString = HexStringToString(HexString, Encoding.UTF8);
            lb_statusNow.Text = textString;
        }


        private string StringToHexString(string s, Encoding encode)
        {
            byte[] b = encode.GetBytes(s);//According to the specified code string programming byte array
            string result = string.Empty;
            for (int i = 0; i < b.Length; i++)//The byte by byte to 16 hexadecimal characters, separated in%
            {
                result += " " + Convert.ToString(b[i], 16);//เว้นด้วยช่องว่าง
            }
            return result;
        }

        private string HexStringToString(string hs, Encoding encode)
        {
            //By division of the string, and remove the null character
            string[] chars = hs.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);//เว้นด้วยช่องว่าง
            byte[] b = new byte[chars.Length];
            //Characters one by one to 16 hexadecimal byte data
            for (int i = 0; i < chars.Length; i++)
            {
                b[i] = Convert.ToByte(chars[i], 16);
            }
            //According to the specified byte array into a string encoding
            return encode.GetString(b);
        }

        //Check RFID  for valid transection 
        private bool checkValidTransaction(String textInput)
        {
            bool IsValid = textInput.All(char.IsDigit);
            //MessageBox.Show(IsValid.ToString());

            return IsValid;// return true or false
        }

        private void lb_tp_vehicle_Click(object sender, EventArgs e)
        {

        }

        private void bt_checkDropDown_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox_station.SelectedValue.ToString());
        }


        private void readPrimaryKeyFromRFID()
        {
            byte mode1 = (readKeyB.Checked) ? (byte)0x01 : (byte)0x00;
            byte mode2 = (readAll.Checked) ? (byte)0x01 : (byte)0x00;
            byte mode = (byte)((mode1 << 1) | mode2);
            byte blk_add = Convert.ToByte("8", 16);
            byte num_blk = Convert.ToByte("1", 16);


            byte[] snr = new byte[6];
            snr = convertSNR(readKey.Text, 6);
            if (snr == null)
            {
                MessageBox.Show("Invalid Serial Number!", "ERROR");
                return;
            }
            byte[] buffer = new byte[16 * num_blk];
            int nRet = Reader.MF_Read(mode, blk_add, num_blk, snr, buffer);
            //ใช้แสดงสถานะว่าอ่านสำเร็จหรือไม่

            if (nRet != 0)
            {
                showStatue(buffer[0]);
            }
            else
            {
                //แสดงผล
                //e0 b8 95 e0 b8 a5 e0 b8 81 35 35 35 FF FF FF FF//12
                //32 35 35 39 31 37 33 33 32 34 33 35 32 36 FF FF//14
                for (int i = 0; i < 14 * num_blk; i++)  // 14 is the length of the key
                {
                    Hex_transectionID += buffer[0 + i].ToString("X2") + " ";
                }
                //MessageBox.Show(Hex_transectionID);
                String_transactionID = HexStringToString(Hex_transectionID, Encoding.UTF8);
                //MessageBox.Show(String_transectionID);
            }
            Hex_transectionID = "";
        }


        //ปุ่มเช็คว่าต้องเริ่ม Transection ใหม่หรือไม่
        private void setNewLoop()
        {
            byte mode1 = (readKeyB.Checked) ? (byte)0x01 : (byte)0x00;
            byte mode2 = (readAll.Checked) ? (byte)0x01 : (byte)0x00;
            byte mode = (byte)((mode1 << 1) | mode2);
            byte blk_add = Convert.ToByte("8", 16);
            byte num_blk = Convert.ToByte("1", 16);


            byte[] snr = new byte[6];
            snr = convertSNR(readKey.Text, 6);
            if (snr == null)
            {
                MessageBox.Show("Invalid Serial Number!", "ERROR");
                return;
            }
            byte[] buffer = new byte[16 * num_blk];
            int nRet = Reader.MF_Read(mode, blk_add, num_blk, snr, buffer);
            //ใช้แสดงสถานะว่าอ่านสำเร็จหรือไม่
         
            if (nRet != 0)
            {
                showStatue(buffer[0]);
            }
            else
            {
                //แสดงผล
                //e0 b8 95 e0 b8 a5 e0 b8 81 35 35 35 FF FF FF FF//12
                //32 35 35 39 31 37 33 33 32 34 33 35 32 36 FF FF//14
                for (int i = 0; i < 14 * num_blk; i++)  // 14 is the length of the key
                {
                    Hex_transectionID += buffer[0 + i].ToString("X2") + " ";
                }
                //MessageBox.Show(Hex_transectionID);
                String String_transectionID = HexStringToString(Hex_transectionID, Encoding.UTF8);
                //MessageBox.Show(String_transectionID);
                bool IsNumberTransection = checkValidTransaction(String_transectionID);
                if (IsNumberTransection)
                {
                    //MessageBox.Show("It is a number");
                    needToNew = 0; // Update the database
                }
                else
                {
                    //MessageBox.Show("It is a text");
                    needToNew = 1;  // Create new transation by insert into the database
                }

            }
            Hex_transectionID = "";
        }

        private void lb_previousStation_Click(object sender, EventArgs e)
        {

        }

        private void lb_previousStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
