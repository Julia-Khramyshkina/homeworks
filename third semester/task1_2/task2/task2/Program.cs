using System;
using System.IO;

namespace task2
{
    class Program
    {
        public static void PrintStates(OSClass[] matrixOfComputers, int size)
        {
            for (int i = 0; i < size; ++i)
            {
                if (matrixOfComputers[i].IsInfected())
                {
                    System.Console.WriteLine("{0} is infected", i);
                }
                else
                {
                    System.Console.WriteLine("{0} is healthy", i);
                }
            }
        }

        static void Main(string[] args)
        {
            StreamReader input = new StreamReader("input.txt");
            string line;
            string[] buf;
            int size = int.Parse(input.ReadLine());
            int[,] arrayOfRelations = new int[size, size];        
            bool[] isInfectedComputers = new bool[size];

            OSClass[] matrixOfComputers = new OSClass[size];

            for (int count = 0; count < size; ++count)
            {
                line = input.ReadLine();
                matrixOfComputers[count] = new OSClass(line);
                if (count == 0)
                {
                    matrixOfComputers[0].Infected();
                    isInfectedComputers[0] = true;
                }
                else
                {
                    isInfectedComputers[count] = false;
                }              
            }

            int variable = 0;
            line = input.ReadLine();

            while ((line = input.ReadLine()) != null)
            {
                buf = line.Split(' ');
                for (int j = 0; j < buf.Length; ++j)
                {
                    arrayOfRelations[variable, j] = Convert.ToInt32(buf[j]);
                }
                ++variable;
            }

            Random rand = new Random();
            while (true)
            {
                int temp = rand.Next(60, 100);
                for (int i = 0; i < size; ++i)
                {
                    if (isInfectedComputers[i])
                    {
                        for (int j = 0; j < size; ++j)
                        {
                            if (arrayOfRelations[i, j] != 0)
                            {
                                matrixOfComputers[j].TryInfect(temp);
                            }
                        }
                    }
                }

                for (int j = 0; j < size; ++j)
                {
                    if (matrixOfComputers[j].IsInfected())
                    {
                        isInfectedComputers[j] = true;
                    }
                }
                Console.WriteLine("Network status");
                PrintStates(matrixOfComputers, size);
                Console.WriteLine("If you want exit, press 0, else press other key");
                int exitKey = Convert.ToInt32(Console.ReadLine());
                if (exitKey == 0)
                    return;
            }
        }
    }
}
