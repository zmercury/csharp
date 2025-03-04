namespace _04_regex;

using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        // string pattern = @"\d"; // single
        string pattern = @"\d+";
        string input = "The price is rs 234234";

        /**
        Match match = Regex.Match(input, pattern);

        if (match.Success)
        {
            Console.WriteLine("The matched value is : " + match.Value);
        }
        else
        {
            Console.WriteLine("Input Mismatched");
        }
        **/


        MatchCollection matches = Regex.Matches(input, pattern);

        foreach (Match hello in matches)
        {
            Console.WriteLine("The matched : " + hello.Value);
        }
    }
}

