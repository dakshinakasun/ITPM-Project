using itmp.buildingClasses.locationClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itmp
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        locationClass n = new locationClass();
        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        //Method to clear Fields 
        public void Clear()
        {
            txtBoxLocIDML.Text = "";
            txtBoxBuildingNamML.Text = "";
            txtBoxRomNameML.Text = "";
            cmbRoomTypeML.Text = "";
            numUpDownML.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Load Data on Database GridView 
            DataTable dt = n.Select();
            dataGridView1.DataSource = dt;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //Load Data on Database GridView 
            DataTable dt = n.Select();
            dataGridView1.DataSource = dt;
        }

        private void btnUpdateML_Click(object sender, EventArgs e)
        {
            //Get the Data from textboxes 
            n.LocationID = int.Parse(txtBoxLocIDML.Text);
            n.BuildingName = txtBoxBuildingNamML.Text;
            n.Room = txtBoxRomNameML.Text;
            n.RoomType = cmbRoomTypeML.Text;
            n.Capacity = Convert.ToInt32(numUpDownML.Text);

            //update data in Database 
            bool success = n.Update(n);
            if(success==true)
            {
                //Update Successfully
                MessageBox.Show("Content has been Successfully");
                DataTable dt = n.Select();
                dataGridView1.DataSource = dt;
                //Call Clear Method 
                Clear();
                
            }
            else
            {
                //Failed to Update 
                MessageBox.Show("Failed to Update Content.Try Agian");
            }

            




        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            //Get the Data From Data Grid View 
            int rowIndex = e.RowIndex;
            txtBoxLocIDML.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            txtBoxBuildingNamML.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            txtBoxRomNameML.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            cmbRoomTypeML.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            numUpDownML.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();




        }

        private void btnClearML_Click(object sender, EventArgs e)
        {
            //call clear 
            Clear();
        }

        private void btnDeleteML_Click(object sender, EventArgs e)
        {
            //Get Data from the TextBox
            n.LocationID = Convert.ToInt32(txtBoxLocIDML.Text);
            bool success = n.Delete(n);
            if(success==true)
            {
                //Successfully Deleted 
                MessageBox.Show("Content has been Successfully Deleted");
                //Refresh Data Grid 
                DataTable dt = n.Select();
                dataGridView1.DataSource = dt;

                //Call Clear Method 
                Clear();

            }
            else
            {
                //Failed to Delete 
                MessageBox.Show("Failed to Deleted. Try Agian");
            }
        }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        private void txtBoxML_TextChanged(object sender, EventArgs e)
        {
            {
                //get the value from textbox
                string keyword = txtBoxML.Text;
                SqlConnection conn = new SqlConnection(myconnstrng);
                SqlDataAdapter oda = new SqlDataAdapter("SELECT * FROM tbl_location WHERE LocationID LIKE '%" + keyword + "%' OR BuildingName LIKE '%" + keyword + "%' OR Room LIKE '%" + keyword + "%'  OR RoomType LIKE '%" + keyword + "%'", conn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void cmbRoomTypeML_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
