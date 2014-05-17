using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework7_task2;
namespace Homework_task2.Tests
{
    [TestClass]
    public class MultiplicityTest
    {
        [TestMethod]
        public void AddElement1Test()
        {
            Multiplicity<int> many = new Multiplicity<int>();
            many.AddElement(1);
            Assert.IsTrue(many.ElementExist(1));
        }

        [TestMethod]
        public void AddElement2Test()
        {
            Multiplicity<string> many = new Multiplicity<string>();
            many.AddElement("1");
            Assert.IsTrue(many.ElementExist("1"));
        }

        [TestMethod]
        public void DeleteElementTest()
        {
            Multiplicity<int> many = new Multiplicity<int>();
            many.AddElement(1);
            many.DeleteELement(1);
            Assert.IsTrue(many.IsEmpty());
        }

        [TestMethod]
        public void EmptyTest()
        {
            Multiplicity<int> many = new Multiplicity<int>();
            Assert.IsTrue(many.IsEmpty());
        }

        [TestMethod]
        public void IntersectionTest()
        {
            Multiplicity<int> many = new Multiplicity<int>();
            many.AddElement(1);
            Multiplicity<int> many2 = new Multiplicity<int>();
            Multiplicity<int> result = many.Intersection(many2);
            Assert.IsTrue(result.IsEmpty());
        }

        [TestMethod]
        public void Intersection2Test()
        {
            Multiplicity<int> many = new Multiplicity<int>();
            many.AddElement(1);
            Multiplicity<int> many2 = new Multiplicity<int>();
            many2.AddElement(1);
            Multiplicity<int> result = many.Intersection(many2);
            Assert.IsFalse(result.IsEmpty());
        }

        [TestMethod]
        public void UnificationTest()
        {
            Multiplicity<int> many = new Multiplicity<int>();
            many.AddElement(1);
            Multiplicity<int> many2 = new Multiplicity<int>();
            many2.Unification(many);
            Assert.IsFalse(many2.IsEmpty());
        }
    }
}
