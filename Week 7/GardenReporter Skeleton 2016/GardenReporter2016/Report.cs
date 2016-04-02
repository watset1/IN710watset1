using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenReporter2016
{
    public class Report
    {
        public delegate void GenerateReport(List<Garden> gardenList, Report report);

        public GenerateReport generateReport;
        public List<String> currentReportContent;

        public Report()
        {
            currentReportContent = new List<String>();
        }
    }
}
