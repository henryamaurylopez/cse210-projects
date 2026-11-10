// Program: runs a number-guessing game where the user guesses a randomly selected number.
// Import Console and Random utilities used by the game.
using System;

// Holds the entry point for this console program.
class Program
{
    /// <summary>Chooses a random number and gives the user feedback until they guess it.</summary>
    /// <param name="args">Command-line arguments; this program does not use them.</param>
    /// <returns>Nothing.</returns>
    static void Main(string[] args)
    {
        // Create a random-number generator.
        Random randomGenerator = new Random();
        // Choose the secret number from 1 through 100 (the upper bound is exclusive).
        int magicNumberInt = randomGenerator.Next(1, 101);

        // Explain the goal of the game to the user.
        Console.WriteLine("Welcome to the Number Guessing Game! Try to guess the random number.");

        // Prompt for the user's first guess.
        Console.Write("What is your guess? ");
        // Read the guess as text.
        string guess = Console.ReadLine();
        // Convert the guess to an integer.
        int guessInt = int.Parse(guess);

        // Continue asking while the guess is not equal to the secret number.
        while (guessInt != magicNumberInt)
        {
            // Tell the user to guess lower when their guess is too high.
            if (guessInt > magicNumberInt)
            {
                Console.WriteLine("Enter a lower number.");
            }
            // Tell the user to guess higher when their guess is too low.
            else if (guessInt < magicNumberInt)
            {
                Console.WriteLine("Enter a higher number.");
            }

            // Ask for another guess.
            Console.Write("What is your guess? ");
            // Read the next guess.
            guess = Console.ReadLine();
            // Convert the next guess to an integer for comparison.
            guessInt = int.Parse(guess);
        }

        // Congratulate the user after the secret number is guessed.
        Console.WriteLine("Congratulations! You guessed it.");
    }
}