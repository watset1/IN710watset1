﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Airplanes
{
    public interface IAirplanePartFactory
    {
         AirplanePart createPart(String partString);
    }
}
