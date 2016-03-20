using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Airplanes
{
    public class RedTail : AirplanePart
    {
        public RedTail()
        {
            Image = Image.FromFile("redtail.png");
        }
    }
}
