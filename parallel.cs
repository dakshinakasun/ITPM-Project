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
    public partial class parallel : Form
    {
        public parallel()
        {
            InitializeComponent();
        }

        private void parallel_Load(object sender, EventArgs e)
        {
             // TODO: This line of code loads data into the 'iTPMDataSet8.concecutive' table. You can move, or remove it, as needed.
            this.concecutiveTableAdapter.Fill(this.iTPMDataSet8.concecutive);
            DataGridViewColumn chkbox = new DataGridViewColumn();
            chkbox.HeaderText = "";
            chkbox.Width = 30;
            chkbox.Name = "checkBoxColumn";
            dataGridView2.Columns.Insert(0, chkbox);



        }
    }
}
