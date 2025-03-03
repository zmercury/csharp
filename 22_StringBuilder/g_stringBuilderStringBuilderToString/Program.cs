namespace g_stringBuilderStringBuilderToString;

using System.Text;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder s = new StringBuilder("Hello World");
        String str = s.ToString();
        Console.WriteLine(s);
        Console.WriteLine(str);
    }
}
