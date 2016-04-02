using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenReporter2016
{
    class AccountBalanceReportMaker : IReportMaker
    {
        public AccountBalanceReportMaker() { }

        public void createReport(List<Garden> gardenList, Report newReport)
        {
            newReport.generateReport = new Report.GenerateReport(AccountBalance);
        }

        public void AccountBalance(List<Garden> gardenList, Report newReport)
        {
            foreach (Garden garden in gardenList)
            {
                String ownerName = garden.OwnerName;
                String symbol = "$";
                String balance = garden.GetAccountBalance().ToString();
                String line = String.Format("{0,-14}:{1,7}{2,1:f2}", ownerName, symbol, balance);
                newReport.currentReportContent.Add(line);
            }
        }
    }
}
