namespace FigureLib.Tests;

public class FigureTests
{
    #region Circle Tests

    [Fact]
    public void Circle_ValidRadius_CalculateArea_ReturnsCorrectValue()
    {
        var circle = new Circle(10);
        var area = circle.CalculateArea();
        Assert.Equal(Math.PI * 100, area, precision: 5);
    }

    [Fact]
    public void Circle_NegativeRadius_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-5));
    }

    [Fact]
    public void Circle_ZeroRadius_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Circle(0));
    }

    #endregion

    #region Triangle Tests

    [Fact]
    public void Triangle_ValidSides_CalculateArea_ReturnsCorrectValue()
    {
        var triangle = new Triangle(3, 4, 5);
        var area = triangle.CalculateArea();
        Assert.Equal(6, area, precision: 5);
    }

    [Fact]
    public void Triangle_InvalidSides_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 10));
    }

    [Fact]
    public void Triangle_ZeroSide_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(0, 4, 5));
    }

    [Fact]
    public void Triangle_NegativeSide_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(-3, 4, 5));
    }

    [Fact]
    public void Triangle_RightAngled_IsRightAngled_ReturnsTrue()
    {
        var triangle = new Triangle(3, 4, 5);
        var isRightAngled = triangle.IsRightAngled();
        Assert.True(isRightAngled);
    }

    [Fact]
    public void Triangle_NotRightAngled_IsRightAngled_ReturnsFalse()
    {
        var triangle = new Triangle(5, 6, 7);
        var isRightAngled = triangle.IsRightAngled();
        Assert.False(isRightAngled);
    }

    #endregion

    #region Generic Tests

    [Fact]
    public void Generic_CalculateAreaForMultipleFigures_ReturnsCorrectValues()
    { 
        var figures = new IFigure[]
        {
            new Circle(10),
            new Triangle(3, 4, 5)
        };
        var areas = figures.Select(f => f.CalculateArea()).ToArray();
        Assert.Equal(Math.PI * 100, areas[0], precision: 5);
        Assert.Equal(6, areas[1], precision: 5);
    }

    #endregion
}