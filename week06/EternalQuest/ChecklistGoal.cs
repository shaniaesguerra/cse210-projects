public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {
        return true;
    }

    public override string GetDetailsString()
    {
        return $"Checklist Goal | Done: {_amountCompleted}";
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist Goal | Done: {_amountCompleted}";
    }
}