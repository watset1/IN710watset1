using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixNMatch
{
    public class CharacterPrinter
    {
        CharacterCreator creator = new CharacterCreator();
        HeadMaker headMaker;
        BodyMaker bodyMaker;
        LegsMaker legsMaker;

        public CharacterPrinter() { }

        public void printHead(PictureBox pictureBox, String characterType)
        {
            headMaker = new HeadMaker();
            Character character = creator.createCharacter(characterType);
            pictureBox.Image = headMaker.makeBodyPart(character);
        }

        public void printBody(PictureBox pictureBox, String characterType)
        {
            bodyMaker = new BodyMaker();
            Character character = creator.createCharacter(characterType);
            pictureBox.Image = bodyMaker.makeBodyPart(character);
        }

        public void printLegs(PictureBox pictureBox, String characterType)
        {
            legsMaker = new LegsMaker();
            Character character = creator.createCharacter(characterType);
            pictureBox.Image = legsMaker.makeBodyPart(character);
        }
    }
}
