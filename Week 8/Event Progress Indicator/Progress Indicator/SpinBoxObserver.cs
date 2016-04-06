using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progress_Indicator
{
    public class SpinBoxObserver : ProgressObserver
    {
        public SpinBoxObserver(ProgressSubject subject) : base(subject) { }

        public override void ProgressHandlerMethod(object subject, ProgressEventArgs pe)
        {
            pe.NumericUpDown.Value += 10;
            pe.NumericUpDown.Refresh();
        }    
    }
}
