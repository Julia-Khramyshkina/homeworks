using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_task4
{
    using GeneralStack;
    using NameSpaceForStack;
    using NameSpaceCalculator;
    using NameSpaceForStackWithArray;
    class Program
    {
        static void Main(string[] args)
        {
            GeneralStack stack = new StackArray();
            Calculator qwety = new Calculator(stack);
            //qwety.PushResult(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            int x = stack.Pop();
            int y = stack.Pop();

        }
    }
}
