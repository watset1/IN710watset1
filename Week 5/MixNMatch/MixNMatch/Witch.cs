using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixNMatch
{
    public class Witch : Character
    {
        public Witch()
        {
            Head = new Bitmap("Witch_0.png");
            Body = new Bitmap("Witch_1.png");
            Legs = new Bitmap("Witch_2.png");
        }
    }
}
