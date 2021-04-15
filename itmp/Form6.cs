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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var objchart = chart.ChartAreas[0];
            objchart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;

            objchart.AxisX.Minimum = 1;
            objchart.AxisX.Maximum = 5;

            objchart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            
            objchart.AxisY.Maximum = 50;

            //Clear 
            chart.Series.Clear();

            //random color 
            Random random = new Random();

            //loop rows 
            foreach (Register t in registerBindingSource.DataSource as List<Register>)
            {
                chart.Series.Add(t.location);
                chart.Series[t.location].Color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                chart.Series[t.location].Legend = "Legend1";
                chart.Series[t.location].ChartArea = "ChartArea1";
                chart.Series[t.location].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                //adding data 
                for (int i = 1; i <= 5; i++)
                    chart.Series[t.location].Points.AddXY(i, Convert.ToInt32(t[$"VS{i}"]));

            }


        }

        private void Form6_Load(object sender, EventArgs e)
        {
            registerBindingSource.DataSource = new List<Register>();
        }
    }
}
