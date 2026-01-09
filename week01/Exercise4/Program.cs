using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercise 4");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numberList = new List<int>(); //list of numbers
        int number = -1; //contains the number that the user enters

        //Ask user continuously for words until they type zero
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            //Add number to the list if the number is not equal to zero:
            if (number != 0)
            {
                numberList.Add(number);
            }
        }

        //For debugging .add function for the list:
        // for (int i = 0; i < numberList.Count; i++)
        // {
        //     Console.Write($"{numberList[i]}, ");
        // }

        int sum = 0; //contains the sum of the numbers in the list
        //Compute the sum of the numbers:
        for (int i = 0; i < numberList.Count; i++)
        {
            sum += numberList[i];
        }
        Console.WriteLine($"The sum is: {sum}");

        double average = 0.0; //contains the average of the numbers in the list
        //Compute the average of the numbers:
        average = (double)sum / numberList.Count;
        Console.WriteLine($"The average is: {average}");

        //Find the largest number:
        int maxNumber = numberList[0]; //stores the value of the first number in the list
        foreach (int num in numberList)
        {
            if (num > maxNumber)
            {
                maxNumber = num;
            }
        }
        Console.WriteLine($"The max is: {maxNumber}");


    }
}