using CalculatorLib;
namespace CalculatorLibUnitTests;

public class CalculatorUnitTests
{
    [Fact]
    public void TestAdding2And2()
    {
        // Arrange
        const double a = 2;
        const double b = 2;
        const double expected = 4;
        Calculator calculator = new();

        var actual = calculator.Add(a, b);
        
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void TestAdding2And3()
    {
        // Arrange
        const double a = 2;
        const double b = 3;
        const double expected = 5;
        Calculator calculator = new();

        var actual = calculator.Add(a, b);
        
        Assert.Equal(expected, actual);
    }
}