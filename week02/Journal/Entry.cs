// Purpose: Represents one dated journal response and can display or serialize it.
using System; // Provides console output.

/// <summary>Represents a journal entry containing a date, prompt, and response.</summary>
public class Entry
{
    /// <summary>The date on which the journal entry was created.</summary>
    public string _date;
    /// <summary>The writing prompt associated with this entry.</summary>
    public string _promptText;
    /// <summary>The user's response to the prompt.</summary>
    public string _entryText;

    /// <summary>Prints the date, prompt, and response for this entry.</summary>
    /// <returns>Nothing; the entry details are written to the console.</returns>
    public void Display()
    {
        // Print the date associated with the entry.
        Console.WriteLine($"Date: {_date}");
        // Print the prompt that inspired the entry.
        Console.WriteLine($"Prompt: {_promptText}");
        // Print the user's written response.
        Console.WriteLine($"Entry: {_entryText}");
    }

    /// <summary>Converts this entry into a pipe-separated line for file storage.</summary>
    /// <returns>The date, prompt, and response joined by pipe characters.</returns>
    public override string ToString()
    {
        // Return the three entry fields in the format expected by Journal.LoadFromFile.
        return $"{_date}|{_promptText}|{_entryText}";
    }
}