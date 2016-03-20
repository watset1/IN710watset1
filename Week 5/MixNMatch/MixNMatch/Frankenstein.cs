using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixNMatch
{
    public class Frankenstein : Character
    {
        public Frankenstein()
        {
            Head = new Bitmap("Frankenstein_0.png");
            Body = new Bitmap("Frankenstein_1.png");
            Legs = new Bitmap("Frankenstein_2.png");
        }
    }
}
