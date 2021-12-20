using System;

namespace Area_of_circle
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Area of Circle Calculation\n");
            Console.Write("Enter the radius of circle: ");
            double r = double.Parse(Console.ReadLine());
            double a = Math.PI * r * r;

            Console.WriteLine($"Area of Circle is {a } unit square.");
        }
    }
}
