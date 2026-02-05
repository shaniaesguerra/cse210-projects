using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Activity activity = new Activity("Test", "testing");
        activity.DisplayStartingMessage();
        activity.ShowSpinner(5);
        activity.ShowCountDown(5);
        activity.DisplayEndingMessage();
    }
}