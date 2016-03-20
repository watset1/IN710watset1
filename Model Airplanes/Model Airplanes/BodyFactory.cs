using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Airplanes
{
    public class BodyFactory : IAirplanePartFactory
    {
        public BodyFactory() { }

        public  AirplanePart createPart(String partString)
        {
            AirplanePart newBody = null;
            switch (partString)
            {
                case "Red Body":
                    newBody = new RedBody();
                    break;
                case "Blue Body":
                    newBody = new BlueBody();
                    break;
                case "Black Body":
                    newBody = new BlackBody();
                    break;
            }
            return newBody;
        }
    }
}
