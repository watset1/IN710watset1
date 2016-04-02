using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenReporter2016
{
    public class ReportTypes
    {
        List<String> currentReport;

        public ReportTypes()
        {

        }

        public List<String> AreaReport(List<Garden> gardenList)
        {
            currentReport.Clear();
            foreach (Garden garden in gardenList)
            {
                String ownerName = garden.OwnerName;
                String area = garden.GetArea().ToString();
                String line = String.Format("{0,-14}:{1,10:f2}", ownerName, area);
                currentReport.Add(line);
            }
            return currentReport;
        }

        public List<String> OutstandingBalanceReport(List<Garden> gardenList)
        {
            currentReport.Clear();
            foreach (Garden garden in gardenList)
            {
                String ownerName = garden.OwnerName;
                String symbol = "$";
                String balance = garden.GetAccountBalance().ToString();
                String line = String.Format("{0,-14}:{1,7}{2,1:f2}", ownerName, symbol, balance);
                currentReport.Add(line);
            }
            return currentReport;
        }
    }
}
