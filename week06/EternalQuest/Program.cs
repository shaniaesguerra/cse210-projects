using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; // to show emojis

        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}