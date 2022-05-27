using System;

class MatrixMath
{
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double[,] result;

        if (vector.Length == 2)
        {
            result = new double[2] {(vector[0] * scalar), (vector[1] * scalar)};
        }
        else if (vector.Length == 3)
        {
            result = new double[3] {(vector[0] * scalar), (vector[1] * scalar), (vector[2] * scalar)};
        }
        return result;
    }
}
