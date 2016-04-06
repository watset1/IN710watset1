using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progress_Indicator
{
    public abstract class ProgressObserver
    {
        protected ProgressSubject subject;

        public ProgressObserver(ProgressSubject subject)
        {
            this.subject = subject;
            EventHandler<ProgressEventArgs> handler = new EventHandler<ProgressEventArgs>(ProgressHandlerMethod);
            subject.ProgressEvent += handler;
        }

        public abstract void ProgressHandlerMethod(object subject, ProgressEventArgs pe);
    }
}