using System;

namespace Homework4_task1
{
    /// <summary>
    /// Abstract class for nodes in the parse tree.
    /// </summary>
    public abstract class Node
    {
        /// <summary>
        /// Caculate this node.
        /// </summary>
        /// <returns></returns>
        public abstract Double Calculate();

        /// <summary>
        /// Print this node.
        /// </summary>
        public abstract void Print();
    }
}
