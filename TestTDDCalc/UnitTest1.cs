using TDDCalc;

namespace TestTDDCalc;

public class UnitTest1
{
    [Fact]
    public void TestAdd()
    {
        // Arrange
        Calculator calc;
        calc = new Calculator();
        
        // Act
        int result = calc.Add(35, 7);
        int correct = 42;
        
        // Assert
        Assert.Equal(correct, result);
    }

    [Fact]
    public void TestSubtract()
    {
        // Arrange
        Calculator calc = new Calculator();
        // Act
        int result = calc.Subtract(37, 7);
        int correct = 30;
        // Assert
        Assert.Equal(correct, result);
    }
}