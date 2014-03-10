using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSpaceCalculator
{
    using GeneralStack;
    class Calculator
    {
        /// <summary>
        /// Constructor for calculator.
        /// </summary>
        /// <param name="stack"> Stack, which we will use.</param>
        public Calculator(GeneralStack stack)
        {
            this.stack = stack;
        }

        private GeneralStack stack;

        /// <summary>
        /// Get value.
        /// </summary>
        /// <returns></returns>
        public int PopValue()
        {
            return stack.Pop();
        }

        /// <summary>
        /// Add result.
        /// </summary>
        /// <param name="value">Value to be pushed.</param>
        public void PushResult(int value)
        {
            stack.Push(value);
        }

        /// <summary>
        /// Addition.
        /// </summary>
        public void Addition()
        {
            PushResult(stack.Pop() + stack.Pop());
        }

        /// <summary>
        /// Subtraction.
        /// </summary>
        public void Subtraction()
        {
            PushResult(stack.Pop() - stack.Pop());
        }

        /// <summary>
        /// Multiplication.
        /// </summary>
        public void Multiplication()
        {
            PushResult(stack.Pop() * stack.Pop());
        }

        /// <summary>
        /// Division.
        /// </summary>
        public void Division()
        {
            PushResult(stack.Pop() / stack.Pop());
        }
    }
}
