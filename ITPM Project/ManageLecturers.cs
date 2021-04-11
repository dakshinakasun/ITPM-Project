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
    public partial class ManageLecturers : Form
    {
        public ManageLecturers()
        {
            InitializeComponent();
        }

        Classes.LecturerClass l = new Classes.LecturerClass();

        private void Clear()
        {
            textBoxId.Text = "";
            comboBoxTitle.SelectedIndex = -1;
            textBoxRank.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxLectureID.Text = "";
            comboBoxCenter.SelectedIndex = -1;
            //comboBoxFaculty.SelectedIndex = -1;
            comboBoxBuilding.SelectedIndex = -1;
            comboBoxDepartment.SelectedIndex = -1;
            comboBoxLevel.SelectedIndex = -1;
            textBoxSearch.Text = "";

        }


        private void ManageLecturers_Load(object sender, EventArgs e)
        {
            //Load data on data grid view
            DataTable dt = l.Select();
            dataGridViewLecturers.DataSource = dt;
        }

        private void comboBoxFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDepartment.Items.Clear();

            if (comboBoxFaculty.SelectedItem.Equals("Computing"))
            {
                comboBoxDepartment.Items.Add("CSSE");
                comboBoxDepartment.Items.Add("DS");
                comboBoxDepartment.Items.Add("CSNE");
                comboBoxDepartment.Items.Add("IT");
                comboBoxDepartment.Items.Add("SE");
                comboBoxDepartment.Items.Add("CS");
                comboBoxDepartment.Items.Add("IM");
            }
            else if (comboBoxFaculty.SelectedItem.Equals("Engineering"))
            {
                comboBoxDepartment.Items.Add("CE");
                comboBoxDepartment.Items.Add("EEE");
                comboBoxDepartment.Items.Add("ME");
                comboBoxDepartment.Items.Add("QS");
            }
            else if (comboBoxFaculty.SelectedItem.Equals("Business"))
            {
                comboBoxDepartment.Items.Add("AF");
                comboBoxDepartment.Items.Add("BA");
                comboBoxDepartment.Items.Add("HCM");
                comboBoxDepartment.Items.Add("MM");
                comboBoxDepartment.Items.Add("IM");
                comboBoxDepartment.Items.Add("BM");
            }
            else if (comboBoxFaculty.SelectedItem.Equals("Humanities and Science"))
            {
                comboBoxDepartment.Items.Add("MU");
                comboBoxDepartment.Items.Add("ELT");
            }
        }

        private void bntUpdate_Click_1(object sender, EventArgs e)
        {

            //Call Generate Method

            Boolean rankGenResult = rankGen();

            //..................Validations.............................

            //Title Combo Box
            if (comboBoxTitle.Text == "")
                MessageBox.Show("Please Fill Lecturer Title...!");

            //Lecture First Name Text Box
            else if (textBoxFirstName.Text == "")
                MessageBox.Show("Please Fill Lecturer First Name...!");
            else if (System.Text.RegularExpressions.Regex.IsMatch(textBoxFirstName.Text, "[^a-zA-Z]"))
                MessageBox.Show("Please Enter Letters Only For Lecturer First Name...!");

            //Lecture Last Name Text Box
            else if (textBoxLastName.Text == "")
                MessageBox.Show("Please Fill Lecturer Last Name...!");
            else if (System.Text.RegularExpressions.Regex.IsMatch(textBoxFirstName.Text, "[^a-zA-Z]"))
                MessageBox.Show("Please Enter Letters Only For Lecturer Last Name...!");

            //Lecture Faculty Combo Box
            else if (comboBoxFaculty.Text == "")
                MessageBox.Show("Please Fill Lecturer Faculty...!");

            //Lecture Department Combo Box
            else if (comboBoxDepartment.Text == "")
                MessageBox.Show("Please Fill Lecturer Department...!");

            //Lecture Faculty Combo Box
            else if (comboBoxCenter.Text == "")
                MessageBox.Show("Please Fill Lecturer Center...!");

            //Lecture Building Combo Box
            else if (comboBoxBuilding.Text == "")
                MessageBox.Show("Please Fill Lecturer Buliding...!");

            //Lecture Level Combo Box
            else if (comboBoxLevel.Text == "")
                MessageBox.Show("Please Fill Lecturer Level...!");

            else
            {

                //get the data from textboxes
                l.Id = int.Parse(textBoxId.Text);
                l.Title = comboBoxTitle.Text;
                l.Rank = textBoxRank.Text;
                l.FirstName = textBoxFirstName.Text;
                l.LastName = textBoxLastName.Text;
                l.LectureID = int.Parse(textBoxLectureID.Text);
                l.Center = comboBoxCenter.Text;
                l.Faculty = comboBoxFaculty.Text;
                l.Building = comboBoxBuilding.Text;
                l.Department = comboBoxDepartment.Text;
                l.LecLevel = comboBoxLevel.Text;

                //update data in database
                bool success = l.Update(l);
                if (success == true)
                {
                    //Uplode successfully
                    MessageBox.Show("Lecturer has been updated.");

                    //Load data on data grid view
                    DataTable dt = l.Select();
                    dataGridViewLecturers.DataSource = dt;

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

        private void dataGridViewLecturers_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get the data from data grid view and load the textboxes 
            int rowIndex = e.RowIndex;
            textBoxId.Text = dataGridViewLecturers.Rows[rowIndex].Cells[0].Value.ToString();
            comboBoxTitle.Text = dataGridViewLecturers.Rows[rowIndex].Cells[1].Value.ToString();
            textBoxRank.Text = dataGridViewLecturers.Rows[rowIndex].Cells[2].Value.ToString();
            textBoxFirstName.Text = dataGridViewLecturers.Rows[rowIndex].Cells[3].Value.ToString();
            textBoxLastName.Text = dataGridViewLecturers.Rows[rowIndex].Cells[4].Value.ToString();
            textBoxLectureID.Text = dataGridViewLecturers.Rows[rowIndex].Cells[5].Value.ToString();
            comboBoxCenter.Text = dataGridViewLecturers.Rows[rowIndex].Cells[6].Value.ToString();
            comboBoxFaculty.Text = dataGridViewLecturers.Rows[rowIndex].Cells[7].Value.ToString();
            comboBoxBuilding.Text = dataGridViewLecturers.Rows[rowIndex].Cells[8].Value.ToString();
            comboBoxDepartment.Text = dataGridViewLecturers.Rows[rowIndex].Cells[9].Value.ToString();
            comboBoxLevel.Text = dataGridViewLecturers.Rows[rowIndex].Cells[10].Value.ToString();
        }


        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (comboBoxTitle.Text == "" && textBoxRank.Text == "" && textBoxFirstName.Text == "" && textBoxLastName.Text == "" && textBoxLectureID.Text == "" && comboBoxCenter.Text == "" && comboBoxBuilding.Text == "" && comboBoxDepartment.Text == "" && comboBoxLevel.Text == "")
                MessageBox.Show("Fields Are Empty...!");
            else
            {
                //get data from the textboxes
                l.Id = Convert.ToInt32(textBoxId.Text);
                bool success = l.Delete(l);
                if (success == true)
                {
                    //Successfully Deleted
                    MessageBox.Show("Lecturer Deleted Successfully");

                    //refresh data grid view
                    //Load data on data grid view
                    DataTable dt = l.Select();
                    dataGridViewLecturers.DataSource = dt;

                    //Call clear method
                    Clear();
                }
                else
                {
                    //Failed to deleted
                    MessageBox.Show("Failed to Delete Lecturer... Try Again...!");
                }
            }
        }

        private void bntClear_Click(object sender, EventArgs e)
        {
            if (comboBoxTitle.Text == "" && textBoxRank.Text == "" && textBoxFirstName.Text == "" && textBoxLastName.Text == "" && textBoxLectureID.Text == "" && comboBoxCenter.Text == "" && comboBoxBuilding.Text == "" && comboBoxDepartment.Text == "" && comboBoxLevel.Text == "" && textBoxSearch.Text == "")
                MessageBox.Show("Fields Are Empty...!");
            else
            {
                //Call clear method
                Clear();
            }

        }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            {
                //get the value from textbox
                string keyword = textBoxSearch.Text;
                SqlConnection conn = new SqlConnection(myconnstring);
                SqlDataAdapter oda = new SqlDataAdapter("SELECT * FROM Lecturer WHERE FirstName LIKE '%" + keyword + "%' OR LastName LIKE '%" + keyword + "%'", conn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridViewLecturers.DataSource = dt;
            }
        }

        //....................Rank Generate Method...................
        public Boolean rankGen()
        {
            Dictionary<String, int> rankGen = new Dictionary<string, int>();
            rankGen.Add("Professor", 1);
            rankGen.Add("Assistant Professor", 2);
            rankGen.Add("Senior Lecturer(HG)", 3);
            rankGen.Add("Senior Lecturer", 4);
            rankGen.Add("Lecturer", 5);
            rankGen.Add("Assistant Lecturer", 6);

            if (textBoxLectureID.Text != "" && comboBoxLevel.Text != "")
            {
                int value = rankGen[comboBoxLevel.Text];

                StringBuilder sb = new StringBuilder();
                sb.Append(value + "." + textBoxLectureID.Text);

                textBoxRank.Text = sb.ToString();
                return true;
            }
            else
            {
                //MessageBox.Show("Please Fill Lecturer ID And Lecturer Level...!");
                return false;
            }
        }

        //Close Form
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
