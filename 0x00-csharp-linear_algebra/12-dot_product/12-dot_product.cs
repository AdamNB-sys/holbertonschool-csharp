using System;

/// <summary>
/// Class VectorMath finds the Dot Product of two passed vectors.
/// </summary>
class VectorMath
{
    /// <summary> 
    /// DotProduct takes in two passed vectors, either 2D or 3D, and
    /// calculates the dot product of the two.
    /// </summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if ((vector1.Length == 2 || vector1.Length == 3) && (vector1.Length == vector2.Length))
        {
            double product = 0;
            for (int i = 0; i < vector1.Length; i++)
            {
                product += vector1[i] * vector2[i];
            }
            return product;
        }
        else
        {
            return -1;
        }
    }
}

