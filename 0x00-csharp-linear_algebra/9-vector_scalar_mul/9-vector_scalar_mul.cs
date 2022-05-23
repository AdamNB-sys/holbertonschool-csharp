using System;

///<summary> Class vector math multiplies two vectors and returns a new vector of the result.</summary>
class VectorMath
{
    ///<summary> Multiply takes in two vectors, adds them, and returns the new vector.</summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] result = new double[1] {-1};

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
