using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Введiть число: ");
            double number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введiть n: ");
            double n = Convert.ToInt32(Console.ReadLine());
            
            int nDigit =Convert.ToInt32 (number/Math.Pow(10, n-1) % 10);
            if (nDigit == 0)
                Console.WriteLine("Error");

            else
                nDigit = nDigit - 1;
                Console.WriteLine($"Вiдповiдь: " + nDigit);


            Console.ReadKey();
           
        }
    }
}
