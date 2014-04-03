namespace Homework2_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            HashFunctionInterface hashFunction = new HashNumberOne();
            HashFunctionInterface hashFunctionChange = new HashNumberTwo();
            HashTable hashTable = new HashTable(hashFunction);
            hashTable.InsertToHashTable(12);
            hashTable.InsertToHashTable(1);
            hashTable.InsertToHashTable(2);
            hashTable.InsertToHashTable(3);
            hashTable.ChangeHashFunction(hashFunctionChange);
        }
    }
}
