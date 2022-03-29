using Xunit;
using Package;

namespace Package.Test;

public class UnitTest1
{
    [Fact]
    public void CalculatorAdd()
    {
        //Given
        var calc = new Calculator();

        //When
        var result = calc.Add(2, 4);

        //Then
        Assert.Equal(6, result);
    }

    [Fact]
    public void CalculatorMultiply()
    {
        //Given
        var calc = new Calculator();

        //When
        var result = calc.Mult(2, 4);

        //Then
        Assert.Equal(8, result);
    }
}