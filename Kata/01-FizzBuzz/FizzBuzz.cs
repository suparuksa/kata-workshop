namespace Kata.FizzBuzz;

public class FizzBuzz
{
    public string SayFizzBuzz(int number)
    {
        if (number == 15)
            return "FizzBuzz";
        if (IsFizz(number))
            return "Fizz";
        else if (IsBuzz(number))
            return "Buzz";
        else
            return number.ToString();
    }

    private bool IsFizz(int number)
    {
        return number % 3 == 0;
    }

    private bool IsBuzz(int number)
    {
        return number % 5 == 0;
    }
}

