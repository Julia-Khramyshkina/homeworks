using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeIsPain
{
    public class PriorityQueue
    {
        private class QueueElement
        {
            public int Value { get; set; }
            public int Priority { get; set; }
            public QueueElement(int value, int priority)
            {
                Value = value;
                Priority = priority;
            }
            public QueueElement Next { get; set; }
        }
        private QueueElement head = null;

        /// <summary>
        /// Checking queue. Empty?
        /// </summary>
        public bool IsEmpty()
        {
            return head == null;
        }

        /// <summary>
        /// Inser to queue.
        /// </summary>
        /// <param name="value">Value to be insert.</param>
        /// <param name="priority">This priority.</param>
        public void Enqueue(int value, int priority)
        {
            if (this.IsEmpty())
            {
                this.head = new QueueElement(value, priority);
                return;
            }

            QueueElement tempElement = this.head;

            if (tempElement.Next == null)
            {
                if (priority > this.head.Priority)
                {
                    var element = this.head;
                    var thisElement = new QueueElement(value, priority);
                    this.head = thisElement;
                    this.head.Next = element;
                    return;
                }
                else
                {
                    this.head.Next = new QueueElement(value, priority);
                    return;
                }
            }
            QueueElement tempElementPrevious = this.head;

            while (tempElement.Priority >= priority)
            {
                if (tempElement.Next == null)
                {
                    break;
                }        

                if (tempElement.Next.Priority >= priority)
                    tempElementPrevious = tempElementPrevious.Next;

                tempElement = tempElement.Next;
            }

            QueueElement newElement = new QueueElement(value, priority);
      
            tempElementPrevious.Next = newElement;
            newElement = tempElement.Next;
        }

        /// <summary>
        /// Get value from queue.
        /// </summary>
        /// <returns></returns>
        public int Dequeue()
        {
            if (this.IsEmpty())
            {
                throw new Exception("Queue is empty");
            }

            int value = this.head.Value;
            this.head = this.head.Next;
            return value;
        }
    }
}
