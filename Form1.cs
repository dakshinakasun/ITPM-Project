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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StudentTag c = new StudentTag();
        public void Clear()
        {
            
            comboBoxTagName.SelectedIndex = -1;
            comboCode.SelectedIndex = -1;
            comboBoxRelated.SelectedIndex = -1;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveTag_Click(object sender, EventArgs e)
        {
            //get the value from the inpute fileds

            c.SubjectName = comboBoxTagName.Text;
            c.SubjectCode = Convert.ToInt32(comboCode.Text);
            c.RelatedTag = comboBoxRelated.Text;

           


            //Insert data into data using the method we created
            bool success = c.Insert(c);
            if (success == true)
            {
                //successfuly inserted
                MessageBox.Show("New Tag Inserted Successfully");
                //call the clear method
                Clear();
            }
            else
            {
                //Faild to add contact
                MessageBox.Show("Failed to Add new Tag... Try Again...!");
            }
        }

        private void btnClearTag_Click(object sender, EventArgs e)
        {
            //call clear method
            Clear();
        }
    }
}
