namespace NameSpaceForStack
{
    /// <summary>
    /// Stack.
    /// </summary>
    public class Stack
    {
        private class StackElement
        {
            public int Value { get; set; }
            /// <summary>
            /// Constructor for Element of stack.
            /// </summary>
            /// <param name="value">Value to be create in stack.</param>
            public StackElement(int value)
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
        public void Push(int value)
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
        public int Pop()
        {
            if (IsEmpty())
            {
                return -33333;
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