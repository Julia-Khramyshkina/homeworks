namespace homework1_task2
{
	class Program
	{
		// calculation of Fibonacci numbers
		static int Fibonacci(int indexNumberOfFibonacchi, int fibonacciPrevious, int fibonacciNext)
		{
			int numberFibonacci = 0;
			for (int i = 2; i <= indexNumberOfFibonacchi; ++i)
			{
				numberFibonacci = fibonacciNext + fibonacciPrevious;
				fibonacciPrevious = fibonacciNext;
				fibonacciNext = numberFibonacci;
			}
			return numberFibonacci;
 		}

		static void Main(string[] args)
		{
			int fibonacciPrevious = 1;
			int fibonacciNext = 1;
			System.Console.WriteLine("Please input number Fibonacchi");
			int indexNumberOfFibonacci = System.Int32.Parse(System.Console.ReadLine());
			if (indexNumberOfFibonacci == 0)
			{
				System.Console.WriteLine("Chislo Fibonacchi {0}", fibonacciPrevious);
				return;
			}
 			else if (indexNumberOfFibonacci == 1)
			{
				System.Console.WriteLine("Chislo Fibonacchi {0}", fibonacciNext);
				return;
			}
			int numberFibonacchi = Fibonacci(indexNumberOfFibonacci, fibonacciPrevious, fibonacciNext);
			System.Console.WriteLine("Chislo Fibonacchi {0}", numberFibonacchi);
		}
	}
}
