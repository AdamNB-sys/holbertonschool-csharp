using System;

class Program
{
    static void Main()
    {
        double[] vector1 = {9, -7, 4};
        double[] vector2 = {4, 90, 5};
        double[] result = VectorMath.Add(vector1, vector2);
        Console.WriteLine(result[0] + result[1] + result[2]);
    }
}
