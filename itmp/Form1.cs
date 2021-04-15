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

        private void btnChartLoad_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f5 = new Form6();
            f5.Show();
        }
    }
}
