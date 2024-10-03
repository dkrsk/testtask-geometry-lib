using DnKR.Geometry.Exceptions;

namespace DnKR.Geometry;

public class Triangle : Figure
{
    private double _a;
    private double _b;
    private double _c;

    public double A
    {
        get => _a;
        set
        {
            _a = value;
            ValidateSides();
        }
    }

    public double B
    {
        get => _b;
        set
        {
            _b = value;
            ValidateSides();
        }
    }

    public double C
    {
        get => _c;
        set
        {
            _c = value;
            ValidateSides();
        }
    }

    /// <summary>
    /// Class representing triangle.
    /// </summary>
    /// <remarks>
    /// The <paramref name="a"/>, <paramref name="b"/>, and <paramref name="c"/> parameters must satisfy the triangle inequality.
    /// </remarks>
    /// <exception cref="InvalidTriangleSidesException"></exception>
    public Triangle(double a, double b, double c)
    {
        _a = a;
        _b = b;
        _c = c;

        ValidateSides();
        Update();
    }

    /// <summary>
    /// Сhecks if the triangle is right angled
    /// </summary>
    /// <returns>Check result</returns>
    public bool IsRectangular()
    {
        if(A*A+B*B==C*C) return true;
        if(C*C+B*B==A*A) return true;
        if(C*C+A*A==B*B) return true;
        return false;
    }

    public override void Update()
    {
        var semiPerimeter = (A + B + C) / 2;
        Perimeter = semiPerimeter * 2;
        Area = Math.Sqrt(semiPerimeter * (semiPerimeter - A) * (semiPerimeter - B) * (semiPerimeter - C));
    }

    protected void ValidateSides()
    {
        if (_a <= 0 || _b <= 0 || _c <= 0)
            throw new ArgumentException("Sides must be positive.");

        if (!CheckTriangleInequality())
            throw new InvalidTriangleSidesException();
    }

    protected bool CheckTriangleInequality()
    {
        return _a + _b > C && _a + _c > _b && _b + _c > _a;
    }
}
