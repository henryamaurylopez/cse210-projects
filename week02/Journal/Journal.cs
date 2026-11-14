using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        entry._date = DateTime.Now.ToString("MM/dd/yyyy");

        Console.WriteLine($"Prompt: {entry._promptText}");

        Console.Write("Enter your response: ");
        entry._entryText = Console.ReadLine();

        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine(); // Add a blank line between entries for better readability
        }
    }

    public void SaveToFile(string file)
    {
        Console.Write("Enter the filename to save the journal: ");
        file = Console.ReadLine();

        if (File.Exists(file))
        {
            File.WriteAllLines(file, _entries.Select(entry => entry.ToString()));

            Console.WriteLine($"Journal saved to '{file}'.");
        }
    }

    public void LoadFromFile(string file)
    {
        Console.Write("Enter the filename to load the journal: ");
        file = Console.ReadLine();

        if (File.Exists(file))
        {
            string[] lines = File.ReadAllLines(file);
            _entries.Clear();

            foreach (string line in lines)
            {
                string[] parts = line.Split("|");
                if (parts.Length == 3)
                {
                    Entry entry = new Entry
                    {
                        _date = parts[0],
                        _promptText = parts[1],
                        _entryText = parts[2]
                    };
                    _entries.Add(entry);
                }
            }
        }

        else
        {
            Console.WriteLine($"File '{file}' does not exist.");
        }
    }
}