using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class Tiger : Animal
    {
        public Tiger()
        {
            name = "Tiger";
            family = "Carnivore";
            food = "Zebra";
            Image = new Bitmap("tiger.jpg");
        }
    }
}
