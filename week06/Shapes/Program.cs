using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square square = new Square("blue", 5.0);
        Rectangle rectangle = new Rectangle("orange", 7, 5);
        Circle circle = new Circle("pink", 3);

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"Shape has: color = {color} | area = {area.ToString("F2")}");
        }
    }
}