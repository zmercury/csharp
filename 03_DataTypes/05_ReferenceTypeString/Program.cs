namespace _05_ReferenceTypeString;

class Program
{
    static void Main(string[] args)
    {
        string a = "Hello";

        Console.WriteLine(a);

        a += " World";

        Console.WriteLine(a);

        a = a + "!";

        Console.WriteLine(a);
    }
}
