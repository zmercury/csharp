namespace a_StringBuilderAppendFormat;

using System.Text;
class Program
{
    static void Main(string[] args)
    {
        StringBuilder s = new StringBuilder("The cost price of this mobile phone is ");
        s.AppendFormat("{0:c}", 999.99);
        Console.WriteLine(s);
    }
}
