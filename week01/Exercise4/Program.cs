// Program: collects numbers until the user enters zero, then reports their sum, count, average, and maximum.
// Import Console utilities for reading input and writing output.
using System;

// Holds the entry point for this console program.
class Program
{
    /// <summary>Collects numbers until zero is entered and displays summary statistics.</summary>
    /// <param name="args">Command-line arguments; this program does not use them.</param>
    /// <returns>Nothing.</returns>
    static void Main(string[] args)
    {
        // Store each entered number so it can be listed and analyzed later.
        List<int> numbers = new List<int>();
        // Track the sum of all numbers entered before the sentinel zero.
        int totalAmount = 0;
        // Track how many numbers were entered before the sentinel zero.
        int totalItems = 0;

        // Explain that entering zero ends number collection.
        Console.WriteLine("Create a list of numbers. Type '0' when finished.");
        // Prompt for the first number.
        Console.Write("Enter another number: ");
        // Read the first input as text so zero can end the loop.
        string input = Console.ReadLine();

        // Continue collecting numbers until the input text is zero.
        while (input != "0")
        {
            // Convert the input text to an integer.
            int number = int.Parse(input);
            // Add the number to the list.
            numbers.Add(number);
            // Add the number to the running sum.
            totalAmount += number;
            // Increase the count of entered numbers.
            totalItems++;
            // Prompt for the next number.
            Console.Write("Enter another number: ");
            // Read the next input.
            input = Console.ReadLine();
        }

        // Print a blank line to separate input from the summary.
        Console.WriteLine("");
        // Introduce the list of numbers.
        Console.WriteLine("The list contains the following numbers:");
        // Visit each stored number in the list.
        foreach (int n in numbers)
        {
            // Print the current number.
            Console.WriteLine(n);
        }

        // Print a blank line before the totals.
        Console.WriteLine("");
        // Display the sum of the entered numbers.
        Console.WriteLine($"The total amount is: {totalAmount}");
        // Display how many numbers were entered.
        Console.WriteLine($"The total number of items is: {totalItems}");

        // Divide the sum by the count using floating-point arithmetic to calculate the average.
        float average = (float)totalAmount / totalItems;
        // Display the average with two digits after the decimal point.
        Console.WriteLine($"The average is: {average:F2}");

        // Find the greatest number in the list.
        int largestNumber = numbers.Max();
        // Display the greatest number.
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}