using System;

class Program
{
    static void Main(string[] args)
    {
        Boolean Quit = false;
        Journal journal = new Journal();

        Console.WriteLine("We hope you have had a great day!");

        while (!Quit)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();
            Console.WriteLine("");

            if (choice == "1")
            {
                // Write
                Entry entry = new Entry();
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