using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_task3
{
    using NameSpaceForHashAndList;
    class Program
    {
        static void Main(string[] args)
        {
            HashTable hashTable = new HashTable();
            hashTable.InsertToHashTable(12);
            hashTable.InsertToHashTable(1);
            hashTable.InsertToHashTable(2);
            hashTable.InsertToHashTable(3);
        }
    }
}
