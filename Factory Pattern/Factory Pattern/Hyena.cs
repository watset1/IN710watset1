using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class Hyena : Animal
    {
        public Hyena()
        {
            name = "Hyena";
            family = "Carnivore";
            food = "Animal Remains";
            Image = new Bitmap("hyena.jpg");
        }
    }
}
