using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City_Database
{
    public class City
    {
        public String CityName { get; set; }
        public String CountryName { get; set; }
        public int Population { get; set; }

        public City(String cityName, String countryName, int population)
        {
            CityName = cityName;
            CountryName = countryName;
            Population = population;
        }

        public override string ToString()
        {
            return String.Format("{0,-15}\t{1,-15}\t{2}",CityName,Population,CountryName);
        }
    }
}
