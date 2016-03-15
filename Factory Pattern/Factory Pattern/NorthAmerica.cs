﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory_Pattern
{
    public class NorthAmerica : Continent 
    {
        public NorthAmerica(ListBox displayBox,Random rGen, int nAnimalTypes, Graphics canvas)
            : base(displayBox, rGen, nAnimalTypes, canvas)
        {
            animalFactory = new NorthAmericanAnimalFactory();
        }
    }
}
