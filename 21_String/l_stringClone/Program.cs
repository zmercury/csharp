namespace l_stringClone;

class Program
{
    static void Main(string[] args)
    {
        string str = "Hello";
        string strTwo = (string)str.Clone();
        Console.WriteLine(str);
        Console.WriteLine(strTwo);
    }
}
