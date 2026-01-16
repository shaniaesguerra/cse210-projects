using System;
using System.IO;

/*
Author: Shania Arvie S. Esguerra
Purpose: W02 - Journal App Project
Description: App that contains features of a Journal where entries can be written,
             saved, loaded, and displayed through the choice of the user.
Enhancement: 
    - Added a feature in PrompGenerator.cs where prompts will be loaded from a text file.
*/
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        journal._entries = new List<Entry>();

        Entry entry;
        PromptGenerator prompts = new PromptGenerator();
        const string promptsFilename = "prompts.txt";
        DateTime currentTime = DateTime.Now;

        int userChoice = -1;

        //Load in the prompts
        prompts._prompts = new List<string>();
        prompts.LoadPrompts(promptsFilename);

        while (userChoice != 5)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Please Select One of the following choices:");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");
            Console.WriteLine("-------------------------------------------");
            Console.Write("What would you like to do? ");
            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                //Write an entry option
                //Create a new Entry
                entry = new Entry();

                //Get date today
                string dateText = currentTime.ToShortDateString();
                entry._date = dateText;

                //Get new prompt 
                string newPrompt = prompts.GetRandomPrompt();
                entry._promptText = newPrompt;

                //Print random prompt
                Console.WriteLine(newPrompt);

                //Ask user's entry
                Console.Write("> ");
                entry._entryText = Console.ReadLine();

                //entry.Display(); //for debugging

                //Add entry to journal
                journal.AddEntry(entry);
            }
            else if (userChoice == 2)
            {
                //Display all journal entries
                journal.DisplayAll();
            }
            else if (userChoice == 3)
            {
                //Load a journal option
                Console.WriteLine("What is the filename you want to load?");
                journal.LoadFromFile(Console.ReadLine());
            }
            else if (userChoice == 4)
            {
                //Save journal option
                Console.WriteLine("What is the filename you want to save it as?");
                journal.SaveFile(Console.ReadLine());
            }
            else if (userChoice == 5)
            {
                //Show Quit Message
                Console.WriteLine("Bye bye for now! Till your next journal entry...");
            }
            else if (userChoice != 5)
            {
                //Show error message
                Console.WriteLine("Invalid choice. Please use only the numbers 1, 2, 3, 4 and 5.");
            }
        }
    }
}