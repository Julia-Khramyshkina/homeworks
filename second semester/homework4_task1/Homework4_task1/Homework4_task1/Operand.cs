using System;

namespace Homework4_task1
{
    /// <summary>
    /// Class of operands in the parse tree.
    /// </summary>
    public class Operand : Node
    {
        public Operand(Double value)
        {
            Value = value;
        }

        public Double Value { get; set; }

        /// <summary>
        /// Caclulate this part of tree.
        /// </summary>
        /// <returns></returns>
        public override Double Calculate()
        {
            return this.Value;
        }

        /// <summary>
        /// Print this part of tree.
        /// </summary>
        /// <returns></returns>
        public override void Print()
        {
            System.Console.Write("{0}", this.Value);
        }
    }
}
