namespace b_pConstructor;

class MyClass
{
    public MyClass(int a)
    {
        Console.WriteLine("Square = " + (a * a));
    }

    public MyClass(int a, int b, int c)
    {
        Console.WriteLine("Volume = " + (a * b * c));
    }
}

class Program
{
    static void Main(string[] args)
    {
        new MyClass(5);
        new MyClass(1, 2, 3);
    }
}
