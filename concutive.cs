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
    public partial class concutive : Form
    {
        public concutive()
        {
            InitializeComponent();
        }

        consecutiveClass c = new consecutiveClass();

        public void Clear()
        {

            numericCon.Value = 0;
            cmbCtag.SelectedIndex = -1;
            cmbCsub.SelectedIndex = -1;
            cmbCsubg.SelectedIndex = -1;

        }
        private void concutive_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTPMDataSet9.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter.Fill(this.iTPMDataSet9.Session);

        }

        private void btnCCon_Click(object sender, EventArgs e)
        {
            //get the value from the inpute fileds
            c.SessionID = Convert.ToInt32(numericCon.Text);
            c.Subject = cmbCsub.Text;
            c.Tag = cmbCtag.Text;
            c.GroupID = cmbCsubg.Text;
            
          


            //Insert data into data using the method we created
            bool success = c.Insert(c);
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

        private void btnCclear_Click(object sender, EventArgs e)
        {
            //call clear method
            Clear(); 
            
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            this.Hide();
            addparallel f2 = new addparallel();
            f2.Show();
        }
    }
}
