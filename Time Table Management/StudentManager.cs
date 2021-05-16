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
    public partial class StudentManager : Form
    {
        public StudentManager()
        {
            InitializeComponent();
        }

        private void StudentManager_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            string conn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

            string query = "SELECT * FROM StudentGroupsTable";
            SqlConnection connection = new SqlConnection(conn);

            SqlDataAdapter dadapter = new SqlDataAdapter(query, connection);
            DataSet ds = new DataSet();


            connection.Open();

            dadapter.Fill(ds, "StudentGroupsTable");
            connection.Close();

            dgv.DataSource = ds;
            dgv.DataMember = "StudentGroupsTable";

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

            string query = "INSERT INTO StudentGroupsTable (StudentGroup,SubGroup,TimeFrom,TimeTo) VALUES (@sg,@sgr,@tf,@tt)";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);

            
            cmd.Parameters.AddWithValue("@sg", groupDrop.Text);
            cmd.Parameters.AddWithValue("@sgr", subDrop.Text);
            cmd.Parameters.AddWithValue("@tf", dateTimeFromPicker.Value.ToString().Split(' ')[1] + " " + dateTimeFromPicker.Value.ToString().Split(' ')[2]);
            cmd.Parameters.AddWithValue("@tt", dateTimeToPicker.Value.ToString().Split(' ')[1] + " " + dateTimeToPicker.Value.ToString().Split(' ')[2]);

            cmd.ExecuteNonQuery();

            connection.Close();
            RefreshData();

            MessageBox.Show("Not Available Time Of Students Added Successfully");
         
            subDrop.SelectedItem = null;
            groupDrop.SelectedItem = null;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            subDrop.SelectedItem = null;
            groupDrop.SelectedItem = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (idTxt.Text.Length <= 0)
            {
                MessageBox.Show("You must enter an id to continue");
            }
            else
            {

                string conn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

                string query = "DELETE FROM StudentGroupsTable WHERE StudentId=@id;";
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

                string query = "SELECT * FROM StudentGroupsTable WHERE StudentId=" + Int32.Parse(idTxt.Text.ToString()) + ";";


                SqlConnection connection = new SqlConnection(conn);
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", idTxt.Text);

                using (IDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                       
                        String group = dr["StudentGroup"].ToString();
                        String subgroup = dr["SubGroup"].ToString();
                        String timefrom = dr["TimeFrom"].ToString();
                        String timeto = dr["TimeTo"].ToString();


                        MessageBox.Show(
                            "Student Group - " + group + "\n\n" +
                            "Sub Group - " + subgroup + "\n\n" +
                                        "Time From - " + timefrom + "\n\n" +
                                        "Time To - " + timeto);


                    }
                }




                connection.Close();




            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
