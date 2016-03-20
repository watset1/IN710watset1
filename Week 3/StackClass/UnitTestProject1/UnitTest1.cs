using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackClass;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsEmptyTestOnEmptyStack()
        {
            Stack testStack = new Stack();

            bool expected = true;

            bool actual = testStack.IsEmpty();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsEmptyTestOnStackWithItems()
        {
            Stack testStack = new Stack();
            StringNode testString1 = new StringNode();
            StringNode testString2 = new StringNode();
            testString1.Value = "Test String 1";
            testString2.Value = "Test String 2";

            bool expected = false;

            testStack.Push(testString1);
            testStack.Push(testString2);

            bool actual = testStack.IsEmpty();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsEmptyTestOnPreviouslyPopulatedStackNowEmpty()
        {
            Stack testStack = new Stack();
            StringNode testString1 = new StringNode();
            StringNode testString2 = new StringNode();
            testString1.Value = "Test String 1";
            testString2.Value = "Test String 2";


            bool expected = true;

            testStack.Push(testString1);
            testStack.Push(testString2);
            testStack.Pop();
            testStack.Pop();

            bool actual = testStack.IsEmpty();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void PeekTestOnEmptyStack()
        {
            Stack testStack = new Stack();

            String actual = testStack.Peek();
        }

        [TestMethod]
        public void PeekTestOnPopulatedStack()
        {
            Stack testStack = new Stack();
            StringNode testString1 = new StringNode();
            StringNode testString2 = new StringNode();
            StringNode testString3 = new StringNode();           
            
            testString1.Value = "Test String 1";
            testString2.Value = "Test String 2";
            testString3.Value = "Test String 3";


            bool expected = true;

            testStack.Push(testString1);
            testStack.Push(testString2);
            testStack.Push(testString3);

            String testPeek = testStack.Peek();
            String testStringStillExists = testStack.Peek();
            bool actual = (testPeek == testString3.Value && testStringStillExists == testString3.Value);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void PeekTestOnPreviouslyPoplulatedStack()
        {
            Stack testStack = new Stack();
            StringNode testString1 = new StringNode();
            StringNode testString2 = new StringNode();
            testString1.Value = "Test String 1";
            testString2.Value = "Test String 2";

            testStack.Push(testString1);
            testStack.Push(testString2);
            testStack.Pop();
            testStack.Pop();

            string actual = testStack.Peek();
        }

        [TestMethod]
        public void CountTestOnPopulatedStack()
        {
            Stack testStack = new Stack();
            StringNode testString1 = new StringNode();
            StringNode testString2 = new StringNode();
            StringNode testString3 = new StringNode();
            
            testString1.Value = "Test String 1";
            testString2.Value = "Test String 2";
            testString3.Value = "Test String 3";

            int expected = 3;

            testStack.Push(testString1);
            testStack.Push(testString2);
            testStack.Push(testString3);

            int actual = testStack.Count();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CountTestOnEmptyStack()
        {
            Stack testStack = new Stack();

            int expected = 0;

            int actual = testStack.Count();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CountTestOnPreviouslyPoplulatedStack()
        {
            Stack testStack = new Stack();
            StringNode testString1 = new StringNode();
            StringNode testString2 = new StringNode();
            testString1.Value = "Test String 1";
            testString2.Value = "Test String 2";


            int expected = 0;

            testStack.Push(testString1);
            testStack.Push(testString2);
            testStack.Pop();
            testStack.Pop();

            int actual = testStack.Count();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void PopTestOnEmptyStack()
        {
            Stack testStack = new Stack();

            testStack.Pop();
        }
    }
}
