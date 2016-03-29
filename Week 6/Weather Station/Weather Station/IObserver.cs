using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Station
{
    public interface IObserver
    {
        void Update(Dictionary<String, double> dataDictionary);
        void Display();
    }
}
