namespace i_stringLowercase;

class Program
{
    static void Main(string[] args)
    {
        string str1 = "Hello";
        string str2 = str1.ToLower();
        Console.WriteLine("Original: " + str1);
        Console.WriteLine("After change: " + str2);
    }
}
