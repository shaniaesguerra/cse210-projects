public class Journal
{
    public List<Entry> _entries;
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry); //add to list of entries
    }
    public void DisplayAll()
    {
        foreach (Entry e in _entries)
        {
            //Display each Journal Entry
            e.Display();
        }
    }
    public void SaveFile(string filename)
    {
        Console.WriteLine("Saving to file..."); //for debugging
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            //Add the entries to the file
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._date}~~{e._promptText}~~{e._entryText}");
            }

        }
        Console.WriteLine("Saved!"); //for debugging
    }
    public void LoadFromFile(string filename)
    {
        Console.WriteLine("Reading list from file...");
        //Clear list
        _entries.Clear();

        //Store each line in the file in a string array
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            //Split into parts;
            string[] parts = line.Split("~~");

            //make new entry
            Entry displayEntry = new Entry();
            displayEntry._date = parts[0];
            displayEntry._promptText = parts[1];
            displayEntry._entryText = parts[2];

            //Add to array
            _entries.Add(displayEntry);
        }
    }
}