using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game_Character;
using System.Windows.Forms;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CharacterAddTestOnKing()
        {
            ListBox listBox = new ListBox();
            List<Character> CharacterList = new List<Character>();
            King king = new King(listBox, "TestName");
            CharacterList.Add(king);
            int expected = 1;
            int actual = CharacterList.Count;

            Assert.AreEqual(expected, actual);
        }
    }
}
