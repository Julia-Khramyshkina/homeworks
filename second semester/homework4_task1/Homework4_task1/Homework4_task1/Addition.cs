using System;

namespace Homework4_task1
{
    /// <summary>
    /// Addition in the parse tree.
    /// </summary>
    public class Addition : Operation
    {
        public Addition(String value, Node left, Node right)
        {
            ValueOperation = value;
            Left = left;
            Right = right;
        }

        /// <summary>
        /// Calculate this part of tree.
        /// </summary>
        /// <returns></returns>
        public override Double Calculate()
        {
            return this.Left.Calculate() + this.Right.Calculate();
        }

        /// <summary>
        /// Print this part of tree.
        /// </summary>
        /// <returns></returns>
        public override void Print()
        {
            System.Console.Write("(");
            this.Left.Print();
            System.Console.Write(" + ");
            this.Right.Print();
            System.Console.Write(")");
        }
    }
}