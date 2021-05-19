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
    public partial class AddSession : Form
    {
        public AddSession()
        {
            InitializeComponent();
            LecFillCombo();
            SubFillCombo();
            GroupFillCombo();
        }

        SessionClass se = new SessionClass();

        private void Clear()
        {
            comboBoxLecture1.SelectedIndex = -1;
            comboBoxLecturer2.SelectedIndex = -1;
            comboBoxSelectTag.SelectedIndex = -1;
            comboBoxSelectGroup.SelectedIndex = -1;
            comboBoxSelectSubGroup.SelectedIndex = -1;
            comboBoxSelectSubject.SelectedIndex = -1;
            comboBoxSelectDuration.SelectedIndex = -1;
            textBoxNoOfStudents.Text = "";

        }

        //Lecture Name combobox loding method
        void LecFillCombo()
        {
            string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
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
                    comboBoxLecture1.Items.Add(title + " " + fname + " " + lname);
                    comboBoxLecturer2.Items.Add(title + " " + fname + " " + lname);
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

        //Subject Names and codes combobox loding method
        void SubFillCombo()
        {
            string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            string sql = "select * from Subjects";
            SqlConnection conn = new SqlConnection(myconnstring);
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader SubReader;

            try
            {
                conn.Open();
                SubReader = cmd.ExecuteReader();

                while (SubReader.Read())
                {
                    string sname = SubReader["SubjectName"].ToString();
                    string scode = SubReader["SubjectCode"].ToString();
                    comboBoxSelectSubject.Items.Add(sname + " - " + scode);
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

        //Group No and Sub group no combobox loding method
        void GroupFillCombo()
        {
            string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            string sql = "select * from tbl_studentg";
            SqlConnection conn = new SqlConnection(myconnstring);
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader GroupReader;

            try
            {
                conn.Open();
                GroupReader = cmd.ExecuteReader();

                while (GroupReader.Read())
                {
                    string gno = GroupReader["GroupID"].ToString();
                    string sgno = GroupReader["SubGroupID"].ToString();
                    comboBoxSelectGroup.Items.Add(gno);
                    comboBoxSelectSubGroup.Items.Add(sgno);
                    
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

        //Close Button
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //.............................Clear Button.....................................
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (comboBoxLecture1.Text == "" && comboBoxLecturer2.Text == "" && comboBoxSelectTag.Text == "" && comboBoxSelectGroup.Text == "" && comboBoxSelectSubGroup.Text == "" && comboBoxSelectSubject.Text == "" && comboBoxSelectDuration.Text == "" && textBoxNoOfStudents.Text == "")
                MessageBox.Show("Fields  Are Empty...!");
            else
            {
                //call the clear method
                Clear();
            }
        }

        //.............................Add Session Button.....................................
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //........................Validation..........................

            //Lecture 1 Combo Box
            if (comboBoxLecture1.Text == "")
                MessageBox.Show("Please Select Lecturer...!");

            //Lecture 2 Combo Box
            else if (comboBoxSelectTag.Text == "")
                MessageBox.Show("Please Select Tag...!");

            //Group Combo Box
            else if (comboBoxSelectGroup.Text == "")
                MessageBox.Show("Please Select Group...!");

            //Sub Group Combo Box
            else if (comboBoxSelectSubGroup.Text == "")
                MessageBox.Show("Please Select Sub Group...!");

            //Sub Group Combo Box
            else if (comboBoxSelectSubject.Text == "")
                MessageBox.Show("Please Select Subject...!");

            //Duration Combo Box
            else if (comboBoxSelectDuration.Text == "")
                MessageBox.Show("Please Select Duration Time...!");

            //No Of Student Text Box
            else if (textBoxNoOfStudents.Text == "")
                MessageBox.Show("Please Fill No Of Students...!");
            else if (System.Text.RegularExpressions.Regex.IsMatch(textBoxNoOfStudents.Text, "[^0-9]"))
                MessageBox.Show("Please Enter Number Only For No Of Students...!");

            else
            {

                //get the value from the inpute fileds
                se.FirstLectureName = comboBoxLecture1.Text;
                se.SecondLectureName = comboBoxLecturer2.Text;
                se.Tag = comboBoxSelectTag.Text;
                se.StudentGroup = comboBoxSelectGroup.Text;
                se.StudentSubGroup = comboBoxSelectSubGroup.Text;
                se.Subject = comboBoxSelectSubject.Text;
                se.Duration = comboBoxSelectDuration.Text;
                se.NoOfStudents = Convert.ToInt32(textBoxNoOfStudents.Text);

                //Insert data into data using the method we created
                bool success = se.Insert(se);
                if (success == true)
                {
                    //successfuly inserted
                    MessageBox.Show("New Session Inserted Successfully");
                    //call the clear method
                    Clear();
                }
                else
                {
                    //Faild to add Subject
                    MessageBox.Show("Failed to Add new Session... Try Again...!");
                }
            }
        }
    }
}
