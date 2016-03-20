using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixNMatch
{
    public class CharacterCreator
    {
        public CharacterCreator() { }

        public Character createCharacter(String characterType)
        {
            Character newCharacter = null;

            switch(characterType)
            {
                case "Fairy":
                    newCharacter = new Fairy();
                    break;
                case "Frankenstein":
                    newCharacter = new Frankenstein();
                    break;
                case "Skeleton":
                    newCharacter = new Skeleton();
                    break;
                case "Vampire":
                    newCharacter = new Vampire();
                    break;
                case "Werewolf":
                    newCharacter = new Werewolf();
                    break;
                case "Witch":
                    newCharacter = new Witch();
                    break;
            }
            return newCharacter;
        }
    }
}
