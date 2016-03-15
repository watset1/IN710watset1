using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class Bison : Animal
    {
        public Bison()
        {
            name = "Bison";
            family = "Herbivore";
            food = "Grass";
            Image = new Bitmap("bison.jpg");
        }
    }
}
