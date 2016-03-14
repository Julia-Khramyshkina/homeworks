/**
 * Created by Юлия on 09.03.2016.
 */
public class task2
{
    static double eps = 0.000001;
    static double[][] A = {
            {3.278164e-8, 1.046583, -1.378574, -0.527466},
            {1.046583, 2.975937, 0.934251, 2.526877},
            {-1.378574, 0.934251, 4.836173, 5.165441}};
    static double [][] b = {
            {-0.527466},
            {2.526877},
            {5.165441}};

    static double [][] E = {
            {1.0, 0.0, 0.0},
            {0.0, 1.0, 0.0},
            {0.0, 0.0, 1.0}};

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

    static double [] simpleIteration(double [][] h, double[][] g, double [] x_current,
         double[] x_prev, int size, int kMax)
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
                    sum = h[i][j] * x_prev[i];
                }

                x_current[i] = sum + g[i][0];
            }

            x_prev = x_current;
            ++k;
        }

        return x_current;
    }

    public static void main(String[] args)
    {

        double alpha = 2.0 / (smallM(A, 3) + bigM(A, 3));

        double [][] h = substOfMatrix(E, multConst(A, 3, 3, alpha), 3);
        double [][] g = multConst(b, 3, 1, alpha);
        System.out.println("matrix H:");
        print(h, 3);

        System.out.println("g:");
        printColumn(g, 3);
        double normOfH = norm(h, 3);

        System.out.println("Norm of matrix H = " +  normOfH);
        double []exactValue = new double[3];
        double [] x_current = new double[3];
        double [] x_prev = new double[3];
        int kMax = 10;
        double []xFromSimpleIteration = simpleIteration(h, g,x_current, x_prev, 3, kMax);
        double []difference = vector(exactValue, xFromSimpleIteration, 3);
        double factAcc = normOfVector(difference, 3);
        double [] newG = new double[3];
        for (int i = 0; i < 3; ++i)
        {
            newG[i] = g[i][0];
        }

        double apriorySimpleIt = Math.pow(normOfH, kMax) / (1 - normOfH) * normOfVector(newG, 3);

        double []vect = vector(x_current, x_prev, 3);
        double aposterSimpleIt = normOfH / (1 - normOfH) * normOfVector(vect, 3);

        
        System.out.println("The actual accuracy:");
    }
}
