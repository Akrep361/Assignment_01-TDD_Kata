namespace FizzBuzzLib;

public static class FizzBuzz
{
    public static string Calculate(int number)
    {
        if (number % 3 == 0 && number % 5 == 0)
            return "FizzBuzz";
        //wenn zahl durch 3 teilbar
        if (number % 3 == 0)
            return "Fizz";
        //wenn zahl durch 5 teilbar
        if (number % 5 == 0)
            return "Buzz";
        
        return number.ToString();
    }

}
