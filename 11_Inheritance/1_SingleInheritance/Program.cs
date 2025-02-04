namespace _1_SingleInheritance;

class SuperClass
{
    public void hi()
    {
        Console.WriteLine("Hi from superclass");
    }
}

class SubClass : SuperClass
{
    public void hello()
    {
        Console.WriteLine("Hi from subclass");
    }

}
class Program
{
    static void Main(string[] args)
    {
        SubClass sb = new SubClass();
        sb.hello();
        sb.hi();
    }
}
