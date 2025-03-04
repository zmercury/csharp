namespace _03_regex;

using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string pattern = @"\bThe";
        // string input = "The sanothimi campus";
        //string input = "here is The sanothimi campus";
        string input = "here is sanothimi campus The";

        Match match = Regex.Match(input, pattern);

        if (match.Success)
        {
            Console.WriteLine("The matched value is : " + match.Value);
        }
        else
        {
            Console.WriteLine("Input Mismatched");
        }

    }
}
