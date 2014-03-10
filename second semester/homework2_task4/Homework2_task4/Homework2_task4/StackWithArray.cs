namespace GeneralStack
{
    /// <summary>
    /// Stack.
    /// </summary>
    public class StackArray : GeneralStack
    {
        private int [] aValue = new int [100];
        private int head = -1;

        /// <summary>
        /// Push value to a stack.
        /// </summary>
        /// <param name="value"> Value to be pushed.</param>
        public void Push(int value)
        {
            ++this.head;
            this.aValue[head] = value;
        }

        /// <summary>
        /// Get value from stack.
        /// </summary>
        public int Pop()
        {
            int temp = this.aValue[head];
            this.aValue[head] = 0;
            --this.head;
            return temp;
        }
    }
}