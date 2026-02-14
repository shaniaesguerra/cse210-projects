public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {
        //shows points added:
        Console.WriteLine($"Congratulations! You have earned 🌟{_points} points!🌟");
    }

    public override bool IsComplete()
    {
        return false; // eternal goal is never completed
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
}