using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Encryption_Tool;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //Rot13
        [TestMethod]
        public void Rot13EncryptTestOnStringNoWhiteSpaces()
        {
            Rot13 target = new Rot13();
            String inputString = "test";
            String expected = "grfg";
            String actual;
            actual = target.Encrypt(inputString);
            Assert.AreEqual(expected, actual);   
        }

        [TestMethod]
        public void Rot13EncryptTestOnStringWhiteSpaces()
        {
            Rot13 target = new Rot13();
            String inputString = "test string";
            String expected = "grfg fgevat";
            String actual;
            actual = target.Encrypt(inputString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException))]
        public void Rot13EncryptTestOnNullString()
        {
            Rot13 target = new Rot13();
            String inputString = null;
            target.Encrypt(inputString);
        }

        //Reverse
        [TestMethod]
        public void ReverseEncryptTestOnStringNoWhiteSpaces()
        {
            Reverse target = new Reverse();
            String inputString = "test";
            String expected = "tset";
            String actual;
            actual = target.Encrypt(inputString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReverseEncryptTestOnStringWhiteSpaces()
        {
            Reverse target = new Reverse();
            String inputString = "test string";
            String expected = "gnirts tset";
            String actual;
            actual = target.Encrypt(inputString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException))]
        public void ReverseEncryptTestOnNullString()
        {
            Reverse target = new Reverse();
            String inputString = null;
            target.Encrypt(inputString);
        }
    }
}
