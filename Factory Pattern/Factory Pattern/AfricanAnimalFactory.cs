using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class AfricanAnimalFactory : IAnimalFactory
    {
        public Animal createAnimal(int animalCode)
        {
            Animal newAnimal = null;

            switch (animalCode)
            {
                case 0:
                    newAnimal = new Lion();
                    break;
                case 1:
                    newAnimal = new Hyena();
                    break;
                case 2:
                    newAnimal = new Tiger();
                    break;
                case 3:
                    newAnimal = new Zebra();
                    break;
            }
            return newAnimal;
        }
    }
}
