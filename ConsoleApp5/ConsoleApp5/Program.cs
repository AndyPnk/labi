using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть n: ");
            double n = Convert.ToInt32(Console.ReadLine());

            double LastDigit = (n % 10);
            Console.WriteLine($"Digit: " + LastDigit);

            Console.ReadKey();
        }
    }
}
