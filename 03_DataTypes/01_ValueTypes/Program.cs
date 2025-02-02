namespace _01_ValueTypes;

class Program
{
    static void Main(string[] args)
    {
        // char - used for declaring characters
        char a = 's';

        // int - used for numeric values
        int i = 89;

        // short
        short s = 12;

        // long
        long l = 2345;

        // unsigned short
        ushort us = 12;

        // unsigned long
        ulong ul = 12312;

        // double - used for fraction values
        double d = 8.24;

        //float (f suffix)
        float f = 12.32f;

        //decimal (m suffix)
        decimal dc = 39.2m;

        Console.WriteLine(a);
        Console.WriteLine(i);
        Console.WriteLine(s);
        Console.WriteLine(l);
        Console.WriteLine(us);
        Console.WriteLine(ul);
        Console.WriteLine(d);
        Console.WriteLine(f);
        Console.WriteLine(dc);
    }
}
