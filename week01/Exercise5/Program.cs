using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercise 5");

        DisplayMessage();
        //Ask user for name and number
        string name = PromptUserName();
        int number = PromptUserNumber();

        //Square the number
        int squareNum = SquareNumber(number);

        //Display result
        DisplayResult(name, squareNum);
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please Enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int squaredNum = number * number;

        return squaredNum;
    }
    
    static void DisplayResult(string name, int squareNum)
    {
        Console.WriteLine($"{name}, the square of your number is {squareNum}");
    }
}