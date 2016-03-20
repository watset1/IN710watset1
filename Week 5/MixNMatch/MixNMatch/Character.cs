using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixNMatch
{
    public abstract class Character
    {
        public Bitmap Head { get; set; }
        public Bitmap Body { get; set; }
        public Bitmap Legs { get; set; }

        public Character()
        {
            this.Head = Head;
            this.Body = Body;
            this.Legs = Legs;
        }
    }
}
