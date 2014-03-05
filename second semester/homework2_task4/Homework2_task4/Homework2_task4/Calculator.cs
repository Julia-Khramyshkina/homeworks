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
        public Calculator(GeneralStack stack)
        {
            this.stack = stack;
        }

        private GeneralStack stack;
        
        public int PopValue()
        {
            return stack.Pop();
        }

        public void PushResult(int value)
        {
            stack.Push(value);
        }

        public void Addition()
        {
            PushResult(stack.Pop() + stack.Pop());
        }

        public void Subtraction()
        {
            PushResult(stack.Pop() - stack.Pop());
        }

        public void Multiplication()
        {
            PushResult(stack.Pop() * stack.Pop());
        }

        public void Division()
        {
            PushResult(stack.Pop() / stack.Pop());
        }

    }
}
