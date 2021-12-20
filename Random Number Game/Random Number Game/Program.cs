using System;

namespace Random_Number_Game
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Random Number Guessing Game\n");
            string choice;

            do
            {
                Random random = new Random();
                int randomnum = random.Next(1, 101);
                bool userWin = false;

                for (int i = 1; i <= 5; i++)
                {
                    Console.Write("Guess the number between 1 and 100 : ");
                    int guess = int.Parse(Console.ReadLine());
                    if (guess == randomnum)
                    {
                        Console.WriteLine("Hooray! You won\n");
                        userWin = true;
                        break;
                    }

                    else if (guess > randomnum)
                    {
                        Console.WriteLine("Sorry!! The guess number is greater than my number.\n");
                    }
                    else
                    {
                        Console.WriteLine("Sorry!! The guess number is smaller than my number.\n");
                    }
                }
                if (!userWin)
                {
                    Console.WriteLine("Oh no! You lost the game.\n");
                    Console.WriteLine($"The correct answer is {randomnum}\n");
                }
                Console.WriteLine("Do you want to continue? (Y/N)");
                choice = Console.ReadLine().ToUpper();
            } while (choice == "Y");


        }
    }
}
