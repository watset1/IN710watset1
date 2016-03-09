using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    public class Queen : Character
    {
        public Queen(ListBox listBox, String name)
            : base(listBox, name)
        {
            this.Name = name;
            this.ListBox = listBox;
            weapon = new Bow();
        }

        public override String Declaim()
        {
            String declaimation = "I am the powerul Queen!";
            return declaimation;
        }

        public override String Attack()
        {
            String battleMessage = weapon.UseWeapon();
            return battleMessage;
        }
    }
}
