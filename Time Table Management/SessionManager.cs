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
    public partial class SessionManager : Form
    {
        private object se;

        public SessionManager()
        {
            InitializeComponent();
            LecFillCombo();
            GroupFillCombo();
        
       
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void RefreshData()
        {
            string conn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

            string query = "SELECT * FROM SessionTable";
            SqlConnection connection = new SqlConnection(conn);

            SqlDataAdapter dadapter = new SqlDataAdapter(query, connection);
            DataSet ds = new DataSet();


            connection.Open();

            dadapter.Fill(ds, "SessionTable");
            connection.Close();

            dgv.DataSource = ds;
            dgv.DataMember = "SessionTable";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            RefreshData();
           

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        void LecFillCombo()
        {
            string myconnstring = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            string sql = "select * from Lecturer";
            SqlConnection conn = new SqlConnection(myconnstring);
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader LecReader;

            try
            {
                conn.Open();
                LecReader = cmd.ExecuteReader();

                while (LecReader.Read())
                {
                    // Load Lecturers first names and last names to combobox
                    string title = LecReader["Title"].ToString();
                    string fname = LecReader["FirstName"].ToString();
                    string lname = LecReader["LastName"].ToString();
                    comboBox1.Items.Add(title + " " + fname + " " + lname);
                   // comboBoxLecturer2.Items.Add(title + " " + fname + " " + lname);
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

        }

        void GroupFillCombo()
        {
            string myconnstring = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            string sql = "select * from tbl_studentg";
            SqlConnection conn = new SqlConnection(myconnstring);
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader LecReader;

            try
            {
                conn.Open();
                LecReader = cmd.ExecuteReader();

                while (LecReader.Read())
                {
                    // Load Lecturers first names and last names to combobox
                    string gid = LecReader["GroupID"].ToString();
                    string sgid = LecReader["SubGroupID"].ToString();
                  
                    groupDrop.Items.Add(gid);
                    subDrop.Items.Add(sgid);
                    // comboBoxLecturer2.Items.Add(title + " " + fname + " " + lname);
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

        }



        private void submitBtn_Click(object sender, EventArgs e)
        {


            



            string conn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            string query = "INSERT INTO SessionTable (Lecture,SelectedGroup,SubGroup,TimeFrom,TimeTo) VALUES (@lc,@sg,@sug,@tf,@tt)";
           
            SqlConnection connection = new SqlConnection(conn);
            connection.Open(); 
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@lc", comboBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@sg", groupDrop.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@sug", subDrop.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@tf", dateTimeFromPicker.Value.ToString().Split(' ')[1] + " " + dateTimeFromPicker.Value.ToString().Split(' ')[2]);
            cmd.Parameters.AddWithValue("@tt", dateTimeToPicker.Value.ToString().Split(' ')[1] + " " + dateTimeToPicker.Value.ToString().Split(' ')[2]);
            cmd.ExecuteNonQuery();
            connection.Close();




            RefreshData();

            MessageBox.Show("Session Added Successfully");
            //lecText.Text = "";
            comboBox1.SelectedItem = null;
            subDrop.SelectedItem = null;
            groupDrop.SelectedItem = null;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = null;
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

                string query = "DELETE FROM SessionTable WHERE ID=@id;";
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

                string query = "SELECT * FROM SessionTable WHERE ID=" + Int32.Parse(idTxt.Text.ToString()) + ";";


                SqlConnection connection = new SqlConnection(conn);
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", idTxt.Text);

                using (IDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        String lecname = dr["Lecture"].ToString();
                        String group = dr["SelectedGroup"].ToString();
                        String subgroup = dr["SubGroup"].ToString();
                        String timefrom = dr["TimeFrom"].ToString();
                        String timeto = dr["TimeTo"].ToString();


                        MessageBox.Show("Lecture Name - " + lecname + "\n\n" +
                            "Selected Group - " + group + "\n\n" +
                            "Sub Group - " + subgroup + "\n\n" +
                                        "Time From - " + timefrom + "\n\n" +
                                        "Time To - " + timeto);


                    }
                }




                connection.Close();




            }


        }

        private void lecText_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupDrop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
