using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixNMatch
{
    public class Fairy : Character
    {
        public Fairy()
        {
            Head = new Bitmap("Fairy_0.png");
            Body = new Bitmap("Fairy_1.png");
            Legs = new Bitmap("Fairy_2.png");
        }
    }
}
