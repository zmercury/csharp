namespace c_abstraction;

abstract class MyClass
{
    public abstract void calculator(double a);
}

class SubClassOne : MyClass
{
    public override void calculator(double a)
    {
        Console.WriteLine("Square Root = " + Math.Sqrt(a));
    }
}

class SubClassTwo : MyClass
{
    public override void calculator(double a)
    {
        Console.WriteLine("Square = " + (a * a));
    }
}

class SubClassThree : MyClass
{
    public override void calculator(double a)
    {
        Console.WriteLine("Cube = " + (a * a * a));
    }
}

class Program
{
    static void Main(string[] args)
    {
        SubClassOne o1 = new SubClassOne();
        SubClassTwo o2 = new SubClassTwo();
        SubClassThree o3 = new SubClassThree();

        o1.calculator(22);
        o2.calculator(22);
        o3.calculator(22);
    }
}
