using System;

namespace Geometric_mean
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Geometric Mean Calculation\n");
            int[] data = { 5, 10, 15, 20, 25 };
            int value = 1;
            for (int i = 0; i < data.Length; i++)
            {
                value = value * data[i];
            }
            double result = Math.Pow(value, 1.0 / data.Length);

            Console.WriteLine($"Geometric Mean = {result}");

        }
    }
}
