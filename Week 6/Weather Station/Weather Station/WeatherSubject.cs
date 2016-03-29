using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Station
{
    public class WeatherSubject : ISubject
    {
        List<IObserver> observerList;
        public Dictionary<String, double> dataDictionary;

        public WeatherSubject()
        {
            observerList = new List<IObserver>();
            dataDictionary = new Dictionary<String, double>();
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
                observer.Update(dataDictionary);
        }
    }
}
