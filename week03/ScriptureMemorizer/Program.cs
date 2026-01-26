using System;
using System.Runtime.InteropServices;

/**
Author: Shania Arvie S. Esguerra
Project: W03 Project- Scripture Memorizer Program
Enhancement: Reads a file and adds the scripture in a list to Randomly generate a scripture
             to memorize everytime the program restarts.
**/

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();//Clear terminal

        List<Scripture> scripturesList = new List<Scripture>();

        string book = "";
        string fullVerseRef = "";
        int chapterNum = 0;
        int verseNum = 0;
        int endVerseNum = 0;
        string scriptureText = "";
        string fileName = "scriptures.txt";

        //Read file:
        //Store each line in the file in a string array
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            //Split into parts;
            string[] parts = line.Split("~~");
            book = parts[0];

            fullVerseRef = parts[1]; //need to split in parts
            string[] verseParts = fullVerseRef.Split(":");

            //Chapter Number:
            string strChapter = verseParts[0];
            chapterNum = int.Parse(strChapter);
            string verse = "";
            string endVerse = "";

            if (verseParts[1].Contains("-") == true)
            {
                string[] strVerseNum = verseParts[1].Split("-");
                verse = strVerseNum[0];
                endVerse = strVerseNum[1];

                verseNum = int.Parse(verse);
                endVerseNum = int.Parse(endVerse);
            }
            else
            {
                verse = verseParts[1];
                verseNum = int.Parse(verse);
            }

            //Verse Text:
            scriptureText = parts[2];

            //Add to list:
            Reference addReference = new Reference(book, chapterNum, verseNum);
            Scripture addScripture = new Scripture(addReference, scriptureText);

            if (endVerseNum == 0)
            {
                addReference = new Reference(book, chapterNum, verseNum);
                addScripture = new Scripture(addReference, scriptureText);
                scripturesList.Add(addScripture);
            }
            else
            {
                addReference = new Reference(book, chapterNum, verseNum, endVerseNum);
                addScripture = new Scripture(addReference, scriptureText);
                scripturesList.Add(addScripture);
            }

        }

        //Create Random Number Generator to generate random scripture verses from file
        Random randomGenerator = new Random();
        int rndScriptureNum = randomGenerator.Next(0, scripturesList.Count());
        Scripture scripture = scripturesList[rndScriptureNum];
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();

        Console.WriteLine("Please press enter to continue or type 'quit' to finish:");
        string userInput = Console.ReadLine();

        while (userInput != "quit" && scripture.IsCompletelyHidden() == false)
        {
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