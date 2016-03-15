﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory_Pattern
{
    public class AnimalManager
    {
        Random rGen = new Random();
        int nAnimalTypes = 3;
        NorthAmerica northAmerica;
        Australia australia;       

        public AnimalManager(ListBox listBox, Graphics canvas)
        {
            northAmerica = new NorthAmerica(listBox, rGen, nAnimalTypes, canvas);
            australia = new Australia(listBox, rGen, nAnimalTypes, canvas);
        }

        public void AustralianSim()
        {
            australia.RunSimulation();
        }

        public void NorthAmericanSim()
        {
            northAmerica.RunSimulation();
        }
    }
}
