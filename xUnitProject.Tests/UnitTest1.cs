using XUnitDemo.Blazor.Data;

namespace xUnitProject.Tests;

public class UnitTest1
{
    [Fact]
    public void Add_ShouldAddNumbers()
    {
        double expected = 3;
        double actual = Calculator.Add(1, 2);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(7, 1.5, 5.5)]
    [InlineData(10.25, 5.5, 4.75)]
    public void Subtract_ShouldSubtractNumbers(double x, double y, double expected)
    {
        double actual = Calculator.Subtract(x, y);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(2.5, 2, 5)]
    [InlineData(2.1, 5, 10.5)]
    public void Multiply_ShouldMultiplyNumbers(double x, double y, double expected)
    {
        double actual = Calculator.Multiply(x, y);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(120, 5, 24)]
    public void Divide_ShouldDivideNumbers(double x, double y, double expected)
    {
        double actual = Calculator.Divide(x, y);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Divide_ShouldReturnZeroWhenDivisorIsZero()
    {
        double expected = 0;
        double actual = Calculator.Divide(15, 0);
        Assert.Equal(expected, actual);
    }
}