using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            double factorial = 1;
            
            Console.WriteLine("Введiть n: ");
            double n = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= n; i++)
                factorial = factorial * i;
            Console.WriteLine($"Factorial: " + factorial);
        }
    }
}
