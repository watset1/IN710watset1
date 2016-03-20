using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Airplanes
{
    public class BlackTail : AirplanePart
    {
        public BlackTail()
        {
            Image = Image.FromFile("blacktail.png");
        }
    }
}
