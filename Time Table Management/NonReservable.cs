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
    public partial class NonReservable : Form
    {
        public NonReservable()
        {
            InitializeComponent();
        }

        private void NonReservable_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            string conn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

            string query = "SELECT * FROM NonReservable";
            SqlConnection connection = new SqlConnection(conn);

            SqlDataAdapter dadapter = new SqlDataAdapter(query, connection);
            DataSet ds = new DataSet();


            connection.Open();

            dadapter.Fill(ds, "NonReservable");
            connection.Close();

            dgv.DataSource = ds;
            dgv.DataMember = "NonReservable";

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

            string query = "INSERT INTO NonReservable (Date,Subject,Room,TimeFrom,TimeTo) VALUES (@dt,@su,@rm,@tf,@tt)";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);


            cmd.Parameters.AddWithValue("@dt", datePicker.SelectionRange.Start.ToShortDateString());
            cmd.Parameters.AddWithValue("@su", subDrop.Text);
            cmd.Parameters.AddWithValue("@rm", roomDrop.Text);
            cmd.Parameters.AddWithValue("@tf", dateTimeFromPicker.Value.ToString().Split(' ')[1] + " " + dateTimeFromPicker.Value.ToString().Split(' ')[2]);
            cmd.Parameters.AddWithValue("@tt", dateTimeToPicker.Value.ToString().Split(' ')[1] + " " + dateTimeToPicker.Value.ToString().Split(' ')[2]);

            cmd.ExecuteNonQuery();

            connection.Close();
            RefreshData();

            MessageBox.Show("Non Reservable Room Added Successfully");

            subDrop.SelectedItem = null;
            roomDrop.SelectedItem = null;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            subDrop.SelectedItem = null;
            roomDrop.SelectedItem = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idTxt.Text.Length <= 0)
            {
                MessageBox.Show("You must enter an id to continue");
            }
            else
            {

                string conn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

                string query = "DELETE FROM NonReservable WHERE TimeId=@id;";
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", idTxt.Text);
                cmd.ExecuteNonQuery();

                connection.Close();

                RefreshData();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (idTxt.Text.Length <= 0)
            {

                MessageBox.Show("You must enter an id to continue"); //View

            }
            else
            {
                string conn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

                string query = "SELECT * FROM NonReservable WHERE TimeId=" + Int32.Parse(idTxt.Text.ToString()) + ";";


                SqlConnection connection = new SqlConnection(conn);
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", idTxt.Text);

                using (IDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {

                        String date = dr["Date"].ToString();
                        String sub = dr["Subject"].ToString();
                        String room = dr["Room"].ToString();
                        String timefrom = dr["TimeFrom"].ToString();
                        String timeto = dr["TimeTo"].ToString();


                        MessageBox.Show(
                            "Date - " + date + "\n\n" +
                            "Subject - " + sub + "\n\n" +
                            "Room - " + room + "\n\n" +
                                        "Time From - " + timefrom + "\n\n" +
                                        "Time To - " + timeto);


                    }
                }




                connection.Close();




            }
        }
    }
}
