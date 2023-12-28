using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace EcosystemProject
{
    public partial class Form1 : Form
    {
        Ecosystem eco;

        Color grassColor = Color.LightGreen;
        Color sheepColor = Color.WhiteSmoke;
        Color wolfColor = Color.Gray;

        List<int> grassPopList;
        List<int> sheepPopList;
        List<int> wolfPopList;

        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private void drawEco()
        {
            string ecoGrid = eco.getTxtGrid();
            displayBox.Text = ecoGrid;
            draw();
            day_Label.Text = Convert.ToString(eco.day);

            grassCount_Label.Text = Convert.ToString(eco.grassCount);
            sheepCountLabel.Text = Convert.ToString(eco.sheepCount);
            wolfCountLabel.Text = Convert.ToString(eco.wolfCount);

            if (eco.day > 0)
            {
                grassGrowth_Label.Text = Convert.ToString(grassPopList[eco.day] - grassPopList[eco.day - 1]);
                sheepGrowth_Label.Text = Convert.ToString(sheepPopList[eco.day] - sheepPopList[eco.day - 1]);
                wolfGrowth_Label.Text = Convert.ToString(wolfPopList[eco.day] - wolfPopList[eco.day - 1]);
            }
            else
            {
                grassGrowth_Label.Text = "0";
                sheepGrowth_Label.Text = "0";
                wolfGrowth_Label.Text = "0";
            }
        }

        private void draw()
        {
            displayBox.Text = displayBox.Text;
            if (colorCheckBox.Checked)
            {
                colorChar('"', grassColor);
                colorChar('@', sheepColor);
                colorChar('a', sheepColor);
                colorChar('v', wolfColor);
                colorChar('¥', wolfColor);
            }
        }

        private void update()
        {
            eco.update();
            grassPopList.Add(eco.grassCount);
            sheepPopList.Add(eco.sheepCount);
            wolfPopList.Add(eco.wolfCount);
        }

        private void colorChar(char c, Color clr)
        {
            if (nightCheckBox.Checked)
            {
                for (int i = 0; i < displayBox.Text.Length; i++)
                {
                    if (displayBox.Text[i] == c)
                    {
                        displayBox.SelectionStart = i;
                        displayBox.SelectionLength = 1;

                        displayBox.SelectionColor = clr;
                    }
                }
            }
            else
            {
                for (int i = 0; i < displayBox.Text.Length; i++)
                {
                    if (displayBox.Text[i] == c)
                    {
                        displayBox.SelectionStart = i;
                        displayBox.SelectionLength = 1;

                        displayBox.SelectionBackColor = clr;
                    }
                }
            }
        }

        private void updateColors()
        {
            if (nightCheckBox.Checked)
            {
                displayBox.BackColor = Color.Black;
                if (colorCheckBox.Checked)
                    displayBox.ForeColor = Color.SaddleBrown;
                else
                    displayBox.ForeColor = Color.White;

                grassColor = Color.Green;
            }
            else
            {
                displayBox.ForeColor = Color.Black;
                displayBox.BackColor = System.Drawing.SystemColors.Info;
                grassColor = Color.LightGreen;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }


        private void createEco_Click(object sender, EventArgs e)
        {

            // get height and width values
            int w = Convert.ToInt32(Math.Round(width_NumericUpDown.Value, 0));
            int h = Convert.ToInt32(Math.Round(height_NumericUpDown.Value, 0));

            // create population lists
            grassPopList = new List<int>();
            sheepPopList = new List<int>();
            wolfPopList = new List<int>();


            eco = new Ecosystem(h, w, antiExtinction_Checkbox.Checked, foodRate.Value, sheepRate.Value, wolfRate.Value);

            // enable buttons
            nextDay_Button.Enabled = true;
            skipDays_Button.Enabled = true;

            popGraph_Button.Enabled = true;
            groGraph_Button.Enabled = true;



            grassPopList.Add(eco.grassCount);
            sheepPopList.Add(eco.sheepCount);
            wolfPopList.Add(eco.wolfCount);
            drawEco();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nextDay_Button_Click(object sender, EventArgs e)
        {
            update();
            drawEco();
        }

        private void colorCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            updateColors();
            draw();
        }

        private void nightCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            updateColors();
            draw();
        }


        private void popGraph_Button_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            if (grassPopCheckBox.Checked)
            {
                f2.addSeries("Grass Pop.", Color.Green);
                for (int i = 0; i < eco.day; i++)
                    f2.addToSeries("Grass Pop.", i, grassPopList[i]);
            }
            if (sheepPopCheckBox.Checked)
            {
                f2.addSeries("Sheep Pop.", Color.Blue);
                for (int i = 0; i < eco.day; i++)
                    f2.addToSeries("Sheep Pop.", i, sheepPopList[i]);
            }
            if (wolfPopCheckBox.Checked)
            {
                f2.addSeries("Wolf Pop.", Color.Red);
                for (int i = 0; i < eco.day; i++)
                    f2.addToSeries("Wolf Pop.", i, wolfPopList[i]);
            }
            
            f2.Show();
        }

        private void groGraph_Button_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            
            if (grassGroCheckBox.Checked)
            {
                f2.addSeries("Grass Growth", Color.Green);
                f2.addToSeries("Grass Growth", 0, 0);
                for (int i = 1; i < eco.day; i++)
                {
                    f2.addToSeries("Grass Growth", i, grassPopList[i]-grassPopList[i-1]);
                }
            }
            if (sheepGroCheckBox.Checked)
            {
                f2.addSeries("Sheep Growth", Color.Blue);
                f2.addToSeries("Sheep Growth", 0, 0);
                for (int i = 1; i < eco.day; i++)
                    f2.addToSeries("Sheep Growth", i, sheepPopList[i]-sheepPopList[i-1]);
            }
            if (wolfGroCheckBox.Checked)
            {
                f2.addSeries("Wolf Growth", Color.Red);
                f2.addToSeries("Wolf Growth", 0, 0);
                for (int i = 1; i < eco.day; i++)
                    f2.addToSeries("Wolf Growth", i, wolfPopList[i]-wolfPopList[i-1]);
            }

            f2.Show();
        }


        private void skipDays_Button_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy == true)
            {
                backgroundWorker1.CancelAsync();
            }
            else
            {
                skipDays_Button.Text = "STOP";
                nextDay_Button.Enabled = false;
                createEco_Button.Enabled = false;

                int daysToSkip = (int)skipDays_NumericUpDown.Value;

                progressBar1.Visible = true;
                progressBar1.Maximum = daysToSkip;
                progressBar1.Value = 0;

                backgroundWorker1.RunWorkerAsync(daysToSkip);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bgw = sender as BackgroundWorker;

            skipDays((int)e.Argument, bgw, e);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            drawEco();
            progressBar1.Visible = false;
            skipDays_Button.Text = "Skip";
            createEco_Button.Enabled = true;
            nextDay_Button.Enabled = true;
        }

        private void skipDays(int l, BackgroundWorker bwg, DoWorkEventArgs e)
        {
            for (int i = 0; i < l; i++)
            {
                if (backgroundWorker1.CancellationPending)
                {
                    break;
                }
                else
                {
                    update();
                    bwg.ReportProgress(i);
                }
            }
        }


    }
}
