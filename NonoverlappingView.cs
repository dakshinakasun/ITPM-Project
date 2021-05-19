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
    public partial class NonoverlappingView : Form
    {
        public NonoverlappingView()
        {
            InitializeComponent();
        }

        consecutiveClass c = new consecutiveClass();

        private void NonoverlappingView_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select2();
            dataGridView1.DataSource = dt;
        }
    }
}
