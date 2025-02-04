namespace _2_SingleInheritanceConstructor;

class ParentClass
{
    public ParentClass()
    {
        Console.WriteLine("Constructor of parent class");
    }

    public void ParentMethod()
    {
        Console.WriteLine("Method of parent class");
    }
}

class ChildClass : ParentClass
{
    public ChildClass()
    {
        Console.WriteLine("Constructor of child class");
    }

    public void ChildMethod()
    {
        Console.WriteLine("Method of child class");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ChildClass ca = new ChildClass();
        ca.ParentMethod();
        ca.ChildMethod();
    }
}
