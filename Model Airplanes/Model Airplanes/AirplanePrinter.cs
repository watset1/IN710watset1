using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model_Airplanes
{
    public class AirplanePrinter
    {
        WingFactory wingFactory;
        BodyFactory bodyFactory;
        TailFactory tailFactory;

        public AirplanePrinter() { }

        public void printWing(String wingString, PictureBox pictureBox)
        {
            wingFactory = new WingFactory();
            AirplanePart wing = wingFactory.createPart(wingString);
            pictureBox.Image = wing.Image;
        }

        public void printBody(String bodyString, PictureBox pictureBox)
        {
            bodyFactory = new BodyFactory();
            AirplanePart body = bodyFactory.createPart(bodyString);
            pictureBox.Image = body.Image;
        }

        public void printTail(String tailString, PictureBox pictureBox)
        {
            tailFactory = new TailFactory();
            AirplanePart tail = tailFactory.createPart(tailString);
            pictureBox.Image = tail.Image;
        }
    }


}
