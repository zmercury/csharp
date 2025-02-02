namespace _01_ClassObjectMethod;

class Program
{
    public void hello()
    {
        Console.WriteLine("Good Morning!");
    }

    static void Main(string[] args)
    {
        Program p1 = new Program();
        p1.hello();
    }
}
