public class PromptGenerator
{
    public List<string> _prompts;
    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        //generate a number from 0 to max length of prompt list
        int randomNumber = rnd.Next(_prompts.Count());

        //Return the random prompt
        return _prompts[randomNumber];
    }
}