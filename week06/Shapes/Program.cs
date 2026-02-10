using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("blue", 5.0);
        string sqColor = square.GetColor();
        double sqArea = square.GetArea();

        Console.WriteLine($"Sqauare: color = {sqColor}, area = {sqArea}");

        Rectangle rectangle = new Rectangle("orange", 7, 5);
        string rectColor = rectangle.GetColor();
        double rectArea = rectangle.GetArea();
        Console.WriteLine($"Rectangle: color = {rectColor}, area = {rectArea}");

    }
}