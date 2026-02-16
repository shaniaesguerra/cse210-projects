public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int lengthInMinutes, double speed) : base(date, lengthInMinutes)
    {
        _speed = speed;
    }
    public override void GetSummary()
    {
        Console.WriteLine($"{GetDate()} Cycling ({GetLength()})- Distance:{CalculateDistance()} km, Speed:{CalculateSpeed()} kph, Pace:{CalculatePace()} min per km");
    }

    public override double CalculateDistance()
    {
        return _speed * GetLength() / 60;
    }
    public override double CalculateSpeed()
    {
        return _speed;
    }
    public override double CalculatePace()
    {
        return 60 / _speed;
    }
}