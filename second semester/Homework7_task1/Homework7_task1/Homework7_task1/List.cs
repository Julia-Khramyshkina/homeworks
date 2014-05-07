using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_task1
{
    /// <summary>
    /// List.
    /// </summary>
    public class List<ElementType> : IEnumerable<ElementType>
    {
        private class ListElement
        {
            public ElementType Value { get; set; }
            public ListElement(ElementType value)
            {
                Value = value;
            }
            public ListElement Next { get; set; }
        }
        private ListElement head = null;



   

       



        IEnumerator<ElementType> IEnumerable<ElementType>.GetEnumerator()
        {
            return new MyEnumerator<ElementType>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)(new MyEnumerator<ElementType>(this));
        }



        /// <summary>
        /// Checking list. Empty?
        /// </summary>
        public bool IsEmpty()
        {
            return head == null;
        }

        /// <summary>
        /// Insert to the head.
        /// </summary>
        /// <param name="value"> Value to be insert to head.</param>
        public void InsertToHead(ElementType value)
        {
            var newElement = new ListElement(value)
            {
                Next = head,
                Value = value
            };
            head = newElement;
        }

        /// <summary>
        /// Insert new element to the end.
        /// </summary>
        /// <param name="value"> Value to be insert to the end.</param>
        public void InsertToEnd(ElementType value)
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
        /// <param name="value">Element for check.</param>
        public bool ElementExist(ElementType value)
        {
            var tempElement = head;
            while (tempElement != null)
            {
                if (tempElement.Value.Equals(value))
                    return true;
                tempElement = tempElement.Next;
            }
            return false;
        }

        /// <summary>
        /// Delete element.
        /// </summary>
        /// <param name="value">Element for delete.</param>
        public void RemoveElement(ElementType value)
        {
            if (!ElementExist(value))
            {
                System.Console.WriteLine("Sorry, this element doesn't exist");
                return;
            }
            var tempElement = head;
            var tempElementPrevious = head;
            if (tempElement.Value.Equals(value))
            {
                head = head.Next;
                return;
            }
            while (!tempElement.Value.Equals(value))
            {
                tempElement = tempElement.Next;
                if (!tempElement.Next.Value.Equals(value))
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
        public ElementType ValueOnPosition(int position)
        {
            if (position < 0 || position > SizeOfList() + 1)
                throw new Exception("This position incorrect.");
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
        public void InsertToThisPosition(int position, ElementType value)
        {
            if (position < 0 || position > SizeOfList() + 1)
            {
                throw new Exception("This position incorrect.");
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
                throw new Exception("This position incorrect.");
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



        public class MyEnumerator<ElementType> : IEnumerator<ElementType>
        {
            private int valueForNumerator = -1;
            private List<ElementType> list;
           
            public MyEnumerator(List<ElementType> list1)
            {
                this.list = list1;
            }


            public object Current
            {
                get
                {
                    return list.ValueOnPosition(valueForNumerator);
                    
                }
            }

            //object MyEnumerator<ElementType>.Current
            //{
            //    get { return Current; }
            //}

           
            public bool MoveNext()
            {
                if (list.head == null)
                    return false;


                if (list.head.Next == null)
                {
                    Reset();
                    return false;
                }
                ++valueForNumerator;
                return true;
            }


            public void Reset()
            {
                valueForNumerator = -1;
            }


            ElementType IEnumerator<ElementType>.Current
            {
                get 
                {
                    return list.ValueOnPosition(valueForNumerator);
                }
            }

            public void Dispose()
            {
                
            }
        }


  
      
    }
}
