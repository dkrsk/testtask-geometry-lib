namespace DnKR.Geometry;

public class Circle : Figure
{
    protected const double _pi = 3.14;
    private double _radius;

    public double Radius
    {
        get => _radius;
        set
        {
            if (value > 0)
                _radius = value;
            else
                _radius = 0.1;
        }
    }


    /// <summary>
    /// Class representing circle.
    /// </summary>
    /// <param name="radius">The radius of circle</param>
    public Circle(double radius)
    {
        Radius = radius;
        Update();
    }

    public override void Update()
    {
        Perimeter = 2 * _pi * Radius;
        Area = _pi * Radius * Radius;
    }
}
