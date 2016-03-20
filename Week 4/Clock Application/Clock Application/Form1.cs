using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock_Application
{
    public partial class Form1 : Form
    {
        IClock digital;
        IClock analog;

        public Form1()
        {
            InitializeComponent();
            digital = new Digital(lblDigitalDisplay, timer1);
            analog = new Analog(analogClock1);
            rdDigital.Checked = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            digital.UpdateTimeDisplay();
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            digital.On();
            analog.On();
        }

        private void btnOff_Click_1(object sender, EventArgs e)
        {
            digital.Off();
            analog.Off();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (rdAnalog.Checked == true)
            {
                analog.ShowClock();
                digital.HideClock();
            }
            else
            {
                digital.ShowClock();
                analog.HideClock();
            }

            
        }
    }
}
