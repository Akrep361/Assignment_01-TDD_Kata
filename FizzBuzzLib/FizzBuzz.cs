namespace FizzBuzzLib;

public static class FizzBuzz
{
    public static string Calculate(int number)
    {
        string result = "";

        if (number % 3 == 0 || number.ToString().Contains('3'))
            result += "Fizz";
        if (number % 5 == 0 || number.ToString().Contains('5'))
            result += "Buzz";

        return result == "" ? number.ToString() : result;
    }
}
