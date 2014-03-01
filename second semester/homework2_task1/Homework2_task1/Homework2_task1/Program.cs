using System;

namespace Homework2_task1
{
    using NameSpaceForStack;
    class Program
    {
        static void Main()
        {
            Stack myStack = new Stack();
            for (int i = 0; i < 10; ++i)
            {
                myStack.Push(i);
            }

            while (!myStack.IsEmpty())
            {
                Console.WriteLine(myStack.Pop());
            }
            return;
        }
    }
}
