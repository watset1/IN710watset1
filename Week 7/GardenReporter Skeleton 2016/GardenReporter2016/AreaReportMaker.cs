using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenReporter2016
{
    public class AreaReportMaker : IReportMaker
    {

        public AreaReportMaker() { }

        public void createReport(List<Garden> gardenList, Report newReport)
        {
            newReport.generateReport = new Report.GenerateReport(Area);
        }

        public void Area(List<Garden> gardenList, Report newReport)
        {
            foreach (Garden garden in gardenList)
            {
                String ownerName = garden.OwnerName;
                String area = garden.GetArea().ToString();
                String line = String.Format("{0,-14}:{1,10:f2}", ownerName, area);
                newReport.currentReportContent.Add(line);
            }
            
        } 
    }
}
