namespace Homework2_task3
{
    /// <summary>
    /// Hashtable.
    /// </summary>
    public class HashTable
    {
        private List[] hashElement = new List[500];
        private HashFunctionInterface hashFunction;
        public HashTable(HashFunctionInterface hashFunction)
        {
            for (int i = 0; i < 500; ++i)
            {
                hashElement[i] = new List();
            }
            this.hashFunction = hashFunction;
        }
     
        /// <summary>
        /// Insert to Hashtable.
        /// </summary>
        /// <param name="newElement">Element, which will insert. </param>
        public void InsertToHashTable(int newElement)
        {
            hashElement[hashFunction.HashFunction(newElement)].InsertToEnd(newElement);
        }

        /// <summary>
        /// Cheking exist element.
        /// </summary>
        /// <param name="value"> Element, which will check</param>
        /// <returns></returns>
        public bool ElementExist(int value)
        {
            return hashElement[hashFunction.HashFunction(value)].ElementExist(value);
        }

        /// <summary>
        /// Delete this element.
        /// </summary>
        /// <param name="value">Element, which will delete.</param>
        public void DeleteElement(int value)
        {
            hashElement[hashFunction.HashFunction(value)].RemoveElement(value);
        }
    }
}
