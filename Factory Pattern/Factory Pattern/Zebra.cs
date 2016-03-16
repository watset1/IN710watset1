﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class Zebra : Animal
    {
        public Zebra()
        {
            name = "Zebra";
            family = "Herbivore";
            food = "Grass";
            Image = new Bitmap("zebra.jpg");
        }
    }
}
