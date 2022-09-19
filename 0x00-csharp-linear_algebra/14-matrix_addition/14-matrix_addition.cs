using System;

/// <summary> Class MatrixMath performs computations with matrices </summary>
class MatrixMath
{
    /// <summary>
    /// This method adds two matrices and returns the result as a matrix
    /// </summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] matrixResult;
        if ((matrix1.GetLength(0) == 2 && matrix1.GetLength(1) == 2) && matrix1.GetLength(0) == matrix2.GetLength(0))
        {
            matrixResult = new double[2,2];
        }
        else if ((matrix1.GetLength(0) == 3 && matrix1.GetLength(1) == 3) && matrix1.GetLength(0) == matrix2.GetLength(0))
        {
            matrixResult = new double[3,3];
        }
        else
        {
            matrixResult = new double[1, 1]{{-1}};
            return matrixResult;
        }

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                matrixResult[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        return matrixResult;
    }
}

