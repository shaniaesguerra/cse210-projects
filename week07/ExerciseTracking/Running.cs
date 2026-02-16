public class Running : Activity
{
    private double _distance;
    public Running(string date, int lengthInMinutes, double distance) : base(date, lengthInMinutes)
    {
        _distance = distance;
    }
    public override void GetSummary()
    {
        Console.WriteLine($"{GetDate()} Running ({GetLength()} min)- Distance:{CalculateDistance()} km, Speed:{CalculateSpeed()} kph, Pace:{CalculatePace()} min per km");
    }

    public override double CalculateDistance()
    {
        return _distance;
    }
    public override double CalculateSpeed()
    {
        return _distance / this.GetLength() * 60;
    }
    public override double CalculatePace()
    {
        return this.GetLength() / _distance;
    }
}