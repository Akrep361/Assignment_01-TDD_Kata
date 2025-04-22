namespace FizzBuzzLib;

public static class FizzBuzz
{
    public static string Calculate(int number)
    {
        string result = "";

        //durch 3 teilbar
        if (number % 3 == 0)
            result += "Fizz";
        //enthält 3
        if (number.ToString().Contains('3'))
            result += "Fizz";

        //durch 5 teilbar
        if (number % 5 == 0)
            result += "Buzz";
        //enthält 5
        if (number.ToString().Contains('5'))
            result += "Buzz";
            
        return result == "" ? number.ToString() : result;
    }
}
