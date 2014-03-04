using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSpaceForList
{
    /// <summary>
    /// List.
    /// </summary>
    public class List
    {
        private class ListElement
        {
            private int aValue;

            public int Value
            {
                get
                {
                    return aValue;
                }

                set
                {
                    this.aValue = value;
                }
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
            var newElement = new ListElement()
            {
                Next = head,
                Value = value
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

            var newElement = new ListElement();
            newElement.Value = value;
            newElement.Next = null;
            tempElement.Next = newElement;
        }

        /// <summary>
        /// Calculating a list size.
        /// </summary>
        public int SizeOfList()
        {
            if (IsEmpty())
            {
                return 0;
            }
            else
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
        }

        /// <summary>
        /// Checking the existence.
        /// </summary>
        /// <param name="Element for check."></param>
        public bool ElementExist(int value)
        {
            if (IsEmpty())
                return false;
            var tempElement = head;
            while (tempElement != null)
            {
                if (tempElement.Value == value)
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
                Console.WriteLine("Sorry, this element doesn't exist\n");
                return;
            }
            var tempElement = head;
            var tempElementPrevious = head;
            while (tempElement.Value != value)
            {
                tempElement = tempElement.Next;
                if (tempElement.Next.Value != value)
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
                Console.WriteLine("{0} ", tempELement.Value);
                tempELement = tempELement.Next;
            }
        }
    }
}
