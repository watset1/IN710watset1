using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixNMatch
{
    public class LegsMaker : IBodyPartMaker
    {
        public LegsMaker() { }

        public Bitmap makeBodyPart(Character character)
        {
            Bitmap legs = new Bitmap(character.Legs);
            return legs;
        }
        
    }
}
