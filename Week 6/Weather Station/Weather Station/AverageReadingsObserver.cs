using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_Station
{
    public class AverageReadingsObserver : WeatherObserver
    {
        List<double> savedValues;    //List of values saved from user input
        List<String> dataTypeList;   //List of field names being used in the form
        int UpdateAmount;            //The number of times the measurements have been read
        int WeatherVariableAmount;   //The amount of fields being read by the form - Could add a class to hold that data

        public AverageReadingsObserver(ListBox listBox, WeatherSubject weatherSubject)
            : base(listBox, weatherSubject)
        {
            this.listBox = listBox;
            this.weatherSubject = weatherSubject;
            savedValues = new List<double>();
            dataTypeList = new List<String>();
            UpdateAmount = 0;
            WeatherVariableAmount = 0;
        }

        public override void Update(Dictionary<String, double> dataDictionary)
        {   
            //Clear previous display data from the dictionary
            computedDataDictionary.Clear();
            while(dataTypeList.Count() == 0)
                GetDataTypes(dataDictionary);
            WeatherVariableAmount = dataTypeList.Count();
            GetDataValues(dataDictionary);
            UpdateAmount++;
            String dataType = "";
            double average = 0;               
                
            for (int j = 0; j < WeatherVariableAmount; j++)
            {
                dataType = dataTypeList.ElementAt(j);
                double total = 0;                    
                for (int k = j; k < savedValues.Count(); k += WeatherVariableAmount)
                    total += savedValues.ElementAt(k);                                        
                average = total / UpdateAmount;
                computedDataDictionary.Add(dataType, average);
            }              
            Display();
        }

        //Populate list of field types from dictionary keys
        public void GetDataTypes(Dictionary<String, double> dataDictionary)
        {
            foreach (var entry in dataDictionary)
                dataTypeList.Add(entry.Key);          
        }
        
        //Populate list of values from all user input
        public void GetDataValues(Dictionary<String, double> dataDictionary)
        {
            foreach (var entry in dataDictionary)
                savedValues.Add(entry.Value);
        }
    }
}
