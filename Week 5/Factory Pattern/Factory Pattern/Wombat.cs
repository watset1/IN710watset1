using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class Wombat : Animal
    {
        public Wombat()
        {
            name = "Wombat";
            family = "Herbivore";
            food = "Grass";
            Image = new Bitmap("wombat.jpg");
        }
    }
}
