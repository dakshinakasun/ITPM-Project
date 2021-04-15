using StudentAndTagProject.Classes;
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

namespace StudentAndTagProject
{
    public partial class ManageTag : Form
    {
        public ManageTag()
        {
            InitializeComponent();
        }
        StudentTag c = new StudentTag();

        public void Clear()
        {
            textBoxid.Text = "";
            comboBoxTagNameManage.SelectedIndex = -1;
            comboCodeTag.SelectedIndex = -1;
            comboBoxRelatedTag.SelectedIndex = -1;
     

        }

        private void ManageTag_Load(object sender, EventArgs e)
        {

            //Load data on data grid view
            DataTable dt = c.Select();
            dataGridViewManageTag.DataSource = dt;
        }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        private void textBoxSearchManageTag_TextChanged(object sender, EventArgs e)
        {
            //get the value from textbox
            string keyword = textBoxSearchManageTag.Text;
            SqlConnection conn = new SqlConnection(myconnstring);
            SqlDataAdapter oda = new SqlDataAdapter("SELECT * FROM tbl_tag WHERE SubjectName LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridViewManageTag.DataSource = dt;
        }

        private void btnUpdateManage_Click(object sender, EventArgs e)
        {

            //get the data from textboxes
            c.ID = int.Parse(textBoxid.Text);
            c.SubjectName = comboBoxTagNameManage.Text;
            c.SubjectCode = Convert.ToInt32(comboCodeTag.Text);
            c.RelatedTag = comboBoxRelatedTag.Text;
                

                //update data in database
                bool success = c.Update(c);
                if (success == true)
                {
                    //Uplode successfully
                    MessageBox.Show("Details has been updated.");

                    //Load data on data grid view
                    DataTable dt = c.Select();
                    dataGridViewManageTag.DataSource = dt;

                    //call the clear method
                    Clear();
                }
                else
                {
                    //Failed to updated
                    MessageBox.Show("Failed to updated... Tey Again...!");
                }
            
        }

       

        private void btnDeleteManage_Click(object sender, EventArgs e)
        {
            //get data from the textboxes
            c.ID = Convert.ToInt32(textBoxid.Text);
            bool success = c.Delete(c);
            if (success == true)
            {
                //Successfully Deleted
                MessageBox.Show("Deleted Successfully");

                //refresh data grid view
                //Load data on data grid view
                DataTable dt = c.Select();
                dataGridViewManageTag.DataSource = dt;

                //Call clear method
                Clear();
            }
            else
            {
                //Failed to deleted
                MessageBox.Show("Failed to Delete... Try Again...!");
            }
        }

        private void btnClearManage_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void ManageTag_Load_1(object sender, EventArgs e)
        {
            //Load data on data grid view
            DataTable dt = c.Select();
            dataGridViewManageTag.DataSource = dt;
        }

        private void dataGridViewManageTag_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textBoxid.Text = dataGridViewManageTag.Rows[rowIndex].Cells[0].Value.ToString();
            comboBoxTagNameManage.Text = dataGridViewManageTag.Rows[rowIndex].Cells[1].Value.ToString();
            comboCodeTag.Text = dataGridViewManageTag.Rows[rowIndex].Cells[2].Value.ToString();
            comboBoxRelatedTag.Text = dataGridViewManageTag.Rows[rowIndex].Cells[3].Value.ToString();
        }
    }
}
