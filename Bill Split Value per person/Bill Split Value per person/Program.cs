using System;

namespace Bill_Split_Value_per_person
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Bill split value per person (2 people)(in an apartment) calculation... \n");
            Console.Write("Enter your roommate salary: Rs. ");
            decimal salary1 = decimal.Parse(Console.ReadLine());
            Console.Write("Enter your salary: Rs. ");
            decimal salary2 = decimal.Parse(Console.ReadLine());
            Console.Write("Enter total amount to pay: Rs. ");
            decimal totalamount = decimal.Parse(Console.ReadLine());
            decimal share = totalamount * (salary1 / (salary1 + salary2));
            Console.WriteLine($"Roommate share = Rs.{ share}");
            Console.WriteLine($"Yours share = Rs. {totalamount - share}");

        }
}
}
