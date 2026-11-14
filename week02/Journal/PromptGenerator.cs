// Purpose: Loads, selects, displays, adds, and removes writing prompts stored in prompts.txt.
using System; // Provides random number generation and console input/output.

/// <summary>Manages writing prompts stored in the prompts.txt file.</summary>
public class PromptGenerator
{
    /// <summary>Holds prompt text loaded from the prompt file.</summary>
    public List<string> _prompts = new List<string>();

    /// <summary>Appends prompt lines from prompts.txt to the in-memory prompt list.</summary>
    /// <returns>Nothing; prompts read from the file are added to <see cref="_prompts"/>.</returns>
    public void FillList()
    {
        // Open the prompt file so each line can be read.
        using (StreamReader reader = new StreamReader("prompts.txt"))
        {
            // Hold the next line read from the file.
            string line;
            // Read until the file has no more lines.
            while ((line = reader.ReadLine()) != null)
            {
                // Add this prompt to the in-memory list.
                _prompts.Add(line);
            }
        }
    }

    /// <summary>Selects and returns one prompt at random from the in-memory list.</summary>
    /// <returns>A randomly selected prompt string.</returns>
    public string GetRandomPrompt()
    {
        // Create a random-number generator for selecting a prompt position.
        Random random = new Random();
        // Choose a valid zero-based index within the prompt list.
        int index = random.Next(_prompts.Count());
        // Return the prompt stored at the selected position.
        return _prompts[index];
    }

    /// <summary>Appends a new prompt to prompts.txt.</summary>
    /// <param name="prompt">The prompt text to add to the file.</param>
    /// <returns>Nothing; the prompt is written as a new file line.</returns>
    public void AddPrompt(string prompt)
    {
        // Open the prompt file in append mode so existing prompts are preserved.
        using (StreamWriter writer = new StreamWriter("prompts.txt", true))
        {
            // Write the new prompt as a separate line.
            writer.WriteLine(prompt);
        }
    }

    /// <summary>Prints the in-memory prompts with one-based numbers, then clears the list.</summary>
    /// <returns>Nothing; the prompt list is written to the console.</returns>
    public void DisplayPrompts()
    {
        // Label the list shown to the user.
        Console.WriteLine("Prompts:");

        // Visit each prompt so it can be printed with a number.
        foreach (string prompt in _prompts)
        {
            // Find the prompt's position and convert it to a one-based display number.
            int count = _prompts.IndexOf(prompt) + 1;
            // Print the number and prompt text together.
            Console.WriteLine($"{count}. {prompt}");
        }

        // Clear the list so a later file load does not add duplicate prompts.
        _prompts.Clear(); // Clear the list after displaying to avoid duplicates on subsequent displays
    }

    /// <summary>Removes the prompt at a valid list index and rewrites prompts.txt.</summary>
    /// <param name="index">The zero-based index of the prompt to remove.</param>
    /// <returns>Nothing; success or an invalid index is reported in the console.</returns>
    public void RemovePrompt(int index)
    {
        // Check that the index is greater than zero and within the list bounds.
        if (index > 0 && index < _prompts.Count)
        {
            // Remove the prompt at the requested position.
            _prompts.RemoveAt(index);
            // Open the file in overwrite mode to replace it with the updated prompt list.
            using (StreamWriter writer = new StreamWriter("prompts.txt"))
            {
                // Write each remaining prompt back to the file.
                foreach (string prompt in _prompts)
                {
                    // Store one prompt on each line.
                    writer.WriteLine(prompt);
                }
            }
            // Confirm that the prompt was removed.
            Console.WriteLine("Prompt removed successfully.");
        }
        // Handle an index that does not pass the range check.
        else
        {
            // Tell the user to choose a valid prompt number.
            Console.WriteLine("Invalid index. Please try again.");
        }
    }
}