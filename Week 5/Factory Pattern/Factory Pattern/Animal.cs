using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class Animal
    {
        protected String name;
        protected String family;
        protected String food;
        public Bitmap Image { get; set; }

        public Animal()
        {
            name = "";
            family = "";
            food = "";
            this.Image = Image;
        }

        public override string ToString()
        {
            String displayString = "I am a " + name;
            displayString += ". I am a " + family;
            displayString += ". I eat " + food + ".";

            return displayString;
        }
    }
}
