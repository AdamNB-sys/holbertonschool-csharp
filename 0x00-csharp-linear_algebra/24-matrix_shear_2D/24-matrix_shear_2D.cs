using System;


/// <summary> Class MatrixMath performs mathematical functions on matrices </summary>
class MatrixMath
{
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] {{-1}};

        switch (direction)
        {
            case 'x':
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    matrix[i, 0] += matrix[i, 1] * factor;
                }
                return matrix;
            case 'y':
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    matrix[i, 1] += matrix[i, 0] * factor;
                }
                return matrix;
            default:
                return new double[,] {{-1}};
        }
    }
}

