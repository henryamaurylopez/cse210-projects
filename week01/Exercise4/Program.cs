using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int totalAmount = 0;
        int totalItems = 0;

        Console.WriteLine("Create a list of numbers. Type '0' when finished.");
        Console.Write("Enter another number:");
        string input = Console.ReadLine();

        while (input != "0")
        {
            int number = int.Parse(input);
            numbers.Add(number);
            totalAmount += number;
            totalItems++;
            Console.Write("Enter another number:");
            input = Console.ReadLine();
        }

        Console.WriteLine("");
        Console.WriteLine("The list contains the following numbers:");
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine("");
        Console.WriteLine($"The total amount is: {totalAmount}");
        Console.WriteLine($"The total number of items is: {totalItems}");

        float average = (float)totalAmount / totalItems;
        Console.WriteLine($"The average is: {average}");

        int largestNumber = numbers.Max();
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}