using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Airplanes
{
    public abstract class AirplanePart
    {
        public Image Image { get; set; }
        
        public AirplanePart()
        {
            this.Image = Image;
        }
    }
}
