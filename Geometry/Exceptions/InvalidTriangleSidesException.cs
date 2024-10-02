namespace DnKR.Geometry.Exceptions;

/// <summary>
/// Сalled if the sides do not satisfy the condition for the existence of a triangle
/// </summary>
public class InvalidTriangleSidesException : Exception
{
    internal InvalidTriangleSidesException()
        : base("The sum of the lengths of any two sides of a triangle must be greater than the length of the third side.") { }
}
