using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Entry entry = new Entry();
        PromptGenerator prompts = new PromptGenerator();
        DateTime currentTime = DateTime.Now;
        int userChoice = -1;

        //Make the prompts

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

            }
            else if (userChoice == 2)
            {
                //Display option
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