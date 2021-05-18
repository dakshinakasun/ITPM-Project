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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        SessionRoomClass n = new SessionRoomClass();
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f16 = new Form7();
            f16.Show();
        }

        private void dataGridSession_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            //Load Data on Database GridView 
            DataTable dt = n.Select();
            dataGridSession.DataSource = dt;
        }
    }
}
