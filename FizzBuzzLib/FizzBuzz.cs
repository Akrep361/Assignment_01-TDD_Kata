namespace FizzBuzzLib;

public static class FizzBuzz
{
    public static string Calculate(int number)
    {
        if (number % 3 == 0)
            return "Fizz";

        return number.ToString();
    }

}
