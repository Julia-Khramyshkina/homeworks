using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework4_Task1.Tests
{
    using Homework4_task1;
    [TestClass]
    public class TreeTest
    {
        private Tree tree;

        [TestInitialize]
        public void Initialize()
        {
            tree = new Tree();
        }

        [TestMethod]
        public void SimpleTest()
        {
            tree.Parse("(+11)");
            Assert.AreEqual(2, tree.Calculate());
        }

        [TestMethod]
        public void SimpleTest1()
        {
            tree.Parse("(*(+12)(-25))");
            Assert.AreEqual(-9, tree.Calculate());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void SimpleTest2()
        {
            tree.Parse("(/10))");
            tree.Calculate();
        }
    }
}
