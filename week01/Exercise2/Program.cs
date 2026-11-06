using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";
        string sign = "";

        Console.Write("Hello! What is your grade percentage? ");
        string gradeInput = Console.ReadLine();
        int grade = int.Parse(gradeInput);

        if (grade >= 90)
        {
            letter = "A";
            if (grade < 93)
            {
                sign = "-";
            }
        }
        else if (grade >= 80)
        {
            letter = "B";
            if (grade < 83)
            {
                sign = "-";
            }
            else if (grade >= 87)
            {
                sign = "+";
            }
        }
        else if (grade >= 70)
        {
            letter = "C";
            if (grade < 73)
            {
                sign = "-";
            }
            else if (grade >= 77)
            {
                sign = "+";
            }
        }
        else if (grade >= 60)
        {
            letter = "D";
            if (grade < 63)
            {
                sign = "-";
            }
            else if (grade >= 67)
            {
                sign = "+";
            }
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass the course. Better luck next time!");
        }
    }
}