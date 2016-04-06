using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progress_Indicator
{
    public class ProgressSubject
    {
        public event EventHandler<ProgressEventArgs> ProgressEvent;
        
        public ProgressSubject() { }

        public void SlowMethod(NumericUpDown NumericUpDown, ProgressBar ProgressBar, TrackBar TrackBar)
        {
            for (int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(500);
                OnUpdateEvent(NumericUpDown, ProgressBar, TrackBar);
            }
        }

        public void OnUpdateEvent(NumericUpDown numericUpDown, ProgressBar progressBar, TrackBar trackBar)
        {
            ProgressEventArgs pe = new ProgressEventArgs(numericUpDown, progressBar, trackBar);
            if (ProgressEvent != null)
                ProgressEvent(this, pe);
            
            
        }
    }
}
