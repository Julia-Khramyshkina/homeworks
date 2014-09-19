using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace task1.Tests
{
    using task1;
    [TestClass]
    public class BinaryTreeSearchTest
    {
        [TestMethod]
        public void TestBinaryInt()
        {
            BinaryTreeSeach<int> tree = new BinaryTreeSeach<int>();
            Assert.IsTrue(tree.IsEmpty());
        }

        [TestMethod]
        public void TestBinaryIntIsInsert()
        {
            BinaryTreeSeach<int> tree = new BinaryTreeSeach<int>();
            CompareInterface<int> comparator = new CompareInt();
            tree.InsertElement(1, comparator);
            Assert.IsFalse(tree.IsEmpty());
        }

        [TestMethod]
        public void TestBinaryIntExist()
        {
            BinaryTreeSeach<int> tree = new BinaryTreeSeach<int>();
            CompareInterface<int> comparator = new CompareInt();
            tree.InsertElement(1, comparator);
            Assert.IsTrue(tree.ElementExist(1, comparator));
        }

        [TestMethod]
        public void TestBinaryIntRemomve()
        {
            BinaryTreeSeach<int> tree = new BinaryTreeSeach<int>();
            CompareInterface<int> comparator = new CompareInt();
            tree.InsertElement(1, comparator);
            tree.RemoveElement(1, comparator);
            Assert.IsFalse(tree.ElementExist(1, comparator));
        }

        [TestMethod]
        public void EnumeratorTestInt()
        {
            BinaryTreeSeach<int> tree = new BinaryTreeSeach<int>();
            CompareInterface<int> comparator = new CompareInt();
            tree.InsertElement(1, comparator);
            tree.InsertElement(2, comparator);
            int count = 0;
            foreach (int i in tree)
                ++count;
            Assert.AreEqual(2, count);
        }

        [TestMethod]
        public void EnumeratorTestInt2()
        {
            BinaryTreeSeach<int> tree = new BinaryTreeSeach<int>();
            CompareInterface<int> comparator = new CompareInt();
            int count = 0;
            foreach (int i in tree)
            {
                ++count;
            }
            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void TestBinarString()
        {
            BinaryTreeSeach<string> tree = new BinaryTreeSeach<string>();
            Assert.IsTrue(tree.IsEmpty());
        }

        [TestMethod]
        public void TestBinaryIntIsInsertString()
        {
            BinaryTreeSeach<string> tree = new BinaryTreeSeach<string>();
            CompareInterface<string> comparator = new CompareString();
            tree.InsertElement("1", comparator);
            Assert.IsFalse(tree.IsEmpty());
        }

        [TestMethod]
        public void TestBinaryIntExistString()
        {
            BinaryTreeSeach<string> tree = new BinaryTreeSeach<string>();
            CompareInterface<string> comparator = new CompareString();
            tree.InsertElement("1", comparator);
            Assert.IsTrue(tree.ElementExist("1", comparator));
        }

        [TestMethod]
        public void TestBinaryStringRemove()
        {
            BinaryTreeSeach<string> tree = new BinaryTreeSeach<string>();
            CompareInterface<string> comparator = new CompareString();
            tree.InsertElement("1", comparator);
            tree.RemoveElement("1", comparator);
            Assert.IsFalse(tree.ElementExist("1", comparator));
        }

        [TestMethod]
        public void EnumeratorTestString()
        {
            BinaryTreeSeach<string> tree = new BinaryTreeSeach<string>();
            CompareInterface<string> comparator = new CompareString();
            tree.InsertElement("1", comparator);
            tree.InsertElement("2", comparator);
            int count = 0;
            foreach (string i in tree)
                ++count;
            Assert.AreEqual(2, count);
        }

        [TestMethod]
        public void EnumeratorTestString2()
        {
            BinaryTreeSeach<string> tree = new BinaryTreeSeach<string>();
            CompareInterface<string> comparator = new CompareString();
            int count = 0;
            foreach (string i in tree)
            {
                ++count;
            }
            Assert.AreEqual(0, count);
        }
    }
}
