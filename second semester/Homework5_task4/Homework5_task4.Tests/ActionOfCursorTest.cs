using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework5_task4.Tests
{
    [TestClass]
    public class ActionOfCursorTest
    {
         private EventLoop eventLoop;
         private Action action;

        [TestInitialize]
        public void Initialize()
        {
            eventLoop = new EventLoop();
            action = new Action(Console.CursorLeft, Console.CursorTop);
            eventLoop.LeftHandler += action.Movement;
            eventLoop.RightHandler += action.Movement;
            eventLoop.UpHandler += action.Movement;
            eventLoop.DownHandler += action.Movement;
        }

        [TestMethod]
        public void StepInTheLeftTest()
        {
            eventLoop.LeftHandler += (sender, eventArgs) => Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }

        [TestMethod]
        public void StepInTheRightTest()
        {
            eventLoop.RightHandler += (sender, eventArgs) => Console.SetCursorPosition(Console.CursorLeft + 1, Console.CursorTop);
            Assert.AreEqual(Console.CursorLeft, 1);
        }
    }
}
