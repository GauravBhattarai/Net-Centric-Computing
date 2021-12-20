using System;

namespace Gravitational_Force
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Gravitational Force Calculation\n");
            double G = 6.67e-11;
            Console.WriteLine("Enter mass of first body: ");
            double m1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter mass of second body: ");
            double m2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter distance between two bodies: ");
            double r = double.Parse(Console.ReadLine());

            double f = (G * m1 * m2) / (r * r);

            Console.WriteLine($"Force = {f} N");

        }
    }
}
