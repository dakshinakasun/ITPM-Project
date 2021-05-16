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
    public partial class PreferredSessions : Form
    {
        public PreferredSessions()
        {
            InitializeComponent();
        }

        private void PreferredSessions_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            string conn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

            string query = "SELECT * FROM PreferredSessionsTable";
            SqlConnection connection = new SqlConnection(conn);

            SqlDataAdapter dadapter = new SqlDataAdapter(query, connection);
            DataSet ds = new DataSet();


            connection.Open();

            dadapter.Fill(ds, "PreferredSessionsTable");
            connection.Close();

            dgv.DataSource = ds;
            dgv.DataMember = "PreferredSessionsTable";

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {

            string conn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

            string query = "INSERT INTO PreferredSessionsTable (Date,Subject,SelectedGroup,Subgroup,TimeFrom,TimeTo) VALUES (@dt,@su,@sg,@sgr,@tf,@tt)";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);


            cmd.Parameters.AddWithValue("@dt", datePicker.SelectionRange.Start.ToShortDateString());
            cmd.Parameters.AddWithValue("@su", subDrop.Text);
            cmd.Parameters.AddWithValue("@sg", groupDrop.Text);
            cmd.Parameters.AddWithValue("@sgr", subGroupDrop.Text);
            cmd.Parameters.AddWithValue("@tf", dateTimeFromPicker.Value.ToString().Split(' ')[1] + " " + dateTimeFromPicker.Value.ToString().Split(' ')[2]);
            cmd.Parameters.AddWithValue("@tt", dateTimeToPicker.Value.ToString().Split(' ')[1] + " " + dateTimeToPicker.Value.ToString().Split(' ')[2]);

            cmd.ExecuteNonQuery();

            connection.Close();
            RefreshData();

            MessageBox.Show("Preferred Session Added Successfully");

            subDrop.SelectedItem = null;
            groupDrop.SelectedItem = null;
            subGroupDrop.SelectedItem = null;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void clearBtn_Click_1(object sender, EventArgs e)
        {
            subDrop.SelectedItem = null;
            groupDrop.SelectedItem = null;
            subGroupDrop.SelectedItem = null;
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

                string query = "DELETE FROM PreferredSessionsTable WHERE SessionId=@id;";
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

                string query = "SELECT * FROM PreferredSessionsTable WHERE SessionId=" + Int32.Parse(idTxt.Text.ToString()) + ";";


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
                        String group = dr["SelectedGroup"].ToString();
                        String subgroup = dr["SubGroup"].ToString();
                        String timefrom = dr["TimeFrom"].ToString();
                        String timeto = dr["TimeTo"].ToString();


                        MessageBox.Show(
                            "Date - " + date + "\n\n" +
                            "Subject - " + sub + "\n\n" +
                            "Group - " + group + "\n\n" +
                            "Sub Group - " + subgroup + "\n\n" +
                                        "Time From - " + timefrom + "\n\n" +
                                        "Time To - " + timeto);


                    }
                }




                connection.Close();




            }
        }
    }
}
