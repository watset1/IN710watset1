using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class Lion : Animal
    {
        public Lion()
        {
            name = "Lion";
            family = "Carnivore";
            food = "Hyena";
            Image = new Bitmap("lion.jpg");
        }
    }
}
