using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenReporter2016
{
    public class Report
    {
        public delegate void GenerateReport(List<Garden> gardenList);

        GenerateReport generateReport;
        public List<String> createdReport;
        public String reportType;

        public Report()
        {
            createdReport = new List<String>();
            reportType = null;
        }

        public void AreaReport(List<Garden> gardenList)
        {
            createdReport.Clear();
            foreach (Garden garden in gardenList)
            {
                String ownerName = garden.OwnerName;
                String area = garden.GetArea().ToString();
                String line = String.Format("{0,-14}:{1,10:f2}", ownerName, area);
                createdReport.Add(line);
            }
        }

        public void OutstandingBalanceReport(List<Garden> gardenList)
        {
            createdReport.Clear();
            foreach (Garden garden in gardenList)
            {
                String ownerName = garden.OwnerName;
                String symbol = "$";
                String balance = garden.GetAccountBalance().ToString();
                String line = String.Format("{0,-14}:{1,7}{2,1:f2}", ownerName, symbol, balance);
                createdReport.Add(line);
            }
        }

        public void createReport(List<Garden> gardenList, String reportType)
        {
            switch (reportType)
            {
                case "area":
                    generateReport = new GenerateReport(AreaReport);
                    break;

                case "charges":
                    generateReport = new GenerateReport(OutstandingBalanceReport);
                    break;
            }

            generateReport(gardenList);
        }
    }
}
