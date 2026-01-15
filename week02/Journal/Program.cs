using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        journal._entries = new List<Entry>();

        Entry entry;
        PromptGenerator prompts = new PromptGenerator();
        DateTime currentTime = DateTime.Now;

        int userChoice = -1;

        //Make the prompts
        prompts._prompts = new List<string>();
        prompts._prompts.Add("What was the best meal you had today?");
        prompts._prompts.Add("How are you really feeling today?");
        prompts._prompts.Add("Where did you want to go today?");

        while (userChoice != 5)
        {
            Console.WriteLine("Please Select One of the following choices:");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");

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
            }
            else if (userChoice == 4)
            {
                //Save journal option
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