
namespace Kata.FizzBuzz.Tests;
public class FizzBuzzTests
{
    [Fact]
    public void SayHelloWorld_ShouldReturnHelloWorld()
    {
        // Arrange
        var sut = new FizzBuzz();
        // Act
        var actual = sut.SayFizzBuzz();
        // Assert
        actual.Should().Be("");
    }
}

