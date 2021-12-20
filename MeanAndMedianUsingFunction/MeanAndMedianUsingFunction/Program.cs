using System;

namespace Mean_and_median
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Mean and Median Calculation\n");
            double[] num = { 6, 1, 8, 4, 2, 7, 5 };
            double sum = 0;
            double mean = MeanCalculate(num, ref sum);

            double md = MedianCalculate(num);
            Console.WriteLine($"Mean = {mean} \n Median = {md}");
        }

        private static double MedianCalculate(double[] num)
        {
            Array.Sort(num);
            double mdn = (num.Length + 1) / 2.0;
            double md = 0;
            if (num.Length % 2 == 0)
                md = (num[(int)mdn - 1] + num[(int)mdn]) / 2.0;
            else
                md = num[(int)mdn - 1];
            return md;
        }

        private static double MeanCalculate(double[] num, ref double sum)
        {
            foreach (double element in num)
            {
                sum += element;
            }

            double mean = sum / num.Length;
            return mean;
        }
    }
}
