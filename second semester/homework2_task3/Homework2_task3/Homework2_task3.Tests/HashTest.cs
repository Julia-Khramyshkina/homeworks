using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework2_task3.Tests
{
    using Homework2_task3;
    [TestClass]
    public class HashTest
    {
        private HashTable hashTable;
        private HashFunctionInterface hashFunction;
        [TestInitialize]
        public void Initialize()
        {
            hashFunction = new HashNumberTwo();
            hashTable = new HashTable(hashFunction);
        }

        [TestMethod]
        public void ElementExistTest()
        {
            hashTable.InsertToHashTable(1);
            Assert.IsTrue(hashTable.ElementExist(1));
        }

        [TestMethod]
        public void DeleteElementTest()
        {
            hashTable.InsertToHashTable(1);
            hashTable.DeleteElement(1);
            Assert.IsFalse(hashTable.ElementExist(1));
        }
    }
}
