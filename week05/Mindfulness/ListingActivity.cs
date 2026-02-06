public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity(string name, string description) : base(name, description)
    {
        //Populate prompts list
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("What blessings happened to you today?");
        _prompts.Add("What food have you eaten today?");
        _prompts.Add("When have you gave thanks this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get Ready... ");
        Console.WriteLine("");
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine("");
        GetRandomPrompt();
        Console.WriteLine("");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine("");

        _count = GetListFromUser().Count();
        Console.WriteLine($"You have listed {_count} items!");
    }

    public void GetRandomPrompt()
    {
        string randomPrompt = "";
        Random rndNumGenerator = new Random();

        randomPrompt = _prompts[rndNumGenerator.Next(0, _prompts.Count())];
        Console.WriteLine($"|==== {randomPrompt} ===|");
    }

    public List<string> GetListFromUser()
    {
        List<string> list = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write(">> ");
            list.Add(Console.ReadLine());
        }

        return list;
    }
}