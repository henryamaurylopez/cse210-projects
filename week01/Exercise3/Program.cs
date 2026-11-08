using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string magicNumber = Console.ReadLine();
        int magicNumberInt = int.Parse(magicNumber);

        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int guessInt = int.Parse(guess);

        while (guessInt != magicNumberInt)
        {
            if (guessInt > magicNumberInt)
            {
                Console.WriteLine("Enter a lower guess.");
            }
            else if (guessInt < magicNumberInt)
            {
                Console.WriteLine("Enter a higher guess.");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed it.");
                break;
            }

            Console.Write("What is your guess? ");
            guess = Console.ReadLine();
            guessInt = int.Parse(guess);
        }
    }
}