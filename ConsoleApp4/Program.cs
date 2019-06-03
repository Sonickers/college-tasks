using System;

namespace ConsoleApp4
{
    class Program
    {
        static int potega(int n, int m)
        {
            if (m == 1)
                return n;
            else
                return potega(n, m - 1) * n;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(potega(2, 10));
        }
    }
}