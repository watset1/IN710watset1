using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixNMatch
{
    public class Vampire : Character
    {
        public Vampire()
        {
            Head = new Bitmap("Vampire_0.png");
            Body = new Bitmap("Vampire_1.png");
            Legs = new Bitmap("Vampire_2.png");
        }
    }
}
