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
            Node tree = new Node();
            String input = "(+(+12)(+(+14)5))=";
            int i = 0;
            tree.InsertElement(input, ref i, tree.First());

        }
    }
}
