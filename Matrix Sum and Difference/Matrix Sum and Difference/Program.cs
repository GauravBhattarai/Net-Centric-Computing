using System;

namespace Matrix_Sum_and_Difference
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Matrix Sum and Difference Calculation\n");
            int i, j;
            int[,] arr1 = new int[5,5];
            int[,] arr2 = new int[5,5];
            int[,] arr3 = new int[5, 5];
            Console.Write("Enter size of square matrix: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Input elements in the first matrix :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("Element - [{0},{1}] : ", i, j);
                    arr1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("Input elements in the second matrix :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("Element - [{0},{1}] : ", i, j);
                    arr2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                    arr3[i, j] = arr1[i, j] + arr2[i, j];
            Console.Write("\nThe Addition of two matrix is : \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", arr3[i, j]);
            }
            Console.Write("\n\n");

            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                    arr3[i, j] = arr1[i, j] - arr2[i, j];
            Console.Write("\nThe Subtraction of two matrix is : \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", arr3[i, j]);
            }
            Console.Write("\n\n");
        }
    }
}
