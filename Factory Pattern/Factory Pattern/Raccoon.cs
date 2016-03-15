using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class Raccoon : Animal
    {
        public Raccoon()
        {
            name = "Raccoon";
            family = "Herbivore";
            food = "Garbage";
            Image = new Bitmap("raccoon.jpg");
        }
    }
}
