using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;
        int count = 0;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            string response = Console.ReadLine();
            guess = int.Parse(response);
            count++;

            if (guess > magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

        Console.WriteLine($"It took you {count} guesses.");
    }
}