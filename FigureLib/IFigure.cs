namespace FigureLib;

/// <summary>
/// Defines the contract for geometric figures.
/// </summary>
public interface IFigure
{
    /// <summary>
    /// Calculates the area of the figure.
    /// </summary>
    /// <returns>The area of the figure as a <see cref="double"/>.</returns>
    double CalculateArea();
}