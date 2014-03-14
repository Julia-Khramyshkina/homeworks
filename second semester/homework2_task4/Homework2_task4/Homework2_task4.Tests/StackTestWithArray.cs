using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework2_task1.Tests
{
    using GeneralStack;
    [TestClass]
    public class StackTest
    {
        private StackArray stack;

        [TestInitialize]
        public void Initialize()
        {
            stack = new StackArray();
        }

        [TestMethod]
        public void PushTest()
        {
            Assert.IsTrue(stack.IsEmpty());
            stack.Push(1);
            Assert.IsFalse(stack.IsEmpty());
        }

        [TestMethod]
        public void PopTest()
        {
            stack.Push(1);
            var result = stack.Pop();
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void PopTestWithTwoElements()
        {
            stack.Push(1);
            stack.Push(2);
            Assert.AreEqual(2, stack.Pop());
            Assert.AreEqual(1, stack.Pop());
        }

        [TestMethod]
        public void PopTestWithNoPush()
        {
            stack.Pop();
        }
    }
}
