using System;

class Program
{
    static void Main(string[] args)
    {
        Boolean Quit = false;
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("We hope you have had a great day!");

        while (!Quit)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Edit Prompts");
            Console.WriteLine("6. Quick Tips");
            Console.WriteLine("7. Quit");

            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();
            Console.WriteLine("");

            if (choice == "1")
            {
                // Write
                Entry entry = new Entry();
                entry._promptText = promptGenerator.GetRandomPrompt();
                journal.AddEntry(entry);
                Console.WriteLine("");
            }
            else if (choice == "2")
            {
                // Display
                journal.DisplayAll();
                Console.WriteLine("");
            }
            else if (choice == "3")
            {
                // Load
                journal.LoadFromFile("");
                Console.WriteLine("");
            }
            else if (choice == "4")
            {
                // Save
                journal.SaveToFile("");
                Console.WriteLine("");
            }
            else if (choice == "5")
            {
                Boolean goBack = false;
                while (!goBack)
                {
                    // Edit Prompts
                    Console.WriteLine("Prompt Management:");
                    Console.WriteLine("1. Display Prompts");
                    Console.WriteLine("2. Add Prompt");
                    Console.WriteLine("3. Remove Prompt");
                    Console.WriteLine("4. Go Back");
                    Console.Write("What would you like to do? ");
                    string promptChoice = Console.ReadLine();
                    Console.WriteLine("");

                    if (promptChoice == "1")
                    {
                        promptGenerator.FillList(); // Ensure the list is filled before displaying
                        promptGenerator.DisplayPrompts();
                        Console.WriteLine("");
                    }
                    else if (promptChoice == "2")
                    {
                        Console.Write("Enter the new prompt: ");
                        string newPrompt = Console.ReadLine();
                        promptGenerator.AddPrompt(newPrompt);
                        promptGenerator.FillList(); // Refresh the list after adding a new prompt
                        Console.WriteLine("Prompt added successfully.");
                        Console.WriteLine("");
                    }
                    else if (promptChoice == "3")
                    {
                        promptGenerator.FillList(); // Ensure the list is filled before displaying
                        promptGenerator.DisplayPrompts();
                        Console.Write("Enter the index of the prompt to remove: ");
                        string indexEntry = Console.ReadLine();
                        int indexToRemove = int.Parse(indexEntry);

                        promptGenerator.RemovePrompt(indexToRemove - 1); // Adjust for zero-based index
                        promptGenerator.FillList(); // Refresh the list after removing a prompt
                        Console.WriteLine("");
                    }
                    else if (promptChoice == "4")
                    {
                        goBack = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please try again.");
                        Console.WriteLine("");
                    }
                }
            }
            else if (choice == "6")
            {
                // Quick Tips
                Console.WriteLine("Quick Tips:");
                Console.WriteLine("- Make sure to load your journal before making changes. Failure to do so may result in data loss.");
                Console.WriteLine("- Write regularly to improve your writing skills.");
                Console.WriteLine("- Be honest and reflective in your entries.");
                Console.WriteLine("- Use prompts to inspire creativity and self-expression.");
                Console.WriteLine("- Review past entries to track personal growth and insights.");
                Console.WriteLine("");
            }
            else if (choice == "7")
            {
                // Quit
                Quit = true;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                Console.WriteLine("");
            }
        }
    }
}