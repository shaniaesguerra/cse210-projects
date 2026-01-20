using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction fraction1 = new Fraction(5, 13);
        Console.WriteLine($"Initital: TOP = {fraction1.GetTop()} BOTTOM = {fraction1.GetBottom()}");

        fraction1.SetTop(25);
        fraction1.SetBottom(2);
        Console.WriteLine($"First Change: TOP = {fraction1.GetTop()} BOTTOM = {fraction1.GetBottom()}");

    }
}