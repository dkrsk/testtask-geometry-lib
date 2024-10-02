using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Dynamic;

namespace DnKR.Geometry;

public abstract class Figure
{
    /// <summary>
    /// The area of figure
    /// </summary>
    /// <remarks>
    /// When changing the parameters of a figure, an <see cref="Update"/> call is required to recalculate this value
    /// </remarks>
    public virtual double Area { get; protected set; }
    /// <summary>
    /// The perimater of figure
    /// </summary>
    /// <remarks>
    /// When changing the parameters of a figure, an <see cref="Update"/> call is required to recalculate this value
    /// </remarks>
    public virtual double Perimeter { get; protected set; }

    /// <summary>
    /// Recalculate the Area and Perimeter of the figure.
    /// </summary>
    /// <remarks>
    /// Calling this function is necessary after changing the shape parameters
    /// </remarks>
    public abstract void Update();


    /*
     * Замечание к ревьюверу:
     * Использование апдейт метода снижает ресурсозатратность при изменении параметров фигуры.
     * (иначе, в случае с многогранной фигурой, каждый раз при изменении каждого свойства , пришлось бы пересчитывать площадь и периметр)
     */


    public override string ToString()
    {
        return $"{this.GetType()}: Perimeter: {Perimeter}. Area: {Area}";
    }
}
