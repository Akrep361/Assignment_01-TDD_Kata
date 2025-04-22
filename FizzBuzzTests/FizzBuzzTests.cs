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
    public void Given3_ShouldReturnFizz()
    {
        var result = FizzBuzz.Calculate(3);
        Assert.Equal("Fizz", result);
    }

    [Fact]
    public void Given5_ShouldReturnBuzz()
    {
        var result = FizzBuzz.Calculate(5);
        Assert.Equal("Buzz", result);
    }

    [Fact]
    public void Given15_ShouldReturnFizzBuzz()
    {
        var result = FizzBuzz.Calculate(15);
        Assert.Equal("FizzBuzz", result);
    }



}


