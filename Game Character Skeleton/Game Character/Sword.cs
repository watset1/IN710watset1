using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    public class Sword : IWeapon
    {
        public Sword() { }

        public String UseWeapon()
        {
            String weaponAction = "I slice with my sword!";
            return weaponAction;
        }
    }
}
