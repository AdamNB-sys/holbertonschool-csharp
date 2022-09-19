using System;


/// <summary> Class MatrixMath performs mathematical functions on matrices </summary>
class MatrixMath
{
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        double[,] matrixResult;
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
        {
            matrixResult = new double[1, 1]{{-1}};
            return matrixResult;
        }
        else
        {
            matrixResult = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
            for (int i = 0; i < matrixResult.GetLength(0); i++) // rows of matrixResult
            {
                for (int j = 0; j < matrixResult.GetLength(1); j++) // columns of matrixResult
                {
                    matrixResult[i, j] = 0;
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                    {
                        matrixResult[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            return matrixResult;
        }
    }
}

