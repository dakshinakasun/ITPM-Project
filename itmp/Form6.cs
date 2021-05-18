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
    public partial class AlloRoom : Form
    {
        public AlloRoom()
        {
            InitializeComponent();
        }
        //AllocateRoom n = new AllocateRoom();
        private void AllocateRooms_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Get the value from the input fields 
            /*n.cbSubject = cbSubject.SelectedValue.ToString();
            n.cbGroup = cbGroup.SelectedValue.ToString();
            n.cbLecture = cbLecture.SelectedValue.ToString();
            n.cbSession = cbSession.SelectedValue.ToString();
            n.ComBoxSelectSessions = ComBoxSelectSessions.SelectedValue.ToString();
            n.cbTag = cbTag.SelectedValue.ToString();
            n.cbRoom = cbRoom.SelectedValue.ToString();

            //inserting data database using the method 
            bool success = n.Insert(n);
            if (success==true)
            {
                //successfull message
                MessageBox.Show("New Details Successfully Insert Inserted");
            }
            else
            {
                //Failed to Add Deatils
                MessageBox.Show("Fialed to add Details. Try Again...");
            }*/
        }
    }
}
