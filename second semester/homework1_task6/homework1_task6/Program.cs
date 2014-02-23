using System;
using System.IO;
//using StreamReader;


namespace Homework1_task6
{
    class Program
    {
        // распечатка части массива при движении вправо
        static int PrintToRight(int[,] array, int positionI, int positionJ, int step, int size)
        {
            int counter = 0;
            while (counter != step)
            {
                ++positionJ;
                ++counter;
                if (positionJ == size)
                    break;
                System.Console.Write("{0} ", array[positionI, positionJ]);
            }
            return positionJ;
        }

        // распечатка части массива при движении вниз
        static int PrintToDown(int[,] array, int positionI, int positionJ, int step, int size)
        {
            int counter = 0;
            while (counter != step)
            {
                ++positionI;
                ++counter;
                if (positionI == size)
                    break;
                System.Console.Write("{0} ", array[positionI, positionJ]);
            }
            return positionI;
        }
        
        // распечатка части массива при движении влево
        static int PrintToLeft(int[,] array, int positionI, int positionJ, int step, int size)
        {
            int counter = 0;
            while (counter != step)
            {
                --positionJ;
                ++counter;
                if (positionJ < 0)
                    break;
                System.Console.Write("{0} ", array[positionI, positionJ]);
            }
            return positionJ;
        }
        
        // распечатка части массива при движении вверх
        static int PrintToUp(int[,] array, int positionI, int positionJ, int step, int size)
        {
            int counter = 0;
            while (counter != step)
            {
                --positionI;
                ++counter;
                if (positionI < 0)
                    break;
                System.Console.Write("{0} ", array[positionI, positionJ]);
            }
            return positionI;
        }

        // обход по спирали
        static void WalkingAlongTheHelix(int[,] array, int size)
        {
            int start = size / 2;
            int step = 1;
            System.Console.Write("{0} ", array[start, start]);
            int positionI = start;
            int positionJ = start;
            while (step != size)
            {
                positionJ = PrintToRight(array, positionI, positionJ, step, size);
                positionI = PrintToDown(array, positionI, positionJ, step, size);
                ++step;
                positionJ = PrintToLeft(array, positionI, positionJ, step, size);
                positionI = PrintToUp(array, positionI, positionJ, step, size);
                if (step + 1 == size)
                {
                    PrintToRight(array, positionI, positionJ, step, size);
                }
                ++step;
            }
        }

        static void Main(string[] args)
        {
            StreamReader input = new StreamReader("input.txt");
            string line;
            string[] buf;
            int size = int.Parse(input.ReadLine());
            int [,] array = new int [size, size];   
            int i = 0;
            while ((line = input.ReadLine()) != null)
            {
                buf = line.Split(' ');
                for (int j = 0; j < buf.Length; j++)
                {
                    array[i, j] = Convert.ToInt32(buf[j]);
                    Console.Write("{0} ", array[i, j]);
                }
                ++i;
                Console.WriteLine();
            }
            WalkingAlongTheHelix(array, size);          
        }
    }
}
