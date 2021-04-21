using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Table_Management
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

            string query = "INSERT INTO TimeSlotTable (Type,TimeFrom,TimeTo) VALUES (@ty,@tf,@tt)";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();


            String stype = "One Hour";
            if (radioButtononehour.Checked)
            {
                stype = "One Hour";
            }
            else if (radioButton30min.Checked) {

                stype = "30 Minute";
            
            }


      


            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ty", stype);
            cmd.Parameters.AddWithValue("@tf", dateTimeFromPicker.Value.ToString().Split(' ')[1] + " " + dateTimeFromPicker.Value.ToString().Split(' ')[2]);
            cmd.Parameters.AddWithValue("@tt", dateTimeToPicker.Value.ToString().Split(' ')[1] + " " + dateTimeToPicker.Value.ToString().Split(' ')[2]);

            cmd.ExecuteNonQuery();

            connection.Close();
            RefreshData();




        }
        private void RefreshData()
        {
            string conn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

            string query = "SELECT * FROM TimeSlotTable";
            SqlConnection connection = new SqlConnection(conn);

            SqlDataAdapter dadapter = new SqlDataAdapter(query, connection);

            DataSet ds = new DataSet();

            connection.Open();

            dadapter.Fill(ds, "TimeSlotTable");
            connection.Close();
            tsdgv.DataSource = ds;
            tsdgv.DataMember = "TimeSlotTable";



        }
        private void button3_Click(object sender, EventArgs e)
        {

            if (idtext.Text.Length <= 0)
            {
                MessageBox.Show("You must enter an id to continue");
            }
            else
            {

                string conn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

                string query = "DELETE FROM TimeSlotTable WHERE Slotid=@id;";
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", idtext.Text);
                cmd.ExecuteNonQuery();

                connection.Close();

                RefreshData();

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            RefreshData();
          //  tsdgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
        }

        private void tsdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
