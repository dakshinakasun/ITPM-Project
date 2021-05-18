using itmp.buildingClasses.locationClasses;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        locationClass n = new locationClass();
        private void lblAddLocation_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCapacity_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void btnSaveLocation_Click(object sender, EventArgs e)
        {
            //Get the value from the layout fields 
            n.BuildingName = txtBoxBuildingName.Text;
            n.Room = txtRoom.Text;
            n.RoomType = cmbRoomType.Text;
            n.Capacity = Convert.ToInt32(numUpDowCapacity.Text);

            //insert into database 
            bool success = n.Insert(n);
            if(success==true)
            {
                //Successfully inserted
                MessageBox.Show("New values Successfully inserted");
                //Call the Clear Method 
                Clear();
            }
            else
            {
                //falling to save 
                MessageBox.Show("Failed Add New Item. Try Again.");
            }





        }

        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Method to clear Fields 
        public void Clear()
        {
            txtBoxBuildingName.Text = "";
            txtRoom.Text = "";
            cmbRoomType.Text = "";
            numUpDowCapacity.Text = "";
        }

        private void btnClearLocation_Click(object sender, EventArgs e)
        {
            //call Clear Method Here 
            Clear();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
