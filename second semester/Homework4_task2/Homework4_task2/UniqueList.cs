using System;

namespace Homework4_task2
{
    public class UniqueList : List
    {
        /// <summary>
        /// Insert to the head with exception.
        /// </summary>
        /// <param name="value"> Value to be insert to head.</param>
        public override void InsertToHead(int value)
        {
            if (ElementExist(value))
            {
                throw new MyException("Element exist");
            }
            this.NeedForHead(value);
        }

        /// <summary>
        /// Insert new element to the end with exception.
        /// </summary>
        /// <param name="value"> Value to be insert to the end.</param>
        public override void InsertToEnd(int value)
        {
            if (ElementExist(value))
            {
                throw new MyException("Element exist");
            }

            if (IsEmpty())
            {
                InsertToHead(value);
                return;
            }

            var tempElement = this.first();
            while (tempElement.Next != null)
            {
                tempElement = tempElement.Next;
            }

            var newElement = new ListElement(value);
            tempElement.Next = newElement;
        }

        /// <summary>
        /// Insert value to this position with exception.
        /// </summary>
        /// <param name="position"> Position.</param>
        /// <param name="value"> Value to be insert.</param>
        public override void InsertToThisPosition(int position, int value)
        {
            if (ElementExist(value))
            {
                throw new MyException("Element exist");
            }

            if (position < 0 || position > SizeOfList() + 1)
            {
                System.Console.WriteLine("This position does not exist");
                return;
            }
            var tempElement = this.first();
            int countPosition = 0;
            var newElement = new ListElement(value);
            var tempElementPrevious = this.first();
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

        public override void RemoveElement(int value)
        {
            if (!ElementExist(value))
            {
                throw new MyException("Element doesn't exist");
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

    }
}


