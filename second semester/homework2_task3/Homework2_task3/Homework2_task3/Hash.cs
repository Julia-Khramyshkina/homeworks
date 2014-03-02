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
        public class HashElement
        {
            public HashElement()
            {
                List hashElement = new List();

               // public
            }
     
       //    public HashElement Next { get; set; }
            
        }
        public HashTable()
        {
            HashElement [] hashTable = new HashElement[sizeOfHash];
            for (int i = 0; i < sizeOfHash; ++i)
            {
                hashTable[i] = new HashElement();
            }
        }


        public int hashFunction(int newElement)
        {
            int valueOfHashFunction = 0;
            for (int i = 0; i < newElement; ++i)
            {
                valueOfHashFunction = valueOfHashFunction + newElement * i;
            }
            valueOfHashFunction = (valueOfHashFunction * ((newElement * newElement) + (newElement / 3) - 1)) % sizeOfHash;
            return valueOfHashFunction;
        }
        
        public void insertToHashTable(int newElement)
        {
           
        }


    }
}
