using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LifeIsPain.Tests
{
    [TestClass]
    public class PriorityQueueTest
    {
        private PriorityQueue priorityQueue;
        [TestInitialize]
        public void Initialize()
        {
            priorityQueue = new PriorityQueue();
        }

        [TestMethod]
        public void IsEmptyTest()
        {
            Assert.IsTrue(priorityQueue.IsEmpty());
        }

        [TestMethod]
        public void EnqueueTest()
        {
            priorityQueue.Enqueue(1, 1);
            Assert.IsFalse(priorityQueue.IsEmpty());
        }

        [TestMethod]
        public void DequeueTest1()
        {
            priorityQueue.Enqueue(1, 1);
            priorityQueue.Enqueue(2, 2);
            Assert.AreEqual(2, priorityQueue.Dequeue());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void DequeueTest2()
        {
           priorityQueue.Dequeue();
        }

        [TestMethod]
        public void DequeueTest3()
        {
            priorityQueue.Enqueue(1, 1);
            priorityQueue.Enqueue(3, 3);
            priorityQueue.Enqueue(2, 3);
            Assert.AreEqual(3, priorityQueue.Dequeue());
        }
    }

}
