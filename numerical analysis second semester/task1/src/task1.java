import java.lang.Math;
/**
 * Created by Юлия on 08.03.2016.
 */
public class task1
{
    static double[][] A = {
    {3.278164e-8, 1.046583, -1.378574, -0.527466},
    {1.046583, 2.975937, 0.934251, 2.526877},
    {-1.378574, 0.934251, 4.836173, 5.165441}};


    static double[][] A1 = {
    {3.278164e-8, 1.046583, -1.378574, -0.527466},
    {1.046583, 2.975937, 0.934251, 2.526877},
    {-1.378574, 0.934251, 4.836173, 5.165441}};

    static double[][] D = {
            {7.35272, 0.88255, -2.270052, 1, 0, 0},
            {0.88255, 5.58351, 0.528167, 0, 1, 0},
            {-2.27005, 0.528167, 4.430329, 0, 0, 1}};
    static double[][] D1 = {
            {7.35272, 0.88255, -2.270052, 1, 0, 0},
            {0.88255, 5.58351, 0.528167, 0, 1, 0},
            {-2.27005, 0.528167, 4.430329, 0, 0, 1}};

    static double[][] check = {
    {1, 2, 3},
    {4, 5, 6}, {7, 8, 9}};

    static double[][] C = {{7.35272, 0.88255, -2.270052, 1},
    {0.88255, 5.58351, 0.528167, 0},
    {-2.27005, 0.528167, 4.430329, 0}};

    static double eps = 0.000001;

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


    static double[][] Gauss2(double[][] m, int size)
{
    int[] changList = new int[size];
    for (int k = 0; k < size; k++)
    {
        int numRow = findMaxInRow(m, k, size);

        change(m, k, numRow, size);
        changList[k] = numRow;

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

    static double [][] inverse(double[][] m, int size)
    {
        for (int k = 0; k < size; k++)
        {
            double a = m[k][k];
            if (Math.abs(a) < eps)
            {
                System.out.println("Too small " + k + " : " + a);
            }
            for (int j = k; j < size * 2; j++)
            {
                m[k][j] /= a;
            }

            for (int j = k + 1; j < size * 2; j++)
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

    static double[][] otherMatrix(double[][] m, int size)
    {
        double [][] matrix = new double[size][size + 1];
        for (int i = 0; i < size; ++i)
        {
            for (int j = 0; j < size; ++j)
            {
                matrix[i][j] = m[i][j];
            }
        }

        return matrix;
    }

    static double[] otherResolve(double[][] newM, double[][] old, int size, int count)
    {
        for (int i = 0; i < size; ++i)
        {
            newM[i][size] = old[i][count];
        }

        double [] result = resolve(newM, 3);
        return result;
    }

    static void inversePrint(double [][]m, int size)
    {
        for (int i = 0; i < size; ++i)
        {
            for (int j = 0; j < size; ++j)
            {
                System.out.print(m[j][i] + " ");
            }
            System.out.println();
        }
    }

    public static void main(String[] args)
    {
//        System.out.println("A:");
//        print(A, 3);
//        print(Gauss2(A, 3), 3);
//        double[] res = resolve(A, 3);
//        System.out.println("Result:");
//        print(res, 3);

//
//        System.out.println("Dif:");
//        print(minus(res2, A1, 3), 3);



        print(D, 3);

        double [][] matrix = inverse(D, 3);
        otherPrint(matrix, 3, 6);
        double [][] newMatrix = otherMatrix(matrix, 3);

        double [][]inverseMatrix = new double[3][3];
        for (int i = 0 ; i < 3; ++i)
        {
            inverseMatrix[i] = otherResolve(newMatrix, matrix, 3, i + 3);
        }

        inversePrint(inverseMatrix, 3);

    }


    static void print(double[][] m, int size)
    {
        for (int j = 0; j < size; j++)
        {
            for (int i = 0; i < size * 2; i++)
            {
                System.out.print(m[j][i] + "  ");
            }
            System.out.println();
        }
        System.out.println();
    }

    static void otherPrint(double[][] m, int one, int two)
    {
        for (int i = 0; i < one; i++)
        {
            for (int j = 0; j < two; j++)
            {
                System.out.print(m[i][j] + "  ");
            }
            System.out.println();
        }
        System.out.println();
    }

    static void print(double[] m, int size)
    {
        for (int j = 0; j < size; j++)
        {
            System.out.print(m[j] + "  ");
        }
        System.out.println();
        System.out.println();
    }

    static int findMaxInRow(double[][] m, int k, int size)
    {
        double max = Math.abs(m[k][k]);
        int res = k;
        for (int i = k + 1; i < size; i++)
        {
            if (max != Math.max(max, Math.abs(m[k][i])))
            {
                res = i;
                max = Math.abs(Math.max(max, m[k][i]));
            }

        }
        return res;
    }

    static double[] mult(double[][] m, double[] mul, int size) {
        double[] res = new double[size];

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                res[i] += m[i][j] * mul[j];
            }

        }

        return res;
    }

    static void change(double[][] m, int k, int numRow, int size)
    {
        for (int i = 0; i < size + 1;  i++)
        {
            double a = m[k][i];
            m[k][i] = m[numRow][i];
            m[numRow][i] = a;
        }
    }

    static double[] minus(double[] m, double[][] res, int size)
    {
        for (int i = 0; i < size; i++)
        {
            m[i] = m[i] - res[i][size];
        }
        return m;
    }

}
