using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть число а: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введiть число b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введiть число c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if ((a > b) && (a > c))
                Console.WriteLine($"Найбiльше а {a}");

            if ((b > a) && (b > c))
                Console.WriteLine($"Найбiльше b {b}");

            if ((c > a) && (c > b))
                Console.WriteLine($"Найбiльше c {c}");

        }
    }
}
