using System;
using System.IO;

namespace Task7
{
    class Program
    {
        // перестановка элементов в соответствии с сортировкой
        static void swap(int[,] array, int j, int size)
        {
            for (int i = 1; i < size; ++i)
            {
                int temp = array[i, j + 1];
                array[i, j + 1] = array[i, j];
                array[i, j] = temp;
            }

        }

        // сортировка матрицы по убыванию
        static void BubbleSort(int[,] array, int size)
        {
            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size - 1; ++j)
                {
                    if (array[0, j + 1] > array[0, j])
                    {
                        int temp = array[0, j + 1];
                        array[0, j + 1] = array[0, j];
                        array[0, j] = temp;
                        swap(array, j, size);
                    }
                }
            }
        }

        // печать матрицы
        static void PrintMatrix(int[,] array, int size)
        {
            for (int i = 0; i < size; ++i)
            {
                Console.WriteLine();
                for (int j = 0; j < size; ++j)
                {
                    Console.Write("{0} ", array[i, j]);
                }
            }
        }

        static void Main(string[] args)
        {
            StreamReader input = new StreamReader("input.txt");
            string line;
            string[] buf;
            int size = int.Parse(input.ReadLine());
            int[,] array = new int[size, size];
            int i = 0;
            Console.Write("Starting matrix:\n");
            while ((line = input.ReadLine()) != null)
            {
                buf = line.Split(' ');
                for (int j = 0; j < buf.Length; ++j)
                {
                    array[i, j] = Convert.ToInt32(buf[j]);
                    Console.Write("{0} ", array[i, j]);
                }
                ++i;
                Console.WriteLine();
            }
            BubbleSort(array, size);
            Console.WriteLine("Sorted matrix\n");
            PrintMatrix(array, size);
        }
    }
}
