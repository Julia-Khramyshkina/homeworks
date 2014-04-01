using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework4_task2.Tests
{
    [TestClass] 
    public class UniqueListTest
    {
        private UniqueList unList;
        private List list;

        [TestInitialize]
        public void Initialize()
        {
            unList = new UniqueList();
            list = new List();
        }

        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void InsertToHeadTest()
        {
            unList.InsertToHead(1);
            unList.InsertToHead(1);

        }

        [TestMethod]
        public void InsertToHeadTest1()
        {
            unList.InsertToHead(1);
            list.InsertToHead(1);
            Assert.AreEqual(list.first().Value, unList.first().Value);
        }

        [TestMethod]
        public void InsertToHeadTest2()
        {
            unList.InsertToHead(1);
            list.InsertToHead(1);
            Assert.AreEqual(list.first().Value, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void InsertToEndTest()
        {
            unList.InsertToEnd(1);
            unList.InsertToEnd(1);
        }

        [TestMethod]
        public void InsertToEndTest1()
        {
            unList.InsertToEnd(1);
            list.InsertToEnd(1);
            Assert.AreEqual(list.first().Value, unList.first().Value);
        }

        [TestMethod]
        public void InsertToEndTest2()
        {
            unList.InsertToEnd(1);
            list.InsertToEnd(1);
            Assert.AreEqual(list.first().Value, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void InsertToThisPositionTest()
        {
            unList.InsertToThisPosition(0, 1);
            unList.InsertToThisPosition(1, 1);
        }

        [TestMethod]
        public void InsertToThisPositionTest1()
        {
            unList.InsertToThisPosition(0, 1);
            list.InsertToThisPosition(0, 1);
            Assert.AreEqual(list.first().Value, unList.first().Value);
        }

        [TestMethod]
        public void InsertToThisPositionTest2()
        {
            unList.InsertToThisPosition(0, 1);
            list.InsertToThisPosition(0, 1);
            Assert.AreEqual(list.first().Value, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void RemoveElementTest()
        {
            unList.RemoveElement(1);
        }

        [TestMethod]
        public void RemoveElementTest1()
        {
            unList.InsertToHead(1);
            list.InsertToHead(1);
            unList.RemoveElement(1);
            list.RemoveElement(1);
            Assert.IsTrue(list.IsEmpty() && unList.IsEmpty());
        }
    }
}
