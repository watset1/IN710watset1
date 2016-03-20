using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IN710_4._1_Animal_Shelter_Solution_2014;
using System.Windows.Forms;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DisplayCritterListTestOnNullCritterList()
        {
            List<PictureBox> testPictureBoxList = new List<PictureBox>();
            List<Critter> testCritterList = new List<Critter>();
            PictureDisplay testMachine = new PictureDisplay(testPictureBoxList);

            testMachine.displayCritterList(testCritterList);

        }
    }
}
