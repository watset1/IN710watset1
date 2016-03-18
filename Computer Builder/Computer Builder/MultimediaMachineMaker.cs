using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Builder
{
    public class MultimediaMachineMaker : IMachineMaker
    {
        public MultimediaMachineMaker(){} 

        public Cpu makeCpu()
        {
            Cpu cpu = new MultimediaCpu();
            return cpu;
        }

        public Gpu makeGpu()
        {
            Gpu gpu = new MultimediaGpu();
            return gpu;
        }

        public Ram makeRam()
        {
            Ram ram = new MultimediaRam();
            return ram;
        }
    }
}
