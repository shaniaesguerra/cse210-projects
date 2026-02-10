using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("blue", 5.0);
        string sqColor = square.GetColor();
        double sqArea = square.GetArea();

        Console.WriteLine($"Sqauare: color = {sqColor}, area = {sqArea.ToString("F2")}");

        Rectangle rectangle = new Rectangle("orange", 7, 5);
        string rectColor = rectangle.GetColor();
        double rectArea = rectangle.GetArea();
        Console.WriteLine($"Rectangle: color = {rectColor}, area = {rectArea.ToString("F2")}");

        Circle circle = new Circle("pink", 3);
        string cColor = circle.GetColor();
        double cArea = circle.GetArea();
        Console.WriteLine($"Circle: color = {cColor}, area = {cArea.ToString("F2")}");


    }
}