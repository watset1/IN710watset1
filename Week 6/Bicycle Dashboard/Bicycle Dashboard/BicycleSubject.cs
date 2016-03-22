using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicycle_Dashboard
{
    public class BicycleSubject : ISubject
    {
        List<IObserver> observerList;
        public int currRpm;

        public BicycleSubject()
        {
            observerList = new List<IObserver>();
            currRpm = 0;
        }

        public void AddObserver(IObserver observer)
        {
            observerList.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observerList.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observerList)
                observer.Update(currRpm);
        }
    }
}
