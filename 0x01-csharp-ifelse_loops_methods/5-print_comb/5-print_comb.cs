using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 99)
            {
                Console.Write($"{i:D2}, ");
                i++;
            }
            Console.Write("99\n");
        }
    }
}
