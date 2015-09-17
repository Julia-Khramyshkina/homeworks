#include <QtCore>
#include <math.h>
#include <iostream>
#include <limits>
#include <iomanip>

using namespace std;

double func(double x0)
{
	return 32 * pow(x0, 6) - 48 * pow(x0, 4) + 18 * pow(x0, 2) - 1 - 9 / (x0 + 10);
}

double dFunc(double x0)
{
	return 192.0 * pow(x0, 5.0) - 192.0 * pow(x0, 3.0) + 36.0 * x0 - 9.0 / pow(x0 + 10.0, 2.0);
}

double funcForIteration(double x0)
{
	return fabs(pow((32.0 * pow(x0, 6.0) - 1.0 - 9.0 / (x0 + 10.0) + 18.0 * pow(x0, 2.0)) / 48.0, 1.0 / 4.0));
}

double dFuncForIteration(double x0)
{
	return (192.0 * pow(x0, 5.0) + 36.0 * x0 + 9.0 / pow(x0 + 10.0, 2.0)) / ((8.0 + pow(3.0, 1.0 / 4.0))
		* (pow(32.0 * pow(x0, 6.0) + 18.0 * pow(x0, 2.0) - 9.0 / (x0 + 10.0) - 1.0, 3.0 / 4.0)));
}

QList<QPair<double, double> > getIntervals()
{
	const double begin = 0.0;
	const double end = 2.0;

	const double step = 0.1;
	QList<QPair<double, double> > result;
	for (double i = begin; i < end; i += step) {
		if (func(i) * func(i + step) < 0) {
			QPair<double, double> temp = qMakePair(i, i + step);
			result.append(temp);
		}
	}

	return result;
}

QPair<double, double> cut(QPair<double, double> interval)
{
	double a = interval.first;
	double b = interval.second;
	double middle = (a + b) / 2;
	if (func(a) * func(middle) <  0) {
		return qMakePair(a, middle);
	} else if (func(middle) * func(b) < 0) {
		return qMakePair(middle, b);
	}
}

QList<QPair<double, double> > getSmallIntervals()
{
	const int quantity = 2;
	QList<QPair<double, double> > startIntervals = getIntervals();
	QList<QPair<double, double> > listWithSmallIntervals;

	for (const QPair<double, double> &currentInterval : startIntervals) {
		QPair<double, double> resultInterval = currentInterval;
		for (int i = 0; i < quantity; ++i) {
			resultInterval = cut(resultInterval);
		}

		listWithSmallIntervals.append(resultInterval);
	}

	return listWithSmallIntervals;
}

double methodNewton(double x0, double eps, int &quantityOFStepsN, int kMax)
{
	int count = 0;
	double xk = x0;
	double xk1 = xk - func(xk) / dFunc(xk);
	while (fabs(xk1 - xk) >= eps && count < kMax) {
		xk = xk1;
		xk1 = xk - func(xk) / dFunc(xk);
		++count;
		++quantityOFStepsN;
	}

	return xk1;
}

double methodSecant(double x0, double x1, double root, double eps, int &quantityOFStepsS, int kMax)
{
	int count = 0;
	double xk = x1;
	double xkPrev = x0;
	cout.precision(7);

	double xk1 = x1 - func(x1) / (func(x1) - func(x0)) * (x1 - x0);
	while (fabs(xk1 - xk) >= eps && count < kMax) {
		xkPrev = xk;
		xk = xk1;
		xk1 = xk - func(xk) / (func(xk) - func(xkPrev)) * (xk - xkPrev);
		cout << "k = " << count << " xk = " << xk1 << "; xk - xk-1 = " << fabs(xk - xk1)  << setprecision(7)
			 << "; xk - root = " << fabs(root - xk1) << setprecision(7)
			 <<  "; f(xk) = " << func(xk1) << setprecision(7) << endl;
		++count;
		++quantityOFStepsS;
	}
	return xk1;
}

