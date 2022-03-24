namespace Kata.FizzBuzz;

public class FizzBuzz
{
    public string SayFizzBuzz(int number)
    {
        if (IsFizz(number))
            return "Fizz";
        else if (number % 5 == 0)
            return "Buzz";
        else
            return number.ToString();
    }

    private bool IsFizz(int number)
    {
        return number % 3 == 0;
    }
}

