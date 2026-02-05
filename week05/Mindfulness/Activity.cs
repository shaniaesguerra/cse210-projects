using Microsoft.VisualBasic;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine($"\n{_description}");
        Console.Write("How long, in seconds, would you like to do this activity? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {

    }

    public void ShowSpinner(int seconds)
    {
        // |/-\|/-\ ==> spinner
        List<string> animationStr = new List<string>();
        animationStr.Add("|");
        animationStr.Add("/");
        animationStr.Add("-");
        animationStr.Add("\\");
        animationStr.Add("|");
        animationStr.Add("/");
        animationStr.Add("-");
        animationStr.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(10);

        while (DateTime.Now < endTime)
        {
            foreach (string s in animationStr)
            {
                Console.Write(s);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
    }
    
    public void ShowCountDown(int seconds)
    {
        
    }
}