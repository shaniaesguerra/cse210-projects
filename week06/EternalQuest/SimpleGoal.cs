public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true; // finished the simple goal

        Console.WriteLine($"Congratulations! You have earned 🌟 {_points} points! 🌟");
    }

    public override bool IsComplete()
    {
        if (_isComplete)
        {
            _isComplete = true;
            return _isComplete  ;
        }
        else
        {
            _isComplete = false;
            return _isComplete;
        }
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }
}