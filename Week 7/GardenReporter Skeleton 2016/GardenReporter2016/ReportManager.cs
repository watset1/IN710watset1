using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GardenReporter2016
{
    public class ReportManager
    {
        GardenManager gardenManager;
        Report newReport;
        public IReportMaker reportMaker;

        public ReportManager()
        {
            gardenManager = new GardenManager();
            newReport = new Report();
        }

        public void generateReport(IReportMaker reportMaker)
        {
            newReport.currentReportContent.Clear();
            reportMaker.createReport(gardenManager.gardenList, newReport);
            newReport.generateReport(gardenManager.gardenList, newReport);
        }

        public void displayReport(ListBox listBox)
        {
            clearReport(listBox);
            foreach (String line in newReport.currentReportContent)
            {
                listBox.Items.Add(line);
            }
        }

        public void clearReport(ListBox listBox)
        {
            listBox.Items.Clear();
        }
    }
}
