﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public interface IAnimalFactory
    {
        Animal createAnimal(int animalCode);
    }
}
