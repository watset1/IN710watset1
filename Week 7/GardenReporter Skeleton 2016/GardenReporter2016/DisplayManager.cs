using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GardenReporter2016
{
    public class DisplayManager
    {
        GardenManager gardenManager;
        Report report;

        public DisplayManager()
        {
            gardenManager = new GardenManager();
            report = new Report();
        }

        public void generateReport(String reportType)
        {
            List<Garden> gardenList = gardenManager.gardenList;
            report.reportType = reportType;
            report.createReport(gardenList, reportType);
        }

        public void displayReport(ListBox listBox)
        {
            clearReport(listBox);
            foreach (String line in report.createdReport)
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
