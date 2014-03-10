namespace GeneralStack
{
    /// <summary>
    /// Stack.
    /// </summary>
    /// 
    public class Stack : GeneralStack
    {
        private class StackElement
        {
            public int Value { get; set; }
            /// <summary>
            /// Constructor for stack.
            /// </summary>
            /// <param name="value">Value to be create in stack.</param>
            public StackElement(int value)
            {
                Value = value;
            }
            public StackElement Next { get; set; }
        }
        private StackElement head = null;

        /// <summary>
        /// Push value to a stack.
        /// </summary>
        /// <param name="Value to be pushed."></param>
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
            if (head == null)
            {
                return -1;
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