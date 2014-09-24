using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace task2.Tests
{
    [TestClass]
    public class TestOfSimulation
    {
        /// <summary>
        /// Original random for generation unique values.
        /// </summary>
        private class NewRandom : Random
        {
            private Random original = new Random();
            private int count = 0;
            private int countValue;
            private bool isConstValue = false;

            public NewRandom(int constValue)
            {
                countValue = constValue;
                isConstValue = true;
            }
            /// <summary>
            /// Redefinition of method "Next".
            /// </summary>
            /// <param name="value1">first value</param>
            /// <param name="value2">second value</param>
            /// <returns>Next random value.</returns>
            public override int Next(int value1, int value2)
            {
                if (isConstValue)
                {
                    return countValue;
                }

                if (count == 0)
                {
                    countValue = original.Next(90, 100);
                    ++count;
                    return countValue;
                }
                else
                {
                    count = 0;
                    return countValue;
                }
            }
        }

        [TestMethod]
        public void TestNetwork1()
        {
            NewRandom originalRand = new NewRandom(100);
            Simulation network = new Simulation(originalRand);
            network.ChangeNetworkState();
            Assert.AreEqual(network.ShowState(4), "is infected.");
        }

        [TestMethod]
        public void TestNetwork2()
        {
            NewRandom originalRand = new NewRandom(100);
            Simulation network = new Simulation(originalRand);
            network.ChangeNetworkState();
            Assert.AreEqual(network.ShowState(3), "is healthy.");
        }

        [TestMethod]
        public void TestNetwork3()
        {
            NewRandom originalRand = new NewRandom(10);
            Simulation network = new Simulation(originalRand);
            network.ChangeNetworkState();
            Assert.AreEqual(network.ShowState(4), "is healthy.");
        }
    }
}
