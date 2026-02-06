using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity("Test", "testing");
        //activity.DisplayStartingMessage();
        //activity.ShowSpinner(3);
        //activity.ShowCountDown(3);
        //activity.DisplayEndingMessage();

        BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        // breathingActivity.DisplayStartingMessage();
        // breathingActivity.Run();
        // breathingActivity.DisplayEndingMessage();

        ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        // reflectingActivity.DisplayStartingMessage();
        // reflectingActivity.Run();
        // reflectingActivity.DisplayEndingMessage();

        ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        listingActivity.DisplayStartingMessage();
        listingActivity.Run();
        listingActivity.DisplayEndingMessage();

    }
}