using AnalogClockControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clock_Application
{
    class Analog : IClock
    {
        AnalogClock analogClock;

        public Analog(AnalogClock analogClock)
        {
            this.analogClock = analogClock;
        }
        
        public void On()
        {
            analogClock.Start();
        }

        public void Off()
        {
            analogClock.Stop();
        }

        public void UpdateTimeDisplay()
        {
            
        }

        public void ShowClock()
        {
            analogClock.Visible = true;
        }

        public void HideClock()
        {
            analogClock.Visible = false;
        }
    }
}
