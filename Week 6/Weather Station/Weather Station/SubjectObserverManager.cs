using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_Station
{
    public class SubjectObserverManager
    {
        WeatherSubject weatherSubject;
        TemperatureObserver temperatureObserver;
        AverageReadingsObserver averageReadingsObserver;
        ForecastObserver forecastObserver;

        public SubjectObserverManager(ListBox listBoxTemp, ListBox listBoxAvg, ListBox listBoxForecast)
        {
            weatherSubject = new WeatherSubject();
            temperatureObserver = new TemperatureObserver(listBoxTemp, weatherSubject);
            averageReadingsObserver = new AverageReadingsObserver(listBoxAvg, weatherSubject);
            forecastObserver = new ForecastObserver(listBoxForecast, weatherSubject);
        }

        public void UpdateMeasurements(String temperature, String humidity, String barometric)
        {
            weatherSubject.dataDictionary.Clear();
            weatherSubject.dataDictionary.Add("Temperature", Convert.ToDouble(temperature));
            weatherSubject.dataDictionary.Add("Humidity", Convert.ToDouble(humidity));
            weatherSubject.dataDictionary.Add("Pressure", Convert.ToDouble(barometric));
            weatherSubject.NotifyObservers();
        }
    }
}
