using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumberInt = randomGenerator.Next(1, 101);

        Console.WriteLine("Welcome to the Number Guessing Game! Try to guess the random number.");

        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int guessInt = int.Parse(guess);

        while (guessInt != magicNumberInt)
        {
            if (guessInt > magicNumberInt)
            {
                Console.WriteLine("Enter a lower number.");
            }
            else if (guessInt < magicNumberInt)
            {
                Console.WriteLine("Enter a higher number.");
            }

            Console.Write("What is your guess? ");
            guess = Console.ReadLine();
            guessInt = int.Parse(guess);
        }

        Console.WriteLine("Congratulations! You guessed it.");
    }
}