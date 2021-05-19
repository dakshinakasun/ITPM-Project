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
    public partial class parallelViewcs : Form
    {
        public parallelViewcs()
        {
            InitializeComponent();
        }
        consecutiveClass c = new consecutiveClass();

        private void parallelViewcs_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select1();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NonoverlappingView rr =new NonoverlappingView();
            rr.Show();

        }
    }
}
