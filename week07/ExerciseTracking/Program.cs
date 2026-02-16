using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("16 Feb 2026", 30, 4.8);
        activities.Add(running);

        Cycling cycling = new Cycling("17 Feb 2026", 45, 20);
        activities.Add(cycling);

        Swimming swimming = new Swimming("18 Feb 2026", 10, 5);
        activities.Add(swimming);


        foreach (Activity activity in activities)
        {
            activity.GetSummary();
        }
    }
}