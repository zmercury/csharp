namespace p_stringContains;

class Program
{
    static void Main(string[] args)
    {
        string s1 = "Sanothimi";
        string s2 = "Sano";
        string s3 = "thimi";
        string s4 = "thulo";

        Console.WriteLine(s1.Contains(s2));
        Console.WriteLine(s1.Contains(s3));
        Console.WriteLine(s1.Contains(s4));
    }
}
