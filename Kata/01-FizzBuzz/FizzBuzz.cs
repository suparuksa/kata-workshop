namespace Kata.FizzBuzz;

public class FizzBuzz
{
    public string SayFizzBuzz(int number)
    {
        if (IsFizzBuzz(number))
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

    private bool IsFizzBuzz(int number)
    {
        return number % 3 == 0 && number % 5 == 0;
    }

    public string PrintFizBuzz(int from_number, int to_number)
    {
        string print_message = "";
        ; for (int i = from_number; i < to_number + 1; i++)
        {
            if (i == to_number)
                print_message += SayFizzBuzz(i);
            else
                print_message += SayFizzBuzz(i) + " ";
        }
        return print_message;
    }

}

