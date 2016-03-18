using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Builder
{
    public abstract class Component
    {
        public String Name { get; set; }
        public double Price { get; set; }

        public Component()
        {
            Name = "";
            Price = 0;
        }

        public override string ToString()
        {
            String componentString = Price + "\t" + Name;
            return componentString;
        }
    }
}
