#include <iostream>
#include<math.h>
#include<algorithm>

#include <QtCore>
#include <limits>
#include <iomanip>

using namespace std;

double function(double x)
{
	return x * x + 2 * x + 1;
	//return 2 * x + 1;
}

double I(double a, double b)
{
	return pow(b, 3.0) / 3.0 - pow(a, 3.0) / 3.0 +
			(b * b - a * a) + (b - a);

//	return (b * b - a * a) + (b - a);
}


double max_f1(double a, double b)
{
	return max(a, b) * 2.0 + 2.0;
//	return 2;
}

double max_f2()
{
	return 2.0;
}

double max_f4()
{
	return 0.0;
}

double I1_left(double a, double b, int N)
{
	double h = (b - a) / N;
	double result = 0;
	for (int i = 1; i <= N; ++i)
	{
		result = result + function(a + (i - 1) * h);
	}

	result = result * h;
	return result;
}

double I1_trap(double a, double b, int N)
{
	double h = (b - a) / N;
	double result = function(a) + function(b);
	for (int i = 1; i < N; ++i)
	{
		result = result + 2 * function(a + i * h);
	}

	result = result * (b - a) / (2 * N);
	return result;
}

double I1_Simps(double a, double b, int N)
{
	double h = (b - a) / (2 * N);
	double result = function(a) + function(b);
	for (int i = 2; i < 2 * N; i += 2)
	{
		result += 2 * function(a + i * h);
		result += 4 * function(a + (i - 1) * h);
	}

	result += 4 * function(a + (2 * N - 1) * h);
	result *= (b - a) / (6 * N);
	return result;
}

double R_left(double a, double b, double N)
{
	return (1.0 / 2.0) * (b - a) * ((b - a) / N) * max_f1(a, b);
}

double R_trap(double a, double b, double N)
{
	return (1.0 / 12.0) * (b - a) * ((b - a) / N) * ((b - a) / N) * max_f2();
}

double R_Simps(double a, double b, double N)
{
	return (1.0 / 2880.0) * (b - a) * pow (((b - a) / N), 4.0) * max_f4();
}

double R_N_left(double a, double b, double N)
{
	return fabs(R_left(a, b, 2.0 * N) - R_left(a, b, N));
}

double R_N_trap(double a, double b, double N)
{
	return (R_trap(a, b, 2.0 * N) - R_trap(a, b, N)) / 3.0;
}

double R_N_Simps(double a, double b, double N)
{
	return fabs(R_Simps(a, b, 2.0 * N) - R_Simps(a, b, N)) / (pow(2.0, 4.0) - 1.0);
}


int main()
{
	double a = 1, b = 3;
	cout << "method  I_2    I-I_2	R_2  |  I_4  I - I_4  R_4  |  R(2)	Iut	I - Iut" << endl;

	double I_2_left = I1_left(a, b, 2);
	double I_4_left = I1_left(a, b, 4);

	double Iut_left = I_4_left + R_N_left(a, b, 2.0);

	cout << "left  " << I_2_left << fixed << setprecision(6) << "  " << I(a, b) - I_2_left
		<< "  " << R_left(a, b, 2.0) << "  |  "
		<< I_4_left << "    " << I(a, b) - I_4_left << "  " << R_left(a, b, 4.0) << "  |  "
		<< R_N_left(a, b, 2.0) << "    " << Iut_left << "   " << I(a, b) - Iut_left << endl;


	double I_2_trap = I1_trap(a, b, 2);
	double I_4_trap = I1_trap(a, b, 4);
	double Iut_trap = I_4_trap + R_N_trap(a, b, 2.0);

	cout << "trap  " << I_2_trap << "     " << I(a, b) - I_2_trap << "   " << R_trap(a, b, 2.0) << "|  "
		<< I_4_trap << "   " << I(a, b) - I_4_trap << "    " << R_trap(a, b, 4.0) << "  | "
		<< R_N_trap(a, b, 2.0) << "  " << Iut_trap << "  " << I(a,b) - Iut_trap << endl;

	double I_2_Simps = I1_Simps(a, b, 2);
	double I_4_Simps = I1_Simps(a, b, 4);
	double Iut_Simps = I_4_Simps + R_N_Simps(a, b, 2.0);

	cout << "Simps  " << I_2_Simps << "    " << I(a, b) - I_2_Simps << "    " << R_Simps(a, b, 2.0) << "  |  "
		<< I_4_Simps << "  " << I(a, b) - I_4_Simps << "  " << R_Simps(a, b, 4.0) << "  |  "
		<< R_N_Simps(a, b, 2.0) << "  " << Iut_Simps << "  " << I(a, b) - Iut_Simps << endl;

	return 0;
}

