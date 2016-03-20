using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Builder
{
    public class LaptopMachineMaker : IMachineMaker
    {
        public LaptopMachineMaker() { }

        public Cpu makeCpu()
        {
            Cpu cpu = new LaptopCpu();
            return cpu;
        }

        public Gpu makeGpu()
        {
            Gpu gpu = new LaptopGpu();
            return gpu;
        }

        public Ram makeRam()
        {
            Ram ram = new LaptopRam();
            return ram;
        } 
   
        public Motherboard makeMotherBoard()
        {
            Motherboard motherboard = new LaptopMotherboard();
            return motherboard;
        }
    }
}
