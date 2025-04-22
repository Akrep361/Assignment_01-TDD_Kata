namespace FizzBuzzLib;

public static class FizzBuzz
{
    public static string Calculate(int number)
    {
        string result = "";

        if (number % 3 == 0)
            result += "Fizz";
        if (number % 5 == 0)
            result += "Buzz";

        return result == "" ? number.ToString() : result;
    }


}
