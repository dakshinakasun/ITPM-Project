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
    public partial class Form7 : Form
    {
        

        public Form7()
        {
            InitializeComponent();
            SeFillCombo();
            SrFillCombo();
        }
        SessionRoomClass c = new SessionRoomClass();

        //Session combobox loding method 
        void SeFillCombo() 
        {
            string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
            string sql = "select * from Session";
            

            SqlConnection conn = new SqlConnection(myconnstrng); 
            SqlCommand cmd = new SqlCommand(sql, conn); 
            SqlDataReader SReader; 
            try {
                conn.Open(); SReader = cmd.ExecuteReader(); 
                while (SReader.Read()) 
                { 
                    string Session = SReader["SessionID"].ToString(); 
                    comBoxSessionMS.Items.Add(Session); 
                } 
            } catch (Exception ex) {

            } 
            finally 
            { 
                conn.Close();
            } 
        }

        //Room combobox loding method 
        void SrFillCombo()
        {
            string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
            string sql = "select * from tbl_location";


            SqlConnection conn = new SqlConnection(myconnstrng);
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader RoomReader;
            try
            {
                conn.Open(); RoomReader = cmd.ExecuteReader();
                while (RoomReader.Read())
                {
                    string tbl_location = RoomReader["Room"].ToString();
                    comBoxRoomsMS.Items.Add(tbl_location);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }



        private void Form7_Load(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveMS_Click(object sender, EventArgs e)
        {
            //Get the value from the layout fields 
            
            c.SessionID = Convert.ToInt32(comBoxSessionMS.Text);
            c.Select_Room = comBoxRoomsMS.Text;
            c.Selected_Sessions = txtBoxSessionMS.Text;


            //insert Data into Database 
            bool success = c.Insert(c);
            if (success == true)
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
            comBoxSessionMS.Text = "";
            comBoxRoomsMS.Text = "";
            txtBoxSessionMS.Text = "";

        }

        private void btnClearMS_Click(object sender, EventArgs e)
        {
            //call Clear Method Here 
            Clear();
        }

        private void btnClickView_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f20 = new Form8();
            f20.Show();
        }

        private void comBoxSessionMS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comBoxRoomsMS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
