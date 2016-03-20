﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class Kangaroo : Animal
    {
        public Kangaroo()
        {
            name = "Kangaroo";
            family = "Herbivore";
            food = "Leaves";
            Image = new Bitmap("kangaroo.jpg");
        }
    }
}
