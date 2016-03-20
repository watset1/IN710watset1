using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Airplanes
{
    public class WingFactory : IAirplanePartFactory
    {
        public WingFactory() { }

        public AirplanePart createPart(String partString)
        {
            AirplanePart newWing = null;
            switch (partString)
            {
                case "Red Wing":
                    newWing = new RedWing();
                    break;
                case "Blue Wing":
                    newWing = new BlueWing();
                    break;
                case "Black Wing":
                    newWing = new BlueWing();
                    break;
            }
            return newWing;
        }
    }
}
