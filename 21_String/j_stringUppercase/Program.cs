namespace j_stringUppercase;

class Program
{
    static void Main(string[] args)
    {
        string str1 = "hello";
        string str2 = str1.ToUpper();
        Console.WriteLine("Original: " + str1);
        Console.WriteLine("After change: " + str2);
    }
}
