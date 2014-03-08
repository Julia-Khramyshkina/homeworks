namespace NameSpaceForList
{
    /// <summary>
    /// List.
    /// </summary>
    public class List
    {
        public class ListElement
        {
            public int aValue { get; set; }
            public ListElement(int value)
            {
                aValue = value;
            }
            public ListElement Next { get; set; }
        }

        private ListElement head = null;

        /// <summary>
        /// Checking list. Empty?
        /// </summary>
        public bool IsEmpty()
        {
            return head == null;
        }

        /// <summary>
        /// Insert new element to head.
        /// </summary>
        /// <param name="Value to be insert to head."></param>
        public void InsertToHead(int value)
        {
            var newElement = new ListElement(value)
            {
                Next = head,
                aValue = value
            };

            head = newElement;
        }

        /// <summary>
        /// Insert new element to the end.
        /// </summary>
        /// <param name="Value to be insert to the end."></param>
        public void InsertToEnd(int value)
        {
            if (IsEmpty())
            {
                InsertToHead(value);
                return;
            }

            var tempElement = head;
            while (tempElement.Next != null)
            {
                tempElement = tempElement.Next;
            }

            var newElement = new ListElement(value);
            tempElement.Next = newElement;
        }

        /// <summary>
        /// Calculating a list size.
        /// </summary>
        public int SizeOfList()
        {
            var tempElement = head;
            int countOfElements = 0;
            while (tempElement != null)
            {
                tempElement = tempElement.Next;
                ++countOfElements;
            }
            return countOfElements;
        }

        /// <summary>
        /// Checking the existence.
        /// </summary>
        /// <param name="Element for check."></param>
        public bool ElementExist(int value)
        {
            var tempElement = head;
            while (tempElement != null)
            {
                if (tempElement.aValue == value)
                    return true;
                tempElement = tempElement.Next;
            }
            return false;
        }

        /// <summary>
        /// Delete element.
        /// </summary>
        /// <param name="Element for delete."></param>
        public void RemoveElement(int value)
        {
            if (!ElementExist(value))
            {
                System.Console.WriteLine("Sorry, this element doesn't exist");
                return;
            }
            var tempElement = head;
            var tempElementPrevious = head;
            while (tempElement.aValue != value)
            {
                tempElement = tempElement.Next;
                if (tempElement.Next.aValue != value)
                {
                    tempElementPrevious = tempElementPrevious.Next;
                }
            }
            tempElementPrevious.Next = tempElement.Next;
        }

        /// <summary>
        /// Print List. Suddenly.
        /// </summary>
        public void PrintList()
        {
            var tempELement = head;
            while (tempELement != null)
            {
                System.Console.WriteLine("{0} ", tempELement.aValue);
                tempELement = tempELement.Next;
            }
        }

        /// <summary>
        /// Get value from this position.
        /// </summary>
        /// <param name="Position from which we obtain the value."></param>
        /// <returns></returns>
        public int ValueOnPosition(int position)
        {
            var tempElement = head;
            int countPosition = 0;
            while (countPosition != position)
            {
                tempElement = tempElement.Next;
            }
            return tempElement.aValue;
        }

        /// <summary>
        /// Insert value to this position.
        /// </summary>
        /// <param name="Position."></param>
        /// <param name="Value to be insert."></param>
        public void InsertToThisPosition(int position, int value)
        {
            var tempElement = head;
            int countPosition = 0;
            var newElement = new ListElement(value);
            var tempElementPrevious = head;
            while (countPosition != position)
            {
                tempElement = tempElement.Next;
                if (countPosition + 1 != position)
                {
                    tempElementPrevious = tempElementPrevious.Next;
                }
            }
            tempElementPrevious.Next = newElement;
            newElement.Next = tempElement;
        }

        /// <summary>
        /// Delete value from this position.
        /// </summary>
        /// <param name="Position."></param>
        public void DeleteFromThisPosition(int position)
        {
            var tempElement = head;
            int countPosition = 0;
            var tempElementPrevious = head;
            while (countPosition != position)
            {
                tempElement = tempElement.Next;
                if (countPosition + 1 != position)
                {
                    tempElementPrevious = tempElementPrevious.Next;
                }
            }
            tempElementPrevious.Next = tempElement.Next;
        }
    }
}