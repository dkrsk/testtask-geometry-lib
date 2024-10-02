namespace DnKR.Geometry;

public class Circle : Figure
{
    public double Radius { get; set; }

    protected const double _pi = 3.14;

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
