using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_Station
{
    public class TemperatureObserver : WeatherObserver
    {
        public TemperatureObserver(ListBox listBox, WeatherSubject weatherSubject)
            : base(listBox, weatherSubject)
        {
            this.listBox = listBox;
            this.weatherSubject = weatherSubject;
        }

        public override void Update(Dictionary<String, double> dataDictionary)
        {
            computedDataDictionary = dataDictionary;
            Display();
        }
    }
}
