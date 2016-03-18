using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Builder
{
    public class GamingMachineMaker : IMachineMaker
    {
        public GamingMachineMaker() { }

        public Cpu makeCpu()
        {
            Cpu cpu = new GamingCpu();
            return cpu;
        }

        public Gpu makeGpu()
        {
            Gpu gpu = new GamingGpu();
            return gpu;
        }

        public Ram makeRam()
        {
            Ram ram = new GamingRam();
            return ram;
        }
    }
}
