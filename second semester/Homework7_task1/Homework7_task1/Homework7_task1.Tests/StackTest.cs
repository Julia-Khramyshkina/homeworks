using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework7_task1;
namespace Homework7_task1.Tests
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void PushTest1()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            Assert.IsFalse(stack.IsEmpty());
        }

        [TestMethod]
        public void PushTest2()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("1");
            Assert.IsFalse(stack.IsEmpty());
        }

        [TestMethod]
        public void PopTest1()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            Assert.AreEqual(stack.Pop(),1);
        }

        [TestMethod]
        public void PopTest2()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("1");
            Assert.AreEqual(stack.Pop(), "1");
        }
    }
}
