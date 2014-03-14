using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework2_task3.Tests
{
    using NameSpaceForHashAndList;
    [TestClass]
    public class HashTest
    {
        private HashTable hashTable;

        [TestInitialize]
        public void Initialize()
        {
            hashTable = new HashTable();
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
