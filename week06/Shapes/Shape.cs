public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    private void SetColor(string color)
    {
        _color = color;
    }

    public abstract double GetArea();
}