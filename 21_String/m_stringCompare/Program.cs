namespace m_stringCompare;

class Program
{
    static void Main(string[] args)
    {
        string s1 = "Hello";
        string s2 = "World";
        string s3 = "World";
        string s4 = "Hello";

        Console.WriteLine(string.Compare(s1, s2));
        Console.WriteLine(string.Compare(s1, s3));
        Console.WriteLine(string.Compare(s3, s4));
        Console.WriteLine(string.Compare(s3, s2));
    }
}
