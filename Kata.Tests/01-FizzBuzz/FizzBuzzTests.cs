
namespace Kata.FizzBuzz.Tests;
public class FizzBuzzTests
{
    [Theory]
    [InlineData(1, "1")]
    [InlineData(2, "2")]
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

