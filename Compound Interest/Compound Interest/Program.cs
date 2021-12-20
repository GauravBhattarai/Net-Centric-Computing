using System;

namespace Compound_Interest
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Compound Interest Calculation\n");
            Console.Write("Principle: ");
            double p = double.Parse(Console.ReadLine());

            Console.Write("Time: ");
            double t = double.Parse(Console.ReadLine());

            Console.Write("Annual Rate: ");
            double r1 = double.Parse(Console.ReadLine());
            double r = r1 / 100;

            Console.Write("Number of time interest will be componded: ");
            double n = double.Parse(Console.ReadLine());

            double i = (p * (Math.Pow((1 + r / n), n * t))) - p;

            Console.Write($"Compound Interest= { i}");
        }
    }
}
