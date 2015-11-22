#include <iostream>
#include <math.h>

using namespace std;

double function(double x)
{
	return sin(x) * pow(1 - x, 3.0 / 4.0);
}

double mediumRectanglesWithTwoNodes()
{
	const double h = 1.0 / 2.0;
	return function(h / 2.0) + function(h / 2.0 + h);
}

double A_1(double x1, double x2, double mu_0, double mu_1)
{
	return (mu_1 - x2 * mu_0) / (x1 - x2);
}

double A_2(double x1, double x2, double mu_0, double mu_1)
{
	return (mu_1 - x1 * mu_0) / (x2 - x1);
}

double interpolFormWithIntegral(double mu_0, double mu_1)
{
	const double x1 = 1.0 / 4.0;
	const double x2 = 3.0 / 4.0;

	const double value_a1 = A_1(x1, x2, mu_0, mu_1);
	const double value_a2 = A_2(x1, x2, mu_0, mu_1);

	return value_a1 * sin(x1) + value_a2 * sin(x2);
}

double gauss()
{
	return (1.0 / 2.0) * (function(-1.0 / sqrt(3.0)) + function(1.0 / sqrt(3.0)));
}

double searchingForKof1(double mu_0, double mu_1, double mu_2, double mu_3)
{
	return (mu_0 * mu_3 - mu_2 * mu_1) / (mu_1 * mu_1 - mu_2 * mu_0);
}

double searchingForKof2(double mu_0, double mu_1, double mu_2, double mu_3)
{
	return (mu_2 * mu_2 - mu_3 * mu_1) / (mu_1 * mu_1 - mu_2 * mu_0);
}

int main()
{
	const double preciseValueOfIntegral = 0.196423;

	const double mu_0 = 0.57143;
	const double mu_1 = 0.20779;
	const double mu_2 = 0.11082;
	const double mu_3 = 0.069993;

	const double a1 = searchingForKof1(mu_0, mu_1, mu_2, mu_3);
	const double a2 = searchingForKof2(mu_0, mu_1, mu_2, mu_3);

	const double node1 = 0.166115;
	const double node2 = 0.676044;

	const double A1 = A_1(node1, node2, mu_0, mu_1);
	const double A2 = A_2(node1, node2, mu_0, mu_1);

	cout << "Checking equivalence A1 + A2 witn mu_0 " << "A1 + A2 = "  << A1 + A2
		 << " mu_0 = " << mu_0 <<  endl;

	const double node1WithReplacement = 0.5 * node1 + 0.5;
	const double node2WithReplacement = 0.5 * node2 + 0.5;

	const double B1 = A1 * 0.5;
	const double B2 = A2 * 0.5;

	const double integralFromGaussBuilt = B1 * sin(node1WithReplacement)
			+ B2 * sin(node2WithReplacement);

	cout << "exact value: " << preciseValueOfIntegral << endl;
	cout << "medium rectangles: " << mediumRectanglesWithTwoNodes() << " difference: "
		 << mediumRectanglesWithTwoNodes() - preciseValueOfIntegral << endl;
	cout << "integral from interpolation formula: " << interpolFormWithIntegral(mu_0, mu_1)
		 << " difference: " << interpolFormWithIntegral(mu_0, mu_1) - preciseValueOfIntegral << endl;
	cout << "Gauss with nodes: " << gauss() << " difference: " << gauss() - preciseValueOfIntegral << endl;
	cout << "Integral from built formula of Gauss: " << integralFromGaussBuilt
		 << " difference: " << integralFromGaussBuilt - preciseValueOfIntegral << endl;

	return 0;
}

