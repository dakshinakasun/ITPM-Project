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
    public partial class addparallel : Form
    {
        public addparallel()
        {
            InitializeComponent();
        }

        ParallelClass p = new ParallelClass();

        public void Clear()
        {

            numericP.Value = 0;
            cmdPsub.SelectedIndex = -1;
            cmbPtag.SelectedIndex = -1;
            cmdPgroup.SelectedIndex = -1;

        }

        private void addparallel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTPMDataSet10.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter.Fill(this.iTPMDataSet10.Session);

        }

        private void btnPsave_Click(object sender, EventArgs e)
        {
            //get the value from the inpute fileds
            p.SessionID = Convert.ToInt32(numericP.Text);
            p.Subject = cmdPsub.Text;
            p.Tag = cmbPtag.Text;
            p.GroupID = cmdPgroup.Text;




            //Insert data into data using the method we created
            bool success = p.Insert(p);
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

        private void btnPclear_Click(object sender, EventArgs e)
        {
            //call clear method
            Clear();
        }

        private void btnn_Click(object sender, EventArgs e)
        {
            this.Hide();
            nonoverlapping f6 = new nonoverlapping();
            f6.Show();
        }
    }
}
