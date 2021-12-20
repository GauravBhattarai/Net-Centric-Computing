using System;

namespace Area_of_circle
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Volume of sphere calculation\n");
            Console.Write("Enter the radius of sphere: ");
            double r = double.Parse(Console.ReadLine());
            double a = (4 * Math.PI * r * r * r) / 3;

            Console.WriteLine($"Volume of sphere is {a } unit cube.");
        }
    }
}
