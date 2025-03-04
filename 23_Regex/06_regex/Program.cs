namespace _06_regex;

using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string pattern = @"\d+";
        string input = "ram:1234 sita:6523 hari:1232";
        string replacement = "****";

        string result = Regex.Replace(input, pattern, replacement);

        Console.WriteLine(result);
    }
}

