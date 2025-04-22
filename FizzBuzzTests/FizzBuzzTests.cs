using FizzBuzzLib;

namespace FizzBuzzTests;

public class FizzBuzzTest
{
    [Fact]
    public void Given1_ShouldReturn1()
    {
        var result = FizzBuzz.Calculate(1);
        Assert.Equal("1", result);
    }

    [Fact]
    public void Given3_ShouldReturnFizzFizz()
    {
        var result = FizzBuzz.Calculate(3);
        Assert.Equal("FizzFizz", result);
    }

    [Fact]
    public void Given5_ShouldReturnBuzzBuzz()
    {
        var result = FizzBuzz.Calculate(5);
        Assert.Equal("BuzzBuzz", result);
    }

    [Fact]
    public void Given15_ShouldReturnFizzBuzzBuzz()
    {
        var result = FizzBuzz.Calculate(15);
        Assert.Equal("FizzBuzzBuzz", result);
    }

    [Fact]
    public void Given53_ShouldReturnFizzBuzz()
    {
        var result = FizzBuzz.Calculate(53);
        Assert.Equal("FizzBuzz", result);
    }

    [Fact]
    public void Given35_ShouldReturnFizzBuzzBuzz()
    {
        var result = FizzBuzz.Calculate(35);
        Assert.Equal("FizzBuzzBuzz", result);
    }

}


