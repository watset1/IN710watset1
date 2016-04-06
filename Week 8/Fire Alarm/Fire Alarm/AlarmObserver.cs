using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Alarm
{
    public class AlarmObserver : FireAlarmObserver
    {
        [DllImport("kernel32.dll")]
        public static extern bool Beep(int freq, int duration);
        const int DURATION = 4000;
        public AlarmObserver(FireAlarmSubject fireSubject) :base(fireSubject) { }

        public override void FireAlarmHandlerMethod(object fireSubject, FireAlarmEventArgs fe)
        {
            int freq = 0;
            switch (fe.FireCategory)
            {
                case EFireCategory.MINOR:
                    freq = 440;                  
                    break;
                case EFireCategory.SERIOUS:
                    freq = 660;
                    break;
                case EFireCategory.INFERNO:
                    freq = 880;
                    break;
                default:
                    break;
            }
            Beep(freq, DURATION);
        }
    }
}
