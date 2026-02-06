public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
        
    }
    
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(3);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("");
            Console.Write("Breathe in... ");
            ShowCountDown(3);
            Console.Write("\n and breathe out... ");
            ShowCountDown(6);
            Console.WriteLine("");
        }
    }
}