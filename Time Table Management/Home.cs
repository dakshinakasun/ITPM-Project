using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Table_Management
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 wd = new Form1();
            wd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 ts = new Form3();
            ts.Show();
        }
    }
}
