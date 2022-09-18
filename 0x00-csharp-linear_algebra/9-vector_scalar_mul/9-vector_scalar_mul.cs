using System;

/// <summary>
/// Class Vector Math does scalar multiplication on 2D and 3D vectors
/// </summary>
class VectorMath
{
    /// <summary> Takes in 2D or 3D vector and multiplies it by the passed scalar </summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length == 2 || vector.Length == 3)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] *= scalar;
            }
            return vector;
        }
        else
        {
            return new double[1] { -1 };
        }
    }
}
