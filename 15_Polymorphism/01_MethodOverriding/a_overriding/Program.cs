namespace a_overriding;

class Dad
{
    public void hi()
    {
        Console.WriteLine("Hi child");
    }
}

class Child : Dad
{
    //public void hi()
    public new void hi()
    {
        Console.WriteLine("Hi Dad");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Child obj = new Child();
        Dad obj2 = new Dad();

        obj.hi();
        obj2.hi();
    }
}
