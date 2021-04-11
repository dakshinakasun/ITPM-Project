using ITPM_Project.Classes;
using System;
using System.Collections;
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
    public partial class AddLecturer : Form
    {
        public AddLecturer()
        {
            InitializeComponent();
        }

        LecturerClass l = new LecturerClass();

        private void Clear()
        {
            comboBoxTitle.SelectedIndex = -1;
            textBoxRank.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxLecturerID.Text = "";
            comboBoxCenter.SelectedIndex = -1;
            //comboBoxFaculty.SelectedIndex = -1;
            comboBoxBuilding.SelectedIndex = -1;
            comboBoxDepartment.SelectedIndex = -1;
            comboBoxLevel.SelectedIndex = -1;

            //Check Boxes Days
            checkBoxMonday.Checked = false;
            checkBoxTudesday.Checked = false;
            checkBoxWednesday.Checked = false;
            checkBoxThursday.Checked = false;
            checkBoxFriday.Checked = false;

            //Check Boxes Hours
            checkBox830930.Checked = false;
            checkBox9301030.Checked = false;
            checkBox10301130.Checked = false;
            checkBox11301230.Checked = false;
            checkBox12301330.Checked = false;
            checkBox13301430.Checked = false;
            checkBox14301530.Checked = false;
            checkBox15301630.Checked = false;
            checkBox16301730.Checked = false;

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

        //....................Active Days And Active Hours Arrays..........................
        ArrayList arrDays = new ArrayList();
        ArrayList arrHours = new ArrayList();

        //.............................Add Lecture Button.....................................
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            //Select Active Days
            if (checkBoxMonday.Checked)
                arrDays.Add("Monday");
            if (checkBoxTudesday.Checked)
                arrDays.Add("Tuesday");
            if (checkBoxWednesday.Checked)
                arrDays.Add("Wednesday");
            if (checkBoxThursday.Checked)
                arrDays.Add("Thursday");
            if (checkBoxFriday.Checked)
                arrDays.Add("Friday");

            //Select Active Hours
            if (checkBox830930.Checked)
                arrHours.Add("08.30 - 09.30");
            if (checkBox9301030.Checked)
                arrHours.Add("09.30 - 10.30");
            if (checkBox10301130.Checked)
                arrHours.Add("10.30 - 11.30");
            if (checkBox11301230.Checked)
                arrHours.Add("11.30 - 12.30");
            if (checkBox12301330.Checked)
                arrHours.Add("12.30 - 13.30");
            if (checkBox13301430.Checked)
                arrHours.Add("13.30 - 14.30");
            if (checkBox14301530.Checked)
                arrHours.Add("14.30 - 15.30");
            if (checkBox15301630.Checked)
                arrHours.Add("15.30 - 16.30");
            if (checkBox16301730.Checked)
                arrHours.Add("16.30 - 17.30");

            String[] Arr1 = (String[])arrDays.ToArray(typeof(String));
            String days = string.Join(",", Arr1);

            string[] Arr2 = (String[])arrHours.ToArray(typeof(String));
            string hours = string.Join(",", Arr2);

            //..................Validations.............................

            //Lecture ID Text Box
            if (textBoxLecturerID.Text == "")
                MessageBox.Show("Please Fill Lecturer ID...!");
            else if (System.Text.RegularExpressions.Regex.IsMatch(textBoxLecturerID.Text, "[^0-9]"))
                MessageBox.Show("Please Enter Number Only For Lecturer ID...!");

            //Title Combo Box
            else if (comboBoxTitle.Text == "")
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

            //Lecture Rank Combo Box
            else if (textBoxRank.Text == "")
                MessageBox.Show("Please Fill Lecturer Rank...!");

            else
            { 
                //get the value from the inpute fileds
                l.Title = comboBoxTitle.Text;
                l.Rank = textBoxRank.Text;
                l.FirstName = textBoxFirstName.Text;
                l.LastName = textBoxLastName.Text;
                l.LectureID = int.Parse(textBoxLecturerID.Text);
                l.Center = comboBoxCenter.Text;
                l.Faculty = comboBoxFaculty.Text;
                l.Building = comboBoxBuilding.Text;
                l.Department = comboBoxDepartment.Text;
                l.LecLevel = comboBoxLevel.Text;
                l.ActiveDays = days;
                l.ActiveHours = hours;

                //Insert data into data using the method
                bool success = l.Insert(l);
                if (success == true)
                {
                    //successfuly inserted
                    MessageBox.Show("New Lecturer Inserted Successfully");
                    //call the clear method
                    Clear();
                }
                else
                {
                    //Faild to add Lecturer
                    MessageBox.Show("Failed to Add new Lecturer... Try Again...!");
                }
            }

            
        }

        //.............................Clear Button.....................................
        private void bntClear_Click(object sender, EventArgs e)
        {
            if (comboBoxTitle.Text == "" && textBoxRank.Text == "" && textBoxFirstName.Text == "" && textBoxLastName.Text == "" && textBoxLecturerID.Text == "" && comboBoxCenter.Text == "" && comboBoxBuilding.Text == "" && comboBoxDepartment.Text == "" && comboBoxLevel.Text == "" && checkBoxMonday.Checked == false && checkBoxTudesday.Checked == false && checkBoxWednesday.Checked == false && checkBoxThursday.Checked == false && checkBoxFriday.Checked == false && checkBox830930.Checked == false && checkBox9301030.Checked == false && checkBox10301130.Checked == false && checkBox11301230.Checked == false && checkBox12301330.Checked == false && checkBox13301430.Checked == false && checkBox14301530.Checked == false && checkBox15301630.Checked == false && checkBox16301730.Checked == false)
                MessageBox.Show("Fields Are Empty...!");
            else
            {
                //Call Clear Method
                Clear();
            }

        }

        //....................Rank Generate Method...................
        public void rankGen()
        {
            int outputValue = 0;
            bool isNumber = false;

            isNumber = int.TryParse(textBoxLecturerID.Text, out outputValue);

            Dictionary<String, int> rankGen = new Dictionary<string, int>();
            rankGen.Add("Professor", 1);
            rankGen.Add("Assistant Professor", 2);
            rankGen.Add("Senior Lecturer(HG)", 3);
            rankGen.Add("Senior Lecturer", 4);
            rankGen.Add("Lecturer", 5);
            rankGen.Add("Assistant Lecturer", 6);

            //Check Lecturer ID  And Lecture Levels Are Not Empty
            if (textBoxLecturerID.Text != "" && comboBoxLevel.Text != "")
            {
                //Check Lecturer ID Is Number Or Not
                if (!isNumber)
                    MessageBox.Show("Please Enter Numbers Only For Lecturer ID...!");
                else
                {
                    int value = rankGen[comboBoxLevel.Text];

                    StringBuilder sb = new StringBuilder();
                    sb.Append(value + "." + textBoxLecturerID.Text);

                    textBoxRank.Text = sb.ToString();
                }
            }
            else
                MessageBox.Show("Please Fill Lecturer ID And Lecturer Level...!");
            }

        private void bntGenerateRank_Click(object sender, EventArgs e)
        {
            rankGen();
        }

        //Close Form
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
