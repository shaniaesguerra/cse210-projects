public class PromptGenerator
{
    public List<string> _prompts;
    public void LoadPrompts(string filename)
    {
        Console.WriteLine("Loading Prompts...");
        //Make sure list is clear
        _prompts.Clear();

        //Store each line in the file in a string array
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            //Add each line to the list
            _prompts.Add(line);
        }
        Console.WriteLine("Prompts Loaded...");
    }
    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        //generate a number from 0 to max length of prompt list
        int randomNumber = rnd.Next(_prompts.Count());

        //Return the random prompt
        return _prompts[randomNumber];
    }
}