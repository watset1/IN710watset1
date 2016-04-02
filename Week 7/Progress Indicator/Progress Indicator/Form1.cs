using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progress_Indicator
{
    public partial class Form1 : Form
    {
        public delegate void FeedbackDelegate();

        public Form1()
        {
            InitializeComponent();           
        }

        public void updateSpinBox()
        {
            numericUpDown1.Value ++;
        }

        public void updateProgressBar()
        {
            progressBar1.Step = 1;
            progressBar1.PerformStep();
        }

        public void updateTrackBar()
        {
            trackBar1.Value++;
        }

        public void slowMethod(FeedbackDelegate feedbackDelegate)
        {

            resetValues();

            for (int i = 0; i < 100; i++)
            {
                System.Threading.Thread.Sleep(50);
                feedbackDelegate();
                Application.DoEvents();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FeedbackDelegate feedbackDelegate = null;

            if (rdoSpinBox.Checked)
                feedbackDelegate = new FeedbackDelegate(updateSpinBox);
            if (rdoProgressBar.Checked)
                feedbackDelegate = new FeedbackDelegate(updateProgressBar);
            if (rdoTrackBar.Checked)
                feedbackDelegate = new FeedbackDelegate(updateTrackBar);

            slowMethod(feedbackDelegate);
        }

        public void resetValues()
        {
            numericUpDown1.Value = 0;
            progressBar1.Value = 0;
            trackBar1.Value = 0;
        }
    }
}
