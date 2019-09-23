using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть N: ");
            double n = Convert.ToInt32(Console.ReadLine());
            if ((n > 20) && (n % 2 != 0))
                Console.WriteLine("True");
            
            else
                Console.WriteLine("False");





            Console.ReadKey();
        }
    }
}
