public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity(string name, string description, int duration, List<string> prompts) : base(name, description, duration)
    {
        foreach (string prompt in prompts)
        {
            _prompts.Add(prompt);
            _count++;
        }
    }

    public void Run()
    {
        Console.WriteLine(_count);
    }

    public void GetRandomPrompt()
    {

    }
    
    public List<string> GetListFromUser()
    {
        List<string> list = new List<string>();

        return list;
    }
}