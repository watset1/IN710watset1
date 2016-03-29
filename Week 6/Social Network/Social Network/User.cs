using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network
{
    public class User : ISubject
    {
        List<IObserver> observerList;
        public Status newStatus;

        public User()
        {
            observerList = new List<IObserver>();
            newStatus = new Status();
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
                observer.Update(newStatus);
        }
    }
}
