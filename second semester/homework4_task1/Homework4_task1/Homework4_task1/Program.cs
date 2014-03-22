using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = System.Console.ReadLine();
            Tree tree = new Tree();
            int i = 0;
            tree.InsertElement(input, ref i, tree.first());
            int value = tree.count(tree.first(), tree.first());

        }
    }
}
