using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace EcosystemProject
{
    public partial class Form2 : Form
    {
        int xInterval = 1;
        int yInterval = 1;

        int yMinimum = 0;
        int yMaximum = 1;

        public Form2()
        {
            InitializeComponent();
            chartLoad();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        void chartLoad()
        {
            chartLoad(xInterval, yInterval);
        }

        void chartLoad(int xInterval, int yInterval)
        {
            var chart = chart1.ChartAreas[0];

            chart.AxisX.IntervalType = DateTimeIntervalType.Number;

            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisX.LabelStyle.IsEndLabelVisible = true;
            

            chart.AxisX.Minimum = 0;
            chart.AxisY.Minimum = yMinimum;
            chart.AxisY.Maximum = yMaximum;

            chart.AxisX.Interval = xInterval;
            chart.AxisY.Interval = yInterval;

            chart1.Series[0].IsVisibleInLegend = false;
        }

        

        public void addSeries(string name, Color clr)
        {
            chart1.Series.Add(name);
            chart1.Series[name].ChartType = SeriesChartType.Line;
            chart1.Series[name].Color = clr;
        }

        public void addToSeries(string name, int x, int y)
        {
            chart1.Series[name].Points.AddXY(x, y);
            
            xInterval = chart1.Series[name].Points.Count / 5;

            if (y < yMinimum)
            {
                yMinimum = -yMaximum;
            }
            if (Math.Abs(y) > (yMaximum))
            {
                yMaximum = Math.Abs(y) + (10 - Math.Abs(y) % 10);
                yMinimum = yMaximum*-Convert.ToInt32(yMinimum < 0);
                yInterval = (yMaximum-yMinimum)/10;
            }
            chartLoad();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
