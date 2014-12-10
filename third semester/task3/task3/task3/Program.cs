using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader input = new StreamReader("input.txt");
            StorageInputData test = new StorageInputData(input);
            Teleportation testTelePortation = new Teleportation(test);
            testTelePortation.Processing();
            bool answer = testTelePortation.GetAnswer();
            System.Console.WriteLine(answer);
        }
    }
}
