public class Swimming : Activity
{
    private int _numberOfLaps = 0;
    public Swimming(string date, int lengthInMinutes, int numberOfLaps) : base(date, lengthInMinutes)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{GetDate()} Swimming ({GetLength()})- Distance:{CalculateDistance()} km, Speed:{CalculateSpeed()} kph, Pace:{CalculatePace()} min per km");
    }

    public override double CalculateDistance()
    {
        return _numberOfLaps * 50 / 1000;
    }
    public override double CalculateSpeed()
    {
        double distance = CalculateDistance();
        double minutes = GetLength();
        return distance  / minutes * 60;
    }
    public override double CalculatePace()
    {
        double distance = CalculateDistance();
        double minutes = GetLength();
        return minutes / distance;
    }
}