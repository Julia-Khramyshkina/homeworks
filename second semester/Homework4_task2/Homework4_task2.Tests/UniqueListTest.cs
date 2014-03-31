using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework4_task2.Tests
{
    [TestClass] 
    public class UniqueListTest
    {
        private List list;

        [TestInitialize]
        public void Initialize()
        {
            list = new List();
        }

        [TestMethod]
        [ExpectedException(typeof(System.DivideByZeroException))]
        public void InsertToHeadTest1()
        {
            try
            {

                list.InsertToHead(1);

                list.InsertToHead(1);
            }

            catch (MyException e)
            {
                Assert.AreEqual(e.Message, "Element exist");
            }

        }
    }
}
