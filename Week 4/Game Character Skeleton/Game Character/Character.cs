using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    public abstract class Character
    {
        public String Name { get; set; }
        public ListBox ListBox { get; set; }
        public IWeapon weapon;

        protected Character(ListBox listBox, string name)
        {
            this.Name = name;
            this.ListBox = listBox;
            weapon = null;
        }

        public virtual String StateName()
        {
            String nameStated = "My name is " + Name;
            return nameStated;
        }

        public abstract String Declaim();

        public abstract String Attack();
    }
}
