using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Sandbox Project.");
        Student s = new Student();
        s.SetName("Shania");
        Console.WriteLine(s.GetName());
    }
}