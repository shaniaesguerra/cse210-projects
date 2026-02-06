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
        breathingActivity.DisplayStartingMessage();
        breathingActivity.Run();
        breathingActivity.DisplayEndingMessage();
    }
}