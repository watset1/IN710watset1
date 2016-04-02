using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenReporter2016
{
    public interface IReportMaker
    {
        void createReport(List<Garden> gardenList, Report newReport);
    }
}
