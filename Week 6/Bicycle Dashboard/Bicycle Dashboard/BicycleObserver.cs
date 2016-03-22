using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bicycle_Dashboard
{
    public abstract class BicycleObserver : IObserver
    {
        protected Label label;
        protected int currentRpm;
        protected double currComputedValue;
        protected BicycleSubject bicycleSubject;


        public BicycleObserver(Label label, BicycleSubject bicycleSubject)
        {
            this.label = label;
            this.bicycleSubject = bicycleSubject;
            currentRpm = 0;
            currComputedValue = 0;
            bicycleSubject.AddObserver(this);
        }

        public abstract void Update(int currentRpm);

        public void Display()
        {
            label.Text = currComputedValue.ToString("F2");
        }
    }
}
