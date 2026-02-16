using System.Diagnostics.CodeAnalysis;

public abstract class Activity
{
    protected string _date;
    protected int _lengthInMinutes;

    public Activity(string date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    public abstract void GetSummary();
    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();

    protected string GetDate()
    {
        return _date;
    }

    protected int GetLength()
    {
        return _lengthInMinutes;
    } 
}

