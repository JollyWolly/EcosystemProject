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
using System.IO;

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

            chart.AxisX.ScaleView.Zoomable = true;
            chart.CursorX.AutoScroll = true;
            chart.CursorX.IsUserSelectionEnabled = true;

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

            Button seriesButton = new Button();
            seriesButton.Name = name;
            this.Controls.Add(seriesButton);
            seriesButton.Text = "save: " + name;
            seriesButton.Location = new Point(700, 30 * (chart1.Series.Count-2) + 10);
            seriesButton.Size = new Size(125, 23);

            seriesButton.Click += new EventHandler(seriesButton_Click);
        }

        public void addToSeries(string name, DataPoint p)
        {
            addToSeries(name, (int)p.XValue, (int)p.YValues[0]);
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

        private void seriesButton_Click(object sender, EventArgs e)
        {
            string pntListStr = "";

            Button clickedButton = (Button)sender;
            foreach (DataPoint p in chart1.Series[clickedButton.Name].Points)
            {
                if (pntListStr.Length > 1)
                    pntListStr += ",";
                pntListStr += String.Format("({0},{1})", p.XValue.ToString(), p.YValues[0].ToString());
            }
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, pntListStr);
                }
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
