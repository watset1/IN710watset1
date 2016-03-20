using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    public class Club : IWeapon
    {
        public Club() { }

        public String UseWeapon()
        {
            String weaponAction = "I whack with my club!";
            return weaponAction;
        }
    }
}
