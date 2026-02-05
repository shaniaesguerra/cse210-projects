using System.Net.NetworkInformation;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity(string name, string description, List<string> prompts, List<string> questions) : base(name, description)
    {
        foreach (string p in prompts)
        {
            _prompts.Add(p);
        }

        foreach (string q in questions)
        {
            _questions.Add(q);
        }
    }

    public void Run()
    {

    }

    public string GetRandomPrompt()
    {
        return "";
    }

    public string GetRandomQuestion()
    {
        return "";
    }

    public void DisplayPrompt()
    {

    }
    
    public void DisplayQuestions()
    {
        
    }
}