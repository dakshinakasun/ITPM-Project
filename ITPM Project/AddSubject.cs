using ITPM_Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITPM_Project
{
    public partial class AddSubject : Form
    {
        public AddSubject()
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
            numericUpDownNoOfLectHour.Value = 0;
            numericUpDownNoOfLabHour.Value = 0;
            numericUpDownNoOfTuteHour.Value = 0;
            numericUpDownNoOfEvaluHours.Value = 0;

        }

        //.............................Add Subject Button.....................................
        private void btnAdd_Click(object sender, EventArgs e)
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
            else if (System.Text.RegularExpressions.Regex.IsMatch(textBoxSubjectCode.Text, "[^a-zA-Z0-9]"))
                MessageBox.Show("Please Enter Letters And Numbers Only For Subject Code...!");
            else
            {

                //get the value from the inpute fileds
                s.SubjectName = textBoxSubjectName.Text;
                s.SubjectCode = textBoxSubjectCode.Text;
                s.OfferedYear = comboBoxOfferdYear.Text;
                s.OfferedSem = comboBoxOfferedSemester.Text;
                s.LecHours = Convert.ToInt32(numericUpDownNoOfLectHour.Text);
                s.LabHours = Convert.ToInt32(numericUpDownNoOfLabHour.Text);
                s.TuteHours = Convert.ToInt32(numericUpDownNoOfTuteHour.Text);
                s.EvaluHours = Convert.ToInt32(numericUpDownNoOfEvaluHours.Text);

                //Insert data into data using the method we created
                bool success = s.Insert(s);
                if (success == true)
                {
                    //successfuly inserted
                    MessageBox.Show("New Subject Inserted Successfully");
                    //call the clear method
                    Clear();
                }
                else
                {
                    //Faild to add Subject
                    MessageBox.Show("Failed to Add new Subject... Try Again...!");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (comboBoxOfferdYear.Text == "" && comboBoxOfferedSemester.Text == "" && textBoxSubjectName.Text == "" && textBoxSubjectCode.Text == "")
                MessageBox.Show("Fields  Are Empty...!");
            else
            {
                //call the clear method
                Clear();
            }

        }

        //Close Form
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
