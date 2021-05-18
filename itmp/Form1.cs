using itmp.buildingClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itmp
{
    public partial class formAddBuilding : Form
    {
        public formAddBuilding()
        {
            InitializeComponent();
        }
        Class1 c = new Class1();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxBuildingId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBuildingName_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Get the value from the layout fields 
            c.BuildingName = txtBoxBuildingName.Text;
            c.NumberOfRooms = Convert.ToInt32(numUpDowNoOfRooms.Text);

            //insert Data into Database 
            bool success = c.Insert(c);
            if(success==true)
            {
                //Successfully inserted
                MessageBox.Show("New values Successfully inserted");
                //Call the Clear Method Here 
                Clear();
            }
            else
            {
                //falling to save 
                MessageBox.Show("Failed Add New Item. Try Again.");
            }

            
            


        }
        //Mthod to Clear fields 
        public void Clear()
        {
            txtBoxBuildingName.Text = "";
            numUpDowNoOfRooms.Text = "";
            
        }
        
        

        private void btnClear_Click(object sender, EventArgs e)
        {
            //call Clear Method Here 
            Clear();
            
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void formAddBuilding_Load(object sender, EventArgs e)
        {

        }

        private void btnForwdLocation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f4 = new Form2();
            f4.Show();
        }

        private void btnAllocate_Click(object sender, EventArgs e)
        {
            this.Hide();
            AlloRoom f10 = new AlloRoom();
            f10.Show();
        }

        private void btnManageSession_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f14 = new Form7();
            f14.Show();
        }

        private void btnSession_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f15 = new Form8();
            f15.Show();
        }

        private void numUpDowNoOfRooms_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f18 = new Form5();
            f18.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 f19 = new Form9();
            f19.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form10 f30 = new Form10();
            f30.Show();
        }
    }
}
