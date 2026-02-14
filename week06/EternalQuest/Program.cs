using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; // to show emojis

        SimpleGoal simpleGoal = new SimpleGoal("Go to the park", "Take some time to unwind and recenter in the park", "50");
        Console.WriteLine(simpleGoal.GetDetailsString());
        simpleGoal.RecordEvent();
        Console.WriteLine(simpleGoal.GetStringRepresentation());


        EternalGoal eternalGoal = new EternalGoal("Read the Scriptures", "Take time to read and study the scriptures daily", "50");
        Console.WriteLine(eternalGoal.GetDetailsString());
        eternalGoal.RecordEvent();
        Console.WriteLine(eternalGoal.GetStringRepresentation());

        ChecklistGoal checklistGoal = new ChecklistGoal("Go to the park", "Take some time to unwind and recenter in the park", "50", 5, 1000);
        Console.WriteLine(checklistGoal.GetDetailsString());
        checklistGoal.RecordEvent();
        Console.WriteLine(checklistGoal.GetStringRepresentation());
    }
}