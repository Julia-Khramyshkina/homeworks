using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSpaceForStack
{
    using GeneralStack;
    /// <summary>
    /// Stack.
    /// </summary>
    /// 
    public class Stack : GeneralStack
    {
        public class StackElement
        {
            public int aValue { get; set; }
            public StackElement(int value)
            {
                aValue = value;
            }
            public StackElement Next { get; set; }
        }

        private StackElement head = null;

        /// <summary>
        /// Push value to a stack.
        /// </summary>
        /// <param name="Value to be pushed."></param>
        public override void Push(int value)
        {
            var newElement = new StackElement(value)
            {
                Next = head,
                aValue = value
            };

            head = newElement;
        }

        /// <summary>
        /// Get value from stack.
        /// </summary>
        public override int Pop()
        {
            if (head == null)
            {
                return -1;
            }

            var temp = head.aValue;
            head = head.Next;
            return temp;
        }

        /// <summary>
        /// Checking stack. Empty?
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return head == null;
        }
    }
}