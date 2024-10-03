namespace DnKR.Geometry.Tests;

[TestClass]
public class TriangleTests
{
    [TestMethod]
    public void Area_3and4and5_6returned()
    {
        double a = 3;
        double b = 4;
        double c = 5;
        double expected = 6.0f;

        var tr = new Triangle(a,b,c);

        Assert.AreEqual(expected, tr.Area);
    }

    [TestMethod]
    public void Triangle_RightAngleCheck_TrueReturned()
    {
        double a = 12;
        double b = 16;
        double c = 20;
        bool expected = true;

        var tr = new Triangle(a, b, c);

        Assert.AreEqual(expected, tr.IsRectangular());
    }

    [TestMethod]
    public void Triangle_RightAngleCheck_FalseReturned()
    {
        double a = 6;
        double b = 6;
        double c = 6;
        bool expected = false;

        var tr = new Triangle(a, b, c);

        Assert.AreEqual(expected, tr.IsRectangular());
    }

    [TestMethod]
    [ExpectedException(typeof(DnKR.Geometry.Exceptions.InvalidTriangleSidesException))]
    public void Triangle_InequalityCheck_ExceptionThrowed()
    {
        double a = 2;
        double b = 3;
        double c = 5;

        var tr = new Triangle(2, 3, 5);
    }

    [TestMethod]
    public void PerimeterAndFigureCastCheck_3and4and6_13returned()
    {
        double a = 3;
        double b = 4;
        double c = 6;
        double expected = 13;

        Figure tr = new Triangle(a, b, c);

        Assert.AreEqual(expected, tr.Perimeter);
    }

    [TestMethod]
    [ExpectedException(typeof(DnKR.Geometry.Exceptions.InvalidTriangleSidesException))]
    public void InequalityChangeProperty_3and4and5to1and3and5_ExceptionThrowed()
    {
        double a = 3;
        double b = 4;
        double c = 5;
        double newA = 1;

        var tr = new Triangle(a, b, c);

        tr.A = newA;
        _ = tr.Area;
    }
}