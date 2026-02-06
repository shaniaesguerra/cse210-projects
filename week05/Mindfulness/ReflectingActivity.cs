public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity(string name, string description) : base(name, description)
    {
        //Populate prompts:
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        _prompts.Add("Think of a time when you achieved something.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you had a vacation.");
        _prompts.Add("Think of a time when you tried something for the first time.");

        //Populate questions:
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself thorugh this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public void Run()
    {
        Console.Clear();
        DisplayPrompt();
        Console.WriteLine("");
        Console.WriteLine("Reflect on the following questions...");
        Console.Write("Get Ready... ");
        ShowSpinner(5);
        Console.WriteLine("\n");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
            ShowSpinner(6);
        }

    }

    private string GetRandomPrompt()
    {
        string randomPrompt = "";
        Random rndNumGenerator = new Random();

        randomPrompt = _prompts[rndNumGenerator.Next(0, _prompts.Count())];
        return randomPrompt;
    }

    private string GetRandomQuestion()
    {
        string randomQuestion = "";
        Random rndNumGenerator = new Random();

        randomQuestion= _questions[rndNumGenerator.Next(0, _questions.Count())];
        return randomQuestion;
    }

    private void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }
    
    private void DisplayQuestions()
    {
        Console.WriteLine($"- {GetRandomQuestion()}");
    }
}
