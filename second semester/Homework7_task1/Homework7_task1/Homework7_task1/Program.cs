using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();


            List<int> list = new List<int>();


            list.InsertToEnd(1);
            list.InsertToEnd(2);

            list.InsertToEnd(3);
            list.InsertToEnd(4);


            foreach (int i in list)
                Console.Write(i + "\t");

        }
    }
}
