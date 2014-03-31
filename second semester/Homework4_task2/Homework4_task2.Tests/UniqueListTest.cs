using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework4_task2.Tests
{
    [TestClass] 
    public class UniqueListTest
    {
        private UniqueList list;

        [TestInitialize]
        public void Initialize()
        {
            list = new UniqueList();
        }

        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void InsertToHeadTest()
        {
            list.InsertToHead(1);
            list.InsertToHead(1);

        }

        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void InsertToEndTest()
        {
            list.InsertToEnd(1);
            list.InsertToEnd(1);
        }

        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void InsertToThisPositionTest()
        {
            list.InsertToThisPosition(0, 1);
            list.InsertToThisPosition(1, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void RemoveElementTest()
        {
            list.RemoveElement(1);
        }
    }
}
