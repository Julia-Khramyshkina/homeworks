using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_task3
{
    using NameSpaceForHash;
    class Program
    {
        static void Main(string[] args)
        {
            HashTable hashTable = new HashTable();
            hashTable.insertToHashTable(12345);
            hashTable.insertToHashTable(1);
            hashTable.insertToHashTable(2);
            hashTable.insertToHashTable(3);
            return;


        }
    }
}
