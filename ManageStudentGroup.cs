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
    public partial class ManageStudentGroup : Form
    {
        public ManageStudentGroup()
        {
            InitializeComponent();
        }

        StudentClass s = new StudentClass();

        //method to clear fields
        public void Clear()
        {
            textBoxID.Text = "";
            combomManage.SelectedIndex = -1;
            textBoxGroupID.Text = "";
            textBoxSubGroupID.Text = "";
            comboBoxProgram.SelectedIndex = -1;
            numericUpDownGroupNumber.Value = 0;
            numericUpDownSubGroupNumber.Value = 0;

        }

        private void ManageStudentGroup_Load(object sender, EventArgs e)
        {

            //Load data on data grid view
            DataTable dt = s.Select();
            dataGridViewManageStudentGroup.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //get the data from textboxes
            s.ID = int.Parse(textBoxID.Text);
            s.AcademicYearAndSemester = combomManage.Text;
            s.Programme = comboBoxProgram.Text;
            s.GroupNo = Convert.ToInt32(numericUpDownGroupNumber.Text);
            s.SubGroupNo = Convert.ToInt32(numericUpDownSubGroupNumber.Text);
            s.GroupID = textBoxGroupID.Text;
            s.SubGroupID = textBoxSubGroupID.Text;

            //update data in database
            bool success = s.Update(s);
            if (success == true)
            {
                //Uplode successfully
                MessageBox.Show("Details has been updated.");

                //Load data on data grid view
                DataTable dt = s.Select();
                dataGridViewManageStudentGroup.DataSource = dt;

                //call the clear method
                Clear();
            }
            else
            {
                //Failed to updated
                MessageBox.Show("Failed to updated... Tey Again...!");
            }
        }

        private void dataGridViewManageStudentGroup_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get the data from data grid view and load the textboxes 
            int rowIndex = e.RowIndex;
            textBoxID.Text = dataGridViewManageStudentGroup.Rows[rowIndex].Cells[0].Value.ToString();
            combomManage.Text = dataGridViewManageStudentGroup.Rows[rowIndex].Cells[1].Value.ToString();
            textBoxGroupID.Text = dataGridViewManageStudentGroup.Rows[rowIndex].Cells[2].Value.ToString();
            textBoxSubGroupID.Text = dataGridViewManageStudentGroup.Rows[rowIndex].Cells[3].Value.ToString();
            numericUpDownGroupNumber.Text = dataGridViewManageStudentGroup.Rows[rowIndex].Cells[4].Value.ToString();
            numericUpDownSubGroupNumber.Text = dataGridViewManageStudentGroup.Rows[rowIndex].Cells[5].Value.ToString();
            comboBoxProgram.Text = dataGridViewManageStudentGroup.Rows[rowIndex].Cells[6].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //get data from the textboxes
            s.ID = Convert.ToInt32(textBoxID.Text);
            bool success = s.Delete(s);
            if (success == true)
            {
                //Successfully Deleted
                MessageBox.Show("Deleted Successfully");

                //refresh data grid view
                //Load data on data grid view
                DataTable dt = s.Select();
                dataGridViewManageStudentGroup.DataSource = dt;

                //Call clear method
                Clear();
            }
            else
            {
                //Failed to deleted
                MessageBox.Show("Failed to Delete... Try Again...!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Call clear method
            Clear();
        }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            //get the value from textbox
            string keyword = textBoxSearch.Text;
            SqlConnection conn = new SqlConnection(myconnstring);
            SqlDataAdapter oda = new SqlDataAdapter("SELECT * FROM tbl_studentg WHERE Programme LIKE '%" + keyword + "%' OR GroupID LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridViewManageStudentGroup.DataSource = dt;
        }

        private void dataGridViewManageStudentGroup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAcadamicYearSem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
