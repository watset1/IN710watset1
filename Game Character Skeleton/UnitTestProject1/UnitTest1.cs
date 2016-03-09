using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game_Character;
using System.Windows.Forms;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeclaimTestOnKing()
        {
            ListBox listBox = new ListBox();
            King king = new King(listBox, "TestName"); 

            String expected = "I am the most mighty of Kings!";
            String actual = king.Declaim();

            Assert.AreEqual(expected, actual);
        }
    }
}
