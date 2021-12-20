using System;

namespace Multiplication
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Multiplication Table Generation\n");
            int i;
            Console.Write("Enter the number for multiplication: ");
            double n = double.Parse(Console.ReadLine());

            for(i=1; i<=10; i++)
                {
                    Console.Write("{0} * {1} = {2} \n", n, i, n * i);
                }

        }
    }
}
