using System;

namespace Homework4_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.Parse("(*(+12)(-25))");
            tree.Print();
            System.Console.WriteLine("\n{0}", tree.Calculate());
        }
    }
}
