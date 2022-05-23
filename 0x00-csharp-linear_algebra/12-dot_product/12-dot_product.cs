using System;


///<summary> Class VectorMath does math on vectors. </summary>
class VectorMath
{
    ///<summary> DocProduct takes two vectors and calculates their dot product </summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        double product = -1;
        if ((vector1.Length == 2 || vector1.Length == 3) && (vector1.Length == vector2.Length))
        {
            product = 0;
            for (int i = 0; i < vector1.Length; i++)
            {
                product += vector1[i] * vector2[i];
            }
        }
        return product;
    }
}
