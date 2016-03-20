using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{
    public class TextDisplay: IDisplay
    {
        public ListBox listBox { get; set; }

        public TextDisplay(ListBox listBox)
        {
            this.listBox = listBox;
        }

        public void displayCritterList(List<Critter> critterList)
        {
            foreach (Critter critter in critterList)
            {
                listBox.Items.Add(critter.Name);               
            }
        }

        public void clearDisplay()
        {
            listBox.Items.Clear();
        }
    }
}
