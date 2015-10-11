#include <iostream>
#include <math.h>
using namespace std;

double func(double x)
{
	return sin(x);
}

double reverseFunc(double x)
{
	return asin(x);
}

double degree0(double y, double values[])
{
	return values[1];
}

double degree1(double y, double values[])
{
	return (y - func(values[1])) / (func(values[0]) - func(values[1])) * values[0] +
		(y - func(values[0])) / (func(values[1]) - func(values[0])) * values[1];
}

double degree2(double y, double values[])
{
	return (y - func(values[1])) * (y - func(values[0])) /
		((func(values[2]) - func(values[1])) * (func(values[2]) - func(values[0]))) * values[2] +
	(y - func(values[2])) * (y - func(values[0])) /
		((func(values[1]) - func(values[2])) * (func(values[1]) - func(values[0]))) * values[1] +
	(y - func(values[1])) * (y - func(values[2])) /
		((func(values[0]) - func(values[1])) * (func(values[0]) - func(values[2]))) * values[0];
}

double Polynomial(double x, double values[])
{
	return (x - values[1]) * (x - values[2]) / (values[0] - values[1]) / (values[0] - values[1]) * func(values[0]) +
		(x - values[0]) * (x - values[2]) / (values[1] - values[0]) / (values[1] - values[2]) * func(values[1]) +
		(x - values[0]) * (x - values[1]) / (values[2] - values[0]) / (values[2] - values[1]) * func(values[2]);
}

double root (double y, double values[])
{
	double xPrev = values[1] - Polynomial(values[1], values) + y;
	double xk = xPrev - Polynomial(xPrev, values) + y;
	while (fabs(xPrev - xk) >= 0.000001) {
		xPrev = xk;
		xk = xPrev - Polynomial(xPrev, values) + y;
	}

	return xk;
}

int main()
{
	double values[5] = { 0.01, 0.45, 0.72, 0.8, 0.91};
	double y = 0.4;
	cout << "values: 0.01, 0.45, 0.72, 0.8, 0.91" << endl;
	cout << "y = 0.4" << endl;
	cout << "degree 0: " << degree0(y, values) << " " << reverseFunc(y) - degree0(y, values) << endl;
	cout << "degree 1: " << degree1(y, values) << " " << reverseFunc(y) - degree1(y, values) << endl;
	cout << "degree 2: " << degree2(y, values) << " " << reverseFunc(y) - degree2(y, values) << endl << endl;

	cout << "precise value: " << root(y, values) << " " << reverseFunc(y) - root(y, values) << endl;
	return 0;
}
