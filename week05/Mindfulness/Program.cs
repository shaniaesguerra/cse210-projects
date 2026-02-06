using System;

/*
Author: Shania Arvie S. Esguerra
Purpose: W05 - Mindfulness Project
Description: App that contains features that promote Mindfulness. Activities that are featured
          are breathing activities, reflecting activities, and listing activity.
Enhancement: 
    - Added meaningful animations in Breathing Activity class
*/
class Program
{
    static void Main(string[] args)
    {
        int userInput = -1;

        while (userInput != 4)
        {
            Console.WriteLine("Welcome to the Mindfulness App!");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu (1-4): ");

            userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathingActivity.DisplayStartingMessage();
                breathingActivity.Run();
                breathingActivity.DisplayEndingMessage();
            }
            else if (userInput == 2)
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflectingActivity.DisplayStartingMessage();
                reflectingActivity.Run();
                reflectingActivity.DisplayEndingMessage();
            }
            else if (userInput == 3)
            {
                ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listingActivity.DisplayStartingMessage();
                listingActivity.Run();
                listingActivity.DisplayEndingMessage();
            }

        }

        Console.WriteLine("See you again soon!");

    }
}