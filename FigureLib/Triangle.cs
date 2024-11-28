namespace FigureLib;

/// <summary>
/// Represents a triangle defined by three sides.
/// </summary>
public class Triangle : IFigure
{
    /// <summary>
    /// Gets the length of the first side of the triangle.
/// </summary>
    public double SideA { get; }

    /// <summary>
    /// Gets the length of the second side of the triangle.
/// </summary>
    public double SideB { get; }

    /// <summary>
    /// Gets the length of the third side of the triangle.
/// </summary>
    public double SideC { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Triangle"/> class.
/// </summary>
    /// <param name="sideA">The length of the first side. Must be positive.</param>
    /// <param name="sideB">The length of the second side. Must be positive.</param>
    /// <param name="sideC">The length of the third side. Must be positive.</param>
    /// <exception cref="ArgumentException">Thrown if the sides do not form a valid triangle or are non-positive.</exception>
    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            throw new ArgumentException("All sides must be positive.");
        if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            throw new ArgumentException("The sides do not form a valid triangle.");

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    /// <inheritdoc/>
    public double CalculateArea()
    {
        var s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    /// <summary>
    /// Determines if the triangle is a right triangle.
/// </summary>
    /// <returns><see langword="true"/> if the triangle is right-angled; otherwise, <see langword="false"/>.</returns>
    public bool IsRightAngled()
    {
        var sides = new[] { SideA, SideB, SideC }.OrderByDescending(x => x).ToArray();
        return Math.Abs(Math.Pow(sides[0], 2) - (Math.Pow(sides[1], 2) + Math.Pow(sides[2], 2))) < 1e-10;
    }
}