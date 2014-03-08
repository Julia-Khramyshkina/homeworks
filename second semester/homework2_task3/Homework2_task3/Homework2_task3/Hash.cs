using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSpaceForHash
{
    using NameSpaceForList;
    public class HashTable
    {
        public int sizeOfHash = 500;
        public List[] hashElement = new List[500];

        public int hashFunction(int newElement)
        {
            int valueOfHashFunction = 0;
            for (int i = 0; i < newElement; ++i)
            {
                valueOfHashFunction = (valueOfHashFunction + newElement * i) % 500;
            }
            return valueOfHashFunction;
        }
        
        public void insertToHashTable(int newElement)
        {
           // this.hashElement[hashFunction(newElement)].InsertToEnd(newElement);
         //   hashElement[hashFunction(newElement)].InsertToEnd(newElement);
        }

    }
}
