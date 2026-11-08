using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Create a list of numbers. Type '0' when finished.");

        string input = Console.ReadLine();
        while (input != "0")
        {
            int number = int.Parse(input);
            numbers.Add(number);
            input = Console.ReadLine();
        }

        Console.WriteLine("The list contains the following numbers:");
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }
    }
}