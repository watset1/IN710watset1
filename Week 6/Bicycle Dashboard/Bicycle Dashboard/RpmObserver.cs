using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bicycle_Dashboard
{
    public class RpmObserver : BicycleObserver
    {
        public RpmObserver(Label label, BicycleSubject bicycleSubject)
            : base(label, bicycleSubject)
        {
            this.label = label;
            this.bicycleSubject = bicycleSubject;
            currentRpm = 0;
            currComputedValue = 0;
            bicycleSubject.AddObserver(this);
        }

        public override void Update(int currentRpm)
        {
            currComputedValue = Convert.ToDouble(currentRpm);
            Display();
        }
    }
}
