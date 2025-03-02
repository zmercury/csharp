namespace d_StringBuilderRemove;

using System.Text;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder s = new StringBuilder("Hello, Welcome to Nepal", 20);
        s.Remove(6, 9);
        Console.WriteLine(s);
    }
}
