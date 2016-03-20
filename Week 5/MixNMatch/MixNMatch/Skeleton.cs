using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixNMatch
{
    public class Skeleton : Character
    {
        public Skeleton()
        {
            Head = new Bitmap("Skeleton_0.png");
            Body = new Bitmap("Skeleton_1.png");
            Legs = new Bitmap("Skeleton_2.png");
        }
    }
}
