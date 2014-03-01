using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSpaceForStack
{
    public class Stack
    {
        private class StackElement
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
            public StackElement Next { get; set; }
        }

        private StackElement head = null;

        public void Push(int value)
        {
            var newElement = new StackElement()
            {
                Next = head,
                Value = value
            };

            head = newElement;
        }

        public int Pop()
        {
            if (head == null)
            {
                return -1;
            }

            var temp = head.Value;
            head = head.Next;
            return temp;
        }

        public bool IsEmpty()
        {
            return head == null;
        }
    }
}