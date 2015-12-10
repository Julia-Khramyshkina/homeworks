#include <iostream>
#include <math.h>

#include <QtCore>
#include <limits>
#include <iomanip>
using namespace std;

double function(double x_m, double y_m)
{
	return (0.6  - y_m * y_m) * cos(x_m) + 0.2 * y_m;
}

QList<double> methodEuler(double a, double b, double step, int N)
{
	const double y0 = 0;
	double x0 = a;
	int i = 1;
	double y_i = y0;
	QList<double> result;
	result.append(y0);
	while (i < N)
	{
		double x_i = x0 + i * step;
		y_i = y_i + step * function(x_i, y_i);
		++i;
		result.append(y_i);
	}

	return result;
}

QList<double> methodRungeKutta(double a, double b, double step, int N)
{
	QList<double> result;
	double y0 = 0;
	int i = 0;
	double x0 = a;
	double x_i = x0 + i * step;
	double y_i = y0;
	result.append(y_i);
	while (i < N)
	{
		double k1 = step * function(x_i, y_i);
		double k2 = step * function(x_i + step / 2.0, y_i + k1 / 2.0);
		double k3 = step * function(x_i + step / 2.0, y_i + k2 / 2.0);
		double k4 = step * function(x_i + step, y_i + k3);
		y_i = y_i + (1.0 / 6.0) * (k1 + 2.0 * k2 + 2.0 * k3 + k4);
		x_i += step;
		result.append(y_i);
		++i;
	}

	return result;
}

QList<QList<double>> differencesFunc(QList<double> x, QList<double> y, double step, double m)
{
	QList<double> q;
	for (int i = 0; i <= m; ++i)
	{
		double q_i = step * function(x.at(i), y.at(i));
		q.append(q_i);
	}

	QList<double> deltaQ;
	for (int i = 0; i <= m - 1; ++i)
	{
		double deltaQ_i = q.at(i + 1) - q.at(i);
		deltaQ.append(deltaQ_i);
	}

	QList<double> delta2Q;
	for (int i = 0; i <= m - 2; ++i)
	{
		double deltaQ_2i = deltaQ.at(i + 1) - deltaQ.at(i);
		delta2Q.append(deltaQ_2i);
	}

	QList<double> delta3Q;
	for (int i = 0; i <= m - 3; ++i)
	{
		double deltaQ_3i = delta2Q.at(i + 1) - delta2Q.at(i);
		delta3Q.append(deltaQ_3i);
	}

	QList<double> delta4Q;
	for (int i = 0; i <= m - 4; ++i)
	{
		double deltaQ_4i = delta3Q.at(i + 1) - delta3Q.at(i);
		delta4Q.append(deltaQ_4i);
	}

	QList<QList<double>> result;
	result.append(q);
	result.append(deltaQ);
	result.append(delta2Q);
	result.append(delta3Q);
	result.append(delta4Q);
	return result;

}

double extraAdams(QList<double> x, QList<double> y, double step, double m)
{
	QList<QList<double>> differences = differencesFunc(x, y, step, m);
	QList<double> q = differences.at(0);
	QList<double> deltaQ = differences.at(1);
	QList<double> delta2Q = differences.at(2);
	QList<double> delta3Q = differences.at(3);
	QList<double> delta4Q = differences.at(4);

	return y.at(m) + q.at(m) + (1.0 / 2.0) * deltaQ.at(m - 1)
			+ (5.0 / 12.0) * delta2Q.at(m - 2) +
			(3.0 / 8.0) * delta3Q.at(m - 3) +
			(251.0 / 720.0) * delta4Q.at(m - 4);
}

QList<double> introAdams(QList<double> x, QList<double> yExtrAdams, double step, double m)
{
	QList<double> yIntrAdams;
	double q[100];
	QList<QList<double>> differences = differencesFunc(x, yExtrAdams, step, m);

	int i = 0;
	while (i < m)
	{
		yIntrAdams.append(yExtrAdams.at(i));
		q[i] = (differences.at(0)).at(i);
		++i;
	}

	for (int j = m - 1; j < m + 15; ++j)
	{
		q[j] = step * function(x.at(j),yIntrAdams.at(j));
		q[j + 1] = step * function(x.at(j + 1), yExtrAdams.at(j + 1));
		yIntrAdams.append(yIntrAdams.at(j) +  (251 * q[j + 1] + 646 * q[j] -
				264 * q[j - 1] + 106 * q[j - 2] - 19 * q[j - 3]) / 720.0);
	}

	return yIntrAdams;
}

