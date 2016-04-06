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
        ProgressSubject slowWorker;
        SpinBoxObserver sbObserver;
        ProgressBarObserver pbObserver;
        TrackBarObserver tbObserver;


        public Form1()
        {
            InitializeComponent();
            slowWorker = new ProgressSubject();
            sbObserver = new SpinBoxObserver(slowWorker);
            pbObserver = new ProgressBarObserver(slowWorker);
            tbObserver = new TrackBarObserver(slowWorker);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            slowWorker.SlowMethod(numericUpDown1, progressBar1, trackBar1);
        }
    }
}
