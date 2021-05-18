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
    public partial class Form9 : Form
    {
        public Form9()
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
            foreach (Temp i in tempBindingSource.DataSource as List<Temp>)
            {
                chart.Series.Add(i.Location);
                chart.Series[i.Location].Color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                chart.Series[i.Location].Legend = "Legend1";
                chart.Series[i.Location].ChartArea = "ChartArea1";
                chart.Series[i.Location].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                //adding data 
                for (int t = 1; t <= 5; t++)
                    chart.Series[i.Location].Points.AddXY(t, Convert.ToInt32(i[$"VS{t}"]));

            }




        }

        private void Form9_Load(object sender, EventArgs e)
        {
            tempBindingSource.DataSource = new List<Temp>();
        }

        private void chart_Click(object sender, EventArgs e)
        {

        }
    }
}
