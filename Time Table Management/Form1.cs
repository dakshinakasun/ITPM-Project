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
    public partial class Form1 : Form

        
    {
        int selected_days = 0;
        List<string> dayslist = new List<string>();

        public Form1()
        {
            InitializeComponent();

            numericUpDown1.Value = selected_days;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dayslist.Add("Sunday");
                selected_days = selected_days + 1;
                numericUpDown1.Value = selected_days;
            }
            else
            {
                if (dayslist.Contains("Sunday"))
                {
                    dayslist.Remove("Sunday");
                }
           
                selected_days = selected_days - 1;
                numericUpDown1.Value = selected_days;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox5.Checked)
            {
                dayslist.Add("Wednesday");
                selected_days = selected_days + 1;
                numericUpDown1.Value = selected_days;
            }
            else
            {
                if (dayslist.Contains("Wednesday"))
                {
                    dayslist.Remove("Wednesday");
                }

                selected_days = selected_days - 1;
                numericUpDown1.Value = selected_days;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (idtext.Text.Length <= 0)
            {
                MessageBox.Show("You must enter an id to continue");
            }
            else
            {

                Form2 edit = new Form2(idtext.Text.ToString());
                edit.FormClosed += Edit_FormClosed;
                edit.Show();
            }
        }
        private void Edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshData();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox2.Checked)
            {
                dayslist.Add("Monday");
                selected_days = selected_days + 1;
                numericUpDown1.Value = selected_days;
            }
            else
            {
                if (dayslist.Contains("Monday"))
                {
                    dayslist.Remove("Monday");
                }

                selected_days = selected_days - 1;
                numericUpDown1.Value = selected_days;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox3.Checked)
            {
                dayslist.Add("Tuesday");
                selected_days = selected_days + 1;
                numericUpDown1.Value = selected_days;
            }
            else
            {
                if (dayslist.Contains("Tuesday"))
                {
                    dayslist.Remove("Tuesday");
                }

                selected_days = selected_days - 1;
                numericUpDown1.Value = selected_days;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox6.Checked)
            {
                dayslist.Add("Thursday");
                selected_days = selected_days + 1;
                numericUpDown1.Value = selected_days;
            }
            else
            {
                if (dayslist.Contains("Thursday"))
                {
                    dayslist.Remove("Thursday");
                }

                selected_days = selected_days - 1;
                numericUpDown1.Value = selected_days;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox4.Checked)
            {
                dayslist.Add("Friday");
                selected_days = selected_days + 1;
                numericUpDown1.Value = selected_days;
            }
            else
            {
                if (dayslist.Contains("Friday"))
                {
                    dayslist.Remove("Friday");
                }
                selected_days = selected_days - 1;
                numericUpDown1.Value = selected_days;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox7.Checked)
            {
                dayslist.Add("Saturday");
                selected_days = selected_days + 1;
                numericUpDown1.Value = selected_days;
            }
            else
            {
                if (dayslist.Contains("Saturday"))
                {
                    dayslist.Remove("Saturday");
                }
                selected_days = selected_days - 1;
                numericUpDown1.Value = selected_days;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            RefreshData();
         //   dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);

        }

        private void RefreshData()
        {
            string conn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

            string query = "SELECT * FROM WorkingDaysTable";
            SqlConnection connection = new SqlConnection(conn);

            SqlDataAdapter dadapter = new SqlDataAdapter(query, connection);

            DataSet ds = new DataSet();

            connection.Open();
            dadapter.Fill(ds, "WorkingDaysTable");
            connection.Close();
            dgv.DataSource = ds;
            dgv.DataMember = "WorkingDaysTable";



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selected_days.Equals(0))
            {


                MessageBox.Show("You must select at least one day");

            }
            else
            {


                string conn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

                string query = "INSERT INTO WorkingDaysTable (WorkingDays,TimeFrom,TimeTo) VALUES (@wd,@tf,@tt)";
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();

               
                String[] str = dayslist.ToArray();


                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@wd", string.Join(",", str));
                cmd.Parameters.AddWithValue("@tf", dateTimeFromPicker.Value.ToString().Split(' ')[1]+" "+ dateTimeFromPicker.Value.ToString().Split(' ')[2]);
                cmd.Parameters.AddWithValue("@tt", dateTimeToPicker.Value.ToString().Split(' ')[1] + " " + dateTimeToPicker.Value.ToString().Split(' ')[2]);

                cmd.ExecuteNonQuery();

                connection.Close();
                RefreshData();

            }
        }

        private void button3_Click(object sender, EventArgs e)

        {

            if(idtext.Text.Length <= 0)
            {
                MessageBox.Show("You must enter an id to continue");
            }
            else
            {

                string conn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

                string query = "DELETE FROM WorkingDaysTable WHERE Timeid=@id;";
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", idtext.Text);
                cmd.ExecuteNonQuery();

                connection.Close();

                RefreshData();

            }

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(idtext.Text.Length <= 0)
            {

                MessageBox.Show("You must enter an id to continue"); //View

            }
            else
            {
                string conn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

                string query = "SELECT * FROM WorkingDaysTable WHERE Timeid="+Int32.Parse(idtext.Text.ToString())+";";
                

                SqlConnection connection = new SqlConnection(conn);
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", idtext.Text);
                
                using (IDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        String workingdays = dr["WorkingDays"].ToString();
                        String timefrom = dr["TimeFrom"].ToString();
                        String timeto = dr["TimeTo"].ToString();


                        MessageBox.Show("Working Days Are -" + workingdays + "\n\n" +
                                        "Time From - " + timefrom + "\n\n" +
                                        "Time To - " + timeto);


                    }
                }


               

                connection.Close();




            }



        }

        private void button5_Click(object sender, EventArgs e)
        {

            Form3 ts = new Form3();
            ts.Show();
        }
    }
}
