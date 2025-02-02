namespace c_implicit;

class Program
{
    static void Main(string[] args)
    {
        byte a = 10;
        int b = (int)a;
        long c = (long)a;
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        // We can only assign the value of smaller data type to the larger data type.
    }
}
