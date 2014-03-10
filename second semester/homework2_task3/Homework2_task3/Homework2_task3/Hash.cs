namespace NameSpaceForHashAndList
{
    /// <summary>
    /// Hashtable.
    /// </summary>
    public class HashTable
    {
        private int sizeOfHash = 500;
        private List[] hashElement = new List[500];
        public HashTable()
        {
            for (int i = 0; i < 500; ++i)
            {
                hashElement[i] = new List();
            }
        }

        /// <summary>
        /// Hashfunction.
        /// </summary>
        /// <param name="newElement"> Hashfunction for new element. </param>
        /// <returns></returns>
        private int HashFunction(int newElement)
        {
            int valueOfHashFunction = 0;
            for (int i = 0; i < newElement; ++i)
            {
                valueOfHashFunction = (valueOfHashFunction + newElement * i) % 500;
            }
            return valueOfHashFunction;
        }
        
        /// <summary>
        /// Insert to Hashtable.
        /// </summary>
        /// <param name="newElement">Element, which will insert. </param>
        public void InsertToHashTable(int newElement)
        {
           hashElement[HashFunction(newElement)].InsertToEnd(newElement);
        }

        /// <summary>
        /// Cheking exist element.
        /// </summary>
        /// <param name="value"> Element, which will check</param>
        /// <returns></returns>
        public bool ElementExist(int value)
        {
            return hashElement[HashFunction(value)].ElementExist(value);
        }

        /// <summary>
        /// Delete this element.
        /// </summary>
        /// <param name="value">Element, which will delete.</param>
        public void DeleteElement(int value)
        {
            hashElement[HashFunction(value)].RemoveElement(value);
        }
    }
}
