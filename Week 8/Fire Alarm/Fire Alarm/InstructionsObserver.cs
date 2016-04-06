using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fire_Alarm
{
    public class InstructionsObserver : FireAlarmObserver
    {
        public InstructionsObserver(FireAlarmSubject fireSubject) : base(fireSubject) { }

        public override void FireAlarmHandlerMethod(object fireSubject, FireAlarmEventArgs fe)
        {
            String message = "Fire is " + fe.FireCategory.ToString() + ".";
            switch (fe.FireCategory)
            {
                case EFireCategory.MINOR:
                    message += " Use a fire extinguisher";
                    break;
                case EFireCategory.SERIOUS:
                    message += " Call the Fire Department";
                    break;
                case EFireCategory.INFERNO:
                    message += " Evactuate Immediately!!!";
                    break;
                default:
                    break;
            }

            MessageBox.Show(message);
        }
    }
}
