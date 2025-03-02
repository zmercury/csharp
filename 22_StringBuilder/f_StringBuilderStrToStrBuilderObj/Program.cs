namespace f_StringBuilderStrToStrBuilderObj;

using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string s1 = "Hello";
        StringBuilder s = new StringBuilder(s1);
        Console.WriteLine(s);

        string a = s.ToString();
        Console.WriteLine(a);
    }
}
