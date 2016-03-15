using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class Wolf : Animal
    {
        public Wolf()
        {
            name = "Wolf";
            family = "Canivore";
            food = "Rabbits";
            Image = new Bitmap("wolf.jpg");
        }
    }
}
