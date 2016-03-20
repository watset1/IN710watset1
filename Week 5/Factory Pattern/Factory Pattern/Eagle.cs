using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class Eagle : Animal
    {
        public Eagle()
        {
            name = "Eagle";
            family = "Canivore";
            food = "Fish";
            Image = new Bitmap("Eagle.jpg");
        }
    }
}
