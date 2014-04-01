using System;

namespace Homework4_task2
{
    /// <summary>
    /// List.
    /// </summary>
    public class List
    {
        public class ListElement
        {
            public int Value { get; set; }
            public ListElement(int value)
            {
                Value = value;
            }
            public ListElement Next { get; set; }
        }
        protected ListElement head = null;

        /// <summary>
        /// Checking list. Empty?
        /// </summary>
        public bool IsEmpty()
        {
            return head == null;
        }

        /// <summary>
        /// Insert to head for descendants.
        /// </summary>
        /// <param name="value">Value to be insert to head.</param>
        protected void NeedForHead(int value)
        {
            var newElement = new ListElement(value)
            {
                Next = head,
                Value = value
            };
            head = newElement;
        }

        /// <summary>
        /// Insert to the head.
        /// </summary>
        /// <param name="value">Value to be insert to head.</param>
        public virtual void InsertToHead(int value)
        {
            this.NeedForHead(value);
        }

        /// <summary>
        /// Insert to end for descendants.
        /// </summary>
        /// <param name="value">Value to be insert to end.</param>
        protected void NeedForEnd(int value)
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
        /// Insert new element to the end.
        /// </summary>
        /// <param name="value"> Value to be insert to the end.</param>
        public virtual void InsertToEnd(int value)
        {
            this.NeedForEnd(value);
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
        /// First element.
        /// </summary>
        /// <returns></returns>
        public ListElement first()
        {
            return this.head;
        }

        /// <summary>
        /// Checking the existence.
        /// </summary>
        /// <param name="value">Element for check.</param>
        public bool ElementExist(int value)
        {
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
        /// Remove for descendants.
        /// </summary>
        /// <param name="value">Value to be removed.</param>
        protected void NeedForRemoveElement(int value)
        {
            if (!ElementExist(value))
            {
                System.Console.WriteLine("Sorry, this element doesn't exist");
                return;
            }
            var tempElement = head;
            var tempElementPrevious = head;
            if (tempElement.Value == value)
            {
                head = head.Next;
                return;
            }
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
        /// Delete element.
        /// </summary>
        /// <param name="value">Element for delete.</param>
        public virtual void RemoveElement(int value)
        {
            this.NeedForRemoveElement(value);
        }

        /// <summary>
        /// Print List. Suddenly.
        /// </summary>
        public void PrintList()
        {
            var tempELement = head;
            while (tempELement != null)
            {
                System.Console.WriteLine("{0} ", tempELement.Value);
                tempELement = tempELement.Next;
            }
        }

        /// <summary>
        /// Get value from this position.
        /// </summary>
        /// <param name="value">Position from which we obtain the value.</param>
        /// <returns></returns>
        public int ValueOnPosition(int position)
        {
            if (position < 0 || position > SizeOfList() + 1)
                return -33333;
            var tempElement = head;
            int countPosition = 0;
            while (countPosition != position)
            {
                tempElement = tempElement.Next;
            }
            return tempElement.Value;
        }

        /// <summary>
        /// Insert to this position for descendants.
        /// </summary>
        /// <param name="position">This position</param>
        /// <param name="value">Value to be insert to this position.</param>
        protected void NeedForThisPosition(int position, int value)
        {
            if (position < 0 || position > SizeOfList() + 1)
            {
                System.Console.WriteLine("This position does not exist");
                return;
            }
            int countPosition = 0;
            if (countPosition == position)
            {
                this.InsertToHead(value);
                return;
            }
            var tempElement = head;
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
        /// Insert value to this position.
        /// </summary>
        /// <param name="position"> Position.</param>
        /// <param name="value"> Value to be insert.</param>
        public virtual void InsertToThisPosition(int position, int value)
        {
            this.NeedForThisPosition(position, value);
        }

        /// <summary>
        /// Delete value from this position.
        /// </summary>
        /// <param name="position"> Position for delete.</param>
        public void DeleteFromThisPosition(int position)
        {
            if (position < 0 || position > SizeOfList() + 1)
            {
                System.Console.WriteLine("This position does not exist");
                return;
            }
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
