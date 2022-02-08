using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MyHomework
{
    public partial class Form1 : Form
    {
        private int n;           // number of points for each path
        private int iterations;  // n. of iterations required

        private DistributionManager GC;

        private ggPictureBox ggPictureBox1;

        public Form1()
        {
            InitializeComponent();

            ggPictureBox1 = new ggPictureBox(MainPanel);
            ggPictureBox1.BackColor = Color.White;
            ggPictureBox1.Top = MainPanel.Height / 10; ;
            ggPictureBox1.Left = MainPanel.Left + MainPanel.Width / 10;
            ggPictureBox1.Height = MainPanel.Height / 10 * 8;
            ggPictureBox1.Width = MainPanel.Width / 10 * 8;
            ggPictureBox1.BorderStyle = BorderStyle.FixedSingle;
            MainPanel.Controls.Add(ggPictureBox1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetVariables();
            DrawChart();
        }

        // Events
        //--------------------------------------------------------

        private void btnRecalc_Click(object sender, EventArgs e)
        {
            SetVariables();
            DrawChart();
        }

        private void NbTrials_ValueChanged(object sender, EventArgs e)
        {
            SetVariables();
            DrawChart();
        }

        private void NbIterations_ValueChanged(object sender, EventArgs e)
        {
            SetVariables();
            DrawChart();
        }

        // Methods
        //--------------------------------------------------------

        private void SetVariables()
        {
            n = (int)NbTrials.Value;
            iterations = (int)NbIterations.Value;
        }

        private void CreateStatEngineInstance()
        {
            GC = new DistributionManager(n, iterations);
        }

        private void DrawChart()
        {
            CreateStatEngineInstance();
            GC.Paths[1] = GC.CreateEmpiricalDistribution(n);
            ChartManager CM = new ChartManager(GC, ggPictureBox1);
            CM.DrawChart();
        }
    }
}
