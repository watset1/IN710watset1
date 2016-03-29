using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_Station
{
    public class ForecastObserver : WeatherObserver
    {
        int temp;
        int pressure;
        //int humidity; Not sure how to include this in the weather calculations
        String tempString;
        String pressureString;
        public ForecastObserver(ListBox listBox, WeatherSubject weatherSubject)
            : base (listBox, weatherSubject)
        {
            this.listBox = listBox;
            this.weatherSubject = weatherSubject;
            temp = 0;
            pressure = 0;
            tempString = "";
            pressureString = "";
        }

        public override void Update(Dictionary<String, double> dataDictionary)
        {
            foreach (var pair in dataDictionary)
            {
                if (pair.Key == "Temperature")
                    temp = Convert.ToInt16(pair.Value);
                else if (pair.Key == "Pressure")
                    pressure = Convert.ToInt16(pair.Value);
            }
            GetTemperatureString(temp);
            GetPressureString(pressure);
            Display();
        }

        public override void Display()
        {
            listBox.Items.Add(tempString + pressureString);
        }

        public String GetTemperatureString(int temp)
        {
            if (temp <= 9)
                temp = 0;
            else if (temp > 9 && temp < 19)
                temp = 1;
            else if (temp > 19)
                temp = 2;
            switch(temp)
            {
                case 0:
                    tempString = "Cold front moving in. ";
                    break;
                case 1:
                    tempString = "Warm periods expected. ";
                    break;
                case 2:
                    tempString = "Expect hot weather. ";
                    break;
            }
            return tempString;
        }

        public String GetPressureString(int pressure)
        {
            if (pressure < 400)
                pressure = 0;
            else if (pressure >= 400 && pressure <= 700)
                pressure = 1;
            else if (pressure > 700)
                pressure = 2;
            
            switch(pressure)
            {
                case 0:
                    pressureString = "Rain and possible thunderstorms. ";
                    break;
                case 1:
                    pressureString = "Fine with posiiblity of cloud coverage. ";
                    break;
                case 2:
                    pressureString = "Heat wave, possible drought. ";
                    break;
            }
            return pressureString;           
        }
    }
}
