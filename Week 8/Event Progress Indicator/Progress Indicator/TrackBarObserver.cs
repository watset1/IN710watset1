using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progress_Indicator
{
    public class TrackBarObserver : ProgressObserver
    {
        public TrackBarObserver(ProgressSubject subject) : base(subject) { }

        public override void ProgressHandlerMethod(object subject, ProgressEventArgs pe)
        {
            pe.TrackBar.Value += 10;
        }  
    }
}
