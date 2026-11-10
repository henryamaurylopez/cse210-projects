// Program: asks for a first and last name, then prints the name in a formatted sentence.
// Import Console utilities for reading input and writing output.
using System;

// Holds the entry point for this console program.
class Program
{
    /// <summary>Reads the user's first and last names and prints the formatted name.</summary>
    /// <param name="args">Command-line arguments; this program does not use them.</param>
    /// <returns>Nothing.</returns>
    static void Main(string[] args)
    {
        // Ask the user for their first name.
        Console.Write("Please enter your first name: ");
        // Store the first name typed by the user.
        string firstName = Console.ReadLine();

        // Ask the user for their last name.
        Console.Write("Please enter your last name: ");
        // Store the last name typed by the user.
        string lastName = Console.ReadLine();

        // Print the last name, first name, and last name in the requested format.
        Console.WriteLine($"My name is {lastName}, {firstName} {lastName}.");
    }
}