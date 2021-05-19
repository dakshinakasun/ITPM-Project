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
    public partial class nonoverlapping : Form
    {
        public nonoverlapping()
        {
            InitializeComponent();
        }
        nonoverlappingClass n = new nonoverlappingClass();

        public void Clear()
        {

            numericNon.Value = 0;
            cmbSubN.SelectedIndex = -1;
            cmbNotag.SelectedIndex = -1;
            cmbNgroup.SelectedIndex = -1;

        }
        private void nonoverlapping_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTPMDataSet12.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter1.Fill(this.iTPMDataSet12.Session);
            // TODO: This line of code loads data into the 'iTPMDataSet11.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter.Fill(this.iTPMDataSet11.Session);

        }

        private void btnNsave_Click(object sender, EventArgs e)
        {
            n.SessionID = Convert.ToInt32(numericNon.Text);
            n.Subject = cmbSubN.Text;
            n.Tag = cmbNotag.Text;
            n.GroupID = cmbNgroup.Text;




            //Insert data into data using the method we created
            bool success = n.Insert(n);
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

        private void btnNclear_Click(object sender, EventArgs e)
        {
            //call clear method
            Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conView cc = new conView();
            cc.Show();
        }
    }
}
