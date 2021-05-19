using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace StudentAndTagProject
{
    public partial class session : Form
    {
        public session()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void session_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTPMDataSet7.concecutive' table. You can move, or remove it, as needed.
            this.concecutiveTableAdapter1.Fill(this.iTPMDataSet7.concecutive);
            // TODO: This line of code loads data into the 'iTPMDataSet5.concecutive' table. You can move, or remove it, as needed.
            this.concecutiveTableAdapter.Fill(this.iTPMDataSet5.concecutive);
            // TODO: This line of code loads data into the 'iTPMDataSet3.Session' table. You can move, or remove it, as needed.
            
            DataGridViewCheckBoxColumn chkbox = new DataGridViewCheckBoxColumn();
            chkbox.HeaderText = "";
            chkbox.Width = 30;
            chkbox.Name = "checkBoxColumn";
            dataGridView1.Columns.Insert(0, chkbox);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        

        private void btnpara_Click(object sender, EventArgs e)
        {
            this.Hide();
            parallel f7 = new parallel();
            f7.Show();
        }

        private void btnaddSession_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["StudentAndTagProject.Properties.Settings.ITPMConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);

            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                bool chkboxselected = Convert.ToBoolean(dr.Cells["checkBoxColumn"].Value);
                if(chkboxselected)
                {
                    string sqlquery = "Insert into [dbo].[concecutive] values (@Tag,@StudentSubGroup,@Subject)";
                    SqlCommand sqlcomm = new SqlCommand(sqlquery,sqlconn);
                    sqlcomm.Parameters.AddWithValue("@Tag", dr.Cells[2].Value);
                    sqlcomm.Parameters.AddWithValue("@StudentSubGroup", dr.Cells[3].Value);
                    sqlcomm.Parameters.AddWithValue("@Subject", dr.Cells[4].Value); 
                    sqlconn.Open();
                    sqlcomm.ExecuteNonQuery();
                    sqlconn.Close();

                }

            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            parallel f9 = new parallel ();
            f9.Show();
        }
    }
}
