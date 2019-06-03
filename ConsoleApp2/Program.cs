
using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static double leibniz(int n)
        {
            double sum = 0;
            double temp = 0;
            for (int i = 0; i < n; i++)
            {
                temp = Math.Pow(-1, i) / (2 * i+ 1);
                sum += temp;
            }
            return sum*4;
        }

        static void Main()
        {
            Console.WriteLine(leibniz(10000000));
        }
    }
}