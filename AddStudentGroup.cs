using StudentAndTagProject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAndTagProject
{
    public partial class AddStudentGroup : Form
    {
        public AddStudentGroup()
        {
            InitializeComponent();
        }

        StudentClass s = new StudentClass();

        public void Clear()
        {

            comboAcademic.SelectedIndex = -1;
            textBoxGroupID.Text = "";
            textBoxSubGroupID.Text = "";
            comboBoxProgram.SelectedIndex = -1;
            numericUpDownGroupNumber.Value = 0;
            numericUpDownSubGroupNumber.Value = 0;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //get the value from the inpute fileds
            s.AcademicYearAndSemester = comboAcademic.Text;
            s.Programme = comboBoxProgram.Text;
            s.GroupNo = Convert.ToInt32(numericUpDownGroupNumber.Text);
            s.SubGroupNo = Convert.ToInt32(numericUpDownSubGroupNumber.Text);
            s.GroupID = textBoxGroupID.Text;
            s.SubGroupID = textBoxSubGroupID.Text;


            //Insert data into data using the method we created
            bool success = s.Insert(s);
            if (success == true)
            {
                //successfuly inserted
                MessageBox.Show("New Group Inserted Successfully");
                //call the clear method
                Clear();
            }
            else
            {
                //Faild to add contact
                MessageBox.Show("Failed to Add new Group... Try Again...!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //call clear method
            Clear();
        }
    }
}