int main()
{
	double a = 0.0;
	double b = 0.5;
	int N = 5;
	double step1 = (b - a) / N;
	double step2 = (b - a) / (2 * N);

	QList<double> xStart;
	for (int i = 0; i <= 10; ++i)
	{
		xStart.append((double) i / 10);
	}

	QList<double> y = { 0.0000000, 0.0603820, 0.1206557,
		0.1795603, 0.2359782, 0.2890110, 0.3380198,
		0.3826289, 0.4227005, 0.4582908, 0.4895988};


	QList<double> y_h = methodEuler(a, b, step1, N);
	QList<double> y_h2 = methodEuler(a, b, step2, 2 * N);

	QList<double> R_main;

	int i = 0;
	while (i < N)
	{
		double tempResult = y_h2.at(2 * i) - y_h.at(i);
		R_main.append(tempResult);
		++i;
	}

	QList<double> y_ut;
	for (int j = 0; j < N; ++j)
	{
		y_ut.append(y_h2.at(2 * j) + R_main.at(j));
	}

	i = 0;
	while (i < N)
	{
		cout << " y_math = " << y.at(i) << "; y^h = " << y_h.at(i)
		<< "; y^h/2 = " << y_h2.at(i * 2)
		<< "; y_rev = " << y_ut.at(i) << "; y_rev - y_math = " << y.at(i) - y_ut.at(i) << endl;
		++i;

	}


	// runge-kutta
	N = 20;
	double step = 1.0 / N;

	QList<double> rungeKutt =  methodRungeKutta(0, 1, step, N);

	cout << "Method Runge-Kutta on [0, 1], eps = 0.00001" << endl;
	for (auto &temp : rungeKutt)
	{
		cout << temp << endl;
	}

	QList<double> yForExtrAdams = methodRungeKutta(0, 5 * step, step, 5);
	QList<double> xForExtrAdams;
	double x = 0.0;
	xForExtrAdams.append(x);
	for (int j = 0; j < 5; ++j)
	{
		x += step;
		xForExtrAdams.append(x);
	}

	QList<double> yIntrAdams;

	for (int j = 5; j < 20; ++j)
	{
		x += step;
		xForExtrAdams.append(x);
		double resExtrAdams = extraAdams(xForExtrAdams, yForExtrAdams, step, j);
		yForExtrAdams.append(resExtrAdams);
	}

	cout << "ExtraAdams [5h; 1]; beginning of table from Runge-Kutt" << endl;

	for (int j = 5; j <= 20; ++j)
	{
		cout << yForExtrAdams.at(j) << endl;
	}

	yIntrAdams = introAdams(xForExtrAdams, yForExtrAdams, step, 5);

	cout << " IntroAdams [5h; 1] " << endl;

	for (int j = 5; j <= 20; ++j)
	{
		cout << yIntrAdams.at(j) << endl;
	}

	return 0;
}





/* exact values from math
 * 0.00 0.0000000 0e+00 0e+00
0.05 0.0301228 -3e-010 3e-011
0.10 0.0603820 -3e-010 7e-011
0.15 0.0906135 -8e-011 1e-010
0.20 0.1206557 4e-010 1e-010
0.25 0.1503534 1e-009 2e-010
0.30 0.1795603 2e-009 2e-010
0.35 0.2081420 3e-009 2e-010
0.40 0.2359782 3e-009 2e-010
0.45 0.2629640 4e-009 2e-010
0.50 0.2890110 5e-009 1e-010
0.55 0.3140479 5e-009 1e-010
0.60 0.3380198 6e-009 1e-010
0.65 0.3608881 6e-009 8e-011
0.70 0.3826289 6e-009 6e-011
0.75 0.4032323 6e-009 4e-011
0.80 0.4227005 6e-009 2e-011
0.85 0.4410461 6e-009 -1e-011
0.90 0.4582908 6e-009 -6e-011
0.95 0.4744635 5e-009 -2e-011
1.00 0.4895988 5e-009 -3e-011

*/
