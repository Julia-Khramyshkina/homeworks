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
            //BeginCount count = new BeginCount();
           // Operation oper = new Operation(tree.first());
            //int result = count.Begin();
          //  int value = tree.(tree.first(), tree.first());
           // Count qwerty = new Count();

        }
    }
}
