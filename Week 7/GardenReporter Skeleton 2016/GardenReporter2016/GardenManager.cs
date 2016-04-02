using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenReporter2016
{
    public class GardenManager
    {
        public List<Garden> gardenList;

        public GardenManager()
        {          
            gardenList = new List<Garden>();
            populateDummyData();
        }

        public void AddGarden(Garden garden)
        {
            gardenList.Add(garden);
        }

        private void populateDummyData()
        {
            Garden garden1 = new Garden(10, 20, "Savitch");
            garden1.AddCharge(123.45);
            garden1.AddCharge(678.90);

            Garden garden2 = new Garden(8.5, 120, "Knuth");
            garden2.AddCharge(45.32);
            garden2.AddCharge(678.90);
            garden2.AddCharge(98.76);

            Garden garden3 = new Garden(54.25, 60, "Winograd");
            garden3.AddCharge(149.32);
            garden3.AddCharge(78.12);
            garden3.AddCharge(150.00);

            AddGarden(garden1);
            AddGarden(garden2);
            AddGarden(garden3);
        }
    }
}
