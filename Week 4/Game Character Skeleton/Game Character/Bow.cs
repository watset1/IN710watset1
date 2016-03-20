using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    public class Bow : IWeapon
    {
        public Bow() { }

        public String UseWeapon()
        {
            String weaponAction = "I shoot with my bow!";
            return weaponAction;
        }
    }
}
