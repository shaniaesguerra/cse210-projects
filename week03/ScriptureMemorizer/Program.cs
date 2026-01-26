using System;

class Program
{
    static void Main(string[] args)
    {
        
        //Test:
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();

        Console.WriteLine("Please press enter to continue or type 'quit' to finish:");
        string userInput = Console.ReadLine();

        while (userInput != "quit" && scripture.IsCompletelyHidden() == false) {
            Console.Clear(); //Clear terminal

            //Hide random words:
            Random randNumGenerator = new Random();
            int randomNumber = randNumGenerator.Next(0, scripture.GetVerseLength());

            //Hide three words at a time
            for (int i = 0; i < 3; i++)
            {
                scripture.HideRandomWords(randomNumber);
                //Console.WriteLine($"Random Number: {randomNumber}"); //for debugging
                randomNumber = randNumGenerator.Next(0, scripture.GetVerseLength());
            }

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Please press enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();
        }

    }
}