// Chisla Fibonacchi
#include <iostream>

using namespace std;

int fibonacchi(int n)
{
	int F0 = 1;
	int F1 = 1;
	if (n <= 1) {
		return 1;
	} else {
		return fibonacchi(n - 1) + fibonacchi(n - 2);
	}
}

int main()
{
	cout << "Please input number of chislo Fibonacchi" << endl;
	int numberOfChisloFibonacchi = 0;
	cin >> numberOfChisloFibonacchi;
	printf("Chislo Fibonacchi %d \n", fibonacchi(numberOfChisloFibonacchi));
	return 0;		
}