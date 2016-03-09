using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Encryption_Tool;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EncryptTestOnString()
        {
            Rot13 target = new Rot13();
            String inputString = "test";
            String expected = "grfg";
            String actual;
            actual = target.Encrypt(inputString);
            Assert.AreEqual(expected, actual);   
        }
    }
}
