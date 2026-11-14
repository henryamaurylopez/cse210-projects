// Purpose: Stores journal entries and supports displaying, loading, and saving them.
using System; // Provides date and console utilities.
using System.IO; // Provides file-reading and file-writing utilities.
using System.Collections.Generic; // Provides the List collection.
using System.Linq; // Provides projection of entries into file lines.

/// <summary>Holds journal entries and provides operations for working with them.</summary>
public class Journal
{
    /// <summary>Stores the entries currently loaded into the journal.</summary>
    public List<Entry> _entries = new List<Entry>();

    /// <summary>Prompts for an entry response, assigns its date, and stores it in the journal.</summary>
    /// <param name="entry">The entry to complete and add to the journal.</param>
    /// <returns>Nothing; the completed entry is added to <see cref="_entries"/>.</returns>
    public void AddEntry(Entry entry)
    {
        // Stamp the entry with the current date in month/day/year format.
        entry._date = DateTime.Now.ToString("MM/dd/yyyy");

        // Show the writing prompt associated with this entry.
        Console.WriteLine($"Prompt: {entry._promptText}");

        // Ask the user to enter the journal response.
        Console.Write("Enter your response: ");
        // Store the response in the entry.
        entry._entryText = Console.ReadLine();

        // Keep the completed entry in this journal.
        _entries.Add(entry);
    }

    /// <summary>Displays each journal entry currently stored in memory.</summary>
    /// <returns>Nothing; the entries are written to the console.</returns>
    public void DisplayAll()
    {
        // Handle the empty journal without starting the display loop.
        if (_entries.Count == 0)
        {
            // Tell the user there are no entries to show.
            Console.WriteLine("No entries to display.");
            // Stop this method because there are no entries to display.
            return;
        }
        // Visit each entry in the journal.
        foreach (Entry entry in _entries)
        {
            // Display the entry's date, prompt, and response.
            entry.Display();
            // Separate consecutive entries with a blank line.
            Console.WriteLine(); // Add a blank line between entries for better readability
        }
    }

    /// <summary>Writes the journal entries to a user-specified file if that file exists.</summary>
    /// <param name="file">An initial filename value; the method asks the user for the actual filename.</param>
    /// <returns>Nothing; the result is written to the file or reported in the console.</returns>
    public void SaveToFile(string file)
    {
        // Ask the user which existing file should receive the journal entries.
        Console.Write("Enter the filename to save the journal: ");
        // Use the filename entered by the user.
        file = Console.ReadLine();

        // Only write to the requested path when it already exists.
        if (File.Exists(file))
        {
            // Convert each entry to a line and write all lines to the file.
            File.WriteAllLines(file, _entries.Select(entry => entry.ToString()));

            // Confirm where the journal was saved.
            Console.WriteLine($"Journal saved to '{file}'.");
        }
        // Report that the requested file was not found.
        else
        {
            // Ask the user to provide another filename.
            Console.WriteLine("That file does not exists. Please enter another filename.");
        }
    }

    /// <summary>Loads valid journal entries from a user-specified file into memory.</summary>
    /// <param name="file">An initial filename value; the method asks the user for the actual filename.</param>
    /// <returns>Nothing; matching entries are added to <see cref="_entries"/>.</returns>
    public void LoadFromFile(string file)
    {
        // Ask the user which file contains the journal entries.
        Console.Write("Enter the filename to load the journal: ");
        // Use the filename entered by the user.
        file = Console.ReadLine();

        // Read the file only when it exists at the requested path.
        if (File.Exists(file))
        {
            // Read the file as an array with one serialized entry per line.
            string[] lines = File.ReadAllLines(file);
            // Replace the current in-memory entries with the file contents.
            _entries.Clear();

            // Process each serialized entry line.
            foreach (string line in lines)
            {
                // Split a line into date, prompt, and response fields.
                string[] parts = line.Split("|");
                // Accept the line only when all three fields are present.
                if (parts.Length == 3)
                {
                    // Recreate an entry from the three saved fields.
                    Entry entry = new Entry
                    {
                        // Restore the entry date from the first field.
                        _date = parts[0],
                        // Restore the prompt from the second field.
                        _promptText = parts[1],
                        // Restore the response from the third field.
                        _entryText = parts[2]
                    };
                    // Add the reconstructed entry to the journal.
                    _entries.Add(entry);
                }
            }
        }

        // Report a missing file instead of attempting to read it.
        else
        {
            // Tell the user which requested file could not be found.
            Console.WriteLine($"File '{file}' does not exist.");
        }
    }
}