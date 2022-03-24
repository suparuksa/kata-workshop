
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
    //final number
    [InlineData(100, "Buzz")]
    public void CanTestASingleNumberFizzBuzz(int input, string expected)
    {
        // Arrange
        var sut = new FizzBuzz();
        // Act
        var actual = sut.SayFizzBuzz(input);
        // Assert
        actual.Should().Be(expected);
    }


    [Theory]
    [InlineData(1, 100, "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz Fizz 22 23 Fizz Buzz 26 Fizz 28 29 FizzBuzz 31 32 Fizz 34 Buzz Fizz 37 38 Fizz Buzz 41 Fizz 43 44 FizzBuzz 46 47 Fizz 49 Buzz Fizz 52 53 Fizz Buzz 56 Fizz 58 59 FizzBuzz 61 62 Fizz 64 Buzz Fizz 67 68 Fizz Buzz 71 Fizz 73 74 FizzBuzz 76 77 Fizz 79 Buzz Fizz 82 83 Fizz Buzz 86 Fizz 88 89 FizzBuzz 91 92 Fizz 94 Buzz Fizz 97 98 Fizz Buzz")]
    private void CanPrintTestNumber1To100(int num1, int num2, string expected)
    {
        var sut = new FizzBuzz();
        // Act
        var actual = sut.PrintFizBuzz(num1, num2);
        // Assert
        actual.Should().Be(expected);
    }

}

