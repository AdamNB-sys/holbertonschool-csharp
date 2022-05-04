using System;

namespace _12_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x < 101; x++)
            {
                if (x % 3 == 0)
                    Console.Write("Fizz");
                if (x % 5 == 0)
                    Console.Write("Buzz");
                if (x % 3 != 0 && x % 5 != 0)
                    Console.Write(x);
                Console.Write(" ");
            }
        }
    }
}
