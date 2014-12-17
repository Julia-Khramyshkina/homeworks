using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace task3.Tests
{
    using task3;
    [TestClass]
    public class TeleportationTests
    {
        private bool GetAnswer(StreamReader input)
        {
            StorageInputData test = new StorageInputData(input);
            Teleportation testTeleportation = new Teleportation(test);
            testTeleportation.Process();
            return testTeleportation.GetAnswer();
        }

        [TestMethod]
        public void TeleportationTest()
        {
            StreamReader input = new StreamReader("input.txt");
            bool answer = GetAnswer(input);
            Assert.IsTrue(answer);
        }

        [TestMethod]
        public void TeleportationTest1()
        {
            StreamReader input = new StreamReader("input1.txt");
            bool answer = GetAnswer(input);
            Assert.IsFalse(answer);
        }

        [TestMethod]
        public void TeleportationTest2()
        {
            StreamReader input = new StreamReader("input2.txt");
            bool answer = GetAnswer(input);
            Assert.IsTrue(answer);
        }

        [TestMethod]
        public void TeleportationTest3()
        {
            StreamReader input = new StreamReader("input3.txt");
            bool answer = GetAnswer(input);
            Assert.IsFalse(answer);
        }

        [TestMethod]
        public void TeleportationTest4()
        {
            StreamReader input = new StreamReader("input4.txt");
            bool answer = GetAnswer(input);
            Assert.IsFalse(answer);
        }

        [TestMethod]
        public void TeleportationTest5()
        {
            StreamReader input = new StreamReader("input5.txt");
            bool answer = GetAnswer(input);
            Assert.IsTrue(answer);
        }

        [TestMethod]
        public void TeleportationTest6()
        {
            StreamReader input = new StreamReader("input6.txt");
            bool answer = GetAnswer(input);
            Assert.IsFalse(answer);
        }
    }
}
