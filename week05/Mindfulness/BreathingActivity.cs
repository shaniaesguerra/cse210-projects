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
            Console.Write("Breathe in ");
            ShowBreatheIn(3);
            Console.Write("\n and breathe out ");
            ShowBreatheOut(6);
            Console.WriteLine("");
        }
    }

    private void ShowBreatheIn(int seconds)
    {
        // . . o o O O  ===> breathing animation
        List<string> animationStr = new List<string>();
        animationStr.Add(".");
        animationStr.Add(" ");
        animationStr.Add(".");
        animationStr.Add(" ");
        animationStr.Add("o");
        animationStr.Add(" ");
        animationStr.Add("o");
        animationStr.Add(" ");
        animationStr.Add("O");
        animationStr.Add(" ");
        animationStr.Add("O");
        animationStr.Add(" ");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            foreach (string s in animationStr)
            {
                Console.Write(s);
                Thread.Sleep(300);
            }

        }
    }

    private void ShowBreatheOut(int seconds)
    {
        // . . o o O O  ===> breathing animation
        List<string> animationStr = new List<string>();
        animationStr.Add("O");
        animationStr.Add(" ");
        animationStr.Add("O");
        animationStr.Add(" ");
        animationStr.Add("o");
        animationStr.Add(" ");
        animationStr.Add("o");
        animationStr.Add(" ");
        animationStr.Add(".");
        animationStr.Add(" ");
        animationStr.Add(".");
        animationStr.Add(" ");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            foreach (string s in animationStr)
            {
                Console.Write(s);
                Thread.Sleep(600);
            }

        }
    }
}