
namespace Kata.FizzBuzz.Tests;
public class FizzBuzzTests
{
    [Theory]
    [InlineData(1, "1")]
    [InlineData(2, "2")]
    [InlineData(3, "Fizz")]
    [InlineData(6, "Fizz")]


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

