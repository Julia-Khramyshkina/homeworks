using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework7_task1;
namespace Homework7_task1.Tests
{
    [TestClass]
    public class ListTest
    {
        [TestMethod]
        public void EmptyTest()
        {
            List<string> list = new List<string>();
            Assert.IsTrue(list.IsEmpty());
        }

        [TestMethod]
        public void InsertTest1()
        {
            List<int> list = new List<int>();
            list.InsertToEnd(1);
            Assert.IsTrue(list.ElementExist(1));
        }

        [TestMethod]
        public void InsertTest2()
        {
            List<string> list = new List<string>();
            list.InsertToEnd("1");
            Assert.IsTrue(list.ElementExist("1"));
        }

        [TestMethod]
        public void DeleteTest()
        {
            List<string> list = new List<string>();
            list.InsertToEnd("1");
            list.RemoveElement("1");
            Assert.IsTrue(list.IsEmpty());
        }   
    }
}
