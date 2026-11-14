// Purpose: Runs the journal menu and coordinates journal and prompt actions.
using System; // Provides console input and output.

/// <summary>Provides the command-line entry point and menu for the journal application.</summary>
class Program
{
    /// <summary>Starts the application and processes menu choices until the user quits.</summary>
    /// <param name="args">Command-line arguments; this application does not use them.</param>
    /// <returns>Nothing; this method runs the interactive menu.</returns>
    static void Main(string[] args)
    {
        // Keep the menu running until the user selects Quit.
        Boolean Quit = false;
        // Create the journal that stores the user's entries.
        Journal journal = new Journal();
        // Create the helper that supplies and manages writing prompts.
        PromptGenerator promptGenerator = new PromptGenerator();

        // Greet the user when the application starts.
        Console.WriteLine("We hope you have had a great day!");

        // Repeat the main menu while the user has not chosen to quit.
        while (!Quit)
        {
            // Show the available journal actions.
            Console.WriteLine("Please select one of the following choices:");
            // Show the option to write an entry.
            Console.WriteLine("1. Write");
            // Show the option to display saved entries.
            Console.WriteLine("2. Display");
            // Show the option to load entries from a file.
            Console.WriteLine("3. Load");
            // Show the option to save entries to a file.
            Console.WriteLine("4. Save");
            // Show the option to manage prompts.
            Console.WriteLine("5. Edit Prompts");
            // Show the option to read journaling tips.
            Console.WriteLine("6. Quick Tips");
            // Show the option to exit the application.
            Console.WriteLine("7. Quit");

            // Ask the user to select a menu option.
            Console.Write("What would you like to do? ");
            // Read the selected option as text.
            string choice = Console.ReadLine();
            // Add a blank line to separate the input from the next output.
            Console.WriteLine("");

            // Handle the option to create a journal entry.
            if (choice == "1")
            {
                // Write
                // Create an entry to hold today's date, prompt, and response.
                Entry entry = new Entry();
                // Load prompts from the file before selecting one.
                promptGenerator.FillList(); // Ensure the list is filled before getting a random prompt
                // Assign a randomly selected prompt to the new entry.
                entry._promptText = promptGenerator.GetRandomPrompt();
                // Ask for the response, date the entry, and store it in the journal.
                journal.AddEntry(entry);
                // Separate this action from the next menu display.
                Console.WriteLine("");
            }
            // Handle the option to display journal entries.
            else if (choice == "2")
            {
                // Display
                // Print all entries currently held by the journal.
                journal.DisplayAll();
                // Separate this action from the next menu display.
                Console.WriteLine("");
            }
            // Handle the option to load entries from a file.
            else if (choice == "3")
            {
                // Load
                // Ask for a filename and load its entries into the journal.
                journal.LoadFromFile("");
                // Separate this action from the next menu display.
                Console.WriteLine("");
            }
            // Handle the option to save entries to a file.
            else if (choice == "4")
            {
                // Save
                // Ask for a filename and save the journal entries there.
                journal.SaveToFile("");
                // Separate this action from the next menu display.
                Console.WriteLine("");
            }
            // Handle the option to manage writing prompts.
            else if (choice == "5")
            {
                // Keep the prompt menu open until the user chooses Go Back.
                Boolean goBack = false;
                // Repeat the prompt menu while the user remains in prompt management.
                while (!goBack)
                {
                    // Edit Prompts
                    // Display the prompt management menu.
                    Console.WriteLine("Prompt Management:");
                    // Show the option to list the prompts.
                    Console.WriteLine("1. Display Prompts");
                    // Show the option to add a prompt.
                    Console.WriteLine("2. Add Prompt");
                    // Show the option to remove a prompt.
                    Console.WriteLine("3. Remove Prompt");
                    // Show the option to return to the main menu.
                    Console.WriteLine("4. Go Back");
                    // Ask the user to select a prompt-management action.
                    Console.Write("What would you like to do? ");
                    // Read the selected prompt-management action.
                    string promptChoice = Console.ReadLine();
                    // Add spacing after the user's selection.
                    Console.WriteLine("");

                    // Handle the option to display available prompts.
                    if (promptChoice == "1")
                    {
                        // Load the latest prompt list before displaying it.
                        promptGenerator.FillList(); // Ensure the list is filled before displaying
                        // Print the prompt list with numbered positions.
                        promptGenerator.DisplayPrompts();
                        // Add spacing after the displayed list.
                        Console.WriteLine("");
                    }
                    // Handle the option to add a prompt.
                    else if (promptChoice == "2")
                    {
                        // Ask the user for the text of the new prompt.
                        Console.Write("Enter the new prompt: ");
                        // Read the new prompt text.
                        string newPrompt = Console.ReadLine();
                        // Append the prompt to the prompt file.
                        promptGenerator.AddPrompt(newPrompt);
                        // Reload the prompt list so it includes the new prompt.
                        promptGenerator.FillList(); // Refresh the list after adding a new prompt
                        // Confirm the addition to the user.
                        Console.WriteLine("Prompt added successfully.");
                        // Add spacing after the confirmation.
                        Console.WriteLine("");
                    }
                    // Handle the option to remove a prompt.
                    else if (promptChoice == "3")
                    {
                        // Load prompts so the user can see the available numbered choices.
                        promptGenerator.FillList(); // Ensure the list is filled before displaying
                        // Show the numbered prompts before asking which one to remove.
                        promptGenerator.DisplayPrompts();
                        // Reload the list because displaying it clears the in-memory list.
                        promptGenerator.FillList(); // Refresh the list after displaying to ensure it's up-to-date
                        // Ask for the visible, one-based prompt number.
                        Console.Write("Enter the index of the prompt to remove: ");
                        // Read the chosen prompt number as text.
                        string indexEntry = Console.ReadLine();
                        // Convert the user's number into an integer.
                        int indexToRemove = int.Parse(indexEntry);

                        // Convert the one-based menu number to a zero-based list index and remove it.
                        promptGenerator.RemovePrompt(indexToRemove - 1); // Adjust for zero-based index
                        // Reload the prompt list after the removal.
                        promptGenerator.FillList(); // Refresh the list after removing a prompt
                        // Add spacing before the next prompt menu display.
                        Console.WriteLine("");
                    }
                    // Handle the option to return to the main menu.
                    else if (promptChoice == "4")
                    {
                        // End the prompt-management loop.
                        goBack = true;
                    }
                    // Handle an unrecognized prompt-management choice.
                    else
                    {
                        // Tell the user the selection was not valid.
                        Console.WriteLine("Invalid choice. Please try again.");
                        // Add spacing before showing the menu again.
                        Console.WriteLine("");
                    }
                }
            }
            // Handle the option to display journaling tips.
            else if (choice == "6")
            {
                // Quick Tips
                // Introduce the list of tips.
                Console.WriteLine("Quick Tips:");
                // Remind the user to load existing work before changing it.
                Console.WriteLine("- Make sure to load your journal before making changes. Failure to do so may result in data loss.");
                // Encourage regular writing practice.
                Console.WriteLine("- Write regularly to improve your writing skills.");
                // Encourage thoughtful and honest responses.
                Console.WriteLine("- Be honest and reflective in your entries.");
                // Suggest using prompts as writing inspiration.
                Console.WriteLine("- Use prompts to inspire creativity and self-expression.");
                // Suggest reviewing earlier writing for reflection.
                Console.WriteLine("- Review past entries to track personal growth and insights.");
                // Add spacing before the main menu appears again.
                Console.WriteLine("");
            }
            // Handle the option to quit the application.
            else if (choice == "7")
            {
                // Quit
                // Set the loop condition so the main menu ends.
                Quit = true;
            }
            // Handle an unrecognized main-menu choice.
            else
            {
                // Tell the user the selection was not valid.
                Console.WriteLine("Invalid choice. Please try again.");
                // Add spacing before showing the main menu again.
                Console.WriteLine("");
            }
        }
    }
}