#include <iostream>
using namespace std;
int main()
{
	int fibonacchiPred = 1;
	int fibonacchiSled = 1;
	int numberOfChisloFibonacchi = 0;
	cout << "Please input number of chislo Fibonacchi" << endl;
	cin >> numberOfChisloFibonacchi;
	if (numberOfChisloFibonacchi == 0) {
		printf("Chislo Fibonacchi %d \n", fibonacchiPred);
		return 0;
	} else if (numberOfChisloFibonacchi == 1) {
		printf("Chislo Fibonacchi %d \n", fibonacchiSled);	
		return 0;
	}
	int chisloFibonacchi = 0;
	for (int i = 2; i <= numberOfChisloFibonacchi; ++i) {
		chisloFibonacchi = fibonacchiSled + fibonacchiPred;
		fibonacchiPred = fibonacchiSled;
		fibonacchiSled = chisloFibonacchi;
	}
	printf("Chislo Fibonacchi %d \n", chisloFibonacchi);
	return 0;
}