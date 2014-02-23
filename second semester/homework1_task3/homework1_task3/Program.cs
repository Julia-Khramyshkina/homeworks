namespace homework1_task3
{
    class Program
    {
        // распечатка массива
        static void PrintArray(int [] array, int size)
        {
       	    for (int i = 0; i < size; ++i) 
       	    {
       	        System.Console.Write("{0} ", array[i]);
       	    }
        }
        // сортировка массива по убыванию
        static void BubbleSort(int [] array, int size)
        {
            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size - 1; ++j)
                {
                    if (array[j + 1] > array[j])
                    {
                        int temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Please input size of array");
            int size = System.Int32.Parse(System.Console.ReadLine());
            int[] array = new int[size];
            System.Console.WriteLine("Please input elements of array");
            for (int i = 0; i < size; ++i)
            {
                array[i] = System.Int32.Parse(System.Console.ReadLine());
            }
            BubbleSort(array, size);
            System.Console.WriteLine("Sorted array");
            PrintArray(array, size);
        }
    }
}
