using ITPM_Project.Classes;
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

namespace ITPM_Project
{
    public partial class ManageSubjects : Form
    {
        public ManageSubjects()
        {
            InitializeComponent();
        }

        SubjectClass s = new SubjectClass();

        //method to clear fields
        public void Clear()
        {
            textBoxSubjectName.Text = "";
            textBoxSubjectCode.Text = "";
            comboBoxOfferdYear.SelectedIndex = -1;
            comboBoxOfferedSemester.SelectedIndex = -1;
            numericUpNoOfLecHour.Value = 0;
            numericUpDownNoOfLabHour.Value = 0;
            numericUpDownNoOfTuteHour.Value = 0;
            numericUpDownNoOfEvaluHours.Value = 0;
            textBoxSearch.Text = "";

        }

        private void bntClear_Click(object sender, EventArgs e)
        {
            if (textSubjectID.Text == "" && comboBoxOfferdYear.Text == "" && comboBoxOfferedSemester.Text == "" && textBoxSubjectName.Text == "" && textBoxSubjectCode.Text == "" && textBoxSearch.Text == "")
                MessageBox.Show("Fields  Are Empty...!");
            else
            {
                //Call Clear Method
                Clear();
            }
        }

        private void ManageSubjects_Load(object sender, EventArgs e)
        {
            //Load data on data grid view
            DataTable dt = s.Select();
            dataGridViewSubjects.DataSource = dt;
        }



        //....................Update button.................................
        private void bntUpdate_Click(object sender, EventArgs e)
        {

            //........................Validation..........................

            //Offered Year Combo Box
            if (comboBoxOfferdYear.Text == "")
                MessageBox.Show("Please Fill Offered Year...!");

            //Offered Semester Combo Box
            else if (comboBoxOfferedSemester.Text == "")
                MessageBox.Show("Please Fill Offered Semester...!");

            //Subject Name Test Box
            else if (textBoxSubjectName.Text == "")
                MessageBox.Show("Please Fill Subject Name...!");
            else if (System.Text.RegularExpressions.Regex.IsMatch(textBoxSubjectName.Text, "[^a-zA-Z ]"))
                MessageBox.Show("Please Enter Letters Only For Subject Name...!");

            //Subject Code Test Box
            else if (textBoxSubjectCode.Text == "")
                MessageBox.Show("Please Fill Subject Code...!");
            else if (System.Text.RegularExpressions.Regex.IsMatch(textBoxSubjectCode.Text, "[^a-zA-Z0-9 ]"))
                MessageBox.Show("Please Enter Letters And Numbers Only For Subject Code...!");

            else
            {

                //get the data from textboxes
                //get the value from the inpute fileds
                s.SubjectID = int.Parse(textSubjectID.Text);
                s.SubjectName = textBoxSubjectName.Text;
                s.SubjectCode = textBoxSubjectCode.Text;
                s.OfferedYear = comboBoxOfferdYear.Text;
                s.OfferedSem = comboBoxOfferedSemester.Text;
                s.LecHours = Convert.ToInt32(numericUpNoOfLecHour.Text);
                s.LabHours = Convert.ToInt32(numericUpDownNoOfLabHour.Text);
                s.TuteHours = Convert.ToInt32(numericUpDownNoOfTuteHour.Text);
                s.EvaluHours = Convert.ToInt32(numericUpDownNoOfEvaluHours.Text);

                //update data in database
                bool success = s.Update(s);
                if (success == true)
                {
                    //Uplode successfully
                    MessageBox.Show("Subject has been updated.");

                    //Load data on data grid view
                    DataTable dt = s.Select();
                    dataGridViewSubjects.DataSource = dt;

                    //call the clear method
                    Clear();
                }
                else
                {
                    //Failed to updated
                    MessageBox.Show("Failed to updated... Tey Again...!");
                }
            }
        }

        private void dataGridViewSubjects_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get the data from data grid view and load the textboxes 
            int rowIndex = e.RowIndex;
            textSubjectID.Text = dataGridViewSubjects.Rows[rowIndex].Cells[0].Value.ToString();
            textBoxSubjectName.Text = dataGridViewSubjects.Rows[rowIndex].Cells[1].Value.ToString();
            textBoxSubjectCode.Text = dataGridViewSubjects.Rows[rowIndex].Cells[2].Value.ToString();
            comboBoxOfferdYear.Text = dataGridViewSubjects.Rows[rowIndex].Cells[3].Value.ToString();
            comboBoxOfferedSemester.Text = dataGridViewSubjects.Rows[rowIndex].Cells[4].Value.ToString();
            numericUpNoOfLecHour.Text = dataGridViewSubjects.Rows[rowIndex].Cells[5].Value.ToString();
            numericUpDownNoOfLabHour.Text = dataGridViewSubjects.Rows[rowIndex].Cells[6].Value.ToString();
            numericUpDownNoOfTuteHour.Text = dataGridViewSubjects.Rows[rowIndex].Cells[7].Value.ToString();
            numericUpDownNoOfEvaluHours.Text = dataGridViewSubjects.Rows[rowIndex].Cells[8].Value.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (textSubjectID.Text == "")
                MessageBox.Show("Fields Are Empty... Cannot Delete...!");
            else
            {

                //get data from the textboxes
                s.SubjectID = Convert.ToInt32(textSubjectID.Text);
                bool success = s.Delete(s);
                if (success == true)
                {
                    //Successfully Deleted
                    MessageBox.Show("Subject Deleted Successfully");

                    //refresh data grid view
                    //Load data on data grid view
                    DataTable dt = s.Select();
                    dataGridViewSubjects.DataSource = dt;

                    //Call clear method
                    Clear();
                }
                else
                {
                    //Failed to deleted
                    MessageBox.Show("Failed to Delete Subject... Try Again...!");
                }
            }
        }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            //get the value from textbox
            string keyword = textBoxSearch.Text;
            SqlConnection conn = new SqlConnection(myconnstring);
            SqlDataAdapter oda = new SqlDataAdapter("SELECT * FROM Subjects WHERE SubjectName LIKE '%" + keyword + "%' OR SubjectCode LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridViewSubjects.DataSource = dt;
        }

        //Close Form
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
