using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class Koala : Animal
    {
        public Koala()
        {
            name = "Koala";
            family = "Herbivore";
            food = "Leaves";
            Image = new Bitmap("koala.jpg");
        }
    }
}
