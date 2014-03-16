namespace GeneralStack
{
    public interface GenStack
    {   
        /// <summary>
        /// Get element to stack.
        /// </summary>
        /// <returns></returns>
        int Pop();

        /// <summary>
        /// Add ellemnt to stack.
        /// </summary>
        /// <param name="value">Value to be pushed.</param>
        void Push(int value);
    }
}
