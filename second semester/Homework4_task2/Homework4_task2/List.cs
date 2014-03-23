﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        /// <param name="value"> Value to be insert to head.</param>
        public virtual void InsertToHead(int value)
        {
            this.NeedForHead(value);
        }

        /// <summary>
        /// Insert new element to the end.
        /// </summary>
        /// <param name="value"> Value to be insert to the end.</param>
        public virtual void InsertToEnd(int value)
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
        /// Delete element.
        /// </summary>
        /// <param name="value">Element for delete.</param>
        public void RemoveElement(int value)
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
        /// Insert value to this position.
        /// </summary>
        /// <param name="position"> Position.</param>
        /// <param name="value"> Value to be insert.</param>
        public virtual void InsertToThisPosition(int position, int value)
        {
            if (position < 0 || position > SizeOfList() + 1)
            {
                System.Console.WriteLine("This position does not exist");
                return;
            }
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


    public class UniqueList : List
    {
       

        public override void InsertToHead(int value)
        {
            if (ElementExist(value))
            {
                throw new Exception("Element exist");
            }
            this.NeedForHead(value);
        }

        public override void InsertToEnd(int value)
        {
            if (ElementExist(value))
            {
                throw new Exception("Element exist");
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

        public override void InsertToThisPosition(int position, int value)
        {
            if (ElementExist(value))
            {
                throw new Exception("Element exist");
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
    }
}

