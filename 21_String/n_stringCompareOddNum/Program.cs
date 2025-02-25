// Compare ordinal and compare to
namespace n_stringCompareOddNum;

class Program
{
    static void Main(string[] args)
    {
        string s1 = "Hello";
        string s2 = "World";
        string s3 = "World";
        string s4 = "Hello";

        Console.WriteLine(string.CompareOrdinal(s1, s2));
        Console.WriteLine(string.CompareOrdinal(s3, s2));
        Console.WriteLine(string.CompareOrdinal(s4, s1));
        Console.WriteLine(s1.CompareTo(s4));
    }
}
