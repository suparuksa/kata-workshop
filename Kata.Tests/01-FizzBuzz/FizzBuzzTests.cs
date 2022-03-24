
namespace Kata.FizzBuzz.Tests;
public class FizzBuzzTests
{
    [Theory]
    //normal number
    [InlineData(1, "1")]
    [InlineData(2, "2")]
    //fizz number
    [InlineData(3, "Fizz")]
    [InlineData(6, "Fizz")]
    //buzz number
    [InlineData(5, "Buzz")]
    [InlineData(10, "Buzz")]
    //fizzbuzz number
    [InlineData(15, "FizzBuzz")]
    [InlineData(30, "FizzBuzz")]
    public void TestGetFizzBuzz(int input, string expected)
    {
        // Arrange
        var sut = new FizzBuzz();
        // Act
        var actual = sut.SayFizzBuzz(input);
        // Assert
        actual.Should().Be(expected);
    }
}

