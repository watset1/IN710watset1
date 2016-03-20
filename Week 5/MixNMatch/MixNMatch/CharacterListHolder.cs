using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixNMatch
{
    public class CharacterListHolder
    {
        List<String> characterList;
        
        public CharacterListHolder()
        {
            characterList = new List<String>();
        }

        public List<String> populateList()
        {
            characterList.Add("Fairy");
            characterList.Add("Frankenstein");
            characterList.Add("Skeleton");
            characterList.Add("Vampire");
            characterList.Add("Werewolf");
            characterList.Add("Witch");

            return characterList;
        }
    }
}
