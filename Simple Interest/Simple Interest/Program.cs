using System;

namespace Simple_Interest
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Simple Interest Calculation\n")
            Console.Write("Principle: ");
            double p = double.Parse(Console.ReadLine());

            Console.Write("Time: ");
            double t = double.Parse(Console.ReadLine());

            Console.Write("Rate: ");
            double r = double.Parse(Console.ReadLine());

            double i = p * t * r / 100;
            Console.WriteLine($"Interest= {i}");

        }
    }
}
