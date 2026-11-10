using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int totalAmount = 0;
        int totalItems = 0;

        Console.WriteLine("Create a list of numbers. Type '0' when finished.");

        string input = Console.ReadLine();
        while (input != "0")
        {
            int number = int.Parse(input);
            numbers.Add(number);
            totalAmount += number;
            totalItems++;
            Console.WriteLine("Enter another number (or '0' to finish):");
            input = Console.ReadLine();
        }

        Console.WriteLine("The list contains the following numbers:");
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine($"The total amount is: {totalAmount}");
        Console.WriteLine($"The total number of items is: {totalItems}");

        float average = (float)totalAmount / totalItems;
        Console.WriteLine($"The average is: {average}");

        int largestNumber = numbers.Max();
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}