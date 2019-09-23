using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

            Console.Write("Введiть а: ");
            double a = Convert.ToInt32(Console.ReadLine());
           
            Console.Write("Введiть b: ");
            double b = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введiть c: ");
            double c = Convert.ToInt32(Console.ReadLine());
            
            

            double averange = (a + b + c) / 3;

            Console.WriteLine("Averange: " + averange);


            Console.ReadKey();
        }
    }
}
