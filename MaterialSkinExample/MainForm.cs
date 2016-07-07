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

namespace MaterialSkinExample
{
    public partial class MainForm : MaterialForm
    {
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
        SqlConnection conn = new SqlConnection("Server=.\\SQLEXPRESS; Database=RMTTS; Trusted_Connection=True;");



        private void materialFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                Showdata();
            }
            catch
            {
                MessageBox.Show("Error");
            }
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
    }
}
