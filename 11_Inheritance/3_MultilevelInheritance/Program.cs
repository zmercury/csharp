namespace _3_MultilevelInheritance;

class Grandfather
{
    public void grandDad()
    {
        Console.WriteLine("Granddad");
    }
}

class Father : Grandfather
{
    public void dad()
    {
        Console.WriteLine("dad");
    }
}

class Child : Father
{
    public void child()
    {
        Console.WriteLine("child");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Child c = new Child();
        c.grandDad();
        c.dad();
        c.child();
    }
}
