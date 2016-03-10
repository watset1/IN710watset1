using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{
    class PictureDisplay: IDisplay
    {
        public List<PictureBox> pictureBoxList { get; set; }

        public PictureDisplay(List<PictureBox> pictureBoxList)
        {
            this.pictureBoxList = pictureBoxList;
        }

        public void displayCritterList(List<Critter> critterList)
        {
            for (int i = 0; i < critterList.Count(); i++)
            {
                pictureBoxList.ElementAt(i).Image = Image.FromFile(critterList.ElementAt(i).ImageFileName);
            }
        }

        public void clearDisplay()
        {
            foreach (PictureBox pictureBox in pictureBoxList)
            {
                pictureBox.Image = null;
            }
        }
    }
}
