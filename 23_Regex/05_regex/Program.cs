namespace _05_regex;

using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string pattern = @"\D";
        string input = "23423423"; // (complement of \d)

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

