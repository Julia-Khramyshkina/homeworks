/**
 * Created by Юлия on 09.03.2016.
 */
public class task2
{
    static int [] Q_Cheb = {1, 15, 7, 9,  3, 13,  5, 11};
    static int p = 8;
    static double eps = 0.000001;
    static double[][] A0 = {
            {7.35272, 0.88255, -2.270052, 1},
            {0.88255, 5.58351, 0.528167, 0},
            {-2.27005, 0.528167, 4.430329, 0}};
    static double[][] A = {
            {7.35272, 0.88255, -2.270052, 1},
            {0.88255, 5.58351, 0.528167, 0},
            {-2.27005, 0.528167, 4.430329, 0}};
    static double [][] b = {
            {1},
            {0},
            {0}};
    static double [] b1 = { 1, 0, 0 };

    static double [][] E = {
            {1.0, 0.0, 0.0},
            {0.0, 1.0, 0.0},
            {0.0, 0.0, 1.0}};

    static double [][] A_simm = {
            {1.234, 0, 0, 2.342},
            {0, 2.342, 0, 6.234},
            {0, 0, 3.4532, 4.55534}};
    static double [] b_simm = { 2.342, 6.234, 4.55534};

    static double [][] A_simm1 = {
            {1.234, 0, 0, 2.342},
            {0, 2.342, 0, 6.234},
            {0, 0, 3.4532, 4.55534}};
    static double [] b_simm1 = { 2.342, 6.234, 4.55534};


    static double [] x_current = new double[3];
    static double [] x_prev = new double[3];

    static double[][] Gauss1(double[][] m, int size)
    {
        for (int k = 0; k < size; k++)
        {
            double a = m[k][k];
            if (Math.abs(a) < eps)
            {
                System.out.println("Too small " + k + " : " + a);
            }

            for (int j = k; j < size + 1; j++)
            {
                m[k][j] /= a;
            }

            for (int j = k + 1; j < size + 1; j++)
            {
                for (int i = 0; i < k; i++)
                    m[k][i] = 0;

                for (int i = k + 1; i < size; i++)
                    m[i][j] -= m[k][j] * m[i][k];
            }

        }
        return m;
    }

    static double[] resolve(double[][] m, int size)
    {
        double[] res = new double[size];
        for (int i = size - 1; i >= 0; i--)
        {
            res[i] = m[i][size];
            for (int j = i + 1; j < size; j++)
            {
                res[i] -= m[i][j] * res[j];
            }
        }
        return res;
    }

    static double smallM(double[][] m, int size)
    {
        double min = 10000;
        for (int i = 0; i < size; ++i)
        {
            double sum = 0;
            for (int j = 0; j < size; ++j)
            {
                if (i != j)
                {
                    sum += Math.abs(m[i][j]);
                }
            }

            double temp = m[i][i] - sum;
            if (temp < min)
            {
                min = temp;
            }
        }

        return min;
    }

    static double bigM(double[][] m, int size)
    {
        double max = -10000;
        for (int i = 0; i < size; ++i)
        {
            double sum = 0;
            for (int j = 0; j < size; ++j)
            {
                if (i != j)
                {
                    sum += Math.abs(m[i][j]);
                }
            }

            double temp = m[i][i] + sum;
            if (temp > max)
            {
                max = temp;
            }
        }

        return max;
    }

    static void print(double[][] m, int size)
    {
        for (int j = 0; j < size; j++)
        {
            for (int i = 0; i < size; i++)
            {
                System.out.print(m[j][i] + "  ");
            }
            System.out.println();
        }
        System.out.println();
    }

    static void printColumn(double [][] b, int size)
    {
        for (int j = 0; j < size; ++j)
        {
            System.out.println(b[j][0]);
        }
        System.out.println();
    }

    static double [][] multConst(double[][] m, int row, int column, double multConst)
    {
        for (int i = 0; i < row; ++i) {
            for (int j = 0; j < column; ++j) {
                m[i][j] *= multConst;
            }
        }

        return m;
    }

    static double[][] substOfMatrix(double[][] first, double[][] second, int size)
    {
        for (int i = 0; i < size; ++i)
        {
            for (int j = 0; j < size; ++j)
            {
                first[i][j] -= second[i][j];
            }
        }
        return first;
    }

    static double norm(double[][] m, int size)
    {
        double max = 0.0;
        for (int i = 0; i < size; ++i)
        {
            double tempSum = 0;
            for (int j = 0; j < size; ++j)
            {
                tempSum += Math.abs(m[i][j]);
            }

            if (tempSum > max)
            {
                max = tempSum;
            }
        }

        return max;

    }

    static double[] vector(double []exact, double[]newValues, int size)
    {
        double [] result = new double[size];
        for (int i = 0; i < size; ++i)
        {
            result[i] = exact[i] - newValues[i];
        }
        return result;
    }

    static double normOfVector(double []vect, int size)
    {
        double max = -10000000;
        for (int i = 0; i < size; ++i)
        {
            double temp = Math.abs(vect[i]);
            if (temp > max)
            {
                max = temp;
            }
        }

        return max;
    }

    static double [] simpleIteration(double [][] h, double[][] g, int size, int kMax)
    {
        for (int i = 0; i < size; ++i)
        {
            x_current[i] = 0;
            x_prev[i] = 0;
        }
        int k = 0;
        while (k < kMax)
        {
            for (int i = 0; i < size; ++i) {
                double sum = 0;
                for (int j = 0; j < size; ++j) {
                    sum += h[i][j] * x_prev[j];
                }

                x_current[i] = sum + g[i][0];
            }

            x_prev = x_current;
            ++k;
        }

        return x_current;
    }

