using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("W03 - Fractions Project");
        Console.WriteLine("Testing Getters and Setters:");
        Fraction fraction1 = new Fraction(5, 13);
        Console.WriteLine($"Initital: TOP = {fraction1.GetTop()} BOTTOM = {fraction1.GetBottom()}");

        fraction1.SetTop(25);
        fraction1.SetBottom(2);
        Console.WriteLine($"First Change: TOP = {fraction1.GetTop()} BOTTOM = {fraction1.GetBottom()}");
        Console.WriteLine();

        Console.WriteLine("Testing Methods");

        Fraction fraction2 = new Fraction();
        fraction2.GetFractionString();
        double decimalValue = fraction2.GetDecimalValue();
        Console.WriteLine(decimalValue);

        fraction2 = new Fraction(5);
        fraction2.GetFractionString();
        decimalValue = fraction2.GetDecimalValue();
        Console.WriteLine(decimalValue);

        fraction2 = new Fraction(3, 4);
        fraction2.GetFractionString();
        decimalValue = fraction2.GetDecimalValue();
        Console.WriteLine(decimalValue);

        fraction2 = new Fraction(1, 3);
        fraction2.GetFractionString();
        decimalValue = fraction2.GetDecimalValue();
        Console.WriteLine(decimalValue);

    }
}