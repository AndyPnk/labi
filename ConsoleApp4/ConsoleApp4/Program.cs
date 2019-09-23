using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть а: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введiть b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введiть h: ");
            double h = Convert.ToDouble(Console.ReadLine());

            double area =(a+b)/2*h;

            Console.WriteLine($"Area: " + area);

            Console.ReadKey();
        }
    }
}
