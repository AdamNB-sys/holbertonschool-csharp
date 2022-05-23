using System;

class Program
{
    static void Main(string[] args)
    {
        double[] vector1 = { 9, -12 };
        double[] vector2 = { 4, 18 };

        // product = VectorMath.DotProduct(vector1, vector2);

        // Console.WriteLine("(" + result[0] + ", " + result[1] + ")");
        // Console.WriteLine("(" + result[0] + ", " + result[1] + ", " + result[2] + ")");
        // Console.WriteLine("(" + result[0] + ")");
        Console.WriteLine(VectorMath.DotProduct(vector1, vector2));
    }
}
