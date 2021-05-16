using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITPM_Project
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelLecturers.Visible = false;
            panelSubjects.Visible = false;
            panelStudents.Visible = false;
            panelTag.Visible = false;
            panelWorkingDaysAndHours.Visible = false;
            panelBuildings.Visible = false;
            panelLocatons.Visible = false;
            panelSession.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panelLecturers.Visible == true)
                panelLecturers.Visible = false;

            if (panelSubjects.Visible == true)
                panelSubjects.Visible = false;

            if (panelStudents.Visible == true)
                panelStudents.Visible = false;

            if (panelTag.Visible == true)
                panelTag.Visible = false;

            if (panelWorkingDaysAndHours.Visible == true)
                panelWorkingDaysAndHours.Visible = false;

            if (panelBuildings.Visible == true)
                panelBuildings.Visible = false;

            if (panelLocatons.Visible == true)
                panelLocatons.Visible = false;

            if (panelSession.Visible == true)
                panelSession.Visible = false;


        }

        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }

            else
                subMenu.Visible = false;

        }

        //............... Lecturer Panel Buttons ...........................
        private void btnLecturers_Click(object sender, EventArgs e)
        {
            showSubmenu(panelLecturers);
        }

        private void btnAddLecturer_Click(object sender, EventArgs e)
        {
            openChildForm(new AddLecturer());
            hideSubmenu();
        }

        private void btnManageLecturers_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageLecturers());
            hideSubmenu();
        }

        //............... Subject Panel Buttons ...........................
        private void Subjects_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubjects);
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            openChildForm(new AddSubject());
            hideSubmenu();
        }

        private void btnManageSubjects_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageSubjects());
            hideSubmenu();
        }

        //............... Student Panel Buttons ...........................
        private void btnStudents_Click(object sender, EventArgs e)
        {
            showSubmenu(panelStudents);
        }

        //............... Tag Panel Buttons ...........................
        private void btnTag_Click(object sender, EventArgs e)
        {
            showSubmenu(panelTag);
        }

        //............... Working days and hours Panel Buttons ...........................
        private void btnWorkingDaysAndHours_Click(object sender, EventArgs e)
        {
            showSubmenu(panelWorkingDaysAndHours);
        }

        //............... Buildings Panel Buttons ...........................
        private void btnBuildings_Click(object sender, EventArgs e)
        {
            showSubmenu(panelBuildings);
        }

        //............... Location Panel Buttons ...........................
        private void btnLocations_Click_1(object sender, EventArgs e)
        {
            showSubmenu(panelLocatons);
        }

        //............... Visualization Statistics Panel Buttons ...........................
        private void btnVisualizationStatistics_Click(object sender, EventArgs e)
        {

        }

        //............... Session Panel Buttons ...........................
        private void btnSession_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSession);
        }

        private void btnAddSession_Click(object sender, EventArgs e)
        {
            openChildForm(new AddSession());
            hideSubmenu();
        }

        private void btnManageSession_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageSession());
            hideSubmenu();
        }


        //............Child Form............
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelPages.Controls.Add(childForm);
            panelPages.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        
    }
}
