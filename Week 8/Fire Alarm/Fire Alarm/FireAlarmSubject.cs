using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Alarm
{
    public class FireAlarmSubject
    {
        public delegate void FireEventHandler(object fireSubject, FireAlarmEventArgs fe);
        public event FireEventHandler FireEvent;

        public FireAlarmSubject() { }

        public void OnFireEvent(EFireCategory fireCategory)
        {
            FireAlarmEventArgs fe = new FireAlarmEventArgs(fireCategory);

            if (FireEvent != null)
                FireEvent(this, fe);
        }
    }
}
