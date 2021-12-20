using System;

namespace Body_Mass_Index
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Body Mass Index Calculation\n");
            Console.Write("Enter the weight in kg: ");
            double w = double.Parse(Console.ReadLine());

            Console.Write("Enter the height in meter: ");
            double h = double.Parse(Console.ReadLine());

            double bmi = w / (h * h);

            Console.WriteLine($"Body Mass Index is { bmi}");
        }
    }
}
