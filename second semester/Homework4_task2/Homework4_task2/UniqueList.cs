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
            this.NeedForEnd(value);
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
            this.NeedForThisPosition(position, value);
        }

        public override void RemoveElement(int value)
        {
            if (!ElementExist(value))
            {
                throw new MyException("Element doesn't exist");
            }
            this.NeedForRemoveElement(value);         
        }
    }
}


