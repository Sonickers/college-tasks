using System;

namespace ConsoleApp3
{
    class Program
    {
        static int sum_n(int n)
        {
            if (n == 1)
                return 1;
            else
                return sum_n(n - 1) + n;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Sum of digits from 1 to 10 is: " + sum_n(10));
        }
    }
}