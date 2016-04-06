using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progress_Indicator
{
    public class ProgressEventArgs : EventArgs
    {
        public NumericUpDown NumericUpDown { get; set; }
        public ProgressBar ProgressBar { get; set; }
        public TrackBar TrackBar { get; set; }

        public ProgressEventArgs(NumericUpDown NumericUpDown, ProgressBar ProgressBar, TrackBar TrackBar)
        {
            this.NumericUpDown = NumericUpDown;
            this.ProgressBar = ProgressBar;
            this.TrackBar = TrackBar;
        }
    }
}
