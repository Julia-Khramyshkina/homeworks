using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace task3.Tests
{
    using task3;
    [TestClass]
    public class TeleportationTests
    {
        [TestMethod]
        public void TeleportationTest()
        {
            StreamReader input = new StreamReader("input.txt");
            StorageInputData test = new StorageInputData(input);
            Teleportation testTeleportation = new Teleportation(test);
            testTeleportation.Processing();
            bool answer = testTeleportation.GetAnswer();
            Assert.IsTrue(answer);
        }

        [TestMethod]
        public void TeleportationTest1()
        {
            StreamReader input = new StreamReader("input1.txt");
            StorageInputData test = new StorageInputData(input);
            Teleportation testTeleportation = new Teleportation(test);
            testTeleportation.Processing();
            bool answer = testTeleportation.GetAnswer();
            Assert.IsFalse(answer);
        }

        [TestMethod]
        public void TeleportationTest2()
        {
            StreamReader input = new StreamReader("input2.txt");
            StorageInputData test = new StorageInputData(input);
            Teleportation testTeleportation = new Teleportation(test);
            testTeleportation.Processing();
            bool answer = testTeleportation.GetAnswer();
            Assert.IsTrue(answer);
        }

        [TestMethod]
        public void TeleportationTest3()
        {
            StreamReader input = new StreamReader("input3.txt");
            StorageInputData test = new StorageInputData(input);
            Teleportation testTeleportation = new Teleportation(test);
            testTeleportation.Processing();
            bool answer = testTeleportation.GetAnswer();
            Assert.IsFalse(answer);
        }

        [TestMethod]
        public void TeleportationTest4()
        {
            StreamReader input = new StreamReader("input4.txt");
            StorageInputData test = new StorageInputData(input);
            Teleportation testTeleportation = new Teleportation(test);
            testTeleportation.Processing();
            bool answer = testTeleportation.GetAnswer();
            Assert.IsFalse(answer);
        }

        [TestMethod]
        public void TeleportationTest5()
        {
            StreamReader input = new StreamReader("input5.txt");
            StorageInputData test = new StorageInputData(input);
            Teleportation testTeleportation = new Teleportation(test);
            testTeleportation.Processing();
            bool answer = testTeleportation.GetAnswer();
            Assert.IsTrue(answer);
        }
    }
}
