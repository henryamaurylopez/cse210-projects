using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(1,3);

        f1.SetTop(5);
        f1.SetBottom(8);

        Console.WriteLine($"f1 numerator is {f1.GetTop()} and its denominator is {f1.GetBottom()}.");
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        Console.WriteLine(f3.GetFractionString());
    }
}