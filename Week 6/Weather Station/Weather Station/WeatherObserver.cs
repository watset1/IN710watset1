using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_Station
{
    public abstract class WeatherObserver : IObserver
    {
        protected ListBox listBox;
        protected Dictionary<String, double> dataDictionary;
        protected WeatherSubject weatherSubject;
        protected Dictionary<String, double> computedDataDictionary;

        public WeatherObserver(ListBox listBox, WeatherSubject weatherSubject)
        {
            this.listBox = listBox;
            dataDictionary = new Dictionary<String, double>();
            weatherSubject.AddObserver(this);
            computedDataDictionary = new Dictionary<String, double>();
        }

        public abstract void Update(Dictionary<String, double> dataDictionary);

        public virtual void Display()
        {
            foreach (var pair in computedDataDictionary)
            {
                var dataType = pair.Key;
                var dataValue = pair.Value;
                listBox.Items.Add(dataType + ":     \t" + dataValue.ToString("F2"));
            }
        }

    }
}
