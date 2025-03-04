namespace _02_regex;

using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string pattern = @"\AThe";
        string input = "The sanothimi campus";

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
