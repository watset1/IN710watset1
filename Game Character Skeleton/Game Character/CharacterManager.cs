using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    class CharacterManager
    {
        public List<Character> CharacterList { get; set; }
        
        public CharacterManager()
        {
            CharacterList = new List<Character>();
        }

        public void DummyDataFill(ListBox listBox)
        {
            CharacterList.Add(new King(listBox, "Stewie"));
            CharacterList.Add(new Queen(listBox, "Meg"));
            CharacterList.Add(new Knight(listBox, "Lancelot"));
            CharacterList.Add(new Knight(listBox, "Irving"));
            CharacterList.Add(new Troll(listBox, "Grumpy"));
        }

        public void AddCharacter(Character character)
        {
            CharacterList.Add(character);
        }

        public void DisplayBattleMessages(List<Character> selectedNames)
        {
            foreach (Character character in selectedNames)
            {
                character.ListBox.Items.Add(character.StateName());
                character.ListBox.Items.Add(character.Declaim());
                character.ListBox.Items.Add(character.Attack());
                character.ListBox.Items.Add("--------------------------------------");
            }
        }

        public void ChangeWeapon(IWeapon newWeapon, List<Character> selectedNames)
        {
            foreach (Character character in selectedNames)
            {
                character.weapon = newWeapon;
            }
        }
    }
}
