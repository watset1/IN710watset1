using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Builder
{
    public class BusinessMachineMaker : IMachineMaker
    {
        public BusinessMachineMaker() { }

        public Cpu makeCpu()
        {
            Cpu cpu = new BusinessCpu();
            return cpu;
        }

        public Gpu makeGpu()
        {
            Gpu gpu = new BusinessGpu();
            return gpu;
        }

        public Ram makeRam()
        {
            Ram ram = new BusinessRam();
            return ram;
        }    
    }
}
