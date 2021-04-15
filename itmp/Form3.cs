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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Class1 c = new Class1();
        private void dataGdManageBuil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            


            //Load Data on Database GridView 
            DataTable dt = c.Select();
            dataGdManageBuil.DataSource = dt;


        }

        //Mthod to Clear fields 
        public void Clear()
        {
            txtBuildingNameMB.Text = "";
            numUpDownoOfRooms.Text = "";
            txtBuildingIDMB.Text = "";

        }

        private void Form3_Load(object sender, EventArgs e)
        {

           
            //Load Data on Database GridView 
            DataTable dt = c.Select();
            dataGdManageBuil.DataSource = dt;
        }

        private void btnUpdateMB_Click(object sender, EventArgs e)
        {
            //Get the Data from Data from textboxes 
            c.BID = int.Parse(txtBuildingIDMB.Text);
            c.BuildingName = txtBuildingNameMB.Text;
            c.NumberOfRooms = Convert.ToInt32(numUpDownoOfRooms.Text);

            //Update  Data in Database
            bool success = c.Update(c);
            if(success==true)
            {
                //Update Successfully
                MessageBox.Show("Content has been Successfully Updated");
                //Load Data on Database GridView 
                DataTable dt = c.Select();
                dataGdManageBuil.DataSource = dt;
                //Clear Method
                Clear();

            }
            else
            {
                //Upate Faild 
                MessageBox.Show("Failed to Updated. Try Agian");
            }
            
        }

        private void dataGdManageBuil_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get the Data from data grid and load it to textboxes 
            //identify the row on width mouse is clicked 
            int rowIndex = e.RowIndex;
            txtBuildingIDMB.Text = dataGdManageBuil.Rows[rowIndex].Cells[0].Value.ToString();
            txtBuildingNameMB.Text = dataGdManageBuil.Rows[rowIndex].Cells[1].Value.ToString();
            numUpDownoOfRooms.Text = dataGdManageBuil.Rows[rowIndex].Cells[2].Value.ToString();






        }

        private void lblBuildingNameMB_Click(object sender, EventArgs e)
        {

        }

        private void btnClearMB_Click(object sender, EventArgs e)
        {
            //Call Clear Method
            Clear();
            
        }

        private void btnDeleteMB_Click(object sender, EventArgs e)
        {
            //Get the Building ID from the Application
            c.BID = Convert.ToInt32(txtBuildingIDMB.Text);
            bool success = c.Delete(c);
            if(success==true)
            {
                //Successfully Deleted
                MessageBox.Show("Content Successfully Deleted");
                //Refresh DataGridView
                DataTable dt = c.Select();
                dataGdManageBuil.DataSource = dt;
                //Call the Clear Method 
                Clear();

            }
            else
            {
                //Failed Deleted 
                MessageBox.Show("Fialed Deleted.Try Again");
            }
        }
    }
}
