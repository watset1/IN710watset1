using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    public class Troll : Character
    {
        public Troll(ListBox listBox, String name)
            : base(listBox, name)
        {
            this.Name = name;
            this.ListBox = listBox;
            //weapon = new Bow() -- this is to the exact specifications of the practical.
            //I thought added a new weapon class specifically for the default troll would be a good idea.
            weapon = new Club();
        }

        public override String Declaim()
        {
            String declaimation = "Trolls don't have time to chat!";
            return declaimation;
        }

        public override String Attack()
        {
            String battleMessage = weapon.UseWeapon();
            return battleMessage;
        }
    }
}
