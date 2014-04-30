using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_task1
{
    /// <summary>
    /// Stack.
    /// </summary>
    public class Stack <ElementType>
    {
        private class StackElement
        {
            public ElementType Value { get; set; }
            /// <summary>
            /// Constructor for Element of stack.
            /// </summary>
            /// <param name="value">Value to be create in stack.</param>
            public StackElement(ElementType value)
            {
                Value = value;
            }
            /// <summary>
            /// Next element in stack.
            /// </summary>
            public StackElement Next { get; set; }
        }

        private StackElement head = null;

        /// <summary>
        /// Push value to a stack.
        /// </summary>
        /// <param name="value">Value to be pushed.</param>
        public void Push(ElementType value)
        {
            var newElement = new StackElement(value)
            {
                Next = head,
                Value = value
            };
            head = newElement;
        }

        /// <summary>
        /// Get value from stack.
        /// </summary>
        public ElementType Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack is empty.");
            }

            var temp = head.Value;
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
