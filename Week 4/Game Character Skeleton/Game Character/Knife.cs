using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    public class Knife : IWeapon
    {
        public Knife() { }

        public String UseWeapon()
        {
            String weaponAction = "I stab with my knife!";
            return weaponAction;
        }
    }
}
