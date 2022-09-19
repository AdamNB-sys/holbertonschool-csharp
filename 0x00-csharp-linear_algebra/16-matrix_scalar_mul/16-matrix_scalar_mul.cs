using System;

/// <summary> Class MatrixMath performs mathematical functions on matrices </summary>
class MatrixMath
{
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double[,] matrixScaled;
        if ((matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2))
        {
            matrixScaled = new double[2,2];
        }
        else if ((matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3))
        {
            matrixScaled = new double[3,3];
        }
        else
        {
            matrixScaled = new double[1, 1]{{-1}};
            return matrixScaled;
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] *= scalar;
            }
        }
        return matrix;
    }
}

