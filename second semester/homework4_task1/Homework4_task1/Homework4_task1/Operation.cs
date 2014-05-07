using System;

namespace Homework4_task1
{
    /// <summary>
    /// Abstract class for operations in the parse tree.
    /// </summary>
    public abstract class Operation : Node
    {
        public Operation(String value, Node left, Node right)
        {
            ValueOperation = value;
            Left = left;
            Right = right;
        }

        public Operation()
        {
        }

        public String ValueOperation { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }
}