double methodChord(double a, double b, double root, double eps, int &quantityOFStepsC, int kMax)
{
	double c;
	double xk;
	if (func(b) > 0) {
		c = b;
		xk = a;
	}
	else {
		c = a;
		xk = b;
	}
	const double step = 0.1;
	double m1 = fabs(func(c));
	for (double i = a; i <= b; i += step) {
		if (fabs(func(i)) < m1) {
			m1 = fabs(func(i));
		}
	}

	int count = 0;
	double funcxk = func(xk);
	double funcc = func(c);
	double xk1 = xk - funcxk / (funcxk - funcc) * (xk - c);
	cout.precision(7);

	while (fabs(xk - root) > func(xk) / m1 && count < kMax) {
		xk = xk1;
		xk1 = xk - funcxk / (funcxk - funcc) * (xk - c);
		cout << "k = " << count << " xk = " << xk1 << "; xk - xk-1 = " << fabs(xk - xk1) << "; xk - root = " << fabs(root - xk1) <<
				 "; f(xk) = " << func(xk1) << endl;
		++count;
		++quantityOFStepsC;
	}
	return xk1;
}

double methodIteration(double x0, double root, double eps, double begin, double end, int kMax, int &quantityOFStepsI)
{
	double xk = funcForIteration(x0);
	double xkPrev = x0;

	double m1 = 1000000;
	double m2 = -10000000;
	const double step = 0.0001;
	for (double i = begin; i <= end; i += step) {
		if (fabs(dFunc(i)) > m2) {
			m2 = fabs(dFunc(i));
		}

		if (fabs(dFunc(i)) < m1) {
			m1 = fabs(dFunc(i));
		}
	}
	int count = 0;

	cout.precision(7);
	while ((!(fabs(xk - root) <= q / (1 - q) * fabs(xk - xkPrev))) && count < kMax) {
		xkPrev = xk;
		xk = funcForIteration(xkPrev);
		cout << "k = " << count << " xk = " << xk  << "; xk - xk-1 = " << fabs(xk - xkPrev) << "; xk - root = " << fabs(root - xk) <<
			 "; f(xk) = " << func(xk) << endl;
		++count;
		++quantityOFStepsI;
	}

	if (count == 0) {
		cout << "k = " << count << " xk = " << xk  << "; xk - xk-1 = " << fabs(xk - xkPrev) << "; xk - root = " << fabs(root - xk) <<
		 "; f(xk) = " << func(xk) << endl;
	}

	return xk;
}

double ololo(double x0)
{
	int l = int(x0);
	x0 = l - x0;
	x0 = int(x0 * pow(10, 5));
	return l - x0 / pow(10, 5);
}

int main(int argc, char *argv[])
{
	double eps = 0.000001;
	double epsIter = 0.00001;
	QList<QPair<double, double>> intervals = getSmallIntervals();
	QList<double> roots;
	int quantityOFStepsN = 0;
	int quantityOFStepsS = 0;
	int quantityOFStepsC = 0;
	int quantityOFStepsI = 0;
	int kMax = 5;

	for (QPair<double, double> currentInterval : intervals) {
		double x0 = (currentInterval.first + currentInterval.second) / 2;
		double x = std::trunc(x0 * 1000000.0) / 1000000.0;
		double root = methodNewton(x0, eps, quantityOFStepsN, kMax);
		roots.append(root);
	//	cout.precision(7);
		cout << "method secant" << endl;
		double rootSecant = methodSecant(x0, x0 + 5 * eps, root, eps, quantityOFStepsS, kMax);

		cout << "method chord" << endl;
		double rootChord = methodChord(currentInterval.first, currentInterval.second, root, eps, quantityOFStepsC, kMax);

		cout << "method iteration" << endl;
		double rootIteration = methodIteration(x, root, epsIter, currentInterval.first, currentInterval.second, kMax, quantityOFStepsI);

		cout << "difference (secant) of roots and quantity of iterations: " << fabs(root - rootSecant) << "; " <<
				quantityOFStepsN - quantityOFStepsS << endl;

		cout << "difference (chord) of roots and quantity of iterations: " << fabs(root - rootChord) << "; " <<
				quantityOFStepsN - quantityOFStepsC << endl;

		cout << "difference (iteration) of roots and quantity of iterations: " << fabs(root - rootIteration)<< "; " <<
				quantityOFStepsN - quantityOFStepsI << endl;

		quantityOFStepsN = 0;
		quantityOFStepsS = 0;
		quantityOFStepsC = 0;
		quantityOFStepsI = 0;
	}

	return 0;
}
