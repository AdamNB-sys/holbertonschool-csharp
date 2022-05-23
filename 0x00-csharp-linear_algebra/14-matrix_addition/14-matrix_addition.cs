using System;


///<summary> MatrixMath does math on matrices </summary>
class MatrixMath
{
    ///<summary> Matrix Add takes two matrices and returns the result as a new matrix </summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] matrixAdded;
        if ((matrix1.GetLength(0) == 2 && matrix1.GetLength(1) == 2) && matrix1.GetLength(0) == matrix2.GetLength(0))
        {
            matrixAdded = new double[2,2];
        }
        else if ((matrix1.GetLength(0) == 3 && matrix1.GetLength(1) == 3) && matrix1.GetLength(0) == matrix2.GetLength(0))
        {
            matrixAdded = new double[3,3];
        }
        else
        {
            matrixAdded = new double[,]{{-1}};
        }

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                matrixAdded[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        return matrixAdded;
    }
}
