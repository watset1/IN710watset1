using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Alarm
{
    public abstract class FireAlarmObserver
    {
        protected FireAlarmSubject fireSubject;

        public FireAlarmObserver(FireAlarmSubject fireSubject)
        {
            this.fireSubject = fireSubject;

            FireAlarmSubject.FireEventHandler handler = new FireAlarmSubject.FireEventHandler(FireAlarmHandlerMethod);
            fireSubject.FireEvent += handler;
        }

        public abstract void FireAlarmHandlerMethod(object fireSubject, FireAlarmEventArgs fe);
    }
}
