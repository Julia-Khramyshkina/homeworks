using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTreeSeach tree = new BinaryTreeSeach();


            tree.InsertElement(10);
            tree.InsertElement(12);
            tree.InsertElement(3);
            tree.InsertElement(5);
            tree.InsertElement(2);


            foreach (int i in tree)
            {
                System.Console.WriteLine("ololo");
            }

            tree.RemoveElement(3);


        }
    }
}
