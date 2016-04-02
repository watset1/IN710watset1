using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenReporter2016
{
    public class ChargesReportMaker : IReportMaker
    {
        public ChargesReportMaker() { }

        public void createReport(List<Garden> gardenList, Report newReport)
        {
            newReport.generateReport = new Report.GenerateReport(Charges);
        }

        public void Charges(List<Garden> gardenList, Report newReport)
        {
            String horizontalLine = "=====================================================\n";
            newReport.currentReportContent.Add(horizontalLine);
            foreach (Garden garden in gardenList)
            {
                String ownerName = garden.OwnerName;
                List<double> chargesList = garden.CurrentCharges;
                String symbol = "$";
                
                newReport.currentReportContent.Add(ownerName);
                newReport.currentReportContent.Add(horizontalLine);
                foreach (double charge in chargesList)
                {
                    newReport.currentReportContent.Add(symbol + charge.ToString("f2"));
                }
                newReport.currentReportContent.Add(horizontalLine);
            }
        }
    }
}
