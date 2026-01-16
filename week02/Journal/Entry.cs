public class Entry
{
    public string _date;
    public string _time;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        //Display Date, Prompt, and Journal Entry to user:
        Console.WriteLine($"Date: {_date} - Time: {_time}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine();
    }
}