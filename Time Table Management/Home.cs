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
            WorkingDays wd = new WorkingDays();
            wd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TimeSlots ts = new TimeSlots();
            ts.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SessionManager ts = new SessionManager();
            ts.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StudentManager ts = new StudentManager();
            ts.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NonReservable ts = new NonReservable();
            ts.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PreferredSessions ts = new PreferredSessions();
            ts.Show();
        }
    }
}
