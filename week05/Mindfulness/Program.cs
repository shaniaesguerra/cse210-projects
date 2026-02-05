using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Activity activity = new Activity("Test", "testing");
        activity.ShowSpinner(5);
    }
}