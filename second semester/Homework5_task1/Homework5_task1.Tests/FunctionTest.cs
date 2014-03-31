using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Homework5_task1.Tests
{
    [TestClass]
    public class FunctionTest
    {
        private List list;
        private ClassForFunction newFunctionClass;

        [TestInitialize]
        public void Initialize()
        {
            list = new List();
            newFunctionClass = new ClassForFunction();
        }

        [TestMethod]
        public void TestMap()
        {
            Func<int, int> somethingG = x => x * 2;
            list.InsertToEnd(2);
            newFunctionClass.Map(list, somethingG);
            Assert.AreEqual(4, list.ValueOnPosition(0));
        }

        [TestMethod]
        public void TestFilter1()
        {
            Func<int, bool> somethingCheck = x => (x % 3) == 0;
            list.InsertToEnd(2);
            list = newFunctionClass.Filter(list, somethingCheck);       
            Assert.IsTrue(list.IsEmpty());
        }

        [TestMethod]
        public void TestFilter2()
        {
            Func<int, bool> somethingCheck = x => (x % 3) == 0;
            list.InsertToEnd(3);
            list = newFunctionClass.Filter(list, somethingCheck);
            Assert.IsFalse(list.IsEmpty());
        }

        [TestMethod]
        public void TestFold()
        {
            Func<int, int, int> thisFunction = (x, y) => x * y;
            list.InsertToEnd(2);
            list.InsertToEnd(2);
            int result = newFunctionClass.Fold(list, 2, thisFunction);
            Assert.AreEqual(8, result);
        }
    }
}
