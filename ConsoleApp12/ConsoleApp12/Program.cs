using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть а: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введiть b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введiть c: ");
            double c = Convert.ToDouble(Console.ReadLine());


            if (a * b * c > 0)
                Console.WriteLine("Positive");
            else
                Console.WriteLine("Negative");
        }
    }
}
