using DnKR.Geometry.Exceptions;

namespace DnKR.Geometry;

public class Triangle : Figure
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    /// <summary>
    /// Class representing triangle.
    /// </summary>
    /// <remarks>
    /// The <paramref name="a"/>, <paramref name="b"/>, and <paramref name="c"/> parameters must satisfy the triangle inequality.
    /// </remarks>
    /// <exception cref="InvalidTriangleSidesException"></exception>
    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
        if(A + B <= C || A + C <= B || B + C <= A)
            throw new InvalidTriangleSidesException();

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

    protected bool CheckTriangleInequality()
    {
        return A + B > C && A + C > B && B + C > A;
    }
}
