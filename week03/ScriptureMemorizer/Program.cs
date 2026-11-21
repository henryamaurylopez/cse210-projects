using System;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Runs a scripture memorization game. It displays a scripture and progressively
/// replaces random words with underscores until the player quits or every word is hidden.
/// </summary>
class Program
{
    /// <summary>
    /// Creates the scripture and manages the user's memorization loop.
    /// </summary>
    /// <param name="args">Command-line arguments supplied when the program starts.</param>
    static void Main(string[] args)
    {
        // Create the reference for John 3:16.
        Reference reference = new Reference("Juan", 3, 16);

        // Store the scripture text together with its reference.
        Scripture scripture = new Scripture
        (
            reference,
            "Porque de tal manera amo Dios al mundo que ha dado a Su Hijo Unigenito para que todo aquel que en El cree no se pierda mas tenga vida eterna."
        );

        // Continue the game until the player quits or every word is hidden.
        while (scripture.IsCompletelyHidden() == false)
        {
            // Display the current reference and scripture text.
            Console.WriteLine(scripture.GetDisplayText());

            // Print a blank line for readability.
            Console.WriteLine("");

            // Ask the player whether to hide words or quit.
            Console.Write("Click 'Enter' to hide some words from the scripture or type 'quit' to end the program. ");

            // Read the player's response.
            string input = Console.ReadLine();

            // End the loop if the player types quit.
            if (input == "quit")
            {
                break;
            }

            // Clear the console so the next view starts fresh.
            Console.Clear();

            // Hide three more randomly selected words.
            scripture.HideRandomWords(3);
        }
    }
}