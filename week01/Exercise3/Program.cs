using System;
using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercise 3");
        Random rndNumGenerator = new Random();
        string response = "yes";
        int guess = -1;

        //Ask user for a number (user generated number)
        //Console.Write("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());

        //Generate a random number from 1 to 100
        int magicNumber = rndNumGenerator.Next(1, 101);
        //For Debugging:
        //Console.WriteLine($"Magic Number: {magicNumber}");

        while (response == "yes")
        {
            while (guess != magicNumber)
            {
                //Ask user for their guess
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                //Check the guess to the magicNumber
                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess == magicNumber)
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            //Ask user if they would like to play again
            Console.Write("Do you want to play again? ");
            response = Console.ReadLine();
        }
    }
}