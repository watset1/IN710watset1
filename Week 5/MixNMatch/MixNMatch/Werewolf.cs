using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixNMatch
{
    public class Werewolf : Character
    {
        public Werewolf()
        {
            Head = new Bitmap("Werewolf_0.png");
            Body = new Bitmap("Werewolf_1.png");
            Legs = new Bitmap("Werewolf_2.png");
        }
    }
}
