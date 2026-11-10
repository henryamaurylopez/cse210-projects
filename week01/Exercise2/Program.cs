// Program: converts a numeric percentage into a letter grade and reports whether the user passed.
// Import Console utilities for reading input and writing output.
using System;

// Holds the entry point for this console program.
class Program
{
    /// <summary>Reads a grade percentage, determines its letter grade, and reports pass status.</summary>
    /// <param name="args">Command-line arguments; this program does not use them.</param>
    /// <returns>Nothing.</returns>
    static void Main(string[] args)
    {
        // Prepare the letter and optional plus/minus suffix for the grade.
        string letter = "";
        string sign = "";

        // Ask the user to enter a percentage grade.
        Console.Write("Hello! What is your grade percentage? ");
        // Read the entered grade as text.
        string gradeInput = Console.ReadLine();
        // Convert the text input to an integer percentage.
        int grade = int.Parse(gradeInput);

        // Assign an A to percentages of 90 or higher.
        if (grade >= 90)
        {
            // Store the base letter grade.
            letter = "A";
            // Add a minus sign to A grades below 93.
            if (grade < 93)
            {
                sign = "-";
            }
        }
        // Otherwise, assign a B to percentages of 80 through 89.
        else if (grade >= 80)
        {
            // Store the base letter grade.
            letter = "B";
            // Add a minus sign to B grades below 83.
            if (grade < 83)
            {
                sign = "-";
            }
            // Add a plus sign to B grades of 87 or higher.
            else if (grade >= 87)
            {
                sign = "+";
            }
        }
        // Otherwise, assign a C to percentages of 70 through 79.
        else if (grade >= 70)
        {
            // Store the base letter grade.
            letter = "C";
            // Add a minus sign to C grades below 73.
            if (grade < 73)
            {
                sign = "-";
            }
            // Add a plus sign to C grades of 77 or higher.
            else if (grade >= 77)
            {
                sign = "+";
            }
        }
        // Otherwise, assign a D to percentages of 60 through 69.
        else if (grade >= 60)
        {
            // Store the base letter grade.
            letter = "D";
            // Add a minus sign to D grades below 63.
            if (grade < 63)
            {
                sign = "-";
            }
            // Add a plus sign to D grades of 67 or higher.
            else if (grade >= 67)
            {
                sign = "+";
            }
        }
        // Grades below 60 receive an F.
        else
        {
            letter = "F";
        }

        // Display the letter grade and any plus/minus suffix.
        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        // Tell the user they passed when their percentage is at least 70.
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        // Otherwise, tell the user they did not pass.
        else
        {
            Console.WriteLine("Unfortunately, you did not pass the course. Better luck next time!");
        }
    }
}