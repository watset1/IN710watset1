using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Airplanes
{
    public class TailFactory : IAirplanePartFactory
    {
        public TailFactory() { }

        public AirplanePart createPart(String partString)
        {
            AirplanePart newTail = null;
            switch (partString)
            {
                case "Red Tail":
                    newTail = new RedTail();
                    break;
                case "Blue Tail":
                    newTail = new BlueTail();
                    break;
                case "Black Tail":
                    newTail = new BlackTail();
                    break;
            }
            return newTail;
        }
    }
}
