﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Airplanes
{
    public class BlueTail : AirplanePart
    {
        public BlueTail()
        {
            Image = Image.FromFile("bluetail.png");
        }
    }
}
