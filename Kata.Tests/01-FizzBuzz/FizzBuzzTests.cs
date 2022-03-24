
namespace Kata.FizzBuzz.Tests;
public class FizzBuzzTests
{
    [Fact]
    public void TestGetFizzBuzz()
    {
        // Arrange
        var sut = new FizzBuzz();
        // Act
        var actual = sut.SayFizzBuzz(1);
        // Assert
        actual.Should().Be("1");
    }
}

