using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть n: ");
            double n = Convert.ToInt32(Console.ReadLine());

            if ((n % 9 == 0) || (n % 11 == 0) || (n % 13 == 0))
                Console.WriteLine("True");

            else
                Console.WriteLine("False");

            Console.ReadKey();
        }
    }
}
