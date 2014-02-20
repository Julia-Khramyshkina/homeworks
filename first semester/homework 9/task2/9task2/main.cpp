#include <iostream>
#include <math.h>
using namespace std;

int factorial(int number)
{
	if (number == 0)
	{
		return 1;
	}
	else
	{
		return number * factorial(number - 1);
	}
}

int numberOfInjections(int powerM, int powerN)
{
	if (powerN >= powerM)
	{
		return factorial(powerN) / factorial (powerN - powerM);
	}
	return 0;
}

int numberOfBijections(int powerM, int powerN)
{
	if (powerM == powerN)
	{
		return factorial(powerM);
	}
	return 0;
}

double numberOfSurjections(int powerM, int powerN)
{
	int amount = 0;
	for (int i = 0; i < powerN; ++i)
	{
		amount = amount + (pow(-1, i) * factorial(powerN) * pow(powerN - i, powerM)) / (factorial(i) * factorial(powerN - i));
	}
	return amount;
}

double numberOfMappings(int powerM, int powerN)
{
	return pow(powerN, powerM);
}

int main()
{
	cout << "Please input power's of M, N\n";
	int powerM = 0;
	cin >> powerM;
	int powerN = 0;
	cin >> powerN;

	cout << "numberOfInjections from M to N " << numberOfInjections(powerM, powerN) << endl;
	cout << "numberOfSurjections from M to N " << numberOfSurjections(powerM, powerN) << endl;
	cout << "numberOfBijections from M to N "  << numberOfBijections(powerM, powerN) << endl;
	cout << "numberOfMappings from M to N " << numberOfMappings(powerM, powerN) << endl;

	return 0;
}