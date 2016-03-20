using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Airplanes
{
    public class BlackWing : AirplanePart
    {
        public BlackWing()
        {
            Image = Image.FromFile("blackwing.png");
        } 
    }
}
