using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1_task1
{
    class Program
    {
        static int Factorial(int n)
        {
            if (n == 1)
            {
                return n;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Please input number ");
            int number = 0;
            number = System.Int32.Parse(System.Console.ReadLine());
            int result = Factorial(number);
            System.Console.WriteLine("Factorial of this number = {0}", result);
        }
    }
}
