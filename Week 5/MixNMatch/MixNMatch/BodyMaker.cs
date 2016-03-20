using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixNMatch
{
    public class BodyMaker : IBodyPartMaker
    {
        public BodyMaker() { }

        public Bitmap makeBodyPart(Character character)
        {
            Bitmap bodyBitmap = new Bitmap(character.Body);
            return bodyBitmap;
        }
    }
}
