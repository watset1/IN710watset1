using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock_Application
{
    public class Digital : IClock
    {
        Label timeDisplayLabel;
        Timer timer;

        public Digital(Label timeDisplayLabel, Timer timer)
        {
            this.timeDisplayLabel = timeDisplayLabel;
            this.timer = timer;
        }

        public void On()
        {
            timer.Enabled = true;         
        }

        public void Off()
        {
            timer.Enabled = false;
        }

        public void UpdateTimeDisplay()
        {
            timeDisplayLabel.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        public void ShowClock()
        {
            timeDisplayLabel.Visible = true; 
        }

        public void HideClock()
        {
            timeDisplayLabel.Visible = false; 
        }
    }
}
