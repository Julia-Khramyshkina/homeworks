using System;
using System.IO;

namespace homework1_task6
{
    class Program
    {
        // распечатка части массива при движении вправо
        static int PrintToRight(int[,] array, int positionI, int positionJ, int step)
        { 
            int counter = 0;
            while (counter != step)
            {
                ++positionJ;
                ++counter;
                System.Console.Write("{0} ", array[positionI, positionJ]);            
            }
            return positionJ;
        }
        // распечатка части массива при движении вниз
        static int PrintToDown(int[,] array, int positionI, int positionJ, int step)
        {
            int counter = 0;
            while (counter != step)
            {
                ++positionI;
                ++counter;
                System.Console.Write("{0} ", array[positionI, positionJ]);        
            }
            return positionI;
        }
        // распечатка части массива при движении влево
        static int PrintToLeft(int[,] array, int positionI, int positionJ, int step)
        {
            int counter = 0;
            while (counter != step)
            {
                --positionI;
                ++counter;
                System.Console.Write("{0} ", array[positionI, positionJ]);      
            }
            return positionI;
        }
        // распечатка части массива при движении вверх
        static int PrintToUp(int[,] array, int positionI, int positionJ, int step)
        {
            int counter = 0;
            while (counter != step)
            {
                --positionJ;
                ++counter;
                System.Console.Write("{0} ", array[positionI, positionJ]);  
            }
            return positionJ;
        }

        static void Main(string[] args)
        {
            const string fileName = "input.txt";
            BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open));
            int size = reader.ReadInt32();
            int[,] array = new int[size, size];
            for (int i = 0; i < size; ++i)
                for (int j = 0; j < size; ++j)
                {
                    array[i, j] = reader.ReadInt32();
                }
            int start = size / 2 + 1;
            int step = 1;
            System.Console.Write("{0} ", array[start, start]);
            int positionI = start;
            int positionJ = start;
            while (step != size)
            {
                positionJ = PrintToRight(array, positionI, positionJ, step);
                positionI = PrintToDown(array, positionI, positionJ, step);
                ++step;
                positionJ = PrintToLeft(array, positionI, positionJ, step);
                positionI = PrintToUp(array, positionI, positionJ, step);
                if (step + 1 == size)
                {
                    PrintToRight(array, positionI, positionJ, step);           
                }
                ++step;
            }
        }
    }
}
