using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Airplanes
{
    public class BlueBody : AirplanePart
    {
        public BlueBody()
        {
            Image = Image.FromFile("bluebody.png");
        }
    }
}
