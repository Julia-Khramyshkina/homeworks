using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework2_task2.Tests
{
    using NameSpaceForList;
    [TestClass]
    public class ListTest
    {
        private List list;

        [TestInitialize]
        public void Initialize()
        {
            list = new List();
        }

        [TestMethod]
        public void InsertToHeadTest()
        {
            list.InsertToHead(1);
            Assert.IsFalse(list.IsEmpty());
        }

        [TestMethod]
        public void InsertToEndTest()
        {
            list.InsertToEnd(1);
            Assert.IsFalse(list.IsEmpty());
        }

        [TestMethod]
        public void IsEmptyTest()
        {
           Assert.IsTrue(list.IsEmpty());
        }

        [TestMethod]
        public void RemoveElementTest()
        {
            list.InsertToHead(1);
            list.RemoveElement(1);
            Assert.IsTrue(list.IsEmpty());
        }

        [TestMethod]
        public void ValueOnPositionTest()
        {
            list.InsertToHead(1);
            int x = list.ValueOnPosition(0);
            Assert.AreEqual(1, x);
        }

        [TestMethod]
        public void SizeOfListTest()
        {
            list.InsertToHead(1);
            int size = list.SizeOfList();
            Assert.AreEqual(1, size);
        }

    }
}
