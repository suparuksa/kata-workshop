namespace Kata.FizzBuzz;

public class FizzBuzz
{
    public string SayFizzBuzz(int number)
    {
        if (number % 3 == 0)
            return "Fizz";
        else
            return number.ToString();
    }
}

