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
        if (IsComplete() == true)
        {
            Console.WriteLine($"Congratulations! You have earned 🌟 {_points} points! 🌟");
            Console.WriteLine($"You also earned 🎉⭐ {_bonus} bonus points ⭐🎉 for reaching your target!");
            int totalPoints = int.Parse(_points) + _bonus;
            _points = totalPoints.ToString();
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned 🌟 {_points} points! 🌟");
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
        if (IsComplete() == false)
        {
            return $"[ ] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[X] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }

    public void SetAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }
}