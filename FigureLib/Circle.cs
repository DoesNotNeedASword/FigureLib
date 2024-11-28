namespace FigureLib;

/// <summary>
/// Represents a circle with a specific radius.
/// </summary>
public class Circle : IFigure
{
    /// <summary>
    /// Gets the radius of the circle.
    /// </summary>
    public double Radius { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Circle"/> class.
    /// </summary>
    /// <param name="radius">The radius of the circle. Must be positive.</param>
    /// <exception cref="ArgumentException">Thrown if the radius is non-positive.</exception>
    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Radius must be positive.");
        Radius = radius;
    }

    /// <inheritdoc/>
    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}