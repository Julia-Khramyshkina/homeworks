﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_task4
{
    using GeneralStack;
    using NameSpaceForStack;
    using NameSpaceCalculator;
    class Program
    {
        static void Main(string[] args)
        {
            GeneralStack stack = new Stack();
            Calculator qwety = new Calculator(stack);
            qwety.PushResult(1);
            stack.Push(2);
        }
    }
}
