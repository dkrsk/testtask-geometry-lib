namespace DnKR.Geometry.Tests;

[TestClass]
public class CircleTests
{
    [TestMethod]
    public void Area_5_78dot5Returned()
    {
        double r = 5;
        double expected = 78.5f;

        var circ = new Circle(r);

        Assert.AreEqual(expected, circ.Area, 0.1);
    }

    [TestMethod]
    public void Perimeter_12_75dot4Returned()
    { 
        double r = 12;
        double expected = 75.4f;

        var circ = new Circle(r);

        Assert.AreEqual(expected, circ.Perimeter, 0.1);
    }

    [TestMethod]
    public void Area_ChangeRadius3to6_113dot04Returned()
    {
        double r = 3f;
        double newRad = 6f;
        double expected = 113.04f;

        var circ = new Circle(r);
        circ.Radius = newRad;
        circ.Update();

        Assert.AreEqual(expected, circ.Area, 0.1);
    }

    [TestMethod]
    public void Area_ChangeRadius3to6_NoUpdate_113dot04Returned()
    {
        double r = 3f;
        double newRad = 6f;
        double expected = 28.26;

        var circ = new Circle(r);
        circ.Radius = newRad;

        Assert.AreEqual(expected, circ.Area, 0.1);
    }
}
