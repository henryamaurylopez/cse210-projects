// Program: prompts for a name and favorite number, squares the number, and displays the result.
// Import Console utilities for reading input and writing output.
using System;

// Holds the entry point and helper methods for this console program.
class Program
{
    /// <summary>Coordinates the prompts, calculation, and result display.</summary>
    /// <param name="args">Command-line arguments; this program does not use them.</param>
    /// <returns>Nothing.</returns>
    static void Main(string[] args)
    {
        // Show the program's welcome message.
        DisplayWelcome();
        // Separate the welcome message from the prompts.
        Console.WriteLine("");

        // Ask for and store the user's name.
        string userName = PromptUserName();
        // Ask for and store the user's favorite number.
        int favoriteNumber = PromptUserNumber();
        // Calculate the square of the favorite number.
        int squaredNumber = SquareNumber(favoriteNumber);

        // Separate the prompts from the result.
        Console.WriteLine("");
        // Display the result with the user's name.
        DisplayResult(userName, squaredNumber);
    }

    /// <summary>Displays the program's welcome message.</summary>
    /// <returns>Nothing.</returns>
    static void DisplayWelcome()
    {
        // Print the welcome text.
        Console.WriteLine("Welcome to the Program!");
    }

    /// <summary>Prompts for and returns the user's name.</summary>
    /// <returns>The name entered by the user.</returns>
    static string PromptUserName()
    {
        // Ask the user to enter their name.
        Console.Write("Please enter your name: ");
        // Read the name from the console.
        string userName = Console.ReadLine();
        // Return the entered name to the caller.
        return userName;
    }

    /// <summary>Prompts for and returns the user's favorite number.</summary>
    /// <returns>The favorite number entered by the user.</returns>
    static int PromptUserNumber()
    {
        // Ask the user to enter their favorite number.
        Console.Write("Please enter your favorite number: ");
        // Read the number as text.
        string numberInput = Console.ReadLine();
        // Convert the text input to an integer.
        int favoriteNumber = int.Parse(numberInput);
        // Return the converted favorite number to the caller.
        return favoriteNumber;
    }

    /// <summary>Calculates and returns the square of a number.</summary>
    /// <param name="number">The integer to multiply by itself.</param>
    /// <returns>The input number multiplied by itself.</returns>
    static int SquareNumber(int number)
    {
        // Multiply the number by itself to calculate its square.
        int squaredNumber = number * number;
        // Return the calculated square to the caller.
        return squaredNumber;
    }

    /// <summary>Displays the user's name and the square of their favorite number.</summary>
    /// <param name="userName">The user's name to include in the result.</param>
    /// <param name="squaredNumber">The calculated square to display.</param>
    /// <returns>Nothing.</returns>
    static void DisplayResult(string userName, int squaredNumber)
    {
        // Print the personalized result sentence.
        Console.WriteLine($"{userName}, the square of your favorite number is {squaredNumber}.");
    }
}