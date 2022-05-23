using System;


class Program
{
    static void Main(string[] args)
    {
        double[] vector = { 9, 2, -12 };
        double scalar = 3;
        double[] result;

        result = VectorMath.Multiply(vector, scalar);

        // Console.WriteLine("(" + result[0] + ", " + result[1] + ")");
        Console.WriteLine("(" + result[0] + ", " + result[1] + ", " + result[2] + ")");
        // Console.WriteLine("(" + result[0] + ")");
    }
}
