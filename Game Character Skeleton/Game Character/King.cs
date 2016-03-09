using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    public class King : Character
    {
        public King(ListBox listBox, String name)
            : base(listBox, name)
        {
            this.Name = name;
            this.ListBox = listBox;
            weapon = new Sword();
        } 
     
        public override String Declaim()
        {
            String declaimation = "I am the most mighty of Kings!";
            return declaimation;
        }

        public override String Attack()
        {
            String battleMessage = weapon.UseWeapon();
            return battleMessage;
        }
    }

     
}
