using System;


/// <summary> Class MatrixMath performs mathematical functions on matrices </summary>
class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double[,] matrixResult;
        if (matrix.GetLength(1) != 2)
        {
            matrixResult = new double[1, 1]{{-1}};
            return matrixResult;
        }
        else
        {
            matrixResult = new double[matrix.GetLength(0), matrix.GetLength(1)];
            double[,] rotation = new double[2, 2] {{Math.Cos(angle), Math.Sin(angle)}, {-1 * Math.Sin(angle), Math.Cos(angle)}};
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // matrixResult[i, j] = 0;
                    for (int k = 0; k < 2; k++)
                    {
                        matrixResult[i, j] = Math.Round(matrixResult[i, j] + (matrix[i, k] * rotation[k, j]), 2);
                    }
                }
            }
            return matrixResult;
        }
    }
}

