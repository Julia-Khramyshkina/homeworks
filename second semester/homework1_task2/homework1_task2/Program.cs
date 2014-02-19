namespace homework1_task2
{
    class Program
    {
        static void Main(string[] args)
        {  
            int fibonacchiPred = 1;
	    int fibonacchiSled = 1;   
            System.Console.WriteLine("Please input number Fibonacchi");
	    int numberOfChisloFibonacchi = System.Int32.Parse(System.Console.ReadLine());
	    if (numberOfChisloFibonacchi == 0) 
            {
		System.Console.WriteLine("Chislo Fibonacchi {0}", fibonacchiPred);
		return;
	    }
            else if (numberOfChisloFibonacchi == 1) 
            {
		System.Console.WriteLine("Chislo Fibonacchi {0}", fibonacchiSled);	
		return;
	    }
	    int chisloFibonacchi = 0;
	    for (int i = 2; i <= numberOfChisloFibonacchi; ++i)
            {
		chisloFibonacchi = fibonacchiSled + fibonacchiPred;
		fibonacchiPred = fibonacchiSled;
		fibonacchiSled = chisloFibonacchi;
	    }
	    System.Console.WriteLine("Chislo Fibonacchi {0}", chisloFibonacchi);
        }
    }
}