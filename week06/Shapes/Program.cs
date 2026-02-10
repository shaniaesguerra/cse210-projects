using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("blue", 5.0);
        string sqColor = square.GetColor();
        double sqArea = square.GetArea();

        Console.WriteLine($"Sqauare: color = {sqColor}, area = {sqArea}");
    }
}