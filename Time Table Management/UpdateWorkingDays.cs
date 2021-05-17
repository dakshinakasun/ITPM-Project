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
    public partial class UpdateWorkingDays : Form
    {
        int selected_days = 0;
        List<string> dayslist = new List<string>();
        int idnum;

        public UpdateWorkingDays(string id)
        {

            InitializeComponent();
            label1.Text = "Updating Working Time on Record " + id;
            label1.Text = label1.Text.ToUpper();
            idnum = Int32.Parse(id);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dayslist.Add("Sunday");
                selected_days = selected_days + 1;
               
            }
            else
            {
                if (dayslist.Contains("Sunday"))
                {
                    dayslist.Remove("Sunday");
                }

                selected_days = selected_days - 1;
              
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                dayslist.Add("Monday");
                selected_days = selected_days + 1;

            }
            else
            {
                if (dayslist.Contains("Monday"))
                {
                    dayslist.Remove("Monday");
                }

                selected_days = selected_days - 1;

            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                dayslist.Add("Tuesday");
                selected_days = selected_days + 1;

            }
            else
            {
                if (dayslist.Contains("Tuesday"))
                {
                    dayslist.Remove("Tuesday");
                }

                selected_days = selected_days - 1;

            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                dayslist.Add("Wednesday");
                selected_days = selected_days + 1;

            }
            else
            {
                if (dayslist.Contains("Wednesday"))
                {
                    dayslist.Remove("Wednesday");
                }

                selected_days = selected_days - 1;

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                dayslist.Add("Thursday");
                selected_days = selected_days + 1;

            }
            else
            {
                if (dayslist.Contains("Thursday"))
                {
                    dayslist.Remove("Thursday");
                }

                selected_days = selected_days - 1;

            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                dayslist.Add("Friday");
                selected_days = selected_days + 1;

            }
            else
            {
                if (dayslist.Contains("Friday"))
                {
                    dayslist.Remove("Friday");
                }

                selected_days = selected_days - 1;

            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                dayslist.Add("Saturday");
                selected_days = selected_days + 1;

            }
            else
            {
                if (dayslist.Contains("Saturday"))
                {
                    dayslist.Remove("Saturday");
                }

                selected_days = selected_days - 1;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string conn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

            string query = "UPDATE WorkingDaysTable SET workingdays=@wd,timefrom=@tf,timeto=@tt WHERE Timeid=@id";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            String[] str = dayslist.ToArray();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", idnum);
            cmd.Parameters.AddWithValue("@wd", string.Join(",", str));
            cmd.Parameters.AddWithValue("@tf", dateTimeFromPicker.Value.ToString().Split(' ')[1] + " " + dateTimeFromPicker.Value.ToString().Split(' ')[2]);
            cmd.Parameters.AddWithValue("@tt", dateTimeToPicker.Value.ToString().Split(' ')[1] + " " + dateTimeToPicker.Value.ToString().Split(' ')[2]);


            cmd.ExecuteNonQuery();

            connection.Close();
            
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