    static double [] multMatrixOnVect(double [][] matrix,  double [] vector, int size)
    {
        double [] result = new double[size];
        for (int i = 0; i < size; ++i)
        {
            double temp = 0;
            for (int j = 0; j < size; ++j)
            {
                temp += matrix[i][j] * vector[j];
            }

            result[i] = temp;
        }
        return result;
    }

    static double [] ariphmetic(double [] Ax, double [] b, double tau, int size)
    {
        double [] result = new double[size];
        for (int i = 0; i < size; ++i)
        {
            result[i] = tau * (b[i] - Ax[i]);
        }
        return result;
    }


    static double [] addForVectors(double [] a, double [] b, int size)
    {
        double [] result = new double[size];
        for (int i = 0; i < size; ++i)
        {
            result[i] = a[i] + b[i];
        }
        return result;
    }

    static double [] iterationWithCheb(double smallM, double bigM, double [] x_current
            , double [] x_prev, double [][] matrixA, double [] b_Cheb)
    {
        double value = 0.5 * Math.sqrt(bigM / smallM) * Math.log10(2 / eps);
        int count = 1;

        while (count < value) {
            for (int i = 0; i < p; ++i)
            {
                for (int k = 0; k < p; ++k)
                {
                    double t_k = Math.cos(Math.PI * Q_Cheb[k] / (2 * p));
                    double tau_k = 2 / (bigM + smallM - (bigM - smallM) * t_k);
                    double[] Ax_prev = multMatrixOnVect(matrixA, x_prev, 3);
                    double[] temp = ariphmetic(Ax_prev, b_Cheb, tau_k, 3);
                    x_current = addForVectors(x_prev, temp, 3);
                    x_prev = x_current;
                }

            }
            ++count;
        }
        return x_current;
    }

    static double forLusternik(double []array, int size)
    {
        double max = Math.abs(array[0]);
        for (int i = 0; i < size; ++i)
        {
            if (Math.abs(array[i]) > max)
            {
                max = array[i];
            }
        }
        return max;
    }

    static void printOneColumn(double []array, int size)
    {
        for (int i = 0; i < size; ++i)
        {
            System.out.println(array[i]);
        }

        System.out.println();
    }

    public static void main(String[] args)
    {
        System.out.println("A:");
        print(A0, 3);
        print(Gauss1(A0, 3), 3);
        double []solution = resolve(A0, 3);
        System.out.println("Exactly solution");
        printOneColumn(solution, 3);

        double smallM = smallM(A, 3);
        double bigM = bigM(A, 3);

        double alpha = 2.0 / (smallM(A, 3) + bigM(A, 3));

        double [][] h = substOfMatrix(E, multConst(A, 3, 3, alpha), 3);
        double [][] g = multConst(b, 3, 1, alpha);
        System.out.println("matrix H:");
        print(h, 3);

        System.out.println("g:");
        printColumn(g, 3);
        double normOfH = norm(h, 3);

        System.out.println("Norm of matrix H = " +  normOfH);
        double [] exactValue = solution;

        int kMax = 15;
        double []xFromSimpleIteration = simpleIteration(h, g, 3, kMax);
        System.out.println("Simple iteration with kMax:");
        printOneColumn(xFromSimpleIteration, 3);
        double []difference = vector(exactValue, xFromSimpleIteration, 3);

        double factAcc = normOfVector(difference, 3);
        System.out.println("The actual accuracy: " + factAcc);
        double [] newG = new double[3];
        for (int i = 0; i < 3; ++i)
        {
            newG[i] = g[i][0];
        }

        double apriorySimpleIt = Math.pow(normOfH, kMax - 1) / (1 - normOfH) * normOfVector(newG, 3);
        System.out.println("The apriory evaluation: " + apriorySimpleIt);

        double []vect = vector(x_current, x_prev, 3);
        double aposterSimpleIt = normOfH / (1 - normOfH) * normOfVector(vect, 3);
        System.out.println("The aposteriory evaluation: " + aposterSimpleIt);

        double [] numbersOfH = {0.523057, -0.430826, 0.046116};

        double newConst = 1 / (1 - forLusternik(numbersOfH, 3));
        double [] temp = ariphmetic(x_current, x_prev, newConst, 3);
        double [] moreExactlyRes = addForVectors(x_prev, temp, 3);
        System.out.println("More exactly solution (Lusternik)");
        printOneColumn(moreExactlyRes, 3);

        double [] x1 = new double[3];
        double [] x2 = new double[3];

        System.out.println("A:");
        print(A_simm, 3);
        print(Gauss1(A_simm, 3), 3);
        double []sol1 = resolve(A_simm, 3);
        System.out.println("Exactly solution");
        printOneColumn(sol1, 3);


        double [] fromCheb = iterationWithCheb(smallM(A_simm1, 3), bigM(A_simm1, 3), x1, x2, A_simm1, b_simm1);
        System.out.println("Solution from Cheb params");
        printOneColumn(fromCheb, 3);

        double [] newDifference = vector(exactValue, fromCheb, 3);
        double factAcc2 = normOfVector(newDifference, 3);

        System.out.println("The actual accuracy:" + factAcc2);
    }
}
