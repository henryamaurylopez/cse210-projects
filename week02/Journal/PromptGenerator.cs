using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public void FillList()
    {
        using (StreamReader reader = new StreamReader("prompts.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                _prompts.Add(line);
            }
        }
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count());
        return _prompts[index];
    }

    public void AddPrompt(string prompt)
    {
        using (StreamWriter writer = new StreamWriter("prompts.txt", true))
        {
            writer.WriteLine(prompt);
        }
    }

    public void DisplayPrompts()
    {
        Console.WriteLine("Prompts:");

        foreach (string prompt in _prompts)
        {
            int count = _prompts.IndexOf(prompt) + 1;
            Console.WriteLine($"{count}. {prompt}");
        }

        _prompts.Clear(); // Clear the list after displaying to avoid duplicates on subsequent displays
    }

    public void RemovePrompt(int index)
    {
        if (index > 0 && index < _prompts.Count)
        {
            _prompts.RemoveAt(index);
            using (StreamWriter writer = new StreamWriter("prompts.txt"))
            {
                foreach (string prompt in _prompts)
                {
                    writer.WriteLine(prompt);
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid index. Please try again.");
        }
    }
}