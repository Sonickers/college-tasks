using System;

namespace ConsoleApp1
{
    class Program
    {
        static void fun1(double x1, double x2)
        {
            Console.WriteLine(1 / (x1 * x1 + x2 * x2)); 
        }
        
        static void Main(string[] args)
        {
            double x = 0.3;
            double y = 0.5;
            fun1(x, y);
        }
            
    }
    
}