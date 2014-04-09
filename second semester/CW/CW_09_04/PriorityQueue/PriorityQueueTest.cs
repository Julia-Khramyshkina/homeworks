using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CW_09_04
{
    [TestClass]
    public class PriorityQueueTest
    {
        private PriorityQueue oueue;

        [TestInitialize]
        public void Initialize()
        {
            oueue = new PriorityQueue();            
        }

        [TestMethod]
        public void EnqueueTest()
        {
            oueue.Enqueue(1, 1);
            Assert.IsFalse(oueue.IsEmpty());
        }

        [TestMethod]
        public void DequeueTest()
        {
            oueue.Enqueue(1, 1);
            oueue.Dequeue();
            Assert.IsTrue(oueue.IsEmpty());
        }
    }
}
