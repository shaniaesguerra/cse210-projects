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
        _amountCompleted += 1; //add to the amount of times completed
        Console.WriteLine($"Congratulations! You have earned {_points} points!");

        if(IsComplete() == true)
        {
            Console.WriteLine($"Awesome! You have earned 🎉⭐ {_bonus} bonus points ⭐🎉 for reaching your target!");
            Console.WriteLine($"Congratulations! You have earned 🌟{int.Parse( _points) + _bonus} points!🌟");
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            // if all items in checklist is completed:
            return true; 
        }
        else
        {
            //otherwise:
            return false;
        }
    }

    public override string GetDetailsString()
    {
        return $"[ ] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}