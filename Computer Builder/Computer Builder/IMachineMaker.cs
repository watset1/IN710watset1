﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Builder
{
    public interface IMachineMaker
    {
        Cpu makeCpu();
        Gpu makeGpu();
        Ram makeRam();
    }
}
