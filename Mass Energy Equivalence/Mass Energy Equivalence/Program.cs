using System;

namespace Mass_Energy_Equivalence
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Mass Energy Equicalence Calculation\n");
            double c = 3.00e8;
            Console.Write("Enter the mass of body in kg: ");
            double m = double.Parse(Console.ReadLine());
            double e = m * c * c;

            Console.WriteLine($"Energy(E) = {e}J");
        }
    }
}
