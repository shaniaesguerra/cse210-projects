using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercise 2");
        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());
        char letter;

        //Check for equivalent letter grade:
        if (grade >= 90)
        {
            letter = 'A';
        }
        else if (grade >= 80)
        {
            letter = 'B';
        }
        else if (grade >= 70)
        {
            letter = 'C';
        }
        else if (grade >= 60)
        {
            letter = 'D';
        }
        else
        {
            letter = 'F';
        }

        Console.WriteLine($"Your letter grade is: {letter}");

        //Check if PASS or FAIL:70
        if (grade >= 70)
        {
            Console.WriteLine("You PASSED! :)");
        }
        else
        {
            Console.WriteLine("Unfortunately you did not pass :(");
        }
    }
}